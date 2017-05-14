using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Object
{
    public class Object_Lop
    {
        private string _maLop;
        private string _tenLop;
        private int _soLuongSV;
        private string _maGV;

        public string MaLop
        {
            get
            {
                return _maLop;
            }

            set
            {
                _maLop = value;
            }
        }

        public string TenLop
        {
            get
            {
                return _tenLop;
            }

            set
            {
                _tenLop = value;
            }
        }

        public int SoLuongSV
        {
            get
            {
                return _soLuongSV;
            }

            set
            {
                _soLuongSV = value;
            }
        }

        public string MaGV
        {
            get
            {
                return _maGV;
            }

            set
            {
                _maGV = value;
            }
        }
    }
}
