using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChucVuServices
    {
        string Add(ChucVuView obj);
        string Update(ChucVuView obj);
        string Delete(ChucVuView obj);
        List<ChucVuView> GetAll();
    }
}
