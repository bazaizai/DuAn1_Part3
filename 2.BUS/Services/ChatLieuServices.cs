using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ChatLieuServices:IChatLieuServices
    {
        private IChatLieuRepos _IChatLieuRepos;
        private List<ChatLieuViews> _lstSp;
        public ChatLieuServices()
        {
            _IChatLieuRepos = new ChatLieuRepos();
            _lstSp = new List<ChatLieuViews>();
        }


        public string Add(ChatLieuViews obj)
        {
            if (obj == null) return "Thêm Không thành công";

            ChatLieu Sp = new ChatLieu()
            {
                Id = obj.Id,
                Ma = MaTT(),
                Ten = obj.Ten,
                TrangThai = obj.TrangThai,
            };
            if (_IChatLieuRepos.Add(Sp)) return "Thêm thành công";
            return "Thêm Không thành công";
        }



        public string Delete(ChatLieuViews obj)
        {
            if (obj == null) return "Delete Không thành công";
            var x = _IChatLieuRepos.GetAll().FirstOrDefault(p => p.Id == obj.Id);
            if (_IChatLieuRepos.Delete(x)) return "Delete thành công";
            return "Delete Không thành công";
        }

        public List<ChatLieuViews> GetAll()
        {
            _lstSp = (from a in _IChatLieuRepos.GetAll()
                      select new ChatLieuViews
                      {
                          Id = a.Id,
                          Ma = a.Ma,
                          Ten = a.Ten,
                          TrangThai = a.TrangThai
                      }).ToList();
            return _lstSp;
        }

        public string Update(ChatLieuViews obj)
        {
            if (obj == null) return "Update Không thành công";
            var x = _IChatLieuRepos.GetAll().FirstOrDefault(p => p.Id == obj.Id);
            x.Id = obj.Id;
            x.Ma = obj.Ma;
            x.Ten = obj.Ten;
            x.TrangThai = obj.TrangThai;
            if (_IChatLieuRepos.Update(x)) return "Update thành công";
            return "Update Không thành công";
        }
        private string MaTT()
        {
            if (_IChatLieuRepos.GetAll().Count > 0)
            {
                return "CL" + Convert.ToString(_IChatLieuRepos.GetAll().Max(c => Convert.ToInt32(c.Ma.Substring(2, c.Ma.Length - 2)) + 1));
            }
            else return "CL1";
        }

    }
}
