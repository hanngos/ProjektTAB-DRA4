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
    public partial class ProdMan : Form
    {
        Main parent;
        int prodman_id;
        DataLayer.Issue selectedIssue;
        DataLayer.Task selectedTask;
        public ProdMan(Main parentIn, int id)
        {
            InitializeComponent();
            parent = parentIn;
            prodman_id = id;
            workerComboBox.Items.AddRange(ManClass.GetWorkers());
            refresh();
        }
        private void GetProperStatuses()
        {
            statusComboBox.Items.Clear();
            string status = "";
            if (selectedIssue != null) status = selectedIssue.status;
            else if (selectedTask != null) status = selectedTask.status;

            switch (status)
            {
                case "ASS":
                    break;
                case "OPN":
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
        private void createTask_Click(object sender, EventArgs e)
        {
            Nullable<int> id = null;
            if (selectedIssue != null) id = selectedIssue.id_iss;
            parent.openChildForm(new Task(parent, "ProdMan", id, prodman_id));
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Logowanie(parent));
        }
        private bool CheckIfAllTasksAreFinished()
        {
            DataLayer.Task[] tasks = TaskClass.GetTasksByIssueId(selectedIssue.id_iss);
            for (int i = 0; i < tasks.Count(); i++)
                if (tasks[i].status != "FIN") return false;
            return true;
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            string status = Utils.GetStatusCode(statusComboBox.Text);
            if (issueTaskTreeView.SelectedNode.Level == 0)
            {
                if (status == "FIN" && !CheckIfAllTasksAreFinished())
                    MessageBox.Show("You cannot change the issue status to finished,\n" +
                        "because some of its tasks are not finished yet!\n" +
                        "Wait until they are!", "Some tasks are not finished!");
                else if ((status == "FIN" || status == "CAN") && String.IsNullOrEmpty(resultTextBox.Text))
                    MessageBox.Show("Before you finish or cancel the issue,\n" +
                        "please provide some final remarks!!", "No final results provided!");
                else
                {
                    int priority = Convert.ToInt32(priorityNumericUpDown.Value);
                    if (status == "FIN" || status == "CAN") priority = 0;
                    IssueClass.UpdateIssue(status, descriptionTextBox.Text, prodman_id, resultTextBox.Text, selectedIssue.id_iss, priority);
                    if (status != selectedIssue.status) HistoryClass.CreateIssueHistory(selectedIssue.id_iss, status, DateTime.Now);
                }
            }
            else if (issueTaskTreeView.SelectedNode.Level == 1)
            {
                if ((status == "FIN" || status == "CAN") && String.IsNullOrEmpty(resultTextBox.Text))
                    MessageBox.Show("Before you finish or cancel the task,\n" +
                        "please provide some final remarks!!", "No final results provided!");
                else
                {
                    string worker = workerComboBox.Text;
                    if (worker != "" && selectedTask.status == "ASS") status = "OPN";
                    if (status == "ASS") worker = "";
                    int priority = Convert.ToInt32(priorityNumericUpDown.Value);
                    if (status == "FIN" || status == "CAN") priority = 0;
                    TaskClass.UpdateTask(status, ManClass.GetManIdByName(worker), descriptionTextBox.Text, resultTextBox.Text, selectedTask.id_task, priority);
                    if (status != selectedTask.status) HistoryClass.CreateTaskHistory(selectedTask.id_task, status, DateTime.Now);
                }
            }

            refresh();
        }
        private void issueTaskTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                DataLayer.Issue iss = (DataLayer.Issue)e.Node.Tag;
                selectedIssue = iss;
                selectedTask = null;
                nameLabel.Text = iss.name;
                idLabel.Text = iss.id_iss.ToString();
                //statusComboBox.Enabled = true;
                statusComboBox.Text = Utils.GetStatusName(iss.status);
                //descriptionTextBox.ReadOnly = false;
                descriptionTextBox.Text = iss.description;
                typeLabel.Text = Utils.GetIssueTypeName(iss.type);
                resultTextBox.Text = iss.result;
                //resultTextBox.ReadOnly = false;
                workerComboBox.Text = "";
                //workerComboBox.Enabled = false;
                priorityNumericUpDown.Enabled = true;
                if (iss.priority == 0)
                    priorityNumericUpDown.Minimum = 0;
                else priorityNumericUpDown.Minimum = 1;
                priorityNumericUpDown.Value = iss.priority;
            }
            else if (e.Node.Level == 1)
            {
                DataLayer.Task task = (DataLayer.Task)e.Node.Tag;
                selectedTask = task;
                selectedIssue = null; // (DataLayer.Issue)e.Node.Parent.Tag;
                nameLabel.Text = task.name;
                idLabel.Text = task.id_task.ToString();
                //statusComboBox.Enabled = true;
                statusComboBox.Text = Utils.GetStatusName(task.status);
                descriptionTextBox.Text = task.description;
                //descriptionTextBox.ReadOnly = false;
                typeLabel.Text = Utils.GetTaskTypeName(task.type);
                resultTextBox.Text = task.result;
                //resultTextBox.ReadOnly = false;
                priorityNumericUpDown.Enabled = true;
                if (task.priority == 0)
                    priorityNumericUpDown.Minimum = 0;
                else priorityNumericUpDown.Minimum = 1;
                priorityNumericUpDown.Value = task.priority;
                //workerComboBox.Enabled = true;
                int id = task.worker_id ?? 0;
                workerComboBox.Text = ManClass.GetManNameByIdAndRole(id, "WRK");
            }

            if (selectedIssue != null || selectedTask != null) historyButton.Enabled = true;
            else historyButton.Enabled = false;

            if ((selectedIssue != null && selectedIssue.status != "FIN" && selectedIssue.status != "CAN") ||
                (selectedTask!= null && selectedTask.status != "FIN" && selectedTask.status != "CAN"))
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

            if (selectedIssue != null || (selectedTask != null && (selectedTask.status == "FIN" || selectedTask.status == "CAN"))) workerComboBox.Enabled = false;
            else workerComboBox.Enabled = true;

            if (selectedIssue != null && (selectedIssue.status != "FIN" && selectedIssue.status != "CAN")) createTaskButton.Enabled = true;
            else createTaskButton.Enabled = false;

            GetProperStatuses();
        }
        private void refresh()
        {
            statusComboBox.Enabled = false;
            workerComboBox.Enabled = false;
            historyButton.Enabled = false;
            applyButton.Enabled = false;
            createTaskButton.Enabled = false;
            descriptionTextBox.ReadOnly = true;
            resultTextBox.ReadOnly = true;
            priorityNumericUpDown.Enabled = false;

            idLabel.Text = "";
            nameLabel.Text = "";
            typeLabel.Text = "";
            statusComboBox.Text = "";
            workerComboBox.Text = "";
            descriptionTextBox.Text = "";
            resultTextBox.Text = "";
            priorityNumericUpDown.Value = 1;
            priorityNumericUpDown.Minimum = 1;

            issueTaskTreeView.Nodes.Clear();
            DataLayer.Issue[] issues = IssueClass.GetIssuesByProdManId(prodman_id);
            
            for (int j = 0; j < issues.Length; j++)
            {
                issueTaskTreeView.Nodes.Add(issues[j].name);
                issueTaskTreeView.Nodes[j].Tag = issues[j];
                issueTaskTreeView.Nodes[j].ForeColor = OtherUtils.statusColor[issues[j].status];

                DataLayer.Task[] tasks = TaskClass.GetTasksByIssueId(issues[j].id_iss);
                for (int k = 0; k < tasks.Length; k++)
                {
                    issueTaskTreeView.Nodes[j].Nodes.Add(tasks[k].name);
                    issueTaskTreeView.Nodes[j].Nodes[k].Tag = tasks[k];
                    if (tasks[k].worker_id == null && tasks[k].status != "ASS" &&
                        tasks[k].status != "FIN" && tasks[k].status != "CAN")
                        issueTaskTreeView.Nodes[j].Nodes[k].ForeColor = Color.DarkSlateBlue;
                    else issueTaskTreeView.Nodes[j].Nodes[k].ForeColor = OtherUtils.statusColor[tasks[k].status];
                }
            }
        }
        private void historyButton_Click(object sender, EventArgs e)
        {
            string message = "";

            if (selectedIssue != null)
            {
                Issue_status_history[] his = HistoryClass.GetIssueHistoryByIssueId(selectedIssue.id_iss);

                for (int i = 0; i < his.Length; i++)
                {
                    message += his[i].date + "\t" + Utils.GetStatusName(his[i].status) + "\n";
                }
                MessageBox.Show(message, selectedIssue.name + " Issue History");
            }
            else if (selectedTask != null)
            {
                Task_status_history[] his = HistoryClass.GetTaskHistoryByTaskId(selectedTask.id_task);

                for (int i = 0; i < his.Length; i++)
                {
                    message += his[i].date + "\t" + Utils.GetStatusName(his[i].status) + "\n";
                }
                MessageBox.Show(message, selectedTask.name + " Task History");
            }


        }
    }
}