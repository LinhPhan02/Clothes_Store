using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LuongDTO
    {
        public string contract_id;
        public int rangeSalary;
        public string staff_id;
        public string startTime;
        public string endTime;
        public LuongDTO()
        {
            contract_id = null;
            rangeSalary = 0;
            staff_id = null;
            startTime = null;
            endTime = null;
        }

        public LuongDTO(string contract_id, string startTime, string endTime, int rangeSalary, string staff_id)
        {
            this.contract_id = contract_id;
            this.rangeSalary = rangeSalary;
            this.staff_id = staff_id;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public string getContract_id { get => contract_id; set => contract_id = value; }
        public int getRangeSalary { get => rangeSalary; set => rangeSalary = value; }
        public string getStaff_id { get => staff_id; set => staff_id = value; }
        public string getStartime { get => startTime; set => startTime = value; }
        public string getEndtime { get => endTime; set => endTime = value; }

    }
}
