using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IUuDaiTichDiemServices
    {
        string Add(UuDaiTichDiemView obj);
        string Update(UuDaiTichDiemView obj);
        string Delete(UuDaiTichDiemView obj);
        UuDaiTichDiemView GetByID(Guid id);
        //List<UuDaiTichDiemView> Search(string obj);
        List<UuDaiTichDiemView> GetAll();
    }
}
