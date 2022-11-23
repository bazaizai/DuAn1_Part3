using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ILichSuTichDiemServices
    {
        string Add(LichSuTichDiemView obj);
        string Update(LichSuTichDiemView obj);
        string Delete(LichSuTichDiemView obj);
        LichSuTichDiemView GetByID(Guid id);
        //List<LichSuTichDiemView> Search(string obj);
        List<LichSuTichDiemView> GetAll();
    }
}
