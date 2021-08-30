
namespace projekt_TAB
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("accmanGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("prodmanGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("workerGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("adminGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("clientGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.applyButton = new System.Windows.Forms.Button();
            this.employeesLabel = new System.Windows.Forms.Label();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Panel();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.Active = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.listPanel = new System.Windows.Forms.Panel();
            this.employeesListView = new System.Windows.Forms.ListView();
            this.loginColumn1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewRequests = new System.Windows.Forms.Button();
            this.backgroundPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.lastNameLabel.SuspendLayout();
            this.listPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.applyButton.ForeColor = System.Drawing.Color.White;
            this.applyButton.Location = new System.Drawing.Point(0, 499);
            this.applyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(1043, 59);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.updateEmployeeButton_Click);
            // 
            // employeesLabel
            // 
            this.employeesLabel.AutoSize = true;
            this.employeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.employeesLabel.ForeColor = System.Drawing.Color.White;
            this.employeesLabel.Location = new System.Drawing.Point(12, 0);
            this.employeesLabel.Name = "employeesLabel";
            this.employeesLabel.Size = new System.Drawing.Size(134, 29);
            this.employeesLabel.TabIndex = 4;
            this.employeesLabel.Text = "Employees";
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.backgroundPanel.Controls.Add(this.panel1);
            this.backgroundPanel.Controls.Add(this.lastNameLabel);
            this.backgroundPanel.Controls.Add(this.listPanel);
            this.backgroundPanel.Controls.Add(this.applyButton);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Margin = new System.Windows.Forms.Padding(4);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(1043, 558);
            this.backgroundPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.viewRequests);
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.addEmployeeButton);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 59);
            this.panel1.TabIndex = 8;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(731, 0);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(343, 59);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.addEmployeeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.addEmployeeButton.Location = new System.Drawing.Point(0, 0);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(354, 59);
            this.addEmployeeButton.TabIndex = 3;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Controls.Add(this.activeCheckBox);
            this.lastNameLabel.Controls.Add(this.roleComboBox);
            this.lastNameLabel.Controls.Add(this.lastNameTextBox);
            this.lastNameLabel.Controls.Add(this.firstNameTextBox);
            this.lastNameLabel.Controls.Add(this.passwordTextBox);
            this.lastNameLabel.Controls.Add(this.loginLabel);
            this.lastNameLabel.Controls.Add(this.roleLabel);
            this.lastNameLabel.Controls.Add(this.LastName);
            this.lastNameLabel.Controls.Add(this.FirstName);
            this.lastNameLabel.Controls.Add(this.Active);
            this.lastNameLabel.Controls.Add(this.Password);
            this.lastNameLabel.Controls.Add(this.Login);
            this.lastNameLabel.Location = new System.Drawing.Point(653, 74);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(414, 434);
            this.lastNameLabel.TabIndex = 7;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.activeCheckBox.Location = new System.Drawing.Point(113, 159);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(18, 17);
            this.activeCheckBox.TabIndex = 12;
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // roleComboBox
            // 
            this.roleComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roleComboBox.ForeColor = System.Drawing.Color.Black;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(113, 309);
            this.roleComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(265, 28);
            this.roleComboBox.TabIndex = 11;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameTextBox.Location = new System.Drawing.Point(113, 267);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(267, 27);
            this.lastNameTextBox.TabIndex = 9;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firstNameTextBox.Location = new System.Drawing.Point(113, 214);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(267, 26);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordTextBox.Location = new System.Drawing.Point(113, 108);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(267, 26);
            this.passwordTextBox.TabIndex = 7;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(113, 53);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(44, 20);
            this.loginLabel.TabIndex = 6;
            this.loginLabel.Text = "login";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roleLabel.ForeColor = System.Drawing.Color.White;
            this.roleLabel.Location = new System.Drawing.Point(20, 318);
            this.roleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(43, 20);
            this.roleLabel.TabIndex = 5;
            this.roleLabel.Text = "Role";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LastName.ForeColor = System.Drawing.Color.White;
            this.LastName.Location = new System.Drawing.Point(20, 265);
            this.LastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(91, 20);
            this.LastName.TabIndex = 4;
            this.LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FirstName.ForeColor = System.Drawing.Color.White;
            this.FirstName.Location = new System.Drawing.Point(20, 212);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(92, 20);
            this.FirstName.TabIndex = 3;
            this.FirstName.Text = "First Name";
            // 
            // Active
            // 
            this.Active.AutoSize = true;
            this.Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Active.ForeColor = System.Drawing.Color.White;
            this.Active.Location = new System.Drawing.Point(20, 159);
            this.Active.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(55, 20);
            this.Active.TabIndex = 2;
            this.Active.Text = "Active";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(20, 106);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(83, 20);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(20, 53);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(50, 20);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.employeesListView);
            this.listPanel.Controls.Add(this.employeesLabel);
            this.listPanel.Location = new System.Drawing.Point(0, 74);
            this.listPanel.Margin = new System.Windows.Forms.Padding(4);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(645, 460);
            this.listPanel.TabIndex = 6;
            // 
            // employeesListView
            // 
            this.employeesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employeesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.loginColumn1,
            this.firstNameColumn,
            this.lastNameColumn});
            this.employeesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.employeesListView.FullRowSelect = true;
            this.employeesListView.GridLines = true;
            listViewGroup11.Header = "accmanGroup";
            listViewGroup11.Name = "Account Managers";
            listViewGroup12.Header = "prodmanGroup";
            listViewGroup12.Name = "Product Managers";
            listViewGroup13.Header = "workerGroup";
            listViewGroup13.Name = "Workers";
            listViewGroup14.Header = "adminGroup";
            listViewGroup14.Name = "Admins";
            listViewGroup15.Header = "clientGroup";
            listViewGroup15.Name = "Clients";
            this.employeesListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup11,
            listViewGroup12,
            listViewGroup13,
            listViewGroup14,
            listViewGroup15});
            this.employeesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.employeesListView.HideSelection = false;
            this.employeesListView.Location = new System.Drawing.Point(16, 32);
            this.employeesListView.MultiSelect = false;
            this.employeesListView.Name = "employeesListView";
            this.employeesListView.Size = new System.Drawing.Size(650, 440);
            this.employeesListView.TabIndex = 7;
            this.employeesListView.UseCompatibleStateImageBehavior = false;
            this.employeesListView.View = System.Windows.Forms.View.Details;
            this.employeesListView.SelectedIndexChanged += new System.EventHandler(this.employeesListView_SelectedIndexChanged);
            // 
            // loginColumn1
            // 
            this.loginColumn1.Text = "Login";
            this.loginColumn1.Width = 152;
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.Text = "First Name";
            this.firstNameColumn.Width = 152;
            // 
            // lastNameColumn
            // 
            this.lastNameColumn.Text = "Last Name";
            this.lastNameColumn.Width = 152;
            // 
            // viewRequests
            // 
            this.viewRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.viewRequests.Dock = System.Windows.Forms.DockStyle.Left;
            this.viewRequests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.viewRequests.ForeColor = System.Drawing.Color.White;
            this.viewRequests.Location = new System.Drawing.Point(354, 0);
            this.viewRequests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewRequests.Name = "viewRequests";
            this.viewRequests.Size = new System.Drawing.Size(381, 59);
            this.viewRequests.TabIndex = 5;
            this.viewRequests.Text = "View Requests";
            this.viewRequests.UseVisualStyleBackColor = false;
            this.viewRequests.Click += new System.EventHandler(this.viewRequests_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 558);
            this.Controls.Add(this.backgroundPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1061, 605);
            this.MinimumSize = new System.Drawing.Size(1061, 605);
            this.Name = "Admin";
            this.Text = "Admin";
            this.backgroundPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.lastNameLabel.ResumeLayout(false);
            this.lastNameLabel.PerformLayout();
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label employeesLabel;
        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Panel lastNameLabel;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label Active;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.ListView employeesListView;
        private System.Windows.Forms.ColumnHeader firstNameColumn;
        private System.Windows.Forms.ColumnHeader lastNameColumn;
        private System.Windows.Forms.ColumnHeader loginColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button viewRequests;
    }
}