using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizLayer;
using System.Security.Cryptography;

namespace projekt_TAB
{
    public partial class Rejestracja : Form
    {
        Main parent;
        public Rejestracja(Main parentIn)
        {
            InitializeComponent();
            parent = parentIn;
            passwordTextBox.UseSystemPasswordChar = true;
            repeatPasswordTextBox.UseSystemPasswordChar = true;
        }
        private string CheckIfFilled()
        {
            string message = "";
            if (String.IsNullOrEmpty(firstNameTextBox.Text)) message += "First Name field\n";
            if (String.IsNullOrEmpty(lastNameTextBox.Text)) message += "Last Name field\n";
            if (String.IsNullOrEmpty(loginTextBox.Text)) message += "Login field\n";
            if (String.IsNullOrEmpty(passwordTextBox.Text)) message += "Password field\n";
            if (String.IsNullOrEmpty(repeatPasswordTextBox.Text)) message += "Repeat Password field\n";
            if (String.IsNullOrEmpty(systemCodeTextBox.Text)) message += "System Code field\n";
            return message;
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            string message;
            if (!String.IsNullOrEmpty(message = CheckIfFilled()))
            {
                MessageBox.Show("Please fill the following fields:\n" + message, "Fill all fileds!");
            }
            else if (ManClass.CheckIfLoginExists(loginTextBox.Text))
            {
                MessageBox.Show("Login already exists!\nPlease choose different one!", "Login already exists!");
            }
            else if (passwordTextBox.Text != repeatPasswordTextBox.Text)
            {
                MessageBox.Show("You've entered two different passwords!\nRepeated password must be the same as the one you've entered!\n", "Passwords do not match!");
            }
            else if(SystemClass.GetSystem(systemCodeTextBox.Text) == null)
            {
                 MessageBox.Show("Wrong system code! Please provide correct name of existing system\n" + message, "System Code Error!");
            }
            else if (notARobotCheckBox.Checked == false)
            {
                MessageBox.Show("Please confirm that you're not a robot!\n" + message, "Are you a human?");
            }
            else
            {
                DataLayer.System system = SystemClass.GetSystem(systemCodeTextBox.Text);
                int id_cli = ManClass.CreateMan(firstNameTextBox.Text, lastNameTextBox.Text, loginTextBox.Text, OtherUtils.HashPassword(passwordTextBox.Text), false, "CLI");
                ManClass.InsertByRole(id_cli, "CLI");
                SystemClass.CreateSystemClient(system.id_sys, id_cli);
                parent.openChildForm(new Logowanie(parent));
            }
            //password regex      
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Logowanie(parent));
        }

    }
}
