using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChatLieuServices
    {
        string Add(ChatLieuViews obj);
        string Update(ChatLieuViews obj);
        string Delete(ChatLieuViews obj);
        List<ChatLieuViews> GetAll();
    }
}
