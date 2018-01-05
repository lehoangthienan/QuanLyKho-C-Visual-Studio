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
    public class BUS_NHAPKHOTHEONGAY
    {
        DAL_NHAPKHOTHEONGAY NKTN = new DAL_NHAPKHOTHEONGAY();
        public bool Insert(NHAPKHOTHEONGAY nktn)
        {
            return NKTN.Insert(nktn);
        }
        public bool Delete(string MaSP)
        {
            return NKTN.Delete(MaSP);
        }
        public DataSet Get_ALL()
        {
            return NKTN.Get_ALL();
        }
        public DataSet Get_TheoNgay(int NgayBD, int ThangBD, int NamBD, int NgayKT, int ThangKT, int NamKT)
        {
            return NKTN.Get_TheoNgay(NgayBD, ThangBD, NamBD, NgayKT, ThangKT, NamKT);
        }
        public bool Update(NHAPKHOTHEONGAY nktn)
        {
            return NKTN.Update(nktn);
        }
        public bool UpdateTen(string MaSP, string TenSP)
        {
            return NKTN.UpdateTen(MaSP, TenSP);
        }
        public bool UpdateGia(string MaSP, decimal Gia)
        {
            return NKTN.UpdateGia(MaSP, Gia);
        }
        public bool UpdateTenGia(string MaSP, string TenSP, decimal Gia)
        {
            return NKTN.UpdateTenGia(MaSP, TenSP, Gia);
        }
    }
}
