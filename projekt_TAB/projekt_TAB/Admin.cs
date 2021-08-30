using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using DataLayer;
using BizLayer;

namespace projekt_TAB
{
    public partial class Admin : Form
    {
        Main parent;
        DataLayer.Man selectedMan;
        public Admin(Main parentIn)
        {
            InitializeComponent();
            parent = parentIn;
            refresh();
        }
        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new User(parent));
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Logowanie(parent));
        }
        private void updateEmployeeButton_Click(object sender, EventArgs e)
        {
            if (ManClass.GetManIdByName(lastNameTextBox.Text + ", " + firstNameTextBox.Text) != null && ManClass.GetManIdByName(lastNameTextBox.Text + ", " + firstNameTextBox.Text) != selectedMan.id_man)
            {
                MessageBox.Show("You're lucky! There is your namesake in database!\nBut to make our life easier, please provide your second name!", "You have a namesake!");
            }
            else
            {
                string password = selectedMan.password;
                string role = selectedMan.role;
                try
                {
                    if (roleComboBox.Text != "" && role != Utils.GetRoleCode(roleComboBox.Text))
                    {
                        role = Utils.GetRoleCode(roleComboBox.Text);
                        Reassign(selectedMan.id_man, selectedMan.role, false);
                        ManClass.DeleteByRole(selectedMan.id_man, selectedMan.role);
                        ManClass.InsertByRole(selectedMan.id_man, Utils.GetRoleCode(roleComboBox.Text));

                    }
                    if (selectedMan.is_active == true && activeCheckBox.Checked == false)
                        Reassign(selectedMan.id_man, selectedMan.role, false);
                    if (passwordTextBox.Text != "")
                        password = OtherUtils.HashPassword(passwordTextBox.Text);
                    ManClass.UpdateMan(firstNameTextBox.Text, lastNameTextBox.Text, loginLabel.Text, password, activeCheckBox.Checked, role);
                }
                catch
                {
                    DialogResult result = MessageBox.Show("Ok, let's consider your situation for a moment! There is no one you can reassign these " +
                "requests/issues/tasks or whatever to! If life is like a box of chocolate, you have no left! " +
                "So if you want to give someone the sack, consider this, better leave him until you find someone new, " +
                "but if that someone wants to quit this job, pay him more! And if that's not enough, you suck! " +
                "Better run, cause this ship is sinking! Remember - the lack of employees is not conducive to the company's development!\n" +
                "\t\tARE YOU SURE?",
                "think think think", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if(result == DialogResult.Yes)
                    {
                        if (roleComboBox.Text != "" && role != Utils.GetRoleCode(roleComboBox.Text))
                        {
                            role = Utils.GetRoleCode(roleComboBox.Text);
                            Reassign(selectedMan.id_man, selectedMan.role, true);
                            ManClass.DeleteByRole(selectedMan.id_man, selectedMan.role);
                            ManClass.InsertByRole(selectedMan.id_man, Utils.GetRoleCode(roleComboBox.Text));

                        }
                        if (selectedMan.is_active == true && activeCheckBox.Checked == false)
                            Reassign(selectedMan.id_man, selectedMan.role, true);
                        if (passwordTextBox.Text != "")
                            password = OtherUtils.HashPassword(passwordTextBox.Text);
                        ManClass.UpdateMan(firstNameTextBox.Text, lastNameTextBox.Text, loginLabel.Text, password, activeCheckBox.Checked, role);
                    }
                }
            }
            refresh();
        }
        private void employeesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataLayer.Man man = (DataLayer.Man)employeesListView.SelectedItems[0].Tag;

                if (man != null)
                {
                    selectedMan = man;
                    loginLabel.Text = man.login;
                    passwordTextBox.Text = "";
                    activeCheckBox.Checked = man.is_active;
                    firstNameTextBox.Text = man.first_name;
                    lastNameTextBox.Text = man.last_name;
                    roleComboBox.Text = Utils.GetRoleName(man.role);
                    if (man.role == "CLI") roleComboBox.Enabled = false;
                    else roleComboBox.Enabled = true;
                    passwordTextBox.ReadOnly = false;
                    activeCheckBox.Enabled = true;
                    firstNameTextBox.ReadOnly = false;
                    lastNameTextBox.ReadOnly = false;
                    applyButton.Enabled = true;
                }
            }
            catch
            {
                selectedMan = null;
                loginLabel.Text = null;
                passwordTextBox.Text = null;
                activeCheckBox.Checked = false;
                firstNameTextBox.Text = null;
                lastNameTextBox.Text = null;
                roleComboBox.Text = null;
                roleComboBox.Enabled = false;
                passwordTextBox.ReadOnly = true;
                activeCheckBox.Enabled = false;
                firstNameTextBox.ReadOnly = true;
                lastNameTextBox.ReadOnly = true;
                applyButton.Enabled = false;
            }
        }
        private void refresh()
        {
            roleComboBox.Enabled = false;
            passwordTextBox.ReadOnly = true;
            activeCheckBox.Enabled = false;
            firstNameTextBox.ReadOnly = true;
            lastNameTextBox.ReadOnly = true;
            applyButton.Enabled = false;

            loginLabel.Text = "";
            passwordTextBox.Text = "";
            activeCheckBox.Checked = false;
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            roleComboBox.Text = "";

            roleComboBox.Items.Clear();
            employeesListView.Items.Clear();
            employeesListView.Groups.Clear();

            Role[] roles = Utils.GetRoles();
            for (int i = 0; i < roles.Length; i++)
                roleComboBox.Items.Add(roles[i].role1);
            roleComboBox.Items.Remove("CLIENT");

            DataLayer.Man[] mans = ManClass.GetMans();

            ListViewGroup accmans = new ListViewGroup("Account Managers", HorizontalAlignment.Left);
            ListViewGroup prodmans = new ListViewGroup("Product Managers", HorizontalAlignment.Left);
            ListViewGroup workers = new ListViewGroup("Workers", HorizontalAlignment.Left);
            ListViewGroup clients = new ListViewGroup("Clients", HorizontalAlignment.Left);
            ListViewGroup admins = new ListViewGroup("Admins", HorizontalAlignment.Left);

            Dictionary<string, ListViewGroup> roleGroup = new Dictionary<string, ListViewGroup> {
            {"ACC", accmans},
            {"PRO", prodmans},
            {"WRK", workers},
            {"CLI", clients},
            {"ADM", admins}
        };

            for (int i = 0; i < mans.Length; i++)
            {
                var group = roleGroup[mans[i].role];
                var row = new string[] { mans[i].login, mans[i].first_name, mans[i].last_name };
                var lvi = new ListViewItem(row, group);
                if (mans[i].is_active == false)
                    lvi.ForeColor = Color.DarkSlateBlue;
                lvi.Tag = mans[i];
                employeesListView.Items.Add(lvi);
            }

            employeesListView.Groups.Add(accmans);
            employeesListView.Groups.Add(prodmans);
            employeesListView.Groups.Add(workers);
            employeesListView.Groups.Add(clients);
            employeesListView.Groups.Add(admins);
        }
        private void Reassign(int id, string role, bool isNullAllowed)
        {
            if(isNullAllowed == false) {
                switch (role)
                {
                    case "ACC":
                        DataLayer.Request[] requests = RequestClass.GetOpenAndInProgressRequestsByAccManId(id);
                        foreach (var r in requests)
                            RequestClass.UpdateRequest(r.status, r.description, r.result, r.id_req, Workload.GetAccManIdByMinWorkLoad(id), r.priority);
                        break;
                    case "PRO":
                        DataLayer.Issue[] issues = IssueClass.GetOpenAndInProgressIssuesByProdManId(id);
                        foreach (var i in issues)
                            IssueClass.UpdateIssue(i.status, i.description, Workload.GetProdManIdByMinWorkLoad(id), i.result, i.id_iss, i.priority);
                        break;
                    case "WRK":
                        DataLayer.Task[] tasks = TaskClass.GetOpenAndInProgressTasksByWorkerId(id);
                        foreach (var t in tasks)
                            TaskClass.UpdateTask(t.status, Workload.GetWorkerIdByMinWorkLoad(id), t.description, t.result, t.id_task, t.priority);
                        break;
                    default:
                        break;
                }
            }
            else if (isNullAllowed == true)
            {
                switch (role)
                {
                    case "ACC":
                        DataLayer.Request[] requests = RequestClass.GetOpenAndInProgressRequestsByAccManId(id);
                        foreach (var r in requests)
                            RequestClass.UpdateRequest(r.status, r.description, r.result, r.id_req, null, r.priority);
                        break;
                    case "PRO":
                        DataLayer.Issue[] issues = IssueClass.GetOpenAndInProgressIssuesByProdManId(id);
                        foreach (var i in issues)
                            IssueClass.UpdateIssue(i.status, i.description, null, i.result, i.id_iss, i.priority);
                        break;
                    case "WRK":
                        DataLayer.Task[] tasks = TaskClass.GetOpenAndInProgressTasksByWorkerId(id);
                        foreach (var t in tasks)
                            TaskClass.UpdateTask(t.status, null, t.description, t.result, t.id_task, t.priority);
                        break;
                    default:
                        break;
                }
            }
        }
        private void viewRequests_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Chief(parent));
        }
    }
}
