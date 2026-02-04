using Azure.Core;
using Microsoft.Extensions.Options;
using System.Net;
using YQuery.Service;
using YQuery.Service.Service;
using YQuery.Shared.Model;

namespace YQuery
{
    public partial class YQuery : Form
    {
        private List<string> serverSuggestions;
        private ToolStripDropDown serverSuggestionsMenu;
        private readonly IOptions<DBCredentials> _dbCredentialsOptions;
        private DBCredentials dBCredentials = new DBCredentials();
        private IRegisterInfraAccess registerInfraAccess;
        private IConnectionService connectionService;
        private ICredentialsService credentialService;

        public YQuery()
        {
            this.InitializeComponent();
            this.InitializeSuggestions();
            this.serverSuggestionsMenu = new ToolStripDropDown();
            this.credentialService = new CredentialsService();
            this.WireEvents();
            this.SetEnabling(false);
        }

        private void InitializeServices(DBCredentials credentials)
        {
            this.credentialService.UpdateCredentials(credentials);

            this.registerInfraAccess = RegisterInfraAccess.GetInstance(this.credentialService);
            this.connectionService = new ConnectionService(this.registerInfraAccess);
        }

        private void WireEvents()
        {
            //WindowsAuthRadioButton.CheckedChanged += Auth_CheckedChanged;
            //SQLServerAuthRadioButton.CheckedChanged += Auth_CheckedChanged;
            ServerNameTextBox.TextChanged += ServerNameTextBox_TextChanged;
            ServerNameTextBox.KeyDown += ServerNameTextBox_KeyDown;
            ServerNameTextBox.Resize += (s, e) => this.serverSuggestionsMenu.Width = this.ServerNameTextBox.Width;
            this.serverSuggestionsMenu.AutoSize = false;
            this.LogInButton.Click += ClickLogin;
            this.ChangeServerButton.Click += ClickChangeServer;
            this.ChangeDatabaseButton.Click += ToggleDisableDatabaseNameGroupBox;
            this.SetDatabaseButton.Click += ClickSetDatabase;

        }

        private void InitializeSuggestions()
        {
            this.serverSuggestions = new List<string>
            {
                "localhost",
                "127.0.0.1",
                "192.168.1.1",
                "MyServerName",
                "sql.example.com",
                "SERVER01",
                "SERVER02",
                "DATABASE_SERVER"
            };



        }

        private void ServerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ShowServerSuggestions();
        }

        private void ServerNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.serverSuggestionsMenu.Close();
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Down && this.serverSuggestionsMenu.Visible)
            {
                if (this.serverSuggestionsMenu.Items.Count > 0)
                {
                    this.serverSuggestionsMenu.Items[0].Select();
                    e.Handled = true;
                }
            }
        }

        private void ShowServerSuggestions()
        {
            string searchText = this.ServerNameTextBox.Text.ToLower().Trim();

            if (this.serverSuggestionsMenu.Items.Count > 0 || this.serverSuggestionsMenu.Items is not null)
            {
                this.serverSuggestionsMenu.Items!.Clear();
            }

            if (string.IsNullOrEmpty(searchText))
            {
                foreach (string suggestion in this.serverSuggestions)
                {
                    this.AddSuggestionItem(suggestion);
                }
            }
            else
            {
                foreach (string suggestion in this.serverSuggestions)
                {
                    if (suggestion.ToLower().Contains(searchText))
                    {
                        this.AddSuggestionItem(suggestion);
                    }
                }
            }

            if (this.serverSuggestionsMenu.Items?.Count > 0)
            {
                this.serverSuggestionsMenu.Width = this.ServerNameTextBox.Width;
                this.serverSuggestionsMenu.Show(this.ServerNameTextBox,
                    new Point(0, this.ServerNameTextBox.Height),
                    ToolStripDropDownDirection.Default);
            }
            else
            {
                this.serverSuggestionsMenu.Close();
            }
        }

        private void AddSuggestionItem(string suggestion)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(suggestion);
            item.Click += (s, e) =>
            {
                this.ServerNameTextBox.Text = suggestion;
                this.serverSuggestionsMenu.Close();
            };
            this.serverSuggestionsMenu.Items.Add(item);
        }

        private async void ClickLogin(object? sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(this.ServerNameTextBox.Text)) ||
                string.IsNullOrWhiteSpace(this.LoginTextBox.Text) ||
                string.IsNullOrWhiteSpace(this.PasswordTextBox.Text))
            {
                return;
            }

            this.dBCredentials.SeverName = this.ServerNameTextBox.Text;
            this.dBCredentials.UserId = this.LoginTextBox.Text;
            this.dBCredentials.Password = this.PasswordTextBox.Text;


            // Initialize services with actual credentials
            this.InitializeServices(this.dBCredentials);

            await this.GetDatabases();
        }

        private async Task GetDatabases()
        {
            this.LogInButton.Enabled = false;
            (List<string> databases, string error) = await this.connectionService.GetDatabasesAsync();

            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Error retrieving databases: {error}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (databases != null)
            {
                databases.ForEach(db => this.DatabaseNameComboBox.Items.Add(db));
                this.SetEnabling(true);
                this.SetEnableResultsAndSearch(false);
            }

            this.LogInButton.Enabled = true;
        }


        private void ClickChangeServer(object? sender, EventArgs e)
        {
            this.SetEnabling(false);
        }

        private void ToggleDisableDatabaseNameGroupBox(object? sender = null, EventArgs? e = null)
        {
            bool isEnabled = !this.DatabaseNameSelectionGroupBox.Enabled;

            this.DatabaseNameSelectionGroupBox.Enabled = isEnabled;
            this.SetEnableResultsAndSearch(!isEnabled);
        }

        private void ClickSetDatabase(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.ServerNameComboBox.SelectedItem?.ToString()) &&
               string.IsNullOrWhiteSpace(this.ServerNameComboBox.Text?.ToString()))
                return;

            this.ToggleDisableDatabaseNameGroupBox();
            this.dBCredentials.DatabaseName = this.DatabaseNameComboBox.SelectedItem?.ToString() ?? this.DatabaseNameComboBox.Text.ToString();
            this.credentialService.UpdateCredentials(this.dBCredentials);
        }

        private void SetEnableResultsAndSearch(bool IsEnabled)
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