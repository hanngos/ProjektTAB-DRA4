
namespace projekt_TAB
{
    partial class Worker
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
            this.taskTreeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.historyButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.priorityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.idLabel = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.NameL = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskTreeView
            // 
            this.taskTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.taskTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskTreeView.Location = new System.Drawing.Point(9, 113);
            this.taskTreeView.Margin = new System.Windows.Forms.Padding(0);
            this.taskTreeView.Name = "taskTreeView";
            this.taskTreeView.Size = new System.Drawing.Size(574, 429);
            this.taskTreeView.TabIndex = 0;
            this.taskTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.taskTreeView_NodeMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tasks";
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.historyButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.ForeColor = System.Drawing.Color.White;
            this.historyButton.Location = new System.Drawing.Point(0, 0);
            this.historyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(527, 59);
            this.historyButton.TabIndex = 5;
            this.historyButton.Text = "View History";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.ForeColor = System.Drawing.Color.White;
            this.applyButton.Location = new System.Drawing.Point(0, 556);
            this.applyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(1068, 59);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.priorityLabel);
            this.panel1.Controls.Add(this.priorityNumericUpDown);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.NameL);
            this.panel1.Controls.Add(this.typeLabel);
            this.panel1.Controls.Add(this.statusComboBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Type);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.resultTextBox);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.taskTreeView);
            this.panel1.Controls.Add(this.applyButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 615);
            this.panel1.TabIndex = 6;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priorityLabel.ForeColor = System.Drawing.Color.White;
            this.priorityLabel.Location = new System.Drawing.Point(630, 254);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(62, 20);
            this.priorityLabel.TabIndex = 49;
            this.priorityLabel.Text = "Priority";
            // 
            // priorityNumericUpDown
            // 
            this.priorityNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priorityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priorityNumericUpDown.Location = new System.Drawing.Point(634, 277);
            this.priorityNumericUpDown.Name = "priorityNumericUpDown";
            this.priorityNumericUpDown.Size = new System.Drawing.Size(413, 26);
            this.priorityNumericUpDown.TabIndex = 48;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.Location = new System.Drawing.Point(757, 87);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(22, 20);
            this.idLabel.TabIndex = 39;
            this.idLabel.Text = "id";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(630, 87);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 38;
            this.ID.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(757, 125);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 20);
            this.nameLabel.TabIndex = 37;
            this.nameLabel.Text = "name";
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameL.ForeColor = System.Drawing.Color.White;
            this.NameL.Location = new System.Drawing.Point(630, 125);
            this.NameL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(53, 20);
            this.NameL.TabIndex = 36;
            this.NameL.Text = "Name";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeLabel.ForeColor = System.Drawing.Color.White;
            this.typeLabel.Location = new System.Drawing.Point(757, 163);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(40, 20);
            this.typeLabel.TabIndex = 35;
            this.typeLabel.Text = "type";
            // 
            // statusComboBox
            // 
            this.statusComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.statusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(634, 222);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(413, 28);
            this.statusComboBox.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.logoutButton);
            this.panel2.Controls.Add(this.historyButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 59);
            this.panel2.TabIndex = 33;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(527, 0);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(541, 59);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Type.ForeColor = System.Drawing.Color.White;
            this.Type.Location = new System.Drawing.Point(630, 163);
            this.Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(45, 20);
            this.Type.TabIndex = 30;
            this.Type.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(629, 422);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(630, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(630, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Description";
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resultTextBox.Location = new System.Drawing.Point(633, 446);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(413, 96);
            this.resultTextBox.TabIndex = 25;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(633, 330);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(413, 88);
            this.descriptionTextBox.TabIndex = 23;
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1068, 615);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Worker";
            this.Text = "Worker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView taskTreeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.NumericUpDown priorityNumericUpDown;
    }
}