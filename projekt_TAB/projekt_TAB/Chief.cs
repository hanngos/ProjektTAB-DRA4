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
    public partial class Chief : Form
    {
        Main parent;
        DataLayer.Request selectedRequest;
        DataLayer.Issue selectedIssue;
        DataLayer.Task selectedTask;
        public Chief(Main parentIn)
        {
            InitializeComponent();
            parent = parentIn;
            refresh();
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Logowanie(parent));
        }
        private void assignButton_Click(object sender, EventArgs e)
        {
            Nullable<int> id = Workload.GetAccManIdByMinWorkLoad();
            if (id != null)
            {
                DataLayer.Request[] requests = RequestClass.GetNotAssignedRequests();
                foreach (var r in requests)
                {
                    if (r.status == "ASS")
                    {
                        r.status = "OPN";
                        HistoryClass.CreateRequestHistory(r.id_req, r.status, DateTime.Now);
                    }
                    RequestClass.UpdateRequest(r.status, r.description, r.result, r.id_req, Workload.GetAccManIdByMinWorkLoad(), r.priority);
                    refresh();
                }
            }
            else
            {
                MessageBox.Show("You have no one you could assign requests to!", "Hire someone!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void viewEmployeesButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Admin(parent));
        }
        private void requestTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                DataLayer.Request req = (DataLayer.Request)e.Node.Tag;
                selectedRequest = req;
                selectedIssue = null;
                selectedTask = null;
                nameLabel.Text = req.name;
                idLabel.Text = req.id_req.ToString();
                statusTextBox.Text = Utils.GetStatusName(req.status);
                descriptionTextBox.Text = req.description;
                typeLabel.Text = "";
                resultTextBox.Text = req.result;
                int id = req.acman_id ?? 0;
                personTextBox.Text = ManClass.GetManNameByIdAndRole(id, "ACC");
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
                statusTextBox.Text = Utils.GetStatusName(iss.status);
                descriptionTextBox.Text = iss.description;
                typeLabel.Text = Utils.GetIssueTypeName(iss.type);
                resultTextBox.Text = iss.result;
                int id = iss.prodman_id ?? 0;
                personTextBox.Text = ManClass.GetManNameByIdAndRole(id, "PRO");
                if (iss.priority == 0)
                    priorityNumericUpDown.Minimum = 0;
                else priorityNumericUpDown.Minimum = 1;
                priorityNumericUpDown.Value = iss.priority;
            }
            else if (e.Node.Level == 2)
            {
                DataLayer.Task task = (DataLayer.Task)e.Node.Tag;
                selectedTask = task;
                selectedIssue = null;
                selectedRequest = null;
                nameLabel.Text = task.name;
                idLabel.Text = task.id_task.ToString();
                statusTextBox.Text = Utils.GetStatusName(task.status);
                descriptionTextBox.Text = task.description;
                typeLabel.Text = Utils.GetTaskTypeName(task.type);
                resultTextBox.Text = task.result;
                int id = task.worker_id ?? 0;
                personTextBox.Text = ManClass.GetManNameByIdAndRole(id, "WRK");
                if (task.priority == 0)
                    priorityNumericUpDown.Minimum = 0;
                else priorityNumericUpDown.Minimum = 1;
                priorityNumericUpDown.Value = task.priority;
            }

            if (selectedRequest != null || selectedIssue != null || selectedTask != null)
                viewHistoryButton.Enabled = true;
            else viewHistoryButton.Enabled = false;

        }
        private void refresh()
        {
            statusTextBox.ReadOnly = true;
            personTextBox.ReadOnly = true;
            viewEmployeesButton.Enabled = true;
            viewHistoryButton.Enabled = false;
            descriptionTextBox.ReadOnly = true;
            resultTextBox.ReadOnly = true;
            priorityNumericUpDown.Enabled = false;

            idLabel.Text = "";
            nameLabel.Text = "";
            typeLabel.Text = "";
            statusTextBox.Text = "";
            personTextBox.Text = "";
            descriptionTextBox.Text = "";
            resultTextBox.Text = "";
            priorityNumericUpDown.Value = 1;
            priorityNumericUpDown.Minimum = 1;

            requestTreeView.Nodes.Clear();
            DataLayer.Request[] requests = RequestClass.GetRequests();

            for (int i = 0; i < requests.Length; i++)
            {
                requestTreeView.Nodes.Add(requests[i].name);
                requestTreeView.Nodes[i].Tag = requests[i];
                if (requests[i].acman_id == null && requests[i].status != "ASS" 
                    && requests[i].status != "FIN" && requests[i].status != "CAN")
                    requestTreeView.Nodes[i].ForeColor = Color.DarkSlateBlue;
                else 
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
    }
}
