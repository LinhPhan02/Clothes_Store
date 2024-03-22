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

        public bool Insert(string contract_id, DateTime startTime, DateTime endTime, string rangeSalary, string staff_id)
        {
            l = new LuongDTO(contract_id, startTime, endTime, rangeSalary, staff_id);
            return Insert(l);
        }
        /*
        public bool Update(string phone, string pass, string name, int type)
        {
            dsl = readDB();
            //Cập nhật lại thông tin nhân viên trong List
            foreach (LuongDTO nv in dsl)
            {
                if (nv.phone.Equals(phone))
                {
                    nv.name = name;
                    nv.pass = pass;
                    nv.type = type;
                    nv.updatedAt = DateTime.Now;
                }
            }
            return qllDAL.Update(phone, pass, name, type);
        }

        public bool Update(string phone, string pass, string name, DateTime create, DateTime update, int status, int type)
        {
            l = new LuongDTO(phone, pass, name, create, update, status, type);
            return Update(phone, pass, name, type);
        }

        public bool Delete(string index)
        {
            dsl = readDB();
            //Xoá nhân viên trong List
            foreach (LuongDTO nv in dsl)
            {
                if (nv.phone.Equals(index))
                {
                    nv.status = 0;
                }
            }
            return qlnvDAL.Delete(index);
        }
        */
        public DataTable Show(string text)
        {
            List<LuongDTO> dsnv_tk = new List<LuongDTO>();
            dsnv_tk = qllDAL.Search(text);
            //Tìm kiếm nhân viên theo chuỗi nhập vào
            return qllDAL.Show(dsnv_tk);
        }
        /*
        public List<CategoryStaffsDTO> LoadCategoryStaff()
        {
            return qllDAL.LoadCategoryStaff();
        }
        */
    }
}
