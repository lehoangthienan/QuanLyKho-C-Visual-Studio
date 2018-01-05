using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_KHACHHANG
    {
        DAL_KHACHHANG dal_kh = new DAL_KHACHHANG();
        public bool Insert(KHACHHANG kh)
        {
            return dal_kh.Insert(kh);
        }
        //public DataSet Get_TheoMa(string MaKho)
        //{
        //    return dal_kh.Get_TheoMa(MaKho);
        //}

        public DataTable Get_MA(string MaKho)
        {
            return dal_kh.Get_MA(MaKho);
        }
        public DataSet Get_HoTen(string MaKho)
        {
            return dal_kh.Get_HoTen(MaKho);
        }
        public bool Update(KHACHHANG kh, string MAKHO)
        {
            return dal_kh.Update(kh, MAKHO);
        }
    }
}
