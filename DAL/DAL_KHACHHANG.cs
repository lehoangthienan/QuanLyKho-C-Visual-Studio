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
    public class DAL_KHACHHANG:BDConnect
    {
        DataTable dt = new DataTable();
        public DAL_KHACHHANG()
        {
            dt = Get_KHACHHANG();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }
        public DataTable Get_KHACHHANG()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from KHACHHANG", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch
            {
                return null;
            }
        }
        public bool Insert(KHACHHANG kh)
        {
            try
            {
                _cn.Open();

                string SQL = "INSERT INTO KHACHHANG   VALUES ('" + kh.MAKHO + "',N'" + kh.HOTEN + "',N'" + kh.SDT + "', N'" + kh.DIACHI + "',N'" + kh.FB  + "')";

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

        public bool Update(KHACHHANG kh, string MAKHO)
        {
            try
            {
                _cn.Open();

                // Query string
                string SQL = "update KHACHHANG set DIACHI = N'" + kh.DIACHI + "' , FB = N'" + kh.FB + "' , SDT = N'" + kh.SDT + "' , HOTEN = N'" + kh.HOTEN + "' where MAKHO = '" + MAKHO + "'";

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
        //public DataSet Get_TheoMa(string MaKho)
        //{
        //    SqlDataAdapter da;
        //    DataSet ds;
        //    string sqlstr = "";
        //    sqlstr = "select HOTEN , SDT , DIACHI , FB ";
        //    sqlstr += "from KHACHHANG ";
        //    sqlstr += "where MAKHO =" + MaKho ;
        //    da = new SqlDataAdapter(sqlstr, _cn);
        //    ds = new DataSet();
        //    ds.Clear();
        //    da.Fill(ds, "KHACHHANG");
        //    return ds;
        //}

        public DataTable Get_MA(string MaKho)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select HOTEN , SDT , DIACHI , FB from KHACHHANG where MAKHO= '" + MaKho + "'", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataSet Get_HoTen(string MaKho)
        {
            SqlDataAdapter da;
            DataSet ds;
            string sqlstr = "";
            sqlstr = " select HOTEN  ";
            sqlstr += "from KHACHHANG ";
            sqlstr += " where MAKHO = '" + MaKho +"'" ;
            da = new SqlDataAdapter(sqlstr, _cn);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "KHACHHANG");
            return ds;
        }
    }
}
