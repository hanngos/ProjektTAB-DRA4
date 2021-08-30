using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizLayer
{
    public class SystemClass
    {
        //SYSTEM
        public static int CreateSystem(string name, string versions)
        {
            DatabaseDataContext dc = new DatabaseDataContext();
            DataLayer.System sys = new DataLayer.System();
            sys.name = name;
            sys.versions = versions;
            dc.System.InsertOnSubmit(sys);
            dc.SubmitChanges();
            return sys.id_sys;
        }
        public static void UpadeSystem(int id_sys, string name, string version)
        {
            DatabaseDataContext dc = new DatabaseDataContext();
            var sys = (from s in dc.System
                        where s.id_sys == id_sys
                        select s).First();
            //sys.name = name;
            sys.versions = version;;
            dc.SubmitChanges();
        }
        public static string[] GetSystems()
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var system = from s in dc.System
                         select s;
            DataLayer.System[] objectsArray = system.ToArray();
            string[] systems = new string[system.Count()];
            for (int i = 0; i < systems.Length; i++)
            {
                systems[i] = objectsArray[i].name;
            }
            return systems;
        }
        public static DataLayer.System GetSystem(string name)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var system = from s in dc.System
                         where s.name == name
                         select s;
            if (system.Any()) return system.First();
            else return null;
        }
        public static DataLayer.System GetSystemById(int sys_id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var system = from s in dc.System
                         where s.id_sys == sys_id
                         select s;
            return system.First();
        }
        public static int GetSystemId(string name)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var system = from s in dc.System
                         where s.name == name
                         select s;
            return system.First().id_sys;
        }
        //SYSTEM-CLIENT
        public static void CreateSystemClient(int id_sys, int id_cli)
        {
            DatabaseDataContext dc = new DatabaseDataContext();
            DataLayer.System_Client sys_cli = new DataLayer.System_Client();
            sys_cli.client_id = id_cli;
            sys_cli.system_id = id_sys;
            sys_cli.version = GetSystemById(id_sys).versions;
            dc.System_Client.InsertOnSubmit(sys_cli);
            dc.SubmitChanges();
        }
        public static void UpadeSystemClient(int id_sys, int id_cli, string version)
        {
            DatabaseDataContext dc = new DatabaseDataContext();
            var sys_cli = (from s in dc.System_Client
                       where s.system_id == id_sys && s.client_id == id_cli
                       select s).First();
            sys_cli.version = version;
            dc.SubmitChanges();
        }
        public static System_Client GetSystemClient(int system_id, int client_id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
                var system = from s in dc.System_Client
                             where s.system_id == system_id && s.client_id == client_id
                             select s;
            if (system.Any()) return system.First();
            else return null;
        }
        public static System_Client[] GetSystemsClientsByClientId(int cli_id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var sys_cli = from s in dc.System_Client
                         where s.client_id == cli_id
                         select s;
            DataLayer.System_Client[] sys_clis = sys_cli.ToArray();
            return sys_clis;
        }
    }
}