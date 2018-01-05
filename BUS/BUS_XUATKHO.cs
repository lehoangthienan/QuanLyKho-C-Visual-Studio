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
    public class BUS_XUATKHO
    {
        DAL_XUATKHO XK = new DAL_XUATKHO();
        public bool Insert(XUATKHO xk)
        {
            return XK.Insert(xk);
        }
        public DataSet Get_ALL()
        {
            return XK.Get_ALL();
        }
        public DataSet Get_TheoMa(string MaSP)
        {
            return XK.Get_TheoMa(MaSP);
        }
        public DataSet Get_TheoTen(string TenSP)
        {
            return XK.Get_TheoTen(TenSP);
        }
        public DataSet Get_TheoKho(string MaKho)
        {
            return XK.Get_TheoKho(MaKho);
        }
        public DataTable Get_MaKho()
        {
            return XK.Get_MaKho();
        }
        public DataTable Get_MaSP(string MAKHO)
        {
            return XK.Get_MaSP(MAKHO);
        }
        public DataTable TENSP(string MAKHO, string MASP)
        {
            return XK.TENSP(MAKHO, MASP);
        }
        public bool Update(XUATKHO xk, string MAKHO, string MASP)
        {
            return XK.Update(xk, MAKHO, MASP);
        }
        public bool Delete(string MAKHO, string MASP)
        {
            return XK.Delete(MAKHO, MASP);
        }
        public DataSet Get_TheoNgay(int NgayBD, int ThangBD, int NamBD, int NgayKT, int ThangKT, int NamKT)
        {
            return XK.Get_TheoNgay(NgayBD, ThangBD, NamBD, NgayKT, ThangKT, NamKT);
        }
        public DataTable Get_BaoCao(string MAKHO)
        {
            return XK.Get_BaoCao(MAKHO);
        }
        public DataTable Get_MaKhoTheoNgay(int NgayBD, int ThangBD, int NamBD, int NgayKT, int ThangKT, int NamKT)
        {
            return XK.Get_MaKhoTheoNgay(NgayBD, ThangBD, NamBD, NgayKT, ThangKT, NamKT);
        }
        public DataSet Get_TheoNgay1(DateTime TuNgay, DateTime DenNgay)
        {
            return XK.Get_TheoNgay1(TuNgay, DenNgay);
        }
    }

}
