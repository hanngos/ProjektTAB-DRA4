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
    public partial class AccMan : Form
    {
        Main parent;
        int accman_id;
        DataLayer.Request selectedRequest;
        DataLayer.Issue selectedIssue;
        DataLayer.Task selectedTask;
        public AccMan(Main parentIn, int id)
        {
            InitializeComponent();
            parent = parentIn;
            accman_id = id;
            refresh();
        }
        private void GetProperStatuses()
        {
            statusComboBox.Items.Clear();
            string status = "";
            if (selectedRequest != null) status = selectedRequest.status;
            else if (selectedIssue != null) status = selectedIssue.status;
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
        private bool CheckIfAllTasksAreFinished()
        {
            DataLayer.Task[] tasks = TaskClass.GetTasksByIssueId(selectedIssue.id_iss);
            for (int i = 0; i < tasks.Count(); i++)
                if (tasks[i].status != "FIN") return false;
            return true;
        }
        private bool CheckIfAllIssuesAreFinished()
        {
            DataLayer.Issue[] issues = IssueClass.GetIssuesByRequestId(selectedRequest.id_req);
            for (int i = 0; i < issues.Count(); i++)
                if (issues[i].status != "FIN") return false;
            return true;
        }
        private void createRequestButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Request(parent, "AccMan", accman_id));
        }
        private void createIssueButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Issue(parent, "AccMan", selectedRequest.id_req, accman_id));
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Logowanie(parent));
        }
        private void createSystemButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Sys(parent, "AccMan", "create", accman_id));
        }
        private void updateSystemButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Sys(parent, "AccMan", "update", accman_id));
        }
        private void requestTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            personComboBox.Items.Clear();
            if (e.Node.Level == 0)
            {
                DataLayer.Request req = (DataLayer.Request)e.Node.Tag;
                selectedRequest = req;
                selectedIssue = null;
                selectedTask = null;
                nameLabel.Text = req.name;
                idLabel.Text = req.id_req.ToString();
                statusComboBox.Text = Utils.GetStatusName(req.status);
                descriptionTextBox.Text = req.description;
                typeLabel.Text = "";
                resultTextBox.Text = req.result;
                personComboBox.Text = "";
                if (req.priority == 0)
                    priorityNumericUpDown.Minimum = 0;
                else priorityNumericUpDown.Minimum = 1;
                priorityNumericUpDown.Value = req.priority;
            }
            else if (e.Node.Level == 1)
            {
                DataLayer.Issue iss = (DataLayer.Issue)e.Node.Tag;
                selectedIssue = iss;
                selectedRequest = null;
                selectedTask = null;
                nameLabel.Text = iss.name;
                idLabel.Text = iss.id_iss.ToString();
                statusComboBox.Text = Utils.GetStatusName(iss.status);
                descriptionTextBox.Text = iss.description;
                typeLabel.Text = Utils.GetIssueTypeName(iss.type);
                resultTextBox.Text = iss.result;
                int id = iss.prodman_id ?? 0;
                personComboBox.Text = ManClass.GetManNameByIdAndRole(id, "PRO");
                personComboBox.Items.AddRange(ManClass.GetProdMans());
                if (iss.priority == 0)
                    priorityNumericUpDown.Minimum = 0;
                else priorityNumericUpDown.Minimum = 1;
                priorityNumericUpDown.Value = iss.priority;
            }
            else if (e.Node.Level == 2)
            {
                DataLayer.Task task = (DataLayer.Task)e.Node.Tag;
                selectedTask = task;
                selectedIssue = null; // (DataLayer.Issue)e.Node.Parent.Tag;
                selectedRequest = null;
                nameLabel.Text = task.name;
                idLabel.Text = task.id_task.ToString();
                statusComboBox.Text = Utils.GetStatusName(task.status);
                descriptionTextBox.Text = task.description;
                typeLabel.Text = Utils.GetTaskTypeName(task.type);
                resultTextBox.Text = task.result;
                int id = task.worker_id ?? 0;
                personComboBox.Text = ManClass.GetManNameByIdAndRole(id, "WRK");
                personComboBox.Items.AddRange(ManClass.GetWorkers());
                if (task.priority == 0)
                    priorityNumericUpDown.Minimum = 0;
                else priorityNumericUpDown.Minimum = 1;
                priorityNumericUpDown.Value = task.priority;
            }

            if (selectedRequest != null || selectedIssue != null || selectedTask != null)
                historyButton.Enabled = true;
            else historyButton.Enabled = false;

            if ((selectedRequest != null && selectedRequest.status != "FIN" && selectedRequest.status != "CAN") ||
                (selectedIssue != null && selectedIssue.status != "FIN" && selectedIssue.status != "CAN") ||
                (selectedTask != null && selectedTask.status != "FIN" && selectedTask.status != "CAN"))
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


            if (selectedRequest != null ||
                (selectedIssue != null && (selectedIssue.status == "FIN" || selectedIssue.status == "CAN")) ||
                (selectedTask != null && (selectedTask.status == "FIN" || selectedTask.status == "CAN")))
                personComboBox.Enabled = false;
            else personComboBox.Enabled = true;

            if (selectedRequest != null && selectedRequest.status != "FIN" && selectedRequest.status != "CAN") createIssueButton.Enabled = true;
            else createIssueButton.Enabled = false;

            GetProperStatuses();
        }
        private void refresh()
        {
            statusComboBox.Enabled = false;
            personComboBox.Enabled = false;
            historyButton.Enabled = false;
            applyButton.Enabled = false;
            createIssueButton.Enabled = false;
            descriptionTextBox.ReadOnly = true;
            resultTextBox.ReadOnly = true;
            priorityNumericUpDown.Enabled = false;

            idLabel.Text = "";
            nameLabel.Text = "";
            typeLabel.Text = "";
            statusComboBox.Text = "";
            personComboBox.Text = "";
            descriptionTextBox.Text = "";
            resultTextBox.Text = "";
            priorityNumericUpDown.Value = 1;
            priorityNumericUpDown.Minimum = 1;

            requestTreeView.Nodes.Clear();
            DataLayer.Request[] requests = RequestClass.GetRequestsByAccManId(accman_id);

            for (int i = 0; i < requests.Length; i++)
            {
                requestTreeView.Nodes.Add(requests[i].name);
                requestTreeView.Nodes[i].Tag = requests[i];
                requestTreeView.Nodes[i].ForeColor = OtherUtils.statusColor[requests[i].status];

                DataLayer.Issue[] issues = IssueClass.GetIssuesByRequestId(requests[i].id_req);
                for (int j = 0; j < issues.Length; j++)
                {
                    requestTreeView.Nodes[i].Nodes.Add(issues[j].name);
                    requestTreeView.Nodes[i].Nodes[j].Tag = issues[j];
                    if (issues[j].prodman_id == null && issues[j].status != "ASS" &&
                        issues[j].status != "FIN" && issues[j].status != "CAN")
                        requestTreeView.Nodes[i].Nodes[j].ForeColor = Color.DarkSlateBlue;
                    else requestTreeView.Nodes[i].Nodes[j].ForeColor = OtherUtils.statusColor[issues[j].status];

                    DataLayer.Task[] tasks = TaskClass.GetTasksByIssueId(issues[j].id_iss);
                    for (int k = 0; k < tasks.Length; k++)
                    {
                        requestTreeView.Nodes[i].Nodes[j].Nodes.Add(tasks[k].name);
                        requestTreeView.Nodes[i].Nodes[j].Nodes[k].Tag = tasks[k];
                        if (tasks[k].worker_id == null && tasks[k].status != "ASS" &&
                        tasks[k].status != "FIN" && tasks[k].status != "CAN")
                            requestTreeView.Nodes[i].Nodes[j].Nodes[k].ForeColor = Color.DarkSlateBlue;
                        else requestTreeView.Nodes[i].Nodes[j].Nodes[k].ForeColor = OtherUtils.statusColor[tasks[k].status];
                    }

                }
            }
        }
        private void historyButton_Click(object sender, EventArgs e)
        {
            string message = "";

            if (selectedRequest != null)
            {
                Request_status_history[] his = HistoryClass.GetRequestHistoryByRequestId(selectedRequest.id_req);

                for (int i = 0; i < his.Length; i++)
                {
                    message += his[i].date + "\t" + Utils.GetStatusName(his[i].status) + "\n";
                }
                MessageBox.Show(message, selectedRequest.name + " Request History");
            }
            else if (selectedIssue != null)
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
        private void applyButton_Click(object sender, EventArgs e)
        {
            string status = Utils.GetStatusCode(statusComboBox.Text);
            int priority = Convert.ToInt32(priorityNumericUpDown.Value);
            if (requestTreeView.SelectedNode.Level == 0)
            {
                if (status == "FIN" && !CheckIfAllIssuesAreFinished())
                    MessageBox.Show("You cannot change the request status to finished,\n" +
                        "because some of its issues are not finished yet!\n" +
                        "Wait until they are!", "Some issues are not finished!");
                else if ((status == "FIN" || status == "CAN") && String.IsNullOrEmpty(resultTextBox.Text))
                    MessageBox.Show("Before you finish or cancel the request,\n" +
                        "please provide some final remarks!!", "No final results provided!");
                else
                {
                    if (status == "FIN" || status == "CAN") priority = 0;
                    if (status != selectedRequest.status) HistoryClass.CreateRequestHistory(selectedRequest.id_req, status, DateTime.Now);
                    RequestClass.UpdateRequest(status, descriptionTextBox.Text, resultTextBox.Text, selectedRequest.id_req, accman_id, priority);
                }
            }
            else if (requestTreeView.SelectedNode.Level == 1)
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
                    string worker = personComboBox.Text;
                    if (worker != "" && selectedIssue.status == "ASS") status = "OPN";
                    if (status == "ASS") worker = "";
                    if (status == "FIN" || status == "CAN") priority = 0;
                    IssueClass.UpdateIssue(status, descriptionTextBox.Text, ManClass.GetManIdByName(worker), resultTextBox.Text, selectedIssue.id_iss, priority);
                    if (status != selectedIssue.status) HistoryClass.CreateIssueHistory(selectedIssue.id_iss, status, DateTime.Now);
                }
            }
            else if (requestTreeView.SelectedNode.Level == 2)
            {
                if ((status == "FIN" || status == "CAN") && String.IsNullOrEmpty(resultTextBox.Text))
                    MessageBox.Show("Before you finish or cancel the task,\n" +
                        "please provide some final remarks!!", "No final results provided!");
                else
                {
                    string worker = personComboBox.Text;
                    if (worker != "" && selectedTask.status == "ASS") status = "OPN";
                    if (status == "ASS") worker = "";
                    if (status == "FIN" || status == "CAN") priority = 0;
                    TaskClass.UpdateTask(status, ManClass.GetManIdByName(worker), descriptionTextBox.Text, resultTextBox.Text, selectedTask.id_task, priority);
                    if (status != selectedTask.status) HistoryClass.CreateTaskHistory(selectedTask.id_task, status, DateTime.Now);
                }
            }

            refresh();
        }
    }
}
