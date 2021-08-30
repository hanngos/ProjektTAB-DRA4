using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizLayer
{
    public class ManClass
    {
        public static int CreateMan(string firstName, string lastName, string login, string password, bool isActive, string role)
        {
            DatabaseDataContext dc = new DatabaseDataContext();

            DataLayer.Man man = new DataLayer.Man();
            man.first_name = firstName;
            man.last_name = lastName;
            man.login = login;
            man.password = password;
            man.is_active = isActive;
            man.role = role;

            dc.Man.InsertOnSubmit(man);
            dc.SubmitChanges();
            return man.id_man;
        }
        public static void UpdateMan(string firstName, string lastName, string login, string password, bool isActive, string role) {
            DatabaseDataContext dc = new DatabaseDataContext();
            var man = (from m in dc.Man
                        where m.login == login
                        select m).First();
            man.first_name = firstName;
            man.last_name = lastName;
            man.password = password;
            man.is_active = isActive;
            man.role = role;
            dc.SubmitChanges();
        }
        public static void CreateClient(int id)
        {
            DatabaseDataContext dc = new DatabaseDataContext();

            DataLayer.Client man = new DataLayer.Client();
            man.id_cli = id;
            dc.Client.InsertOnSubmit(man);
            dc.SubmitChanges();
        }
        public static void CreateAccMan(int id)
        {
            DatabaseDataContext dc = new DatabaseDataContext();

            DataLayer.AcMan man = new DataLayer.AcMan();
            man.id_acc = id;
            dc.AcMan.InsertOnSubmit(man);
            dc.SubmitChanges();
        }
        public static void CreateProdMan(int id)
        {
            DatabaseDataContext dc = new DatabaseDataContext();

            DataLayer.ProdMan man = new DataLayer.ProdMan();
            man.id_prod = id;
            dc.ProdMan.InsertOnSubmit(man);
            dc.SubmitChanges();
        }
        public static void CreateWorker(int id)
        {
            DatabaseDataContext dc = new DatabaseDataContext();

            DataLayer.Worker man = new DataLayer.Worker();
            man.id_work = id;
            dc.Worker.InsertOnSubmit(man);
            dc.SubmitChanges();
        }
        public static void CreateAdmin(int id)
        {
            DatabaseDataContext dc = new DatabaseDataContext();

            DataLayer.Admin man = new DataLayer.Admin();
            man.id_admin = id;
            dc.Admin.InsertOnSubmit(man);
            dc.SubmitChanges();
        }
        public static void DeleteAccMan(int id)
        {
            DatabaseDataContext dc = new DatabaseDataContext();
            var man = (from m in dc.AcMan
                      where m.id_acc == id
                      select m).First();
            dc.AcMan.DeleteOnSubmit(man);
            dc.SubmitChanges();
        }
        public static void DeleteProdMan(int id)
        {
            DatabaseDataContext dc = new DatabaseDataContext();
            var man = (from m in dc.ProdMan
                       where m.id_prod == id
                       select m);
            if (man.Any())
            {
                dc.ProdMan.DeleteOnSubmit(man.First());
                dc.SubmitChanges();
            }
            else return;
        }
        public static void DeleteWorker(int id)
        {
            DatabaseDataContext dc = new DatabaseDataContext();
            var man = (from m in dc.Worker
                       where m.id_work == id
                       select m).First();
            dc.Worker.DeleteOnSubmit(man);
            dc.SubmitChanges();
        }
        public static void InsertByRole(int id, string role)
        {
            switch (role)
            {
                case "ACC":
                    CreateAccMan(id);
                    break;
                case "PRO":
                    CreateProdMan(id);
                    break;
                case "WRK":
                    CreateWorker(id);
                    break;
                case "CLI":
                    CreateClient(id);
                    break;
                case "ADM":
                    CreateAdmin(id);
                    break;
                default:
                    break;
            }
        }
        public static void DeleteByRole(int id, string role)
        {
            switch (role)
            {
                case "ACC":
                    DeleteAccMan(id);
                    break;
                case "PRO":
                    DeleteProdMan(id);
                    break;
                case "WRK":
                    DeleteWorker(id);
                    break;
                case "CLI":
                    break;
                case "ADM":
                    break;
                default:
                    break;
            }
        }
        public static bool CheckIfLoginExists(string login)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var man = (from m in dc.Man
                        where m.login == login
                        select m);
            if (man.Count() == 0)
                return false;
            else
                return true;
        }
        public static Nullable<int> GetManIdByLogin(string login)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var name = (from n in dc.Man
                        where n.login == login
                        select n);
            if (name.Any()) return name.First().id_man;
            else return null;
        }
        public static Man GetManByLoginAndPassword(string login, string password)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var name = (from n in dc.Man
                        where n.login == login && n.password == password
                        select n);
            if (name.Count() == 0) return null;
            else return name.First();
        }
        public static Nullable<int> GetManIdByName(string name)
        {
            if (name == "") return null;
            else
            {
                string[] separator = { ", " };
                string[] str = name.Split(separator, 2, StringSplitOptions.RemoveEmptyEntries);
                DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
                var id = (from i in dc.Man
                          where i.last_name == str[0] && i.first_name == str[1]
                          select i);//.First();
                if (id.Any()) return id.First().id_man;
                else return null;
            }
        }
        public static string GetManNameByIdAndRole(int id, string role)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            if (id == 0) return "";
            else
            {
                var name = (from n in dc.Man
                            where n.id_man == id && n.role == role
                            select n).First();
                return name.last_name + ", " + name.first_name;
            }
        }
        public static Man[] GetManNameByRole(string role)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var name = (from n in dc.Man
                        where n.role == role
                        select n);
            Man[] names = name.ToArray();
            return names;
        }
        public static Man[] GetMans()
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var name = (from n in dc.Man
                        select n);
            Man[] names = name.ToArray();
            return names;
        }
        public static void Deactivate(int id)
        {
            DatabaseDataContext dc = new DatabaseDataContext();
            var man = (from m in dc.Man
                       where m.id_man == id
                       select m).First();
            man.is_active = false;
            dc.SubmitChanges();
        }
        public static string[] GetWorkers()
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var workers = from w in dc.Worker
                          join m in dc.Man on w.id_work equals m.id_man
                          where m.is_active == true
                          select w;
            Worker[] workersArray = workers.ToArray();
            string[] workerses = new string[workers.Count()];
            for (int i = 0; i < workerses.Length; i++)
            {
                workerses[i] = GetManNameByIdAndRole(workersArray[i].id_work, "WRK");//man.last_name + ", " + man.first_name;
            }
            return workerses;
        }
        public static string[] GetProdMans()
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var prodmans = from pm in dc.ProdMan
                           join m in dc.Man on pm.id_prod equals m.id_man
                           where m.is_active == true
                           select pm;
            ProdMan[] prodmanArray = prodmans.ToArray();
            string[] prodmanses = new string[prodmans.Count()];
            for (int i = 0; i < prodmanses.Length; i++)
            {
                prodmanses[i] = GetManNameByIdAndRole(prodmanArray[i].id_prod, "PRO");//man.last_name + ", " + man.first_name;
            }
            return prodmanses;
        }

    }
}