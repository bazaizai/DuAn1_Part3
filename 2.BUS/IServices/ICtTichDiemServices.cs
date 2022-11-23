using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ICtTichDiemServices
    {
        string Add(CtTinhDiemView obj);
        string Update(CtTinhDiemView obj);
        string Delete(CtTinhDiemView obj);
        List<CtTinhDiemView> GetAll();
    }
}
