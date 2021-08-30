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

namespace projekt_TAB
{

    public partial class User : Form
    {
        Main parent;
        public User(Main parentIn)
        {
            InitializeComponent();
            parent = parentIn;
            DataLayer.Role[] roles = BizLayer.Utils.GetRoles();
            for (int i = 0; i < roles.Length; i++)
                roleComboBox.Items.Add(roles[i].role1);
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
            if (String.IsNullOrEmpty(roleComboBox.Text)) message += "Role field\n";
            return message;
        }
        private void confirmUserButton_Click(object sender, EventArgs e)
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
            else if (ManClass.GetManIdByName(lastNameTextBox.Text+", "+firstNameTextBox.Text) != null)
            {
                MessageBox.Show("You're lucky! There is your namesake in database!\nBut to make our life easier, please provide your second name!", "You have a namesake!");
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to apply changes?", "Caution", buttons);
                if (result == DialogResult.Yes)
                {
                    int id_man = ManClass.CreateMan(firstNameTextBox.Text, lastNameTextBox.Text, loginTextBox.Text, OtherUtils.HashPassword(passwordTextBox.Text), activeCheckBox.Checked, BizLayer.Utils.GetRoleCode(roleComboBox.Text));
                    ManClass.InsertByRole(id_man, Utils.GetRoleCode(roleComboBox.Text));
                    parent.openChildForm(new Admin(parent));
                }
            }   
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Admin(parent));
        }

    }
}
