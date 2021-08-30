using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizLayer
{
    public class RequestClass
    {
        public static int CreateRequest(string name, string status, int system_id, int client_id, Nullable<int> accman_id, string description, int priority)
        {
            DatabaseDataContext dc = new DatabaseDataContext();
            System_Client sys_cli = SystemClass.GetSystemClient(system_id, client_id);

            Request req = new Request();
            req.name = name;
            req.status = status;
            req.systems_id = sys_cli.id_systems;
            req.description = description;
            req.acman_id = accman_id;
            req.priority = priority;
            dc.Request.InsertOnSubmit(req);
            dc.SubmitChanges();

            return req.id_req;
        }
        public static void UpdateRequest(string status, string description, string result, int req_id, Nullable<int> accman_id, int priority)
        {
            DatabaseDataContext dc = new DatabaseDataContext();
            var req = (from r in dc.Request
                       where r.id_req == req_id
                       select r).First();
            req.status = status;
            req.description = description;
            req.result = result;
            req.acman_id = accman_id;
            req.priority = priority;
            dc.SubmitChanges();
        }
        public static Request[] GetRequests()
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var requests = from r in dc.Request
                           orderby r.status descending
                           select r;
            Request[] requestTable = requests.ToArray();
            return requestTable;

        }
        public static Request[] GetRequestsByAccManId(int accman_id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var requests = from r in dc.Request
                           where r.acman_id == accman_id
                           orderby r.status
                           orderby r.priority descending
                           select r;
            Request[] requestTable = requests.ToArray();
            return requestTable;
        }
        public static Request[] GetOpenAndInProgressRequestsByAccManId(int accman_id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var requests = from r in dc.Request
                           where r.acman_id == accman_id && (r.status == "OPN" || r.status == "PRO")
                           orderby r.status
                           orderby r.priority descending
                           select r;
            Request[] requestTable = requests.ToArray();
            return requestTable;
        }
        public static Request GetRequestById(int req_id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var request = (from r in dc.Request
                           where r.id_req == req_id
                           select r).First();
            return request;
        }
        public static Request[] GetRequestsBySysCliId(int syscli_id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var request = (from r in dc.Request
                           where r.systems_id == syscli_id
                           select r);
            Request[] requests = request.ToArray();
            return requests;
        }
        public static Request[] GetNotAssignedRequests()
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var requests = from r in dc.Request
                           where r.status != "FIN" && r.status != "CAN" 
                           && r.acman_id == null
                           select r;
            Request[] requestTable = requests.ToArray();
            return requestTable;
        }
    }
}
