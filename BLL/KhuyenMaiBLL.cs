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
    public class KhuyenMaiBLL
    {
        private KhuyenMaiDTO km;
        private List<KhuyenMaiDTO> DsKM;
        KhuyenMaiDAL KmDAL = new KhuyenMaiDAL();

        public List<KhuyenMaiDTO> readDB()
        {
            return KmDAL.readDB();
        }

        public DataTable Display()
        {
            DsKM = readDB();
            return KmDAL.Display(DsKM);
        }

        public bool Insert(KhuyenMaiDTO discount)
        {
            DsKM = readDB();
            DsKM.Add(discount);
            return KmDAL.Insert(discount);
        }

        public bool Insert(string discount_id, string discount_name, string start_day, string end_day, int discount_amount) 
        {
            km = new KhuyenMaiDTO(discount_id, discount_name, start_day, end_day, discount_amount);
            return Insert(km);
        }

        public DataTable Show(string text, string number)
        {
            List<KhuyenMaiDTO> dskm = new List<KhuyenMaiDTO>();
            dskm = KmDAL.Search(text, number);
            //Tìm kiếm mã giảm 
            return KmDAL.Show(dskm);
        }

        public static bool Insert(string textboxMaKM, string textboxGiamGia, DateTime dayBD, DateTime dayKT)
        {
            throw new NotImplementedException();
        }
    }
}
