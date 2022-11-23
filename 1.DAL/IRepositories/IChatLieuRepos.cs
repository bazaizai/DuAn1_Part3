using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChatLieuRepos
    {
        bool Add(ChatLieu obj);
        bool Update(ChatLieu obj);
        bool Delete(ChatLieu obj);
        ChatLieu GetById(Guid id);
        List<ChatLieu>GetAll();
    }
}
