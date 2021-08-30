namespace projekt_TAB
{
    partial class Logowanie
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.forgotPasswordButton = new System.Windows.Forms.Button();
            this.noAccountButton = new System.Windows.Forms.Button();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.backgroundPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(12, 35);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(57, 24);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(8, 115);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(92, 24);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginTextBox.Location = new System.Drawing.Point(12, 62);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(760, 16);
            this.loginTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordTextBox.Location = new System.Drawing.Point(12, 142);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(760, 16);
            this.passwordTextBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(0, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(800, 48);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Log In";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // forgotPasswordButton
            // 
            this.forgotPasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.forgotPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forgotPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.forgotPasswordButton.ForeColor = System.Drawing.Color.White;
            this.forgotPasswordButton.Location = new System.Drawing.Point(400, 52);
            this.forgotPasswordButton.Name = "forgotPasswordButton";
            this.forgotPasswordButton.Size = new System.Drawing.Size(400, 48);
            this.forgotPasswordButton.TabIndex = 5;
            this.forgotPasswordButton.Text = "I forgot password";
            this.forgotPasswordButton.UseVisualStyleBackColor = false;
            this.forgotPasswordButton.Click += new System.EventHandler(this.forgotPasswordButton_Click);
            // 
            // noAccountButton
            // 
            this.noAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(9)))), ((int)(((byte)(159)))));
            this.noAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.noAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noAccountButton.ForeColor = System.Drawing.Color.White;
            this.noAccountButton.Location = new System.Drawing.Point(0, 52);
            this.noAccountButton.Name = "noAccountButton";
            this.noAccountButton.Size = new System.Drawing.Size(400, 48);
            this.noAccountButton.TabIndex = 6;
            this.noAccountButton.Text = "I don\'t have an account";
            this.noAccountButton.UseVisualStyleBackColor = false;
            this.noAccountButton.Click += new System.EventHandler(this.noAccountButton_Click);
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.Controls.Add(this.dataPanel);
            this.backgroundPanel.Controls.Add(this.buttonsPanel);
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(800, 500);
            this.backgroundPanel.TabIndex = 8;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.noAccountButton);
            this.buttonsPanel.Controls.Add(this.forgotPasswordButton);
            this.buttonsPanel.Controls.Add(this.okButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 400);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(800, 100);
            this.buttonsPanel.TabIndex = 7;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.passwordTextBox);
            this.dataPanel.Controls.Add(this.passwordLabel);
            this.dataPanel.Controls.Add(this.loginLabel);
            this.dataPanel.Controls.Add(this.loginTextBox);
            this.dataPanel.Location = new System.Drawing.Point(0, 100);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(800, 200);
            this.dataPanel.TabIndex = 8;
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.backgroundPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.backgroundPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button forgotPasswordButton;
        private System.Windows.Forms.Button noAccountButton;
        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Panel dataPanel;
    }
}