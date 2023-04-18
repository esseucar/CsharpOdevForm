using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EFramework;

namespace EFramwork
{
    public class UrunDal
    {
        public List<Urun> GetAll()
        {

            using (KurabiyeContext context = new KurabiyeContext())
            {
                return context.kurabiye.ToList();
            }
        }
        public void Add(Urun urun)
        {
            using (KurabiyeContext context = new KurabiyeContext())
            {
                var entity = context.Entry(urun);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(Urun urun)
        {
            using (KurabiyeContext context = new KurabiyeContext())
            {
                var entity = context.Entry(urun);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Urun urun)
        {
            using (KurabiyeContext context = new KurabiyeContext())
            {

                var entity = context.Entry(urun);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
