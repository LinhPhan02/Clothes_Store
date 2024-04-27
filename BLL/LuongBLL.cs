using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LuongBLL
    {
        private LuongDTO l;
        private List<LuongDTO> dsl;
        LuongDAL qllDAL = new LuongDAL();

        public List<LuongDTO> readDB()
        {
            return qllDAL.readDB();
        }

        public DataTable Display()
        {
            dsl = readDB();
            return qllDAL.Display(dsl);
        }

        public bool Insert(LuongDTO salary)
        {
            dsl = readDB();
            //Thêm nhân viên mới vào List
            dsl.Add(salary);
            return qllDAL.Insert(salary);
        }

        public bool Insert(string contract_id, string startTime, string endTime, int rangeSalary, string staff_id)
        {
            l = new LuongDTO(contract_id, startTime, endTime, rangeSalary, staff_id);
            return qllDAL.Insert(l);
        }
        
        public DataTable Show(string text)
        {
            List<LuongDTO> dsnv_tk = new List<LuongDTO>();
            dsnv_tk = qllDAL.Search(text);
            //Tìm kiếm nhân viên theo chuỗi nhập vào
            return qllDAL.Show(dsnv_tk);
        }
        
    }
}
