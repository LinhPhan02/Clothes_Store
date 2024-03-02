using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class spcDAL
    {
        public static List<spcbhDTO> GetDataSPC(string id)
        {
            List<spcbhDTO> productBHs = new List<spcbhDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand($"SELECT detailproduct.id as spcid,products.name as namesp,products.id as parentId,products.image as imagesp,prices,origin FROM detailproduct,products where detailproduct.product_id = {id} and products.id = {id} and detailproduct.isActive = 1", conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                spcbhDTO productBH = new spcbhDTO();
                productBH.Id = reader.GetString("spcid");
                productBH.Namesp = reader.GetString("namesp");
                productBH.Imgsp = reader.GetString("imagesp");
                productBH.Origin = reader.GetString("origin");
                productBH.Prices = reader.GetString("prices");
                productBH.ParentId = reader.GetInt32("parentId");
                productBHs.Add(productBH);
            }


            conn.Close();

            return productBHs;
        }

        public static bool UpdateData(spcbhDTO spc)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                string query = $"UPDATE `detailproduct` SET `isActive`='0' WHERE id = {spc.Id} ";
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
    }
}
