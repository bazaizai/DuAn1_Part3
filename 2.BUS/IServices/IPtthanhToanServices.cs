using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IPtthanhToanServices
    {
        string Add(PtthanhToanViews obj);
        string Update(PtthanhToanViews obj);
        string Delete(PtthanhToanViews obj);
        List<PtthanhToanViews> GetAll();
        

    }
}
