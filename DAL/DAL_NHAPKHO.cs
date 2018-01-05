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
    public class DAL_NHAPKHO:BDConnect
    {
        DataTable dt = new DataTable();
        public DAL_NHAPKHO()
        {
            dt = Get_NHAPKHO();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }
        public DataTable Get_NHAPKHO()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from NHAPKHO", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
              
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public bool Insert ( NHAPKHO nk )
        {
            try
            {
                _cn.Open();

                string SQL = "INSERT INTO NHAPKHO  VALUES ('" + nk.MASP + "',N'" + nk.TENSP + "',N'" + nk.SOLUONGNHAP + "', '" + nk.TIENNHAP +"','"+nk.TONGTIEN+ "')";

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
        public bool Update (NHAPKHO nk)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NHAPKHO", _cn);
                DataRow r = dt.Rows.Find(nk.MASP.ToString());
                if (r != null)
                {
                    r["TENSP"] = nk.TENSP;
                    r["SOLUONGNHAP"] = nk.SOLUONGNHAP;
                    r["TIENNHAP"] = nk.TIENNHAP;
                    r["TONGTIEN"] = nk.TONGTIEN;
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
        public bool Delete (string MaSP)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(" select * from NHAPKHO ", _cn);
                DataRow r = dt.Rows.Find(MaSP);
                if(r!=null)
                {
                    r.Delete();
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
        public DataSet Get_ALL()
        {
            SqlDataAdapter da;
            DataSet ds;
            string sqlstr = "";
           //  sqlstr = "select MASP 'Mã Sản Phẩm', TENSP 'Tên Sản Phẩm', SOLUONGNHAP 'Số Lượng', TIENNHAP 'Đơn Giá (/1SP) (VND)'";
            sqlstr = "select *";
            sqlstr += "from NHAPKHO ";
            da = new SqlDataAdapter(sqlstr, _cn);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "NHAPKHO");
            return ds;
        }
        public DataSet Get_TheoMa(string MaSP)
        {
            SqlDataAdapter da;
            DataSet ds;
            string sqlstr = "";
            sqlstr = "select *";
            sqlstr += "from NHAPKHO ";
            sqlstr += "where MASP LIKE'%"+MaSP+"%'";
            da = new SqlDataAdapter(sqlstr, _cn);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "NHAPKHO");
            return ds;
        }
        public DataSet Get_TheoTen(string TenSP)
        {
            SqlDataAdapter da;
            DataSet ds;
            string sqlstr = "";
            sqlstr = "select *";
            sqlstr += "from NHAPKHO ";
            sqlstr += "where TENSP LIKE N'%" + TenSP + "%'";
            da = new SqlDataAdapter(sqlstr, _cn);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "NHAPKHO");
            return ds;
        }
        public DataTable Get_MA(string MASP)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from NHAPKHO where MASP='"+MASP+"'", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable Get_SL(string MASP)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select SOLUONGNHAP from NHAPKHO where MASP='" + MASP + "'", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public bool UpdateSoLuongNhap(double SoLuong ,string MASP)
        {
            try
            {
                _cn.Open();

                // Query string
                string SQL = "update NHAPKHO set '" + SoLuong + "' where MASP = '" + MASP + "'";

                // Command (mặc định command type = text nên chúng ta khỏi phải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _cn);

                // Query và kiểm tra
                cmd.ExecuteNonQuery();
                _cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
