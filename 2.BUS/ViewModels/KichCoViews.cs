using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class KichCoViews
    {
        public Guid Id { get; set; }
      
        public string Ma { get; set; }
     
        public string Size { get; set; }
      
        public decimal? Cm { get; set; }
   
        public int? TrangThai { get; set; }
    }
}
