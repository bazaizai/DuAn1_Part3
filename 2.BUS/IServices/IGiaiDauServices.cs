using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IGiaiDauServices
    {
        string Add(GiaiDauView giaiDau);
        string Update(GiaiDauView giaiDau);
        string Delete(GiaiDauView giaiDau);
        Guid GetIdByName(string name);
        List<GiaiDauView> GetAll();
    }
}
