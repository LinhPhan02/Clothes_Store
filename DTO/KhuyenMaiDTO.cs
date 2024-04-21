using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuyenMaiDTO
    {
        public string discount_id;
        public string discount_name;
        public string start_day;
        public string end_day;
        public int discount_amount;
        public KhuyenMaiDTO()
        {
            discount_id = null;
            discount_name = null;
            start_day = null;
            end_day = null;
            discount_amount = 0;
        }

        public KhuyenMaiDTO(string discount_id, string discount_name, string start_day, string end_day, int discount_amount)
        {
            this.discount_id = discount_id;
            this.discount_name = discount_name;
            this.start_day = start_day;
            this.end_day = end_day;
            this.discount_amount = discount_amount;
        }

        public string getDiscount_id { get => discount_id; set => discount_id = value; }
        public string getDiscount_name { get => discount_name; set => discount_name = value; }
        public string getStart_day { get => start_day; set => start_day = value; }
        public string getEnd_day { get => end_day; set => end_day = value; }
        public int getDiscount_amount { get => discount_amount; set => discount_amount = value; }   

    }
}
