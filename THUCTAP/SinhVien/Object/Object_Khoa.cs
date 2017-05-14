using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Object
{
public     class Object_Khoa
    {
        private string _maKhoa;
        private string _tenKhoa;
        private string _maCNKhoa;

        public string MaKhoa
        {
            get
            {
                return _maKhoa;
            }

            set
            {
                _maKhoa = value;
            }
        }

        public string TenKhoa
        {
            get
            {
                return _tenKhoa;
            }

            set
            {
                _tenKhoa = value;
            }
        }

        public string MaCNKhoa
        {
            get
            {
                return _maCNKhoa;
            }

            set
            {
                _maCNKhoa = value;
            }
        }
    }
}
