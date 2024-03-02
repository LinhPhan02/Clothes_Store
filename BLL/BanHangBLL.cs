using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BanHangBLL
    {
        public static KhachHangDTO GetCustomer(string phoneNumber)
        {
            return BanHangDAL.GetCustomer(phoneNumber);
        }

        public static void UpdateTotalCustomer(PhieuXuatDTO xuat)
        {
            BanHangDAL.UpdateTotalCustomer(xuat);
        }

        public static PhieuXuatDTO AddBill(PhieuXuatDTO xuat)
        {
            return BanHangDAL.AddBill(xuat);
        }

        public static void AddDetailBill(int billId, List<spcbhDTO> list)
        {
             BanHangDAL.AddDetailBill(billId, list);
        }

        public static void AddDetailMaintain(string customerPhone, List<spcbhDTO> list, List<int> productIds)
        {
            BanHangDAL.AddDetailMaintain(customerPhone, list, productIds);
        }
    }
}
