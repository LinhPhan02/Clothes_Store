using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuXuatDTO
    {
        public int Id { get; set; }
        public string staffId { get; set; } 
        public string staffName { get; set;}
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
        public int Total {  get; set; } 
        public string CustomerPhone { get; set; }   
        public string CustomerName { get; set; }

        public PhieuXuatDTO()
        {
            CreatedAt  = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}
