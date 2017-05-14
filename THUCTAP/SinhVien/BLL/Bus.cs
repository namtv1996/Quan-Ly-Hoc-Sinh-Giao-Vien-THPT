using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SinhVien.DAL;
using SinhVien.Object;

namespace SinhVien.BLL
{
    public class Bus
    {
        //--------SINH VIÊN------------------
        //
        //xem thoi khoa bieu
        public static DataTable GetThoiKhoaBieu(Object_SinhVien sv)
        {
            return Dao.GetThoiKhoaBieu(sv);
        }
        //load sv
        public static DataTable GetListSinhVien()
        {
            return Dao.GetListSinhVien();
        }
        //load lop
        public static DataTable GestListTenLop()
        {
            return Dao.GetListTenLop();
        }
        //xem thoi khoa bieu
        public static DataTable GetBangDiem(Object_SinhVien sv)
        {
            return Dao.GetBangDiem(sv);
        }
        //Xem thong tinsv tren bang diem
        public static DataTable GetThongTinSV(Object_SinhVien sv)
        {
            return Dao.GetThongTinSV(sv);
        }
       
        public static int themSV(Object_SinhVien sv)
        {
            return Dao.themSV(sv);
        }
        public static int XoaSV(Object_SinhVien sv)
        {
            return Dao.XoaSinhVien(sv);
        }
        public static int SuaSV(Object_SinhVien sv)
        {
            return Dao.SuaSinhVien(sv);
        }

        //----------LỚP------------------------
        //
        public static DataTable Getlop()
        {
            return Dao.GetListLop();
        }
        public static int Themlop(Object_Lop lop)
        {
            return Dao.ThemLop(lop);
        }
        public static int SuaLop(Object_Lop lop)
        {
            return Dao.SuaLop(lop);
        }
        public static int XoaLop(Object_Lop lop)
        {
            return Dao.XoaLop(lop);
        }
        //-----------GIẢNG VIÊN----------------
        //
        public static DataTable GetLichDay(Object_GiangVien gv,Object_LopHocPhan lhp)
        {
            return Dao.GetLichDay(gv, lhp);
        }
        public static DataTable GetGiangVien()
        {
            return Dao.GetListGiangVien();
        }
        public static int ThemGiangVien(Object_GiangVien gv,Object_Khoa kh)
        {
            return Dao.ThemGiangVien(gv,kh);
        }
        public static int SuaGiangVien(Object_GiangVien gv,Object_Khoa kh)
        {
            return Dao.SuaGiangVien(gv,kh);
        }
        public static int XoaGiangVien(Object_GiangVien gv)
        {
            return Dao.XoaGiangVien(gv);
        }
        //------------------ ADMIN BẢNG ĐIỂM -----------------
        public static DataTable GetDiem_LHP(Object_LopHocPhan lhp)
        {
            return Dao.GetDiem_LHP(lhp);
        }
        //chỉnh sửa bảng điểm
        public static int CapNhatDiem(Object_BangDiem bd)
        {
            return Dao.CapNhatDiem(bd);
        } 
        //thống kê điểm theo mã LHP
        public static DataTable ThongKeDiem_MaLHP(Object_LopHocPhan lhp)
        {
            return Dao.ThongKeDiem_MaLHP(lhp);
        }
        // thống kê theo mã lớp
        public static DataTable ThongKeDiem_MaLop(Object_Lop l)
        {
            return Dao.ThongKeDiem_MaLop(l);
        }
        // thống kê điểm theo từng sinh viên
        public static DataTable ThongKeDiem_MaSV(Object_SinhVien sv)
        {
            return Dao.ThongKeDiem_MaSV(sv);
        }
        //
        public static DataTable GetTenMon_MaLHP(Object_LopHocPhan lhp)
        {
            return Dao.GetTenMon_MaLHP(lhp);
        }
        public static DataTable GetTenLop_MaLop(Object_Lop l)
        {
            return Dao.GetTenLop_MaLop(l);
        }
        public static DataTable ThongKeDiem_MaSV_NamHoc_HocKi(Object_SinhVien sv, Object_LopHocPhan lhp)
        {
            return Dao.ThongKeDiem_MaSV_NamHoc_HocKi(sv, lhp);
        }
        public static DataTable GetThongTinSV_ThongKe(Object_SinhVien sv, Object_LopHocPhan lhp)
        {
            return Dao.GetThongTinSV_ThongKe(sv, lhp);
        }
    }
}
