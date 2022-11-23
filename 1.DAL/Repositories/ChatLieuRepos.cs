using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
     public class ChatLieuRepos:IChatLieuRepos
     {
        public FpolyDBContext _dbContext;
        public ChatLieuRepos()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(ChatLieu obj)
        {
            obj.Id = Guid.NewGuid();
            if (obj == null) return false;
            try
            {
                _dbContext.ChatLieus.Add(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public bool Update(ChatLieu obj)
        {
            if (obj == null) return false;
            try
            {
                var tempobj = _dbContext.ChatLieus.FirstOrDefault(x => x.Id == obj.Id);
                tempobj.Ma = obj.Ma;
                tempobj.Ten = obj.Ten;
                tempobj.TrangThai = obj.TrangThai;
                _dbContext.ChatLieus.Update(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }          
        }

        public bool Delete(ChatLieu obj)
        {
            if (obj == null) return false;
            try
            {
                var tempobj = _dbContext.ChatLieus.FirstOrDefault(x => x.Id == obj.Id);
                _dbContext.Remove(obj);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
          
        }

        public List<ChatLieu> GetAll()
        {
            return _dbContext.ChatLieus.ToList();
        }

        public ChatLieu GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.ChatLieus.FirstOrDefault(c => c.Id == id);
        }
    }
}
