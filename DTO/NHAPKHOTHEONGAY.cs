using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NHAPKHOTHEONGAY
    {
        private string _MASP;
        private string _TENSP;
        private decimal _SOLUONGNHAP;
        private decimal _TIENNHAP;
        private decimal _TONGTIEN;
        private DateTime _THOIGIANNHAP;

        public string MASP
        {
            get
            {
                return _MASP;
            }

            set
            {
                _MASP = value;
            }
        }

        public string TENSP
        {
            get
            {
                return _TENSP;
            }

            set
            {
                _TENSP = value;
            }
        }

        public decimal SOLUONGNHAP
        {
            get
            {
                return _SOLUONGNHAP;
            }

            set
            {
                _SOLUONGNHAP = value;
            }
        }

        public decimal TIENNHAP
        {
            get
            {
                return _TIENNHAP;
            }

            set
            {
                _TIENNHAP = value;
            }
        }

        public decimal TONGTIEN
        {
            get
            {
                return _TONGTIEN;
            }

            set
            {
                _TONGTIEN = value;
            }
        }

        public DateTime THOIGIANNHAP
        {
            get
            {
                return _THOIGIANNHAP;
            }

            set
            {
                _THOIGIANNHAP = value;
            }
        }
        public NHAPKHOTHEONGAY(DateTime THOIGIANNHAP , string MASP = "", string TENSP = "", decimal SOLUONGNHAP = 0, decimal TIENNHAP = 0, decimal TONGTIEN = 0)
        {
            this.MASP = MASP;
            this.TENSP = TENSP;
            this.SOLUONGNHAP = SOLUONGNHAP;
            this.TIENNHAP = TIENNHAP;
            this.TONGTIEN = TONGTIEN;
            this.THOIGIANNHAP = THOIGIANNHAP;
        }
    }
}
