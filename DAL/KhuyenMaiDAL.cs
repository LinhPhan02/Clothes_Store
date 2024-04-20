using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class KhuyenMaiDAL : DatabaseAcess
    {
        MySqlConnection conn = SqlConnectionData.Connect();
        private List<KhuyenMaiDTO> DsKM, found;
        //Đọc dữ liệu từ CSDL để lưu vào List
        public List<KhuyenMaiDTO> readDB()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM discount";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader read = cmd.ExecuteReader();
                DsKM = new List<KhuyenMaiDTO>();
                while (read.Read())
                {
                    KhuyenMaiDTO km = new KhuyenMaiDTO();   //Khởi tạo đối tượng mới
                    km.getDiscount_id = read.GetString(0);
                    km.discount_name = read.GetString(1);
                    km.description = read.GetString(2);
                    km.start_day = read.GetString(3);
                    km.end_day= read.GetString(4);
                    km.discount_amount = read.GetInt32(5);
                    DsKM.Add(km);   //Thêm đối tượng vừa đọc vào List
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
            return DsKM;
        }
        public bool Insert(KhuyenMaiDTO km)
        {
            conn.Open();
            try
            {
                string query = $"INSERT INTO discount (discount_id, discount_name, description, start_day, end_day, discount_amount) VALUES ('{km.discount_id}', '{km.discount_name}', '{km.description}', '{km.start_day}','{km.end_day}', '{km.discount_amount}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
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

        public List<KhuyenMaiDTO> Search(string text, string number)
        {
            text = text.ToLower();
            number = text.ToString();
            try
            {
                foreach (KhuyenMaiDTO km in DsKM)
                {
                    conn.Open();
                    string query = "SELECT * FROM discount WHERE discount_id LIKE '" + text + "' OR discount_name LIKE '" + text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader read = cmd.ExecuteReader();
                    found = new List<KhuyenMaiDTO>();
                    while (read.Read())
                    {
                        km.getDiscount_id = read.GetString(0);
                        km.discount_name = read.GetString(1);
                        km.description = read.GetString(2);
                        km.start_day = read.GetString(3);
                        km.end_day = read.GetString(4);
                        km.discount_amount = read.GetInt32(5);
                        found.Add(km);   //Thêm đối tượng vừa đọc vào List
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
        public DataTable Display(List<KhuyenMaiDTO> DsKM)
        {
            DsKM = readDB();
            return Show(DsKM);
        }

        public DataTable Show(List<KhuyenMaiDTO> DsKM)
        {
            DataTable dtb = new DataTable();    //Khởi tạo bảng, sau đó thêm các cột và gán kiểu dữ liệu
            dtb.Columns.Add("STT", typeof(int));
            dtb.Columns.Add("Mã khuyến mãi", typeof(string));
            dtb.Columns.Add("Tên khuyến mãi", typeof(string));
            dtb.Columns.Add("Mô tả khuyến mãi", typeof(string));
            dtb.Columns.Add("Ngày bắt đầu", typeof(string));
            dtb.Columns.Add("Ngày kết thúc", typeof(string));
            dtb.Columns.Add("Phần trăm giảm", typeof (string));

            foreach (KhuyenMaiDTO km in DsKM)
            {
                DataRow data = dtb.NewRow();

                data["Mã khuyến mãi"] = km.getDiscount_id;
                data["Tên khuyến mãi"] = km.discount_name;
                data["Mô tả khuyến mãi"] = km.description;
                data["Ngày bắt đầu"] = km.start_day;
                data["Ngày kết thúc"] = km.end_day;
                data["Phần trăm giảm"] = km.discount_amount;

                dtb.Rows.Add(data); //Thêm đối tượng vào bảng

                for (int i = 0; i < dtb.Rows.Count; i++)
                {
                    data["STT"] = i + 1;    //set số thứ tự tăng dần cho bảng
                }

            }
            return dtb;
        }

    }
}
