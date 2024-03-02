using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhapDTO
    {
        public int id { set; get; }
        public DateTime createAt { set; get; }
        public string staff_name { set; get; }
        public string staff_id { get; set; }


        public int total { set; get; }
        public string producer_name { set; get; }
        public int producer_id { get; set; }

    }
}
