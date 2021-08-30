using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizLayer
{
    public class HistoryClass
    {
        public static void CreateTaskHistory(int task_id, string status, DateTime time)
        {
            DatabaseDataContext dc = new DatabaseDataContext();

            Task_status_history his = new Task_status_history
            {
                task_id = task_id,
                status = status,
                date = time
            };

            dc.Task_status_history .InsertOnSubmit(his);
            dc.SubmitChanges();
        }

        public static Task_status_history[] GetTaskHistoryByTaskId(int task_id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var his = (from h in dc.Task_status_history
                       where h.task_id == task_id
                       orderby h.date descending
                       select h);
            DataLayer.Task_status_history[] history = his.ToArray();
            return history;
        }

        public static void CreateIssueHistory(int issue_id, string status, DateTime time)
        {
            DatabaseDataContext dc = new DatabaseDataContext();

            Issue_status_history his = new Issue_status_history
            {
                issue_id = issue_id,
                status = status,
                date = time
            };

            dc.Issue_status_history.InsertOnSubmit(his);
            dc.SubmitChanges();
        }

        public static Issue_status_history[] GetIssueHistoryByIssueId(int issue_id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var his = (from h in dc.Issue_status_history
                       where h.issue_id == issue_id
                       orderby h.date descending
                       select h);
            DataLayer.Issue_status_history[] history = his.ToArray();
            return history;
        }
        public static void CreateRequestHistory(int request_id, string status, DateTime time)
        {
            DatabaseDataContext dc = new DatabaseDataContext();

            Request_status_history his = new Request_status_history();
            his.request_id = request_id;
            his.status = status;
            his.date = time;

            dc.Request_status_history.InsertOnSubmit(his);
            dc.SubmitChanges();
        }

        public static Request_status_history[] GetRequestHistoryByRequestId(int request_id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var his = (from h in dc.Request_status_history
                       where h.request_id == request_id
                       orderby h.date descending
                       select h);
            DataLayer.Request_status_history[] history = his.ToArray();
            return history;
        }
    }
}
