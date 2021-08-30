using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BizLayer;

namespace projekt_TAB
{
    public partial class Client : Form
    {
        Main parent;
        int client_id;
        DataLayer.System_Client selectedSystem_Client;
        DataLayer.Request selectedRequest;
        public Client(Main parentIn, int id)
        {
            InitializeComponent();
            this.parent = parentIn;
            client_id = id;
            refreshTreeView();
        }
        private void deactivateButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to deactivate your account?", "Deactivate", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ManClass.Deactivate(client_id);
                parent.openChildForm(new Main());
            }
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Main());
            /*var result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You have been logged out", "Result");
                parent.openChildForm(new Main());
            }*/
        }
        private void createRequestButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Request(parent, "Client", client_id));
        }
        private void requestTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                DataLayer.System_Client sys_cli = (DataLayer.System_Client)e.Node.Tag;
                selectedSystem_Client = sys_cli;
                selectedRequest = null;
            }
            if (e.Node.Level == 1)
            {
                DataLayer.Request req = (DataLayer.Request)e.Node.Tag;
                nameTextBox.Text = req.name;
                statusTextBox.Text = Utils.GetStatusName(req.status);
                descriptionTextBox.Text = req.description;
                resultTextBox.Text = req.result;
                selectedRequest = req;
            }
        }
        private void refreshTreeView()
        {
            requestTreeView.Nodes.Clear();
            nameTextBox.Text = "";
            statusTextBox.Text = "";
            descriptionTextBox.Text = "";
            resultTextBox.Text = "";

            
            DataLayer.System_Client[] sys_cli = SystemClass.GetSystemsClientsByClientId(client_id);

            for (int i = 0; i < sys_cli.Length; i++)
            {
                DataLayer.System system = SystemClass.GetSystemById(sys_cli[i].system_id);
                requestTreeView.Nodes.Add(system.name);
                requestTreeView.Nodes[i].Tag = sys_cli[i];


                DataLayer.Request[] requests = RequestClass.GetRequestsBySysCliId(sys_cli[i].id_systems);
                for (int j = 0; j < requests.Length; j++)
                {
                    requestTreeView.Nodes[i].Nodes.Add(requests[j].name);
                    requestTreeView.Nodes[i].Nodes[j].Tag = requests[j];
                    requestTreeView.Nodes[i].Nodes[j].ForeColor = OtherUtils.statusColor[requests[j].status];

                }
            }
          
            
        }
        private void addSystemButton_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new Sys(parent, "Client", "add", client_id));
        }
    }
}
