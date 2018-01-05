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
    public class BUS_NHAPKHO
    {
        DAL_NHAPKHO NK = new DAL_NHAPKHO();
        public bool Insert(NHAPKHO nk)
        {
            return NK.Insert(nk);
        }
        public bool Update(NHAPKHO nk)
        {
            return NK.Update(nk);
        }
        public bool Delete(string MaSP)
        {
            return NK.Delete(MaSP);
        }
        public DataSet Get_ALL()
        {
            return NK.Get_ALL();
        }
        public DataTable Get_NHAPKHO()
        {
            return NK.Get_NHAPKHO();
        }
        public DataTable Get_TenSp(string MASP)
        {
            return NK.Get_MA(MASP);
        }
        public DataTable Get_SL(string MASP)
        {
            return NK.Get_SL(MASP);
        }
        public DataSet Get_TheoMa(string MaSP)
        {
            return NK.Get_TheoMa(MaSP);
        }
        public DataSet Get_TheoTen(string TenSP)
        {
            return NK.Get_TheoTen(TenSP);
        }
        public bool UpdateSoLuongNhap(double SoLuong, string MASP)
        {
            return NK.UpdateSoLuongNhap(SoLuong, MASP);
        }
    }
}
