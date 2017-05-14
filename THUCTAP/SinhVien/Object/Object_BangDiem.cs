using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Object
{
    public class Object_BangDiem
    {

        private string _maSV;
        private string _maLHP;
        private Double _diem_01;
        private Double _diem_02;
        private Double _diem_07;

        public string MaSV
        {
            get
            {
                return _maSV;
            }

            set
            {
                _maSV = value;
            }
        }

        public string MaLHP
        {
            get
            {
                return _maLHP;
            }

            set
            {
                _maLHP = value;
            }
        }

        public Double Diem_01
        {
            get
            {
                return _diem_01;
            }

            set
            {
                _diem_01 = value;
            }
        }

        public Double Diem_02
        {
            get
            {
                return _diem_02;
            }

            set
            {
                _diem_02 = value;
            }
        }

        public Double Diem_07
        {
            get
            {
                return _diem_07;
            }

            set
            {
                _diem_07 = value;
            }
        }
    }
}
