using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IAnhServices
    {
        string Add(AnhViews Obj);
        string Update(AnhViews Obj);
        string Delete(AnhViews Obj);
        AnhViews GetByID(Guid ID);
        List<AnhViews> GetAll();
    }
}
