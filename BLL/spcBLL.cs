using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class spcBLL
    {
        public static List<spcbhDTO> GetData(string id)
        {
            return spcDAL.GetDataSPC(id);
        }
        public static bool UpdateData(spcbhDTO spc)
        {
            return spcDAL.UpdateData(spc);
        }
    }
}
