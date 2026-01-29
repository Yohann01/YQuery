using YQuery.Service;
using YQuery.Shared.Model;

namespace YQuery
{
    public partial class YQuery : Form
    {

        private DBCredentials dBCredentials = new DBCredentials();
        private readonly UserSession userSession = new UserSession();
        private readonly IConnectionService connectionService;

        public YQuery(UserSession userSession)
        {
            this.InitializeComponent();
            this.userSession = userSession;
            this.connectionService = new ConnectionService(this.userSession);
            this.WireEvents();
            this.SetEnabling(false);
        }

        private void WireEvents()
        {
            //WindowsAuthRadioButton.CheckedChanged += Auth_CheckedChanged;
            //SQLServerAuthRadioButton.CheckedChanged += Auth_CheckedChanged;
            //ExportButton.Click += BtnExport_Click;
            //btnExport.Click += BtnExport_Click;
            this.LogInButton.Click += ClickLogin;
            this.ChangeServerButton.Click += ClickChangeServer;
            this.ChangeDatabaseButton.Click += ToggleDisableDatabaseNameSelectionGroupBox;
            this.SetDatabaseButton.Click += ToggleDisableDatabaseNameSelectionGroupBox;

        }

        private async void ClickLogin(object? sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(this.ServerNameComboBox.SelectedItem?.ToString()) && string.IsNullOrWhiteSpace(this.ServerNameComboBox.Text?.ToString())) ||
                string.IsNullOrWhiteSpace(this.LoginTextBox.Text) ||
                string.IsNullOrWhiteSpace(this.PasswordTextBox.Text))

            {
                return;
            }

            this.dBCredentials.SeverName = this.ServerNameComboBox.SelectedItem?.ToString() ?? this.ServerNameComboBox.Text.ToString();
            this.dBCredentials.UserId = this.LoginTextBox.Text;
            this.dBCredentials.Password = this.PasswordTextBox.Text;

            this.userSession.SetCredentials(this.dBCredentials);

            await this.GetDatabases();

        }

        private async Task GetDatabases()
        {
            List<string> databases = await this.connectionService.GetDatabasesAsync();

            if (databases != null)
            {
                databases.ForEach(db => this.DatabaseNameComboBox.Items.Add(db));
                this.SetEnabling(true);
                this.SetEnableResultsAndSearchOptionsGroupBox(false);
            }
        }


        private void ClickChangeServer(object? sender, EventArgs e)
        {
            this.SetEnabling(false);
        }

        private void ToggleDisableDatabaseNameSelectionGroupBox(object? sender, EventArgs e)
        {

            bool isEnabled = !this.DatabaseNameSelectionGroupBox.Enabled;

            this.DatabaseNameSelectionGroupBox.Enabled = isEnabled;

            this.SetEnableResultsAndSearchOptionsGroupBox(!isEnabled);
        }
        
        private void SetEnableResultsAndSearchOptionsGroupBox(bool IsEnabled)
        {
            this.ResultsGroupBox.Enabled = IsEnabled;
            this.SearchOptionsGroupBox.Enabled = IsEnabled;
        }

        private void SetEnabling(bool IsEnabled)
        {
            foreach (Control ctrl in this.Controls)
            {
                    ctrl.Enabled = IsEnabled;
            }

            this.DatabaseConnectionGroupBox.Enabled = !IsEnabled;
        }
    }
}
