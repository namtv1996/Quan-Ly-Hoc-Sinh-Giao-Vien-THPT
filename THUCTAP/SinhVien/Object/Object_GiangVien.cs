using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Object
{
   public  class Object_GiangVien
    {
        private string _MaGV;
        private string _TenGV;
        private string _GioiTinhGV;
        private string _Sdt;

        public string MaGV
        {
            get
            {
                return _MaGV;
            }

            set
            {
                _MaGV = value;
            }
        }

        public string TenGV
        {
            get
            {
                return _TenGV;
            }

            set
            {
                _TenGV = value;
            }
        }

        public string GioiTinhGV
        {
            get
            {
                return _GioiTinhGV;
            }

            set
            {
                _GioiTinhGV = value;
            }
        }

        public string Sdt
        {
            get
            {
                return _Sdt;
            }

            set
            {
                _Sdt = value;
            }
        }
    }
}
