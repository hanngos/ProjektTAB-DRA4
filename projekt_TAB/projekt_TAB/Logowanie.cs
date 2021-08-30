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
using DataLayer;

namespace projekt_TAB
{
    public partial class Logowanie : Form
    {
        Main parent;
        public Logowanie(Main parentIn)
        {
            InitializeComponent();
            parent = parentIn;
            passwordTextBox.UseSystemPasswordChar = true;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            if (!ManClass.CheckIfLoginExists(loginTextBox.Text))
            {
                MessageBox.Show("There is no such account!\nPlease enter the proper login or create an account!", "Wrong login!");
            }
            else
            {
                Man man = ManClass.GetManByLoginAndPassword(loginTextBox.Text, OtherUtils.HashPassword(passwordTextBox.Text));
                if (man == null)
                    MessageBox.Show("Wrong password!\nPlease enter the proper one or click \"I forgot password!\"", "Wrong password!");
                else if (man.is_active == false)
                    MessageBox.Show("Account is not active!\nPlease wait for activation!", "Account is not active!");
                else
                {
                    switch (man.role)
                    {
                        case "ACC":
                            parent.openChildForm(new AccMan(parent, man.id_man));
                            break;
                        case "CLI":
                            parent.openChildForm(new Client(parent, man.id_man));
                            break;
                        case "PRO":
                            parent.openChildForm(new ProdMan(parent, man.id_man));
                            break;
                        case "WRK":
                            parent.openChildForm(new Worker(parent, man.id_man));
                            break;
                        case "ADM":
                            parent.openChildForm(new Admin(parent));
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To reset Your password call the Administrator: 666 090 991.", "I forgot password", MessageBoxButtons.OK);
        }
        private void noAccountButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Rejestracja(parent));
        }
    }
}
