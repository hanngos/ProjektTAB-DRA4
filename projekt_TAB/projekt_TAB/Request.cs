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
    public partial class Request : Form
    {
        Main parent;
        String origin;
        int parent_id;
        public Request(Main parentIn, String _origin, int _id)
        {
            InitializeComponent();
            parent = parentIn;
            origin = _origin;
            parent_id = _id;

            statusTextBox.Text = "TO ASSIGN";
            statusTextBox.ReadOnly = true;
            if (origin == "AccMan")
                systemComboBox.Items.AddRange(SystemClass.GetSystems());
            else if (origin == "Client")
            {
                DataLayer.System_Client[] sys_cli = SystemClass.GetSystemsClientsByClientId(parent_id);
                for (int i = 0; i < sys_cli.Length; i++)
                    systemComboBox.Items.Add(SystemClass.GetSystemById(sys_cli[i].system_id).name);
            }
            priorityNumericUpDown.Minimum = 1;

        }
        private string CheckIfFilled()
        {
            string message = "";
            if (String.IsNullOrEmpty(nameText.Text)) message += "Name field\n";
            if (String.IsNullOrEmpty(systemComboBox.Text)) message += "System name field\n";
            if (String.IsNullOrEmpty(descriptionText.Text)) message += "Description field\n";
            return message;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            if (origin == "AccMan")
                parent.openChildForm(new AccMan(parent, parent_id));
            if (origin == "Client")
                parent.openChildForm(new Client(parent, parent_id));
        }
        private void applyButton_Click(object sender, EventArgs e)
        {
            string message;
            if (!String.IsNullOrEmpty(message = CheckIfFilled()))
            {
                MessageBox.Show("Please fill the following fields:\n" + message, "Fill all fileds!");
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to apply changes?", "Caution", buttons);
                if (result == DialogResult.Yes)
                {
                    if (origin == "AccMan")
                    {
                        int id = RequestClass.CreateRequest(nameText.Text, Utils.GetStatusCode(statusTextBox.Text), SystemClass.GetSystemId(systemComboBox.Text), (int)ManClass.GetManIdByLogin("INTERNAL"), parent_id, descriptionText.Text, Convert.ToInt32(priorityNumericUpDown.Value));
                        HistoryClass.CreateRequestHistory(id, Utils.GetStatusCode(statusTextBox.Text), DateTime.Now);
                        string status = "OPEN";
                        RequestClass.UpdateRequest(Utils.GetStatusCode(status), descriptionText.Text, "", id, parent_id, Convert.ToInt32(priorityNumericUpDown.Value));
                        HistoryClass.CreateRequestHistory(id, Utils.GetStatusCode(status), DateTime.Now);
                        parent.openChildForm(new AccMan(parent, parent_id));
                    }
                    if (origin == "Client")
                    {
                        int id = RequestClass.CreateRequest(nameText.Text, Utils.GetStatusCode(statusTextBox.Text), SystemClass.GetSystemId(systemComboBox.Text), parent_id, null, descriptionText.Text, Convert.ToInt32(priorityNumericUpDown.Value));
                        HistoryClass.CreateRequestHistory(id, Utils.GetStatusCode(statusTextBox.Text), DateTime.Now);
                        if (Workload.GetAccManIdByMinWorkLoad() != null)
                        {
                            string status = "OPEN";
                            RequestClass.UpdateRequest(Utils.GetStatusCode(status), descriptionText.Text, "", id, Workload.GetAccManIdByMinWorkLoad(), Convert.ToInt32(priorityNumericUpDown.Value));
                            HistoryClass.CreateRequestHistory(id, Utils.GetStatusCode(status), DateTime.Now);
                        }
                        else MessageBox.Show("You better run, cause this ship is sinking!", "RUN, FORREST, RUN!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        parent.openChildForm(new Client(parent, parent_id));
                    }

                    
                }
            }
        }
    }
}
