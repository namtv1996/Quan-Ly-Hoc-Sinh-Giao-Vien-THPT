using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Object
{
   public class Object_SinhVien
    {

        private string _MaSV;
        private string _TenSV;
        private DateTime _NgaySinh;
        private string _GioiTinhSV;
        private string _QueQuan;
        private string _MaLop;

        public string MaSV
        {
            get
            {
                return _MaSV;
            }

            set
            {
                _MaSV = value;
            }
        }

        public string TenSV
        {
            get
            {
                return _TenSV;
            }

            set
            {
                _TenSV = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return _NgaySinh;
            }

            set
            {
                _NgaySinh = value;
            }
        }

        public string GioiTinhSV
        {
            get
            {
                return _GioiTinhSV;
            }

            set
            {
                _GioiTinhSV = value;
            }
        }

        public string QueQuan
        {
            get
            {
                return _QueQuan;
            }

            set
            {
                _QueQuan = value;
            }
        }

        public string MaLop
        {
            get
            {
                return _MaLop;
            }

            set
            {
                _MaLop = value;
            }
        }
    }
}
