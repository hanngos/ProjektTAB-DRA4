using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizLayer
{
    public class Workload
    {
        public static Nullable<int> GetAccManIdByMinWorkLoad()
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var sum = (from a in dc.AcMan
                       join r in dc.Request on a.id_acc equals r.acman_id into accmans
                       from acc in accmans.DefaultIfEmpty()
                       join m in dc.Man on a.id_acc equals m.id_man
                       where (acc.status == "OPN" || acc.status == "PRO" || acc.status == null)
                       && m.is_active == true
                       group acc by a.id_acc into accs
                       select new
                       {
                           AccManId = accs.Key,
                           PrioritySum = accs.Sum(r => (int?)r.priority ?? 0)
                       }).ToArray();
            if (sum.Any())
            {
                var accman_id = sum.Where(p => p.PrioritySum == sum.Min(m => m.PrioritySum))
                .Select(a => a.AccManId).First();
                return accman_id;
            }
            else return null;
        }
        public static int GetAccManIdByMinWorkLoad(int id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var sum = (from a in dc.AcMan
                       join r in dc.Request on a.id_acc equals r.acman_id into accmans
                       from acc in accmans.DefaultIfEmpty()
                       join m in dc.Man on a.id_acc equals m.id_man
                       where (acc.status == "OPN" || acc.status == "PRO" || acc.status == null)
                       && m.is_active == true && a.id_acc != id
                       group acc by a.id_acc into accs
                       select new
                       {
                           AccManId = accs.Key,
                           PrioritySum = accs.Sum(r => (int?)r.priority ?? 0)
                       }).ToArray();
            var accman_id = sum.Where(p => p.PrioritySum == sum.Min(m => m.PrioritySum))
            .Select(a => a.AccManId).First();
            return accman_id;

        }
        public static int GetProdManIdByMinWorkLoad(int id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var sum = (from p in dc.ProdMan
                       join i in dc.Issue on p.id_prod equals i.prodman_id into prodmans
                       from prod in prodmans.DefaultIfEmpty()
                       join m in dc.Man on p.id_prod equals m.id_man
                       where (prod.status == "OPN" || prod.status == "PRO" || prod.status == null)
                       && m.is_active == true && p.id_prod != id
                       group prod by p.id_prod into prdmans
                       select new
                       {
                           ProdManId = prdmans.Key,
                           PrioritySum = prdmans.Sum(r => (int?)r.priority ?? 0)
                       }).ToArray();
            var wrk_id = sum.Where(p => p.PrioritySum == sum.Min(m => m.PrioritySum))
            .Select(a => a.ProdManId).First();
            return wrk_id;
        }
        public static int GetWorkerIdByMinWorkLoad(int id)
        {
            DataLayer.DatabaseDataContext dc = new DatabaseDataContext();
            var sum = (from w in dc.Worker
                       join t in dc.Task on w.id_work equals t.worker_id into workers
                       from wrk in workers.DefaultIfEmpty()
                       join m in dc.Man on w.id_work equals m.id_man
                       where (wrk.status == "OPN" || wrk.status == "PRO" || wrk.status == null)
                       && m.is_active == true && w.id_work != id
                       group wrk by w.id_work into wrks
                       select new
                       {
                           WorkerId = wrks.Key,
                           PrioritySum = wrks.Sum(t => (int?)t.priority ?? 0)
                       }).ToArray();
            var wrk_id = sum.Where(p => p.PrioritySum == sum.Min(m => m.PrioritySum))
            .Select(a => a.WorkerId).First();
            return wrk_id;
        }
    }
}
