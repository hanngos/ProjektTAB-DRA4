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
    public partial class Task : Form
    {
        Main parent;
        String origin;
        int parent_id;
        int issue_id;
        public Task(Main parentIn, String _origin, Nullable<int> iss_id, int _parent_id)
        {
            InitializeComponent();
            parent = parentIn;
            origin = _origin;
            parent_id = _parent_id;
            statusTextBox.Text = "TO ASSIGN";
            statusTextBox.ReadOnly = true;
            typeComboBox.Items.AddRange(Utils.GetTaskType());
            issue_id = iss_id ?? 0;
            if (iss_id != null) issueNameTextBox.Text = IssueClass.GetIssuesById(issue_id).name;
            issueNameTextBox.ReadOnly = true;
            priorityNumericUpDown.Minimum = 1;
            //issueNameComboBox.Text = IssueClass.GetIssuesById(issue_id).name;
        }
        private string CheckIfFilled()
        {
            string message = "";
            if (String.IsNullOrEmpty(nameText.Text)) message += "Name field\n";
            if (String.IsNullOrEmpty(typeComboBox.Text)) message += "Type field\n";
            if (String.IsNullOrEmpty(descriptionText.Text)) message += "Description field\n";
            return message;
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
                    int id = TaskClass.CreateTask(nameText.Text, Utils.GetStatusCode(statusTextBox.Text), issue_id, Utils.GetTaskTypeCode(typeComboBox.Text), descriptionText.Text, Convert.ToInt32(priorityNumericUpDown.Value));
                    HistoryClass.CreateTaskHistory(id, Utils.GetStatusCode(statusTextBox.Text), DateTime.Now);
                    /*if (origin == "Worker")
                        parent.openChildForm(new Worker(parent));////to chyba nie jest potrzebne!*/
                    if (origin == "ProdMan")
                        parent.openChildForm(new ProdMan(parent, parent_id));
                }
            }
        }
        private void backButton_Click_1(object sender, EventArgs e)
        {
            /*if (origin == "Worker")
                parent.openChildForm(new Worker(parent));//to chyba nie jest potrzebne!!*/
            if (origin == "ProdMan")
                parent.openChildForm(new ProdMan(parent, parent_id));
        }
    }
}
