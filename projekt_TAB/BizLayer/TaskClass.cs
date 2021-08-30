using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizLayer
{
    public class TaskClass
    {
        public static int CreateTask(string name, string status, int issue_id, string type, string description, int priority)
        {
            DatabaseDataContext dc = new DatabaseDataContext();

            DataLayer.Task task = new DataLayer.Task();
            task.name = name;
            task.status = status;
            task.issue_id = issue_id;
            task.type = type;
            task.description = description;
            task.priority = priority;
            dc.Task.InsertOnSubmit(task);
            dc.SubmitChanges();

            return task.id_task;
        }
        public static void UpdateTask(string status, Nullable<int> worker_id, string description, string result, int task_id, int priority)
        {
            DatabaseDataContext dc = new DatabaseDataContext();
            var task = (from t in dc.Task
                       where t.id_task == task_id
                       select t).First();
            task.status = status;
            task.worker_id = worker_id;
            task.description = description;
            task.result = result;
            task.priority = priority;
            dc.SubmitChanges();
        }
        public static DataLayer.Task[] GetTasks()
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var tasks = from t in dc.Task
                         select t;
            DataLayer.Task[] taskTable = tasks.ToArray();
            return taskTable;
        }
        public static DataLayer.Task[] GetTasksByIssueId(int issue_id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var tasks = (from t in dc.Task
                         where t.issue_id == issue_id
                         orderby t.status
                         orderby t.priority descending
                         select t);
            DataLayer.Task[] taskTable = tasks.ToArray();
            return taskTable;
        }
        public static DataLayer.Task[] GetTasksByWorkerId(int worker_id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var tasks = (from t in dc.Task
                         where t.worker_id == worker_id
                         orderby t.status
                         orderby t.priority descending
                         select t);
            DataLayer.Task[] taskTable = tasks.ToArray();
            return taskTable;
        }
        public static DataLayer.Task[] GetOpenAndInProgressTasksByWorkerId(int worker_id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var tasks = (from t in dc.Task
                         where t.worker_id == worker_id && (t.status == "OPN" || t.status == "PRO")
                         orderby t.status
                         orderby t.priority descending
                         select t);
            DataLayer.Task[] taskTable = tasks.ToArray();
            return taskTable;
        }

    }
}
