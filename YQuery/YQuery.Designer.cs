using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
namespace YQuery
{
    partial class YQuery : Form
    {
        // LEFT PANEL CONTROLS
        private GroupBox DatabaseConnectionGroupBox;
        private Label ServerNameLabel;
        private Guna2TextBox ServerNameTextBox;  // CHANGED: Use Guna2TextBox instead
        private Guna2ComboBox ServerNameComboBox; // Keep if you want dropdown for suggestions
        private GroupBox AuthenticationGroupBox;
        private RadioButton WindowsAuthRadioButton;
        private RadioButton SQLServerAuthRadioButton;
        private Label LoginLabel;
        private TextBox LoginTextBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Button LogInButton;

        private GroupBox DatabaseNameSelectionGroupBox;
        private Label DatabaseNameLabel;
        private ComboBox DatabaseNameComboBox;
        private Button SetDatabaseButton;
        private Button ChangeServerButton;
        private Button ChangeDatabaseButton;

        private GroupBox SearchOptionsGroupBox;
        private Button SearchButton;
        private GroupBox SearchInGroupBox;
        private RadioButton NameRadioButton;
        private RadioButton DefinitionRadioButton;
        private GroupBox ConditionGroupBox;
        private RadioButton ContainsRadioButton;
        private RadioButton BeginsWithRadioButton;
        private RadioButton EndsWithRadioButton;
        private TextBox SearchTextBox;

        private GroupBox ResultsGroupBox;
        private TextBox ResultsTextBox;
        private Label ExportToPathLabel;
        private TextBox ExportPathTextBox;
        private Button ExportButton;


