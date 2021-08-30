using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizLayer
{
    public class IssueClass
    {
        public static int CreateIssue(string name, string status, int requestId, string type, string description, int priority)
        {
            DatabaseDataContext dc = new DatabaseDataContext();

            Issue iss = new Issue();
            iss.name = name;
            iss.status = status;
            iss.request_id = requestId;
            iss.type = type;
            iss.description = description;
            iss.priority = priority;
            dc.Issue.InsertOnSubmit(iss);
            dc.SubmitChanges();

            return iss.id_iss;
        }
        public static void UpdateIssue(string status, string description, Nullable<int> prodman_id, string result, int iss_id, int priority)
        {
            DatabaseDataContext dc = new DatabaseDataContext();
            var iss = (from i in dc.Issue
                       where i.id_iss == iss_id
                       select i).First();
            iss.status = status;
            iss.description = description;
            iss.prodman_id = prodman_id;
            iss.result = result;
            iss.priority = priority;
            dc.SubmitChanges();
        }
        public static Issue[] GetIssues()
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var issues = from i in dc.Issue
                           select i;
            Issue[] issueTable = issues.ToArray();
            return issueTable;
        }
        public static string[] GetIssuesNames()
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var issues = from i in dc.Issue
                         select i;
            Issue[] issueTable = issues.ToArray();
            string[] issueses = new string[issues.Count()];
            for (int i = 0; i < issueses.Length; i++)
            {
                issueses[i] = issueTable[i].name;
            }
            return issueses;
        }
        public static Issue[] GetIssuesByRequestId(int request_id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var issues = (from i in dc.Issue
                          where i.request_id == request_id
                          orderby i.status
                          orderby i.priority descending
                          select i);
            Issue[] issueTable = issues.ToArray();
            return issueTable;
        }
        public static Issue[] GetIssuesByProdManId(int prodman_id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var issues = (from i in dc.Issue
                          where i.prodman_id == prodman_id
                          orderby i.status
                          orderby i.priority descending
                          select i);
            Issue[] issueTable = issues.ToArray();
            return issueTable;
        }
        public static Issue[] GetOpenAndInProgressIssuesByProdManId(int prodman_id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var issues = (from i in dc.Issue
                          where i.prodman_id == prodman_id && (i.status == "OPN" || i.status == "PRO")
                          orderby i.priority descending
                          select i);
            Issue[] issueTable = issues.ToArray();
            return issueTable;
        }
        public static Issue GetIssuesById(int iss_id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var issue = (from i in dc.Issue
                          where i.id_iss == iss_id
                          select i).First();
            return issue;
        }
    }
}
