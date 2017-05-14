using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Object
{
   public  class Object_LopHocPhan
    {
        private string _malhp;
        private DateTime _ngaybd;
        private DateTime _ngaykt;
        private string _giangduong;
        private string _hocki;
        private string _mamh;
        private string _namhoc;

        public string Malhp
        {
            get
            {
                return _malhp;
            }

            set
            {
                _malhp = value;
            }
        }

        public DateTime Ngaybd
        {
            get
            {
                return _ngaybd;
            }

            set
            {
                _ngaybd = value;
            }
        }

        public DateTime Ngaykt
        {
            get
            {
                return _ngaykt;
            }

            set
            {
                _ngaykt = value;
            }
        }

        public string Giangduong
        {
            get
            {
                return _giangduong;
            }

            set
            {
                _giangduong = value;
            }
        }

        public string Hocki
        {
            get
            {
                return _hocki;
            }

            set
            {
                _hocki = value;
            }
        }

        public string Mamh
        {
            get
            {
                return _mamh;
            }

            set
            {
                _mamh = value;
            }
        }

        public string Namhoc
        {
            get
            {
                return _namhoc;
            }

            set
            {
                _namhoc = value;
            }
        }
    }
}
