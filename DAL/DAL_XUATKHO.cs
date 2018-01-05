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
  public  class DAL_XUATKHO : BDConnect
    {
        DataTable dt = new DataTable();
        public DAL_XUATKHO()
        {
            dt = Get_XUATKHO();
           // dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }
        public DataTable Get_XUATKHO()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from XUATKHO", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch
            {
                return null;
            }
        }
        public bool Insert(XUATKHO xk)
        {
            try
            {
                _cn.Open();

                string SQL = "INSERT INTO XUATKHO   VALUES ('" + xk.MAKHO + "','" + xk.THOIGIANXUAT + "','" + xk.MASP + "', N'" + xk.TENSP + "','" + xk.SOLUONGXUAT + "','" + xk.TIENXUAT + "','" + xk.TIENNHAP + "','" + xk.TONGTIENXUAT + "','" +xk.TONGTIENNHAP + "','" + xk.LOINHUAN + "')";

                SqlCommand cmd = new SqlCommand(SQL, _cn);
                cmd.ExecuteNonQuery();
                _cn.Close();
                //SqlDataAdapter da = new SqlDataAdapter("select * from XUATKHO")
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(XUATKHO xk , string MAKHO , string MASP)
        {
            try
            {
                //SqlDataAdapter da = new SqlDataAdapter("select * from XUATKHO", _cn);
                //DataRow r = dt.Rows.Find(MAKHO);
                //DataRow r1 = dt.Rows.Find(MASP);
                //if (r != null)
                //{
                //    if(r1!=null)
                //    {
                //        r["MAKHO"] = xk.MAKHO;
                //        r["THOIGIANXUAT"] = xk.THOIGIANXUAT;
                //        r["MASP"] = xk.MASP;
                //        r["TENSP"] = xk.TENSP;
                //        r["SOLUONGXUAT"] = xk.SOLUONGXUAT;
                //        r["TIENXUAT"] = xk.TIENXUAT;
                //        r["TIENNHAP"] = xk.TIENNHAP;
                //        r["TONGTIENXUAT"] = xk.TONGTIENXUAT;
                //        r["LOINHUAN"] = xk.LOINHUAN;
                //    }

                //}
                //SqlCommandBuilder cm = new SqlCommandBuilder(da);
                //da.Update(dt);
                //return true;
                // Ket noi
                _cn.Open();

                // Query string
                string SQL = "update XUATKHO set THOIGIANXUAT = '" + xk.THOIGIANXUAT + "' , SOLUONGXUAT = '" + xk.SOLUONGXUAT + "' , TIENXUAT = '" + xk.TIENXUAT + "' , TIENHHAP = '" + xk.TIENNHAP + "' , TONGTIENXUAT = '" + xk.TONGTIENXUAT + "' , LOINHUAN = '" + xk.LOINHUAN +"' , TONGTIENNHAP = '"+xk.TONGTIENNHAP + "' where MASP = '" + MASP + "' and MAKHO = '" + MAKHO + "'";

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
        public bool Delete(string MAKHO, string MASP)
        {
            try
            {
                // Ket noi
                _cn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string sqlstr = "";
                sqlstr = "delete from XUATKHO where MAKHO='";
                sqlstr += MAKHO +"' and MASP ='"+MASP;
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
            sqlstr += "from XUATKHO ";
            da = new SqlDataAdapter(sqlstr, _cn);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "XUATKHO");
            return ds;
        }
        public DataSet Get_TheoMa(string MaSP)
        {
            SqlDataAdapter da;
            DataSet ds;
            string sqlstr = "";
            sqlstr = "select *";
            sqlstr += "from XUATKHO ";
            sqlstr += "where MASP LIKE '%" + MaSP + "%'";
            da = new SqlDataAdapter(sqlstr, _cn);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "XUATKHO");
            return ds;
        }
        public DataSet Get_TheoTen(string TenSP)
        {
            SqlDataAdapter da;
            DataSet ds;
            string sqlstr = "";
            sqlstr = "select *";
            sqlstr += "from XUATKHO ";
            sqlstr += "where TENSP LIKE N'%" + TenSP + "%'";
            da = new SqlDataAdapter(sqlstr, _cn);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "XUATKHO");
            return ds;
        }
        public DataSet Get_TheoKho(string MaKho)
        {
            SqlDataAdapter da;
            DataSet ds;
            string sqlstr = "";
            sqlstr = "select *";
            sqlstr += "from XUATKHO ";
            sqlstr += "where MAKHO LIKE '%" + MaKho + "%'";
            da = new SqlDataAdapter(sqlstr, _cn);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "XUATKHO");
            return ds;
        }
        public DataTable Get_MaKho()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select DISTINCT MAKHO from XUATKHO ", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable Get_MaSP(string MAKHO)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select MASP from XUATKHO where MAKHO='"+MAKHO+"'", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable TENSP(string MAKHO , string MASP)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from XUATKHO where MASP='" + MASP + "' and MAKHO='"+MAKHO+"'", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        //public DataSet Get_TheoNgay(int NgayBD , int ThangBD , int NamBD , int NgayKT , int ThangKT , int NamKT)
        //{
        //    SqlDataAdapter da;
        //    DataSet ds;
        //    string sqlstr = "";
        //    //  sqlstr = "select MASP 'Mã Sản Phẩm', TENSP 'Tên Sản Phẩm', SOLUONGNHAP 'Số Lượng', TIENNHAP 'Đơn Giá (/1SP) (VND)'";
        //    sqlstr = "select MASP , TENSP ,SUM(SOLUONGXUAT) SOLUONG,SUM(LOINHUAN) LAI ,SUM(TONGTIENXUAT) BANRA , SUM(TONGTIENNHAP) VON ";
        //    sqlstr += " from XUATKHO ";
        //    sqlstr += " where day(THOIGIANXUAT)>=" + NgayBD + "and day(THOIGIANXUAT)<=" + NgayKT + "and month(THOIGIANXUAT)>=" + ThangBD + "and month(THOIGIANXUAT)<=" + ThangKT + "and year(THOIGIANXUAT)>=" + NamBD + "and year(THOIGIANXUAT)<=" + NamKT;
        //    sqlstr += " group by MASP ,TENSP ";
        //    da = new SqlDataAdapter(sqlstr, _cn);
        //    ds = new DataSet();
        //    ds.Clear();
        //    da.Fill(ds, "XUATKHO");
        //    return ds;
        //}

        public DataSet Get_TheoNgay(int NgayBD, int ThangBD, int NamBD, int NgayKT, int ThangKT, int NamKT)
        {
            SqlDataAdapter da;
            DataSet ds;
            string sqlstr = "";
            int NgayKT1 = NgayKT + 1;
            //  sqlstr = "select MASP 'Mã Sản Phẩm', TENSP 'Tên Sản Phẩm', SOLUONGNHAP 'Số Lượng', TIENNHAP 'Đơn Giá (/1SP) (VND)'";
            sqlstr = "select MASP , TENSP ,SUM(SOLUONGXUAT) SOLUONG,SUM(LOINHUAN) LAI ,SUM(TONGTIENXUAT) BANRA , SUM(TONGTIENNHAP) VON ";
            sqlstr += " from XUATKHO ";
            sqlstr += " where THOIGIANXUAT BETWEEN '"+ ThangBD +"/"+NgayBD+"/"+NamBD +"' AND '"+ ThangKT + "/" + NgayKT1  + "/" + NamKT+"'";
            sqlstr += " group by MASP ,TENSP ";
            da = new SqlDataAdapter(sqlstr, _cn);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "XUATKHO");
            return ds;
        }

        public DataSet Get_TheoNgay1(DateTime TuNgay , DateTime DenNgay)
        {
            SqlDataAdapter da;
            DataSet ds;
            string sqlstr = "";
            //  sqlstr = "select MASP 'Mã Sản Phẩm', TENSP 'Tên Sản Phẩm', SOLUONGNHAP 'Số Lượng', TIENNHAP 'Đơn Giá (/1SP) (VND)'";
            sqlstr = "select MASP , TENSP ,SUM(SOLUONGXUAT) SOLUONG,SUM(LOINHUAN) LAI ,SUM(TONGTIENXUAT) BANRA , SUM(TONGTIENNHAP) VON ";
            sqlstr += " from XUATKHO ";
            sqlstr += " where THOIGIANXUAT BETWEEN " + TuNgay +" AND " +DenNgay;
            sqlstr += " group by MASP ,TENSP ";
            da = new SqlDataAdapter(sqlstr, _cn);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "XUATKHO");
            return ds;
        }

        public DataTable Get_BaoCao(string MAKHO)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select TENSP ,SOLUONGXUAT, TIENXUAT, TONGTIENXUAT from XUATKHO where MAKHO='" + MAKHO + "'", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable Get_MaKhoTheoNgay(int NgayBD, int ThangBD, int NamBD, int NgayKT, int ThangKT, int NamKT)
        {
            try
            {
                int NgayKT1 = NgayKT + 1;
                SqlDataAdapter da = new SqlDataAdapter("Select DISTINCT MAKHO from XUATKHO where THOIGIANXUAT BETWEEN '" + ThangBD + "/" + NgayBD + "/" + NamBD + "' AND '" + ThangKT + "/" + NgayKT1 + "/" + NamKT + "'", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
