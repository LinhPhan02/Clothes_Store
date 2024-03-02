using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class spcbhDTO
    {
        public string Id { get; set; }
        public string Namesp { get; set; }
        public string Prices { get; set; }

        public string Origin { get; set; }

        public string Imgsp { get; set; }

        public int ParentId { get; set; }

        public spcbhDTO()
        {
            Id = null;
            Namesp = null;
            Origin = null;
            Prices = null;
            Imgsp = null;
        }
        public spcbhDTO(string id, string namesp,string prices, string origin, string imgsp)
        {
            Id = id;
            Namesp = namesp;
            Prices = prices;
            Origin = origin;
            Imgsp = imgsp;
        }
    }
}
