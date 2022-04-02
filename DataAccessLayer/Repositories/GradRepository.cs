using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GradRepository : IGradDal
    {
        public void AddGrad(Grad grad)
        {
            using var c = new Context();
            c.Add(grad);
            c.SaveChanges();
        }

        public Grad GetGrad(int id)
        {
            using var c = new Context();
            return c.Grads.Find(id);            
        }

        public List<Grad> ListAllGrad()
        {
            using var c = new Context();
            return c.Grads.ToList();
        }

        public void RemoveGrad(Grad grad)
        {
            using var c = new Context();
            c.Remove(grad);
            c.SaveChanges();
        }

        public void UpdateGrad(Grad grad)
        {
            using var c = new Context();
            c.Update(grad);
            c.SaveChanges();
        }
    }
}
