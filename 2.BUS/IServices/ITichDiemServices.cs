using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ITichDiemServices
    {
        string Add(TichDiemView obj);
        string Update(TichDiemView obj);
        string Delete(TichDiemView obj);
        TichDiemView GetByID(Guid id);
        //List<TichDiemView> Search(string obj);
        List<TichDiemView> GetAll();
    }
}
