using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class BanHangDAL
    {
        public static PhieuXuatDTO AddBill(PhieuXuatDTO xuat)
        {
            // Tạo đối tượng Random để tạo số ngẫu nhiên
            Random random = new Random();
            // Tạo mã hợp đồng
            int maHoaDon = random.Next(1000, 10000);
            xuat.Id = maHoaDon;

            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                string query = $"insert into billexport values('{xuat.Id}','{xuat.staffId}',1,'{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}','{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}',{xuat.Total},'{xuat.CustomerPhone}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                PhieuXuatDTO xuatReturn = new PhieuXuatDTO();

                MySqlCommand cmd1 = new MySqlCommand("Select b.id, b.staff_id, b.status, b.total, b.createdAt, s.name as staff_name,c.name from billexport as b, staffs as s, customer as c where s.phoneNumber = b.staff_id and b.customerPhone = c.phoneNumber order by id desc limit 1", conn);

                MySqlDataReader reader = cmd1.ExecuteReader();

             


                while (reader.Read())
                {
                    xuatReturn.Id = reader.GetInt32("id");
                    xuatReturn.staffName = reader.GetString("staff_name");
                    xuatReturn.Total = reader.GetInt32("total");
                    xuatReturn.CreatedAt = reader.GetDateTime("createdAt");
                    xuatReturn.staffId = reader.GetString("staff_id");
                    xuatReturn.CustomerName = reader.GetString("name");
                    xuatReturn.CustomerPhone = xuat.CustomerPhone;
                }


                conn.Close();
                return xuatReturn;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static void UpdateTotalCustomer(PhieuXuatDTO xuat)
        {
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd2 = new MySqlCommand($"select total from customer where phoneNumber like '{xuat.CustomerPhone}'", conn);
            MySqlDataReader reader = cmd2.ExecuteReader();

            int total=0;

            while (reader.Read())
            {
                total = reader.GetInt32("total");
            }
            
            conn.Close();

            conn.Open();
            MySqlCommand cmd3 = new MySqlCommand($"update customer set total = '{total + xuat.Total}' where phoneNumber like '{xuat.CustomerPhone}'", conn);
            cmd3.ExecuteNonQuery();
            conn.Close();
        }

        public static KhachHangDTO GetCustomer(string phoneNumber)
        {
           KhachHangDTO kh = new KhachHangDTO();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand($"select name, total, phoneNumber from customer where phoneNumber like '{phoneNumber}'", conn);

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                kh.ToTal = reader.GetInt32("total");
                kh.Name = reader.GetString("Name");
                kh.Phone = reader.GetString("phoneNumber");
            }


            conn.Close();

            return kh;
        }
        /*
        public static void AddDetailMaintain(string customerPhone, List<spcbhDTO> list, List<int> productIds)
        {
            DateTime createdAt = DateTime.Now;

            string ids = "";

            for(int i = 0; i < productIds.Count;i++)
            {
                ids += productIds[i].ToString();
                if(i < productIds.Count - 1)
                {
                    ids+= ",";
                }
            }

            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"select * from maintainance where product_id in ({ids})", conn);
            MySqlDataReader reader = cmd.ExecuteReader();


            List<BaoHanhDTO> baohanhs = new List<BaoHanhDTO>();


            while (reader.Read())
            {

                BaoHanhDTO baohanh = new BaoHanhDTO();
                baohanh.ProductId = reader.GetInt32("product_id");
                baohanh.Time = reader.GetInt32("time");
                baohanhs.Add(baohanh);
            }

            conn.Close();

            conn.Open();

            string insertDetail = "insert into detailmaintainance values ";
            for (int i = 0; i < list.Count; i++)
            {
                int time = FindTime(list[i].ParentId, baohanhs);
                DateTime outOfDate = createdAt.AddDays(time);
                insertDetail += $"(NULL,{list[i].Id},'{customerPhone}','{createdAt.ToString("yyyy-MM-dd hh:mm:ss")}','{outOfDate.ToString("yyyy-MM-dd hh:mm:ss")}',0)";
                if (i < list.Count - 1)
                {
                    insertDetail += ",";
                }
            }
            MySqlCommand cmd2 = new MySqlCommand(insertDetail, conn);
            cmd2.ExecuteNonQuery();

       
            conn.Close();

        }
        
        static int FindTime(int parentId, List<BaoHanhDTO> baohanhs)
        {
            foreach(BaoHanhDTO baohanh in baohanhs)
            {
                if(baohanh.ProductId == parentId)
                {
                    return baohanh.Time;
                }
            }
            return 0;
        }
        */
        public static void AddDetailBill(int billId, List<spcbhDTO> list)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                string query = $"insert into detailbillexport values ";

                string queryUpdateChild = "";

                for (int i = 0; i < list.Count; i++)
                {
                    query += $"({billId},{list[i].Id},{list[i].Prices},1,'{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}','{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}')";
                    queryUpdateChild += list[i].Id;
                    if (i < list.Count - 1)
                    {
                        query += ",";
                        queryUpdateChild += ",";
                    }
                }


                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MySqlCommand cmd2 = new MySqlCommand($"update detailproduct set isActive = 0 where id in ({queryUpdateChild})", conn);
                cmd2.ExecuteNonQuery();



                conn.Close();
            }
            catch (MySqlException e)
            {
            }
        }
    }
}
