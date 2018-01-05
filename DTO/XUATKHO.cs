using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class XUATKHO
    {
        private string _MAKHO;
        private DateTime _THOIGIANXUAT;
        private string _MASP;
        private string _TENSP;
        private decimal _SOLUONGXUAT;
        private decimal _TIENXUAT;
        private decimal _TIENNHAP;
        private decimal _TONGTIENXUAT;
        private decimal _LOINHUAN;
        private decimal _TONGTIENNHAP;

        public string MAKHO
        {
            get
            {
                return _MAKHO;
            }

            set
            {
                _MAKHO = value;
            }
        }

        public DateTime THOIGIANXUAT
        {
            get
            {
                return _THOIGIANXUAT;
            }

            set
            {
                _THOIGIANXUAT = value;
            }
        }

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

        public decimal SOLUONGXUAT
        {
            get
            {
                return _SOLUONGXUAT;
            }

            set
            {
                _SOLUONGXUAT = value;
            }
        }

        public decimal TIENXUAT
        {
            get
            {
                return _TIENXUAT;
            }

            set
            {
                _TIENXUAT = value;
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

        public decimal TONGTIENXUAT
        {
            get
            {
                return _TONGTIENXUAT;
            }

            set
            {
                _TONGTIENXUAT = value;
            }
        }

        public decimal LOINHUAN
        {
            get
            {
                return _LOINHUAN;
            }

            set
            {
                _LOINHUAN = value;
            }
        }

        public decimal TONGTIENNHAP
        {
            get
            {
                return _TONGTIENNHAP;
            }

            set
            {
                _TONGTIENNHAP = value;
            }
        }

        public XUATKHO(DateTime THOIGIANXUAT , string MAKHO = "", string MASP = "", string TENSP = "",  decimal SOLUONGXUAT = 0, decimal TIENXUAT = 0, decimal TIENNHAP =0, decimal TONGTIENXUAT =0, decimal LOINHUAN =0, decimal TONGTIENNHAP=0)
        {
            this.THOIGIANXUAT = THOIGIANXUAT;
            this.MASP = MASP;
            this.TENSP = TENSP;
            this.SOLUONGXUAT = SOLUONGXUAT;
            this.TIENXUAT = TIENXUAT;
            this.MAKHO = MAKHO;
            this.TIENNHAP = TIENNHAP;
            this.LOINHUAN = LOINHUAN;
            this.TONGTIENXUAT = TONGTIENXUAT;
            this.TONGTIENNHAP = TONGTIENNHAP;
        }
    }
}
