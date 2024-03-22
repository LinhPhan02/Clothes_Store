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
        public string rangeSalary;
        public string staff_id;
        public DateTime startTime;
        public DateTime endTime;
        public LuongDTO()
        {
            contract_id = null;
            rangeSalary = null;
            staff_id = null;
            startTime = DateTime.Now;
            endTime = DateTime.Now;
        }

        public LuongDTO(string contract_id, DateTime startTime, DateTime endTime, string rangeSalary, string staff_id)
        {
            this.contract_id = contract_id;
            this.rangeSalary = rangeSalary;
            this.staff_id = staff_id;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public string getContract_id { get => contract_id; set => contract_id = value; }
        public string getRangeSalary { get => rangeSalary; set => rangeSalary = value; }
        public string getStaff_id { get => staff_id; set => staff_id = value; }
        public DateTime getStartTime() { return startTime; }
        public DateTime getEndTime() { return endTime; }
    }
}
