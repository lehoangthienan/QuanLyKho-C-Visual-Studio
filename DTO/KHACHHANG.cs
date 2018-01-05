using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class KHACHHANG
    {
        private string _MAKHO;
        private string _HOTEN;
        private string _SDT;
        private string _DIACHI;
        private string _FB;

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

        public string HOTEN
        {
            get
            {
                return _HOTEN;
            }

            set
            {
                _HOTEN = value;
            }
        }

        public string SDT
        {
            get
            {
                return _SDT;
            }

            set
            {
                _SDT = value;
            }
        }

        public string DIACHI
        {
            get
            {
                return _DIACHI;
            }

            set
            {
                _DIACHI = value;
            }
        }

        public string FB
        {
            get
            {
                return _FB;
            }

            set
            {
                _FB = value;
            }
        }
        public KHACHHANG (string MAKHO="",string HOTEN ="",string SDT ="" , string DIACHI ="",string FB = "" )
        {
            this.MAKHO = MAKHO;
            this.HOTEN = HOTEN;
            this.SDT = SDT;
            this.DIACHI = DIACHI;
            this.FB = FB;
        }
    }
}
