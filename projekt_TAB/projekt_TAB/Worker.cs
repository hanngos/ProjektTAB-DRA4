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
    public partial class Worker : Form
    {
        Main parent;
        int worker_id;
        DataLayer.Task selectedTask;
        public Worker(Main parentIn, int id)
        {
            InitializeComponent();
            parent = parentIn;
            worker_id = id;
            refershTreeView();
        }
        private void GetProperStatuses()
        {
            statusComboBox.Items.Clear();
            string status = "";
            if (selectedTask != null) status = selectedTask.status;

            switch (status)
            {
                case "ASS":
                    break;//do zakomentowania - tego nie ma
                case "OPN":;
                    statusComboBox.Items.Add(Utils.GetStatusName("PRO"));
                    statusComboBox.Items.Add(Utils.GetStatusName("FIN"));
                    statusComboBox.Items.Add(Utils.GetStatusName("CAN"));
                    break;
                case "PRO":
                    statusComboBox.Items.Add(Utils.GetStatusName("FIN"));
                    statusComboBox.Items.Add(Utils.GetStatusName("CAN"));
                    break;
                case "CAN":
                    break;
                case "FIN":
                    break;
                default:
                    statusComboBox.Items.Add(Utils.GetStatus());
                    break;
            }
        }
        private void historyButton_Click(object sender, EventArgs e)
        {
            string message = "";

            if (selectedTask != null)
            {
                Task_status_history[] his = HistoryClass.GetTaskHistoryByTaskId(selectedTask.id_task);

                for (int i = 0; i < his.Length; i++)
                {
                    message += his[i].date + "\t" + Utils.GetStatusName(his[i].status) + "\n";
                }
                MessageBox.Show(message, selectedTask.name + " Task History");
            }
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Main());
/*                        var result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
            {
                MessageBox.Show("You have been logged out", "Result");
                parent.openChildForm(new Main());
            }*/   
        }
        private void applyButton_Click(object sender, EventArgs e)
        {
            string status = Utils.GetStatusCode(statusComboBox.Text);
            if (taskTreeView.SelectedNode.Level == 0)
            {
                if ((status == "FIN" || status == "CAN") && String.IsNullOrEmpty(resultTextBox.Text))
                    MessageBox.Show("Before you finish or cancel the task,\n" +
                        "please provide some final remarks!!", "No final results provided!");
                else
                {
                    int priority = Convert.ToInt32(priorityNumericUpDown.Value);
                    if (status == "FIN" || status == "CAN") priority = 0;
                    if (status != selectedTask.status) HistoryClass.CreateTaskHistory(selectedTask.id_task, status, DateTime.Now);
                    TaskClass.UpdateTask(status, selectedTask.worker_id, descriptionTextBox.Text, resultTextBox.Text, selectedTask.id_task, priority);
                }
            }

            refershTreeView();
        }
        private void taskTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                DataLayer.Task task = (DataLayer.Task)e.Node.Tag;
                selectedTask = task;
                nameLabel.Text = task.name;
                idLabel.Text = task.id_task.ToString();
                //statusComboBox.Enabled = true;
                statusComboBox.Text = Utils.GetStatusName(task.status);
                descriptionTextBox.Text = task.description;
                typeLabel.Text = Utils.GetTaskTypeName(task.type);
                resultTextBox.Text = task.result;
                //priorityNumericUpDown.Enabled = true;
                if (task.priority == 0)
                    priorityNumericUpDown.Minimum = 0;
                else priorityNumericUpDown.Minimum = 1;
                priorityNumericUpDown.Value = task.priority;
            }

            if (selectedTask != null)
                historyButton.Enabled = true;
            else historyButton.Enabled = false;

            if (selectedTask.status != "FIN" && selectedTask.status != "CAN")
            {
                applyButton.Enabled = true;
                statusComboBox.Enabled = true;
                priorityNumericUpDown.Enabled = true;
                descriptionTextBox.ReadOnly = false;
                resultTextBox.ReadOnly = false;
            }
            else
            {
                statusComboBox.Enabled = false;
                applyButton.Enabled = false;
                priorityNumericUpDown.Enabled = false;
                descriptionTextBox.ReadOnly = true;
                resultTextBox.ReadOnly = true;
            }

            GetProperStatuses();
        }
        private void refershTreeView()
        {
            statusComboBox.Enabled = false;           
            taskTreeView.Nodes.Clear();
            applyButton.Enabled = false;
            historyButton.Enabled = false;
            priorityNumericUpDown.Enabled = false;
            descriptionTextBox.ReadOnly = true;
            resultTextBox.ReadOnly = true;

            idLabel.Text = "";
            nameLabel.Text = "";
            typeLabel.Text = "";
            statusComboBox.Text = "";          
            descriptionTextBox.Text = "";
            resultTextBox.Text = "";
            priorityNumericUpDown.Value = 1;
            priorityNumericUpDown.Minimum = 1;

            DataLayer.Task[] tasks = TaskClass.GetTasksByWorkerId(worker_id);

            for (int k = 0; k < tasks.Length; k++)
            {
                taskTreeView.Nodes.Add(tasks[k].name);
                taskTreeView.Nodes[k].Tag = tasks[k];
                taskTreeView.Nodes[k].ForeColor = OtherUtils.statusColor[tasks[k].status];
            }
        }

    }
}
