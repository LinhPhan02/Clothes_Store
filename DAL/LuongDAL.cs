using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using System.Data;

namespace DAL
{
    public class LuongDAL : DatabaseAcess
    {
        MySqlConnection conn = SqlConnectionData.Connect();
        private List<LuongDTO> dsl, found;
        //Đọc dữ liệu từ CSDL để lưu vào List
        public List<LuongDTO> readDB()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM salary";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader read = cmd.ExecuteReader();
                dsl = new List<LuongDTO>();
                while (read.Read())
                {
                    LuongDTO l = new LuongDTO();   //Khởi tạo đối tượng mới
                    l.getContract_id = read.GetString(0);
                    l.startTime = read.GetDateTime(1);
                    l.endTime = read.GetDateTime(2);
                    l.rangeSalary = read.GetString(3);
                    l.staff_id = read.GetString(4);
                    dsl.Add(l);   //Thêm đối tượng vừa đọc vào List
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex); //Hiển thị lỗi nếu có
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }
            return dsl;
        }
        public bool Insert(LuongDTO l)
        {
            conn.Open();
            try
            {
                string query = $"INSERT INTO salary (contract_id, startTime, endTime, salary, staff_id) VALUES ('{l.getContract_id}', '{l.startTime.ToString("yyyy-MM-dd hh:mm:ss")}', '{l.endTime.ToString("yyyy-MM-dd hh:mm:ss")}', '{l.rangeSalary}','{l.staff_id}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Thêm khách hàng mới vào CSDL
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);    //Hiển thị lỗi nếu có
                return false;
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }

        }
        /*
        public bool Update(string phone, string pass, string name, int type)
        {
            conn.Open();
            try
            {
                LuongDTO nv = new LuongDTO();
                string query = "UPDATE staffs SET "
                    + "phoneNumber = '" + phone
                    + "',password = '" + pass
                    + "',name = '" + name
                    + "',updatedAt = '" + nv.updatedAt.ToString("yyyy-MM-dd hh:mm:ss")
                    + "',CategoryStaffs_id = '" + type
                    + "' where phoneNumber='" + phone + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Thực hiện câu lệnh cập nhật khách hàng trong CSDL
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);    //Hiển thị lỗi nếu có
                return false;
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }
        }
        
        //Xoá theo số điện thoại
        public bool Delete(string index)
        {
            conn.Open();
            try
            {
                foreach (LuongDTO nv in dsnv)
                {
                    if (nv.phone.Equals(index)) //Nếu số điện thoại bằng giá trị ô được chọn của cột "Số điện thoại" thì mới cập nhật lại status
                    {
                        string query = "UPDATE staffs SET status = '" + nv.status + "' WHERE phoneNumber = '" + index + "'";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);    //Hiển thị lỗi nếu có
                return false;
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }
        }
        */
        public List<LuongDTO> Search(string text)
        {
            text = text.ToLower();
            try
            {
                foreach (LuongDTO l in dsl)
                {
                    conn.Open();
                    string query = "SELECT * FROM salary WHERE contract_id LIKE '" + text + "' OR staff_id LIKE '" + text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader read = cmd.ExecuteReader();
                    found = new List<LuongDTO>();
                    while (read.Read())
                    {
                        l.getContract_id = read.GetString(0);
                        l.startTime = read.GetDateTime(1);
                        l.endTime = read.GetDateTime(2);
                        l.rangeSalary = read.GetString(3);
                        l.staff_id = read.GetString(4);
                        found.Add(l);   //Thêm đối tượng vừa đọc vào List
                    }
                    conn.Close();   //Sau mỗi lần đọc lần đóng kết nối lại
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);    //Hiển thị lỗi nếu có
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }
            return found;
        }
        //Hiển thị + Reload dữ liệu vào DataGridView
        public DataTable Display(List<LuongDTO> dsl)
        {
            dsl = readDB();
            return Show(dsl);
        }

        public DataTable Show(List<LuongDTO> dsl)
        {
            DataTable dtb = new DataTable();    //Khởi tạo bảng, sau đó thêm các cột và gán kiểu dữ liệu
            dtb.Columns.Add("STT", typeof(int));
            dtb.Columns.Add("Số HĐ", typeof(string));
            dtb.Columns.Add("Ngày bắt đầu", typeof(DateTime));
            dtb.Columns.Add("Ngày kết thúc", typeof(DateTime));
            dtb.Columns.Add("Mức lương", typeof(int));
            dtb.Columns.Add("Mã nhân viên", typeof(string));

            foreach (LuongDTO l in dsl)
            {
                DataRow data = dtb.NewRow();

                data["Số HĐ"] = l.getContract_id;
                data["Ngày bắt đầu"] = l.startTime;
                data["Ngày kết thúc"] = l.endTime;
                data["Mức lương"] = l.rangeSalary;
                data["Mã nhân viên"] = l.staff_id;

                dtb.Rows.Add(data); //Thêm đối tượng vào bảng

                for (int i = 0; i < dtb.Rows.Count; i++)
                {
                    data["STT"] = i + 1;    //set số thứ tự tăng dần cho bảng
                }
                /*
                if (nv.status == 1)  //Nếu status bằng 1 thì mới hiển thị ra bảng
                {
                    DataRow data = dtb.NewRow();

                    data["Họ tên"] = nv.name;
                    data["Số điện thoại"] = nv.phone;
                    data["Mật khẩu"] = nv.pass;
                    data["Loại nhân viên"] = nv.type;
                    data["Ngày tạo"] = nv.createdAt;
                    data["Ngày cập nhật"] = nv.updatedAt;

                    dtb.Rows.Add(data); //Thêm đối tượng vào bảng

                    for (int i = 0; i < dtb.Rows.Count; i++)
                    {
                        data["STT"] = i + 1;    //set số thứ tự tăng dần cho bảng
                    }
                }
                */
            }
            return dtb;
        }
        /*
        public List<CategoryStaffsDTO> LoadCategoryStaff()
        {
            List<CategoryStaffsDTO> list = new List<CategoryStaffsDTO>();
            try
            {
                conn.Open();
                string query = "SELECT * FROM categorystaffs where status = 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader read = cmd.ExecuteReader();
                dsnv = new List<LuongDTO>();
                while (read.Read())
                {
                    CategoryStaffsDTO ct = new CategoryStaffsDTO(read.GetInt32("id").ToString(), read.GetString("name"));
                    list.Add(ct);
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex); //Hiển thị lỗi nếu có
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }

            return list;
        }
        */
    }
}
