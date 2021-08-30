using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace BizLayer
{
    public class Utils
    {
        public static string[] GetStatus()
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var status = from s in dc.Status
                         select s;
            Status[] objectsArray = status.ToArray();
            string[] statuses = new string[status.Count()];
            for (int i = 0; i < statuses.Length; i++)
            {
                statuses[i] = objectsArray[i].status_name;
            }
            return statuses;
        }
        public static string GetStatusCode(string status)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var statusCode = from s in dc.Status
                         where s.status_name == status
                         select s;
            return statusCode.First().status1;
        }
        public static string GetStatusName(string status_code)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var statusCode = from s in dc.Status
                             where s.status1 == status_code
                             select s;
            return statusCode.First().status_name;
        }
        public static string[] GetIssueType()
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var type = from t in dc.Issue_Type
                         select t;
            Issue_Type[] objectsArray = type.ToArray();
            string[] types = new string[type.Count()];
            for (int i = 0; i < types.Length; i++)
            {
                types[i] = objectsArray[i].type_name;
            }
            return types;
        }
        public static string[] GetTaskType()
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var type = from t in dc.Task_Type
                       select t;
            Task_Type[] objectsArray = type.ToArray();
            string[] types = new string[type.Count()];
            for (int i = 0; i < types.Length; i++)
            {
                types[i] = objectsArray[i].type_name;
            }
            return types;
        }
        public static string GetIssueTypeCode(string type)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var typeCode = from t in dc.Issue_Type
                             where t.type_name == type
                             select t;
            return typeCode.First().type;
        }
        public static string GetIssueTypeName(string type_code)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var typeCode = from t in dc.Issue_Type
                             where t.type == type_code
                             select t;
            return typeCode.First().type_name;
        }
        public static string GetTaskTypeCode(string type)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var typeCode = from t in dc.Task_Type
                           where t.type_name == type
                           select t;
            return typeCode.First().type;
        }
        public static string GetTaskTypeName(string type_code)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var typeCode = from t in dc.Task_Type
                           where t.type == type_code
                           select t;
            return typeCode.First().type_name;
        }
        public static Role[] GetRoles()
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var roles = from r in dc.Role
                         select r;
            Role[] rolesTable = roles.ToArray();
            return rolesTable;
        }
        public static string GetRoleCode(string role)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var roleCode = from r in dc.Role
                           where r.role1 == role
                           select r;
            return roleCode.First().code;
        }
        public static string GetRoleName(string role)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var roleCode = from r in dc.Role
                           where r.code == role
                           select r;
            return roleCode.First().role1;
        }
    }
}