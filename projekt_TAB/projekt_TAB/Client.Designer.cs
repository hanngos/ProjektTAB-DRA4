
namespace projekt_TAB
{
    partial class Client
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.deactivateButton = new System.Windows.Forms.Button();
            this.createRequestButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.requestTreeView = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addSystemButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(712, 0);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(356, 59);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // deactivateButton
            // 
            this.deactivateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.deactivateButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deactivateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deactivateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactivateButton.ForeColor = System.Drawing.Color.White;
            this.deactivateButton.Location = new System.Drawing.Point(0, 0);
            this.deactivateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deactivateButton.Name = "deactivateButton";
            this.deactivateButton.Size = new System.Drawing.Size(356, 59);
            this.deactivateButton.TabIndex = 1;
            this.deactivateButton.Text = "Deactivate";
            this.deactivateButton.UseVisualStyleBackColor = false;
            this.deactivateButton.Click += new System.EventHandler(this.deactivateButton_Click);
            // 
            // createRequestButton
            // 
            this.createRequestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.createRequestButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createRequestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRequestButton.ForeColor = System.Drawing.Color.White;
            this.createRequestButton.Location = new System.Drawing.Point(0, 556);
            this.createRequestButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createRequestButton.Name = "createRequestButton";
            this.createRequestButton.Size = new System.Drawing.Size(1068, 59);
            this.createRequestButton.TabIndex = 2;
            this.createRequestButton.Text = "Create Request";
            this.createRequestButton.UseVisualStyleBackColor = false;
            this.createRequestButton.Click += new System.EventHandler(this.createRequestButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Requests";
            // 
            // requestTreeView
            // 
            this.requestTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.requestTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.requestTreeView.Location = new System.Drawing.Point(9, 35);
            this.requestTreeView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requestTreeView.Name = "requestTreeView";
            this.requestTreeView.Size = new System.Drawing.Size(617, 438);
            this.requestTreeView.TabIndex = 4;
            this.requestTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.requestTreeView_NodeMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.createRequestButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 615);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.descriptionTextBox);
            this.panel4.Controls.Add(this.resultTextBox);
            this.panel4.Controls.Add(this.nameTextBox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.statusTextBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(635, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(430, 496);
            this.panel4.TabIndex = 45;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(16, 191);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(397, 129);
            this.descriptionTextBox.TabIndex = 34;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resultTextBox.Location = new System.Drawing.Point(16, 357);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(397, 126);
            this.resultTextBox.TabIndex = 36;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.Location = new System.Drawing.Point(16, 73);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(397, 22);
            this.nameTextBox.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Description";
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.statusTextBox.Location = new System.Drawing.Point(16, 132);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(397, 22);
            this.statusTextBox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 333);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Result";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addSystemButton);
            this.panel3.Controls.Add(this.logoutButton);
            this.panel3.Controls.Add(this.deactivateButton);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1068, 59);
            this.panel3.TabIndex = 44;
            // 
            // addSystemButton
            // 
            this.addSystemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.addSystemButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addSystemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addSystemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSystemButton.ForeColor = System.Drawing.Color.White;
            this.addSystemButton.Location = new System.Drawing.Point(356, 0);
            this.addSystemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addSystemButton.Name = "addSystemButton";
            this.addSystemButton.Size = new System.Drawing.Size(356, 59);
            this.addSystemButton.TabIndex = 2;
            this.addSystemButton.Text = "Add System";
            this.addSystemButton.UseVisualStyleBackColor = false;
            this.addSystemButton.Click += new System.EventHandler(this.addSystemButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.requestTreeView);
            this.panel2.Location = new System.Drawing.Point(3, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 475);
            this.panel2.TabIndex = 43;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1068, 615);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Client";
            this.Text = "Client";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button deactivateButton;
        private System.Windows.Forms.Button createRequestButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView requestTreeView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button addSystemButton;
    }
}