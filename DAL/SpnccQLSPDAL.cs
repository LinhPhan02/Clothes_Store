using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class SpnccQLSPDAL
    {

        public static List<spnccDTO> GetData()
        {
            List<spnccDTO> productsNCC = new List<spnccDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand($"SELECT *,producers.name as producers_name from productproducers,producers where productproducers.producer_id = producers.id and producers.status = 1", conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                spnccDTO productNCC = new spnccDTO();
                productNCC.Id = reader.GetInt32("id");
                productNCC.Name = reader.GetString("name");
                productNCC.Type = reader.GetString("producers_name");
                productNCC.Origin = reader.GetString("origin");
                productNCC.Image = reader.GetString("image");
                productNCC.Prices = reader.GetInt32("prices");
                productNCC.Producer = reader.GetInt32("producer_id");
                productNCC.TypeID = reader.GetString("category_id");
                productsNCC.Add(productNCC);
            }


            conn.Close();

            return productsNCC;
        }

    

        public static List<spnccDTO> GetDatacbbType()
        {
            List<spnccDTO> productQL = new List<spnccDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("Select * from producers where status = 1", conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                spnccDTO product = new spnccDTO();
                product.Name = reader.GetString("name");
                product.Id = reader.GetInt32("id");
                productQL.Add(product);
            }
            conn.Close();

            return productQL;
        }

        public static List<spnccDTO> GetDatacbb()
        {
            List<spnccDTO> productQL = new List<spnccDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("Select * from category", conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                spnccDTO product = new spnccDTO();
                product.Name = reader.GetString("name");
                product.Id = reader.GetInt32("id");
                productQL.Add(product);
            }
            conn.Close();

            return productQL;
        }

        public static bool AddData(spnccDTO cart)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                string query = $"INSERT INTO products VALUES ({cart.Id},'{cart.Name}','{cart.TypeID}','{DateTime.Now.ToString("yyyyMMddHHmmss")}','{cart.Origin}','{DateTime.Now.ToString("yyyyMMddHHmmss")}','{cart.Prices * 1.3}','{cart.Quantity}','{cart.Producer}','{cart.Image}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static bool UpdateData(spnccDTO cart)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                string query = $"UPDATE `products` SET `quantity`='{cart.Quantity}' WHERE id = {cart.Id}";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public static bool AddDataSPC(List<spcDTO> spc)
        {
            try
            {

                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                

                foreach(spcDTO item in spc)
                {
                    string values = "";
                    for(int i = 0; i < Convert.ToInt32(item.Quantity); i++)
                    {
                        values += $"(NULL,{Convert.ToInt32(item.Id)},1)";
                        if(i < Convert.ToInt32(item.Quantity) - 1)
                        {
                            values += ",";
                        }
                    }

                    MySqlCommand cmd = new MySqlCommand($"insert into detailproduct values {values}", conn);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public static NhapDTO AddBill(NhapDTO nhap)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                string query = $"INSERT INTO billimport VALUES (NULL,'{nhap.staff_id}',1,'{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}','{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}',{nhap.total},{nhap.producer_id})";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                NhapDTO nhapReturn = new NhapDTO();

                MySqlCommand cmd1 = new MySqlCommand("Select b.id, b.staff_id, b.status, b.total, b.producer_id, b.createdAt, s.name, p.name as producer_name from billimport as b, staffs as s, producers as p where s.phoneNumber = b.staff_id  and b.producer_id = p.id order by id desc limit 1", conn);

                MySqlDataReader reader = cmd1.ExecuteReader();

                while (reader.Read())
                {
                 
                    nhapReturn.id = reader.GetInt32("id");
                    nhapReturn.producer_id = reader.GetInt32("producer_id");
                    nhapReturn.total = reader.GetInt32("total");
                    nhapReturn.staff_id = reader.GetString("staff_id");
                    nhapReturn.staff_name = reader.GetString("name");
                    nhapReturn.createAt = reader.GetDateTime("createdAt");
                    nhapReturn.producer_name = reader.GetString("producer_name");
                }
                conn.Close();
                return nhapReturn;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static void AddDetailBill(int billId, List<spnccDTO> list)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                string query = $"insert into detailbillimport values ";

                for(int i = 0; i < list.Count; i++)
                {
                    query += $"({billId},{list[i].Id},{list[i].Prices},{list[i].Quantity},'{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}','{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}')";
                    if (i < list.Count - 1)
                    {
                        query += ",";
                    }
                }
            

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

              
                conn.Close();
            }
            catch(MySqlException e)
            {
            }
        }

    }
}
