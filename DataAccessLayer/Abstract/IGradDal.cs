using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGradDal
    {
        List<Grad> ListAllGrad();
        void AddGrad(Grad grad);
        void RemoveGrad(Grad grad);
        void UpdateGrad(Grad grad);
        Grad GetGrad(int id);
    }
}
