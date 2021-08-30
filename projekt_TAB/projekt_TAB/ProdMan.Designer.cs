
namespace projekt_TAB
{
    partial class ProdMan
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
            this.issueTaskTreeView = new System.Windows.Forms.TreeView();
            this.Issues = new System.Windows.Forms.Label();
            this.createTaskButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.NameL = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.Worker = new System.Windows.Forms.Label();
            this.workerComboBox = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.historyButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.priorityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.idLabel = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumericUpDown)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // issueTaskTreeView
            // 
            this.issueTaskTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(136)))));
            this.issueTaskTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.issueTaskTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.issueTaskTreeView.Location = new System.Drawing.Point(5, 55);
            this.issueTaskTreeView.Margin = new System.Windows.Forms.Padding(4);
            this.issueTaskTreeView.Name = "issueTaskTreeView";
            this.issueTaskTreeView.Size = new System.Drawing.Size(591, 434);
            this.issueTaskTreeView.TabIndex = 0;
            this.issueTaskTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.issueTaskTreeView_NodeMouseClick);
            // 
            // Issues
            // 
            this.Issues.AutoSize = true;
            this.Issues.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Issues.ForeColor = System.Drawing.Color.White;
            this.Issues.Location = new System.Drawing.Point(0, 15);
            this.Issues.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Issues.Name = "Issues";
            this.Issues.Size = new System.Drawing.Size(82, 29);
            this.Issues.TabIndex = 1;
            this.Issues.Text = "Issues";
            // 
            // createTaskButton
            // 
            this.createTaskButton.AutoSize = true;
            this.createTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.createTaskButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.createTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTaskButton.ForeColor = System.Drawing.Color.White;
            this.createTaskButton.Location = new System.Drawing.Point(0, 0);
            this.createTaskButton.Margin = new System.Windows.Forms.Padding(4);
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Size = new System.Drawing.Size(346, 59);
            this.createTaskButton.TabIndex = 2;
            this.createTaskButton.Text = "Create Task";
            this.createTaskButton.UseVisualStyleBackColor = false;
            this.createTaskButton.Click += new System.EventHandler(this.createTask_Click);
            // 
            // applyButton
            // 
            this.applyButton.AutoSize = true;
            this.applyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.applyButton.ForeColor = System.Drawing.Color.White;
            this.applyButton.Location = new System.Drawing.Point(0, 0);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(1067, 59);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.AutoSize = true;
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(699, 0);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(368, 59);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameL.ForeColor = System.Drawing.Color.White;
            this.NameL.Location = new System.Drawing.Point(25, 55);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(53, 20);
            this.NameL.TabIndex = 5;
            this.NameL.Text = "Name";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Type.ForeColor = System.Drawing.Color.White;
            this.Type.Location = new System.Drawing.Point(25, 87);
            this.Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(45, 20);
            this.Type.TabIndex = 6;
            this.Type.Text = "Type";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(163, 55);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 20);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "name";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeLabel.ForeColor = System.Drawing.Color.White;
            this.typeLabel.Location = new System.Drawing.Point(163, 87);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(40, 20);
            this.typeLabel.TabIndex = 8;
            this.typeLabel.Text = "type";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.Location = new System.Drawing.Point(25, 119);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(57, 20);
            this.Status.TabIndex = 9;
            this.Status.Text = "Status";
            // 
            // statusComboBox
            // 
            this.statusComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.statusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(29, 143);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(413, 28);
            this.statusComboBox.TabIndex = 10;
            // 
            // Worker
            // 
            this.Worker.AutoSize = true;
            this.Worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Worker.ForeColor = System.Drawing.Color.White;
            this.Worker.Location = new System.Drawing.Point(25, 175);
            this.Worker.Name = "Worker";
            this.Worker.Size = new System.Drawing.Size(63, 20);
            this.Worker.TabIndex = 11;
            this.Worker.Text = "Worker";
            // 
            // workerComboBox
            // 
            this.workerComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.workerComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.workerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.workerComboBox.FormattingEnabled = true;
            this.workerComboBox.Location = new System.Drawing.Point(29, 199);
            this.workerComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.workerComboBox.Name = "workerComboBox";
            this.workerComboBox.Size = new System.Drawing.Size(413, 28);
            this.workerComboBox.TabIndex = 12;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Description.ForeColor = System.Drawing.Color.White;
            this.Description.Location = new System.Drawing.Point(25, 283);
            this.Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(95, 20);
            this.Description.TabIndex = 13;
            this.Description.Text = "Description";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Result.ForeColor = System.Drawing.Color.White;
            this.Result.Location = new System.Drawing.Point(25, 392);
            this.Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(57, 20);
            this.Result.TabIndex = 14;
            this.Result.Text = "Result";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionTextBox.Location = new System.Drawing.Point(29, 307);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(415, 81);
            this.descriptionTextBox.TabIndex = 15;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultTextBox.Location = new System.Drawing.Point(29, 412);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(415, 77);
            this.resultTextBox.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.applyButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 556);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 59);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.historyButton);
            this.panel2.Controls.Add(this.logOutButton);
            this.panel2.Controls.Add(this.createTaskButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 59);
            this.panel2.TabIndex = 18;
            // 
            // historyButton
            // 
            this.historyButton.AutoSize = true;
            this.historyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.historyButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.historyButton.ForeColor = System.Drawing.Color.White;
            this.historyButton.Location = new System.Drawing.Point(346, 0);
            this.historyButton.Margin = new System.Windows.Forms.Padding(4);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(355, 59);
            this.historyButton.TabIndex = 5;
            this.historyButton.Text = "View History";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.issueTaskTreeView);
            this.panel3.Controls.Add(this.Issues);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 497);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.priorityLabel);
            this.panel4.Controls.Add(this.priorityNumericUpDown);
            this.panel4.Controls.Add(this.idLabel);
            this.panel4.Controls.Add(this.ID);
            this.panel4.Controls.Add(this.Description);
            this.panel4.Controls.Add(this.NameL);
            this.panel4.Controls.Add(this.Type);
            this.panel4.Controls.Add(this.nameLabel);
            this.panel4.Controls.Add(this.resultTextBox);
            this.panel4.Controls.Add(this.typeLabel);
            this.panel4.Controls.Add(this.descriptionTextBox);
            this.panel4.Controls.Add(this.Status);
            this.panel4.Controls.Add(this.Result);
            this.panel4.Controls.Add(this.statusComboBox);
            this.panel4.Controls.Add(this.Worker);
            this.panel4.Controls.Add(this.workerComboBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(596, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(471, 497);
            this.panel4.TabIndex = 20;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priorityLabel.ForeColor = System.Drawing.Color.White;
            this.priorityLabel.Location = new System.Drawing.Point(25, 231);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(62, 20);
            this.priorityLabel.TabIndex = 47;
            this.priorityLabel.Text = "Priority";
            // 
            // priorityNumericUpDown
            // 
            this.priorityNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priorityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priorityNumericUpDown.Location = new System.Drawing.Point(29, 254);
            this.priorityNumericUpDown.Name = "priorityNumericUpDown";
            this.priorityNumericUpDown.Size = new System.Drawing.Size(413, 26);
            this.priorityNumericUpDown.TabIndex = 46;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.Location = new System.Drawing.Point(163, 23);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(22, 20);
            this.idLabel.TabIndex = 18;
            this.idLabel.Text = "id";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(25, 23);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 17;
            this.ID.Text = "ID";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1067, 615);
            this.panel5.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 59);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1067, 497);
            this.panel6.TabIndex = 21;
            // 
            // ProdMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1043, 558);
            this.Controls.Add(this.panel5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1061, 605);
            this.MinimumSize = new System.Drawing.Size(1061, 605);
            this.Name = "ProdMan";
            this.Text = "ProdMan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumericUpDown)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView issueTaskTreeView;
        private System.Windows.Forms.Label Issues;
        private System.Windows.Forms.Button createTaskButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label Worker;
        private System.Windows.Forms.ComboBox workerComboBox;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.NumericUpDown priorityNumericUpDown;
    }
}