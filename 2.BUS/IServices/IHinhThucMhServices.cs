using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHinhThucMhServices
    {
        string Add(HinhThucMhViews obj);
        string Update(HinhThucMhViews obj);
        string Delete(HinhThucMhViews obj);
        List<HinhThucMhViews> GetAll();
    }
}
