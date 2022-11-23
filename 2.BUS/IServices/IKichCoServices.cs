using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IKichCoServices
    {
        string Add(KichCoViews obj);
        string Update(KichCoViews obj);
        string Delete(KichCoViews obj);
        List<KichCoViews> GetAll();
    }
}
