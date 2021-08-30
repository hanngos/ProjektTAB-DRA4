
namespace projekt_TAB
{
    partial class AccMan
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
            this.applyButton = new System.Windows.Forms.Button();
            this.createRequestButton = new System.Windows.Forms.Button();
            this.createIssueButton = new System.Windows.Forms.Button();
            this.createSystemButton = new System.Windows.Forms.Button();
            this.updateSystemButton = new System.Windows.Forms.Button();
            this.requestTreeView = new System.Windows.Forms.TreeView();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.personComboBox = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.historyButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.priorityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.NameL = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumericUpDown)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.applyButton.ForeColor = System.Drawing.Color.White;
            this.applyButton.Location = new System.Drawing.Point(0, 556);
            this.applyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(1067, 59);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // createRequestButton
            // 
            this.createRequestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.createRequestButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.createRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createRequestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createRequestButton.ForeColor = System.Drawing.Color.White;
            this.createRequestButton.Location = new System.Drawing.Point(0, 0);
            this.createRequestButton.Margin = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.createRequestButton.Name = "createRequestButton";
            this.createRequestButton.Size = new System.Drawing.Size(178, 59);
            this.createRequestButton.TabIndex = 1;
            this.createRequestButton.Text = "Create Request";
            this.createRequestButton.UseVisualStyleBackColor = false;
            this.createRequestButton.Click += new System.EventHandler(this.createRequestButton_Click);
            // 
            // createIssueButton
            // 
            this.createIssueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.createIssueButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.createIssueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createIssueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createIssueButton.ForeColor = System.Drawing.Color.White;
            this.createIssueButton.Location = new System.Drawing.Point(178, 0);
            this.createIssueButton.Margin = new System.Windows.Forms.Padding(0);
            this.createIssueButton.Name = "createIssueButton";
            this.createIssueButton.Size = new System.Drawing.Size(178, 59);
            this.createIssueButton.TabIndex = 2;
            this.createIssueButton.Text = "Create Issue";
            this.createIssueButton.UseVisualStyleBackColor = false;
            this.createIssueButton.Click += new System.EventHandler(this.createIssueButton_Click);
            // 
            // createSystemButton
            // 
            this.createSystemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.createSystemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createSystemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createSystemButton.ForeColor = System.Drawing.Color.White;
            this.createSystemButton.Location = new System.Drawing.Point(534, 1);
            this.createSystemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createSystemButton.Name = "createSystemButton";
            this.createSystemButton.Size = new System.Drawing.Size(177, 59);
            this.createSystemButton.TabIndex = 4;
            this.createSystemButton.Text = "Create System";
            this.createSystemButton.UseVisualStyleBackColor = false;
            this.createSystemButton.Click += new System.EventHandler(this.createSystemButton_Click);
            // 
            // updateSystemButton
            // 
            this.updateSystemButton.AutoSize = true;
            this.updateSystemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.updateSystemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateSystemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateSystemButton.ForeColor = System.Drawing.Color.White;
            this.updateSystemButton.Location = new System.Drawing.Point(710, 1);
            this.updateSystemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateSystemButton.Name = "updateSystemButton";
            this.updateSystemButton.Size = new System.Drawing.Size(178, 59);
            this.updateSystemButton.TabIndex = 5;
            this.updateSystemButton.Text = "Update System";
            this.updateSystemButton.UseVisualStyleBackColor = false;
            this.updateSystemButton.Click += new System.EventHandler(this.updateSystemButton_Click);
            // 
            // requestTreeView
            // 
            this.requestTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.requestTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.requestTreeView.Location = new System.Drawing.Point(9, 41);
            this.requestTreeView.Margin = new System.Windows.Forms.Padding(0);
            this.requestTreeView.Name = "requestTreeView";
            this.requestTreeView.Size = new System.Drawing.Size(629, 447);
            this.requestTreeView.TabIndex = 6;
            this.requestTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.requestTreeView_NodeMouseClick);
            // 
            // statusComboBox
            // 
            this.statusComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.statusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(669, 209);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(388, 24);
            this.statusComboBox.TabIndex = 7;
            // 
            // personComboBox
            // 
            this.personComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.personComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.personComboBox.FormattingEnabled = true;
            this.personComboBox.Location = new System.Drawing.Point(669, 257);
            this.personComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personComboBox.Name = "personComboBox";
            this.personComboBox.Size = new System.Drawing.Size(388, 24);
            this.personComboBox.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(665, 89);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 9;
            this.ID.Text = "ID";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.Location = new System.Drawing.Point(796, 89);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(22, 20);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "id";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Type.ForeColor = System.Drawing.Color.White;
            this.Type.Location = new System.Drawing.Point(665, 157);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(45, 20);
            this.Type.TabIndex = 11;
            this.Type.Text = "Type";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeLabel.ForeColor = System.Drawing.Color.White;
            this.typeLabel.Location = new System.Drawing.Point(796, 157);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(40, 20);
            this.typeLabel.TabIndex = 12;
            this.typeLabel.Text = "type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(664, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(664, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Assigned person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(665, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Result";
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resultTextBox.ForeColor = System.Drawing.Color.Black;
            this.resultTextBox.Location = new System.Drawing.Point(669, 461);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(388, 86);
            this.resultTextBox.TabIndex = 16;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(669, 357);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(388, 80);
            this.descriptionTextBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(665, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Description";
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(887, 0);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(180, 59);
            this.logOutButton.TabIndex = 19;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.historyButton);
            this.panel1.Controls.Add(this.createIssueButton);
            this.panel1.Controls.Add(this.createRequestButton);
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.updateSystemButton);
            this.panel1.Controls.Add(this.createSystemButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 59);
            this.panel1.TabIndex = 20;
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.historyButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.historyButton.ForeColor = System.Drawing.Color.White;
            this.historyButton.Location = new System.Drawing.Point(356, 0);
            this.historyButton.Margin = new System.Windows.Forms.Padding(0);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(178, 59);
            this.historyButton.TabIndex = 20;
            this.historyButton.Text = "View History";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.priorityLabel);
            this.panel2.Controls.Add(this.priorityNumericUpDown);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.NameL);
            this.panel2.Controls.Add(this.nameLabel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.resultTextBox);
            this.panel2.Controls.Add(this.applyButton);
            this.panel2.Controls.Add(this.descriptionTextBox);
            this.panel2.Controls.Add(this.statusComboBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.personComboBox);
            this.panel2.Controls.Add(this.ID);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.idLabel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Type);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.typeLabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 615);
            this.panel2.TabIndex = 21;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priorityLabel.ForeColor = System.Drawing.Color.White;
            this.priorityLabel.Location = new System.Drawing.Point(665, 283);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(62, 20);
            this.priorityLabel.TabIndex = 45;
            this.priorityLabel.Text = "Priority";
            // 
            // priorityNumericUpDown
            // 
            this.priorityNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priorityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priorityNumericUpDown.Location = new System.Drawing.Point(669, 306);
            this.priorityNumericUpDown.Name = "priorityNumericUpDown";
            this.priorityNumericUpDown.Size = new System.Drawing.Size(388, 26);
            this.priorityNumericUpDown.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.requestTreeView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 497);
            this.panel3.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(4, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 29);
            this.label11.TabIndex = 7;
            this.label11.Text = "Requests";
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameL.ForeColor = System.Drawing.Color.White;
            this.NameL.Location = new System.Drawing.Point(664, 122);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(53, 20);
            this.NameL.TabIndex = 21;
            this.NameL.Text = "Name";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(796, 122);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 20);
            this.nameLabel.TabIndex = 22;
            this.nameLabel.Text = "name";
            // 
            // AccMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 608);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1083, 655);
            this.MinimumSize = new System.Drawing.Size(1083, 655);
            this.Name = "AccMan";
            this.Text = "AccMan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumericUpDown)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button createRequestButton;
        private System.Windows.Forms.Button createIssueButton;
        private System.Windows.Forms.Button createSystemButton;
        private System.Windows.Forms.Button updateSystemButton;
        private System.Windows.Forms.TreeView requestTreeView;
        private System.Windows.Forms.ComboBox personComboBox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.NumericUpDown priorityNumericUpDown;
    }
}