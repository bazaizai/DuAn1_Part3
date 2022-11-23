using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IKieuSpServices
    {
        string Add(KieuSpView Obj);
        string Update(KieuSpView Obj);
        string Delete(KieuSpView Obj);
        string Mats();
        KieuSpView GetById(Guid Id);
        List<KieuSpView> GetAll();
    }
}