        private void InitializeComponent()
        {
            CustomizableEdges customizableEdges1 = new CustomizableEdges();
            CustomizableEdges customizableEdges2 = new CustomizableEdges();
            CustomizableEdges customizableEdges3 = new CustomizableEdges();
            CustomizableEdges customizableEdges4 = new CustomizableEdges();

            this.DatabaseConnectionGroupBox = new GroupBox();
            this.ServerNameTextBox = new Guna2TextBox();  // ADDED
            this.ServerNameComboBox = new Guna2ComboBox(); // Optional: for dropdown suggestions
            this.ServerNameLabel = new Label();
            this.AuthenticationGroupBox = new GroupBox();
            this.WindowsAuthRadioButton = new RadioButton();
            this.SQLServerAuthRadioButton = new RadioButton();
            this.LoginLabel = new Label();
            this.LoginTextBox = new TextBox();
            this.PasswordLabel = new Label();
            this.PasswordTextBox = new TextBox();
            this.LogInButton = new Button();
            this.DatabaseNameSelectionGroupBox = new GroupBox();
            this.DatabaseNameLabel = new Label();
            this.DatabaseNameComboBox = new ComboBox();
            this.SetDatabaseButton = new Button();
            this.ChangeServerButton = new Button();
            this.ChangeDatabaseButton = new Button();
            this.SearchOptionsGroupBox = new GroupBox();
            this.SearchButton = new Button();
            this.SearchInGroupBox = new GroupBox();
            this.NameRadioButton = new RadioButton();
            this.DefinitionRadioButton = new RadioButton();
            this.ConditionGroupBox = new GroupBox();
            this.ContainsRadioButton = new RadioButton();
            this.BeginsWithRadioButton = new RadioButton();
            this.EndsWithRadioButton = new RadioButton();
            this.SearchTextBox = new TextBox();
            this.ResultsGroupBox = new GroupBox();
            this.ResultsTextBox = new TextBox();
            this.ExportToPathLabel = new Label();
            this.ExportPathTextBox = new TextBox();
            this.ExportButton = new Button();
            this.DatabaseConnectionGroupBox.SuspendLayout();
            this.AuthenticationGroupBox.SuspendLayout();
            this.DatabaseNameSelectionGroupBox.SuspendLayout();
            this.SearchOptionsGroupBox.SuspendLayout();
            this.SearchInGroupBox.SuspendLayout();
            this.ConditionGroupBox.SuspendLayout();
            this.ResultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatabaseConnectionGroupBox
            // 
            this.DatabaseConnectionGroupBox.Controls.Add(this.ServerNameTextBox);
            this.DatabaseConnectionGroupBox.Controls.Add(this.ServerNameLabel);
            this.DatabaseConnectionGroupBox.Controls.Add(this.AuthenticationGroupBox);
            this.DatabaseConnectionGroupBox.Controls.Add(this.LoginLabel);
            this.DatabaseConnectionGroupBox.Controls.Add(this.LoginTextBox);
            this.DatabaseConnectionGroupBox.Controls.Add(this.PasswordLabel);
            this.DatabaseConnectionGroupBox.Controls.Add(this.PasswordTextBox);
            this.DatabaseConnectionGroupBox.Controls.Add(this.LogInButton);
            this.DatabaseConnectionGroupBox.Location = new Point(20, 20);
            this.DatabaseConnectionGroupBox.Name = "DatabaseConnectionGroupBox";
            this.DatabaseConnectionGroupBox.Size = new Size(360, 238);
            this.DatabaseConnectionGroupBox.TabIndex = 0;
            this.DatabaseConnectionGroupBox.TabStop = false;
            this.DatabaseConnectionGroupBox.Text = "Database Connection";
            // 
            // ServerNameTextBox
            // 
            this.ServerNameTextBox.BorderColor = Color.FromArgb(200, 213, 230);
            this.ServerNameTextBox.BorderRadius = 0;
            this.ServerNameTextBox.Cursor = Cursors.IBeam;
            this.ServerNameTextBox.CustomizableEdges = customizableEdges1;
            this.ServerNameTextBox.DefaultText = "";
            this.ServerNameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            this.ServerNameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            this.ServerNameTextBox.DisabledState.ForeColor = Color.FromArgb(166, 166, 166);
            this.ServerNameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(166, 166, 166);
            this.ServerNameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            this.ServerNameTextBox.Font = new Font("Segoe UI", 10F);
            this.ServerNameTextBox.ForeColor = Color.FromArgb(68, 88, 112);
            this.ServerNameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            this.ServerNameTextBox.Location = new Point(110, 22);
            this.ServerNameTextBox.Name = "ServerNameTextBox";
            this.ServerNameTextBox.PasswordChar = '\0';
            this.ServerNameTextBox.PlaceholderText = "Enter or select server name";
            this.ServerNameTextBox.SelectedText = "";
            this.ServerNameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.ServerNameTextBox.Size = new Size(235, 36);
            this.ServerNameTextBox.TabIndex = 1;
            // 
            // ServerNameLabel
            // 
            this.ServerNameLabel.Location = new Point(15, 25);
            this.ServerNameLabel.Name = "ServerNameLabel";
            this.ServerNameLabel.Size = new Size(85, 20);
            this.ServerNameLabel.TabIndex = 0;
            this.ServerNameLabel.Text = "Server Name:";
            // 
            // AuthenticationGroupBox
            // 
            this.AuthenticationGroupBox.Controls.Add(this.WindowsAuthRadioButton);
            this.AuthenticationGroupBox.Controls.Add(this.SQLServerAuthRadioButton);
            this.AuthenticationGroupBox.Location = new Point(110, 64);
            this.AuthenticationGroupBox.Name = "AuthenticationGroupBox";
            this.AuthenticationGroupBox.Size = new Size(235, 55);
            this.AuthenticationGroupBox.TabIndex = 2;
            this.AuthenticationGroupBox.TabStop = false;
            // 
            // WindowsAuthRadioButton
            // 
            this.WindowsAuthRadioButton.Location = new Point(8, 12);
            this.WindowsAuthRadioButton.Name = "WindowsAuthRadioButton";
            this.WindowsAuthRadioButton.Size = new Size(200, 20);
            this.WindowsAuthRadioButton.TabIndex = 0;
            this.WindowsAuthRadioButton.Text = "Windows Authentication";
            // 
            // SQLServerAuthRadioButton
            // 
            this.SQLServerAuthRadioButton.Checked = true;
            this.SQLServerAuthRadioButton.Location = new Point(8, 30);
            this.SQLServerAuthRadioButton.Name = "SQLServerAuthRadioButton";
            this.SQLServerAuthRadioButton.Size = new Size(200, 20);
            this.SQLServerAuthRadioButton.TabIndex = 1;
            this.SQLServerAuthRadioButton.TabStop = true;
            this.SQLServerAuthRadioButton.Text = "SQL Server Authentication";
            // 
            // LoginLabel
            // 
            this.LoginLabel.Location = new Point(15, 129);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new Size(85, 20);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Login:";
            this.LoginLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new Point(110, 127);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new Size(235, 23);
            this.LoginTextBox.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new Point(15, 159);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new Size(85, 20);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new Point(110, 157);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.Size = new Size(235, 23);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new Point(110, 194);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new Size(100, 30);
            this.LogInButton.TabIndex = 7;
            this.LogInButton.Text = "Log In";
            // 
            // DatabaseNameSelectionGroupBox
            // 
            this.DatabaseNameSelectionGroupBox.Controls.Add(this.DatabaseNameLabel);
            this.DatabaseNameSelectionGroupBox.Controls.Add(this.DatabaseNameComboBox);
            this.DatabaseNameSelectionGroupBox.Controls.Add(this.SetDatabaseButton);
            this.DatabaseNameSelectionGroupBox.Location = new Point(20, 264);
            this.DatabaseNameSelectionGroupBox.Name = "DatabaseNameSelectionGroupBox";
            this.DatabaseNameSelectionGroupBox.Size = new Size(360, 100);
            this.DatabaseNameSelectionGroupBox.TabIndex = 1;
            this.DatabaseNameSelectionGroupBox.TabStop = false;
            this.DatabaseNameSelectionGroupBox.Text = "Database Name Selection";
            // 
            // DatabaseNameLabel
            // 
            this.DatabaseNameLabel.Location = new Point(15, 28);
            this.DatabaseNameLabel.Name = "DatabaseNameLabel";
            this.DatabaseNameLabel.Size = new Size(100, 20);
            this.DatabaseNameLabel.TabIndex = 0;
            this.DatabaseNameLabel.Text = "Database Name:";
            // 
            // DatabaseNameComboBox
            // 
            this.DatabaseNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.DatabaseNameComboBox.Location = new Point(125, 25);
            this.DatabaseNameComboBox.Name = "DatabaseNameComboBox";
            this.DatabaseNameComboBox.Size = new Size(220, 23);
            this.DatabaseNameComboBox.TabIndex = 1;
            // 
            // SetDatabaseButton
            // 
            this.SetDatabaseButton.Location = new Point(125, 60);
            this.SetDatabaseButton.Name = "SetDatabaseButton";
            this.SetDatabaseButton.Size = new Size(120, 30);
            this.SetDatabaseButton.TabIndex = 2;
            this.SetDatabaseButton.Text = "Set Database";
            // 
            // ChangeServerButton
            // 
            this.ChangeServerButton.Location = new Point(50, 374);
            this.ChangeServerButton.Name = "ChangeServerButton";
            this.ChangeServerButton.Size = new Size(120, 30);
            this.ChangeServerButton.TabIndex = 4;
            this.ChangeServerButton.Text = "Change Server";
            // 
            // ChangeDatabaseButton
            // 
            this.ChangeDatabaseButton.Location = new Point(190, 374);
            this.ChangeDatabaseButton.Name = "ChangeDatabaseButton";
            this.ChangeDatabaseButton.Size = new Size(130, 30);
            this.ChangeDatabaseButton.TabIndex = 5;
            this.ChangeDatabaseButton.Text = "Change Database";
            // 
            // SearchOptionsGroupBox
            // 
            this.SearchOptionsGroupBox.Controls.Add(this.SearchButton);
            this.SearchOptionsGroupBox.Controls.Add(this.SearchInGroupBox);
            this.SearchOptionsGroupBox.Controls.Add(this.ConditionGroupBox);
            this.SearchOptionsGroupBox.Controls.Add(this.SearchTextBox);
            this.SearchOptionsGroupBox.Location = new Point(400, 20);
            this.SearchOptionsGroupBox.Name = "SearchOptionsGroupBox";
            this.SearchOptionsGroupBox.Size = new Size(560, 120);
            this.SearchOptionsGroupBox.TabIndex = 2;
            this.SearchOptionsGroupBox.TabStop = false;
            this.SearchOptionsGroupBox.Text = "TFSID/ TaskID/ BugID/ SP Name:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new Point(15, 25);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new Size(80, 25);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            // 
            // SearchInGroupBox
            // 
            this.SearchInGroupBox.Controls.Add(this.NameRadioButton);
            this.SearchInGroupBox.Controls.Add(this.DefinitionRadioButton);
            this.SearchInGroupBox.Location = new Point(110, 15);
            this.SearchInGroupBox.Name = "SearchInGroupBox";
            this.SearchInGroupBox.Size = new Size(160, 50);
            this.SearchInGroupBox.TabIndex = 1;
            this.SearchInGroupBox.TabStop = false;
            this.SearchInGroupBox.Text = "Search in:";
            // 
            // NameRadioButton
            // 
            this.NameRadioButton.Checked = true;
            this.NameRadioButton.Location = new Point(10, 18);
            this.NameRadioButton.Name = "NameRadioButton";
            this.NameRadioButton.Size = new Size(60, 20);
            this.NameRadioButton.TabIndex = 0;
            this.NameRadioButton.TabStop = true;
            this.NameRadioButton.Text = "Name";
            // 
            // DefinitionRadioButton
            // 
            this.DefinitionRadioButton.Location = new Point(75, 18);
            this.DefinitionRadioButton.Name = "DefinitionRadioButton";
            this.DefinitionRadioButton.Size = new Size(85, 20);
            this.DefinitionRadioButton.TabIndex = 1;
            this.DefinitionRadioButton.Text = "Definition";
            // 
            // ConditionGroupBox
            // 
            this.ConditionGroupBox.Controls.Add(this.ContainsRadioButton);
            this.ConditionGroupBox.Controls.Add(this.BeginsWithRadioButton);
            this.ConditionGroupBox.Controls.Add(this.EndsWithRadioButton);
            this.ConditionGroupBox.Location = new Point(280, 15);
            this.ConditionGroupBox.Name = "ConditionGroupBox";
            this.ConditionGroupBox.Size = new Size(265, 50);
            this.ConditionGroupBox.TabIndex = 2;
            this.ConditionGroupBox.TabStop = false;
            this.ConditionGroupBox.Text = "Condition";
            // 
            // ContainsRadioButton
            // 
            this.ContainsRadioButton.Checked = true;
            this.ContainsRadioButton.Location = new Point(10, 18);
            this.ContainsRadioButton.Name = "ContainsRadioButton";
            this.ContainsRadioButton.Size = new Size(75, 20);
            this.ContainsRadioButton.TabIndex = 0;
            this.ContainsRadioButton.TabStop = true;
            this.ContainsRadioButton.Text = "Contains";
            // 
            // BeginsWithRadioButton
            // 
            this.BeginsWithRadioButton.Location = new Point(90, 18);
            this.BeginsWithRadioButton.Name = "BeginsWithRadioButton";
            this.BeginsWithRadioButton.Size = new Size(85, 20);
            this.BeginsWithRadioButton.TabIndex = 1;
            this.BeginsWithRadioButton.Text = "Begins With";
            // 
            // EndsWithRadioButton
            // 
            this.EndsWithRadioButton.Location = new Point(180, 18);
            this.EndsWithRadioButton.Name = "EndsWithRadioButton";
            this.EndsWithRadioButton.Size = new Size(75, 20);
            this.EndsWithRadioButton.TabIndex = 2;
            this.EndsWithRadioButton.Text = "Ends With";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new Point(15, 75);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new Size(530, 23);
            this.SearchTextBox.TabIndex = 3;
            // 
            // ResultsGroupBox
            // 
            this.ResultsGroupBox.Controls.Add(this.ResultsTextBox);
            this.ResultsGroupBox.Controls.Add(this.ExportToPathLabel);
            this.ResultsGroupBox.Controls.Add(this.ExportPathTextBox);
            this.ResultsGroupBox.Controls.Add(this.ExportButton);
            this.ResultsGroupBox.Location = new Point(400, 150);
            this.ResultsGroupBox.Name = "ResultsGroupBox";
            this.ResultsGroupBox.Size = new Size(560, 360);
            this.ResultsGroupBox.TabIndex = 3;
            this.ResultsGroupBox.TabStop = false;
            this.ResultsGroupBox.Text = "Results";
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.BackColor = Color.White;
            this.ResultsTextBox.Location = new Point(15, 25);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = ScrollBars.Both;
            this.ResultsTextBox.Size = new Size(530, 260);
            this.ResultsTextBox.TabIndex = 0;
            // 
            // ExportToPathLabel
            // 
            this.ExportToPathLabel.Location = new Point(15, 295);
            this.ExportToPathLabel.Name = "ExportToPathLabel";
            this.ExportToPathLabel.Size = new Size(90, 20);
            this.ExportToPathLabel.TabIndex = 1;
            this.ExportToPathLabel.Text = "Export To Path:";
            // 
            // ExportPathTextBox
            // 
            this.ExportPathTextBox.Location = new Point(110, 293);
            this.ExportPathTextBox.Name = "ExportPathTextBox";
            this.ExportPathTextBox.Size = new Size(435, 23);
            this.ExportPathTextBox.TabIndex = 2;
            this.ExportPathTextBox.Text = "C:\\WorkArea\\Scripts";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new Point(15, 322);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new Size(100, 30);
            this.ExportButton.TabIndex = 3;
            this.ExportButton.Text = "Export";
            // 
            // YQuery
            // 
            this.ClientSize = new Size(980, 520);
            this.Controls.Add(this.DatabaseConnectionGroupBox);
            this.Controls.Add(this.DatabaseNameSelectionGroupBox);
            this.Controls.Add(this.ChangeServerButton);
            this.Controls.Add(this.ChangeDatabaseButton);
            this.Controls.Add(this.SearchOptionsGroupBox);
            this.Controls.Add(this.ResultsGroupBox);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "YQuery";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Export Script";
            this.DatabaseConnectionGroupBox.ResumeLayout(false);
            this.DatabaseConnectionGroupBox.PerformLayout();
            this.AuthenticationGroupBox.ResumeLayout(false);
            this.DatabaseNameSelectionGroupBox.ResumeLayout(false);
            this.SearchOptionsGroupBox.ResumeLayout(false);
            this.SearchOptionsGroupBox.PerformLayout();
            this.SearchInGroupBox.ResumeLayout(false);
            this.ConditionGroupBox.ResumeLayout(false);
            this.ResultsGroupBox.ResumeLayout(false);
            this.ResultsGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}