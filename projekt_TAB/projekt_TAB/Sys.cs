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
    public partial class Sys : Form
    {
        Main parent;
        string origin;
        string action;
        int parent_id;

        public Sys(Main parentIn, string _origin, string _action, int _parent_id)
        {
            InitializeComponent();
            parent = parentIn;
            parent_id = _parent_id;
            action = _action;
            origin = _origin;
            if (action == "create")
            {
                versionNumericUpDown.Minimum = 1;
                nameTextBox.Visible = true;
                nameComboBox.Visible = false;
            }
            else if (action == "update")
            {
                nameTextBox.Visible = false;
                nameComboBox.Visible = true;
                nameComboBox.Items.AddRange(SystemClass.GetSystems());
            }
            else if (action == "add")
            {
                nameTextBox.Visible = false;
                nameComboBox.Visible = true;
                nameComboBox.Items.AddRange(SystemClass.GetSystems());
                DataLayer.System_Client[] sys_cli = SystemClass.GetSystemsClientsByClientId(parent_id);
                for (int i = 0; i< sys_cli.Length; i++)
                {
                    nameComboBox.Items.Remove(SystemClass.GetSystemById(sys_cli[i].system_id).name);
                }
                versionNumericUpDown.Enabled = false;
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            if (origin == "AccMan")
                parent.openChildForm(new AccMan(parent, parent_id));
            else if (origin == "Client")
                parent.openChildForm(new Client(parent, parent_id));
        }
        private string CheckIfFilled()
        {
            string message = "";
            if (String.IsNullOrEmpty(nameTextBox.Text) && String.IsNullOrEmpty(nameComboBox.Text)) message += "Name field\n";
            return message;
        }
        private void applyButton_Click(object sender, EventArgs e)
        {
            string message;
            if (!String.IsNullOrEmpty(message = CheckIfFilled()))
                MessageBox.Show("Please fill the following fields:\n" + message, "Fill all fileds!");
            else
            {
                if (action == "create")
                {
                    DataLayer.System sys = SystemClass.GetSystem(nameTextBox.Text);
                    if (sys != null)
                    {
                        MessageBox.Show("There is a system in database with exactly the same name!\nPlease provide different one!" + message, "The same name!");
                    }
                    else if (sys == null)
                    {
                        DialogResult result = MessageBox.Show("Do you want to apply?", "Caution", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            int id = SystemClass.CreateSystem(nameTextBox.Text, versionNumericUpDown.Value.ToString());
                            SystemClass.CreateSystemClient(id, (int)ManClass.GetManIdByLogin("INTERNAL"));
                            backButton_Click(sender, e);
                        }
                    }
                }
                else if (action == "update")
                {
                    decimal version = versionNumericUpDown.Value;
                    DataLayer.System system = SystemClass.GetSystem(nameComboBox.Text);
                    if (version == int.Parse(system.versions))
                        MessageBox.Show("You haven't changed version in this system\n" +
                            "Why do you want to update?" + message, "No update?");
                    else
                    {
                        DialogResult result = MessageBox.Show("Do you want to apply?", "Caution", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            SystemClass.UpadeSystem(system.id_sys, nameComboBox.Text, versionNumericUpDown.Value.ToString());
                            SystemClass.UpadeSystemClient(system.id_sys, (int)ManClass.GetManIdByLogin("INTERNAL"), versionNumericUpDown.Value.ToString());
                            backButton_Click(sender, e);
                        }
                    }
                }
                else if (action == "add")
                {
                    DataLayer.System system = SystemClass.GetSystem(nameComboBox.Text);
                    DialogResult result = MessageBox.Show("Do you want to apply?", "Caution", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        
                        SystemClass.CreateSystemClient(system.id_sys, parent_id);
                        backButton_Click(sender, e);
                    }
                }
            }
        }
        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataLayer.System system = SystemClass.GetSystem(nameComboBox.Text);
            versionNumericUpDown.Minimum = int.Parse(system.versions);
            versionNumericUpDown.Value = int.Parse(system.versions);
        }
    }
}
