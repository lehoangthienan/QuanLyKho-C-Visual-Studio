using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_NHAPKHOTHEONGAY :BDConnect
    {
        DataTable dt = new DataTable();
        public DAL_NHAPKHOTHEONGAY()
        {
            dt = Get_NHAPKHOTHEONGAY();
        //    dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }
        public DataTable Get_NHAPKHOTHEONGAY()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from NHAPKHOTHEONGAY", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch
            {
                return null;
            }
        }
        public bool Insert(NHAPKHOTHEONGAY nktn)
        {
            try
            {
                _cn.Open();

                string SQL = "INSERT INTO NHAPKHOTHEONGAY  VALUES ('" + nktn.MASP + "',N'" + nktn.TENSP + "',N'" + nktn.SOLUONGNHAP + "', '" + nktn.TIENNHAP + "','" + nktn.TONGTIEN +"','"+nktn.THOIGIANNHAP+"')";

                SqlCommand cmd = new SqlCommand(SQL, _cn);
                cmd.ExecuteNonQuery();
                _cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(NHAPKHOTHEONGAY nktn)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NHAPKHOTHEONGAY", _cn);
                DataRow r = dt.Rows.Find(nktn.MASP.ToString());
                if (r != null)
                {
                    r["TENSP"] = nktn.TENSP;
                //    r["SOLUONGNHAP"] = nk.SOLUONGNHAP;
                    r["TIENNHAP"] = nktn.TIENNHAP;
                    r["TONGTIEN"] = nktn.TONGTIEN;
                }
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateTen(string MaSP ,string TenSP)
        {
            try
            {
                _cn.Open();
                string SQL = "update NHAPKHOTHEONGAY set TENSP = '" + TenSP + "' where MASP='"+MaSP+"'";
                SqlCommand cmd = new SqlCommand(SQL, _cn);
                cmd.ExecuteNonQuery();
                _cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateGia(string MaSP, decimal Gia)
        {
            try
            {
                _cn.Open();
                string SQL = "update NHAPKHOTHEONGAY set TIENNHAP = '" + Gia + "' where MASP='" + MaSP + "'";
                SqlCommand cmd = new SqlCommand(SQL, _cn);
                cmd.ExecuteNonQuery();
                _cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateTenGia(string MaSP,string TenSP, decimal Gia)
        {
            try
            {
                _cn.Open();
                string SQL = "update NHAPKHOTHEONGAY set TIENNHAP = '" + Gia +"',TENSP='"+TenSP+ "' where MASP='" + MaSP + "'";
                SqlCommand cmd = new SqlCommand(SQL, _cn);
                cmd.ExecuteNonQuery();
                _cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(string MaSP)
        {
            try
            {
                // Ket noi
                _cn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string sqlstr = "";
                sqlstr = "delete from NHAPKHOTHEONGAY where MASP='";
                sqlstr += MaSP;
                sqlstr += "'";
                SqlCommand cmd = new SqlCommand(sqlstr, _cn);

                cmd.ExecuteNonQuery();
                _cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataSet Get_ALL()
        {
            SqlDataAdapter da;
            DataSet ds;
            string sqlstr = "";
            //  sqlstr = "select MASP 'Mã Sản Phẩm', TENSP 'Tên Sản Phẩm', SOLUONGNHAP 'Số Lượng', TIENNHAP 'Đơn Giá (/1SP) (VND)'";
            sqlstr = "select *";
            sqlstr += "from NHAPKHOTHEONGAY ";
            da = new SqlDataAdapter(sqlstr, _cn);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "NHAPKHOTHEONGAY");
            return ds;
        }
        public DataSet Get_TheoNgay(int NgayBD, int ThangBD, int NamBD, int NgayKT, int ThangKT, int NamKT)
        {
            SqlDataAdapter da;
            DataSet ds;
            int NgayKT1 = NgayKT + 1;
            string sqlstr = "";
            //  sqlstr = "select MASP 'Mã Sản Phẩm', TENSP 'Tên Sản Phẩm', SOLUONGNHAP 'Số Lượng', TIENNHAP 'Đơn Giá (/1SP) (VND)'";
            sqlstr = "select MASP , TENSP , SOLUONGNHAP ,TIENNHAP,TIENNHAP*SOLUONGNHAP as TT , THOIGIANNHAP  ";
            sqlstr += " from NHAPKHOTHEONGAY ";
            sqlstr += " where THOIGIANNHAP BETWEEN '" + ThangBD + "/" + NgayBD + "/" + NamBD + "' AND '" + ThangKT + "/" + NgayKT1 + "/" + NamKT + "'";
           // sqlstr += " group by MASP ,TENSP ";
            da = new SqlDataAdapter(sqlstr, _cn);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "NHAPKHOTHEONGAY");
            return ds;
        }
    }
}
