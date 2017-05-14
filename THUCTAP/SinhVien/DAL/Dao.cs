using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SinhVien.Object;

namespace SinhVien.DAL
{
    //chuyen thuc hien them sua xoa loaddata
    public class Dao
    {
        //-------SINH VIÊN-----------------
        //LOAD SV
        public static DataTable GetListSinhVien()
        {
            return DataProvider.GetData("LoadSinhVien");
        }
        //LOAD TÊN LỚP
        public static DataTable GetListTenLop()
        {
            return DataProvider.GetData("LoadTenLop");
        }
        //XEM THỜI KHÓA BIỂU
        public static DataTable GetThoiKhoaBieu(Object_SinhVien sv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masv",sv.MaSV),
            };
            return DataProvider.GetDatadk("xemthoikhoabieu", para);
        }
        //XEM BẢNG ĐIỂM
        public static DataTable GetBangDiem(Object_SinhVien sv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masv",sv.MaSV)
            };
            return DataProvider.GetDatadk("ketquahoctap", para);
        }
        //XEM THÔNG TIN TRÊN BẢNG ĐIỂM
        public static DataTable GetThongTinSV(Object_SinhVien sv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masv",sv.MaSV)
            };
            return DataProvider.GetDatadk("thongtinsv_bangdiem", para);
        }

        //TÌM KIẾM SV
        // THÊM SV
        public static int themSV(Object_SinhVien sv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masv", sv.MaSV),
                new SqlParameter("@ten", sv.TenSV),
                new SqlParameter("@ngaysinh", sv.NgaySinh),
                new SqlParameter("@gioitinh", sv.GioiTinhSV),
                new SqlParameter("@quequan", sv.QueQuan),
                new SqlParameter("@tenlop", sv.MaLop),
            };

            return DataProvider.ExecuteNonQuery("THEMSINHVIEN", para);
        }
        //SỬA SV
        public static int SuaSinhVien(Object_SinhVien sv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masv",sv.MaSV),
                new SqlParameter("@tensv",sv.TenSV),
                new SqlParameter("@ngaysinh",sv.NgaySinh),
                new SqlParameter("@gioitinh",sv.GioiTinhSV),
                new SqlParameter("@quequan",sv.QueQuan),
                new SqlParameter("@tenlop",sv.MaLop)
            };
            return DataProvider.ExecuteNonQuery("suasinhvien", para);
        }
        //XÓA SV
        public static int XoaSinhVien(Object_SinhVien sv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter("@masv", sv.MaSV)
            };


            return DataProvider.ExecuteNonQuery("xoasinhvien", para);
        }

        //----------lỚP----------------------
        //LOAD LỚP
        public static DataTable GetListLop()
        {
            return DataProvider.GetData("loadlop");
        }
        //THÊM LỚP
        public static int ThemLop(Object_Lop lop)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("malop",lop.MaLop),
                new SqlParameter("tenlop",lop.TenLop),
                new SqlParameter("soluongsv",lop.SoLuongSV),
                new SqlParameter("magv",lop.MaGV)
            };
            return DataProvider.ExecuteNonQuery("themlop", para);
        }
        //SỬA LỚP
        public static int SuaLop(Object_Lop lop)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter ("@malop",lop.MaLop),
                new SqlParameter("@tenlop",lop.TenLop),
                new SqlParameter("@soluongsv",lop.SoLuongSV),
                new SqlParameter("@magv",lop.MaGV)
            };
            return DataProvider.ExecuteNonQuery("sualop", para);
        }
        //XÓA LỚP
        public static int XoaLop(Object_Lop lop)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@malop",lop.MaLop)
            };
            return DataProvider.ExecuteNonQuery("Xoalop",para);
        } 
        //---------------GIẢNG VIÊN-------------
        //LOAD GIẢNG VIÊN
        public static DataTable GetListGiangVien()
        {
            return DataProvider.GetData("loadgiangvien");
        }
        // Lịch giảng dạy
        public static DataTable GetLichDay(Object_GiangVien gv,Object_LopHocPhan lhp)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@magv",gv.MaGV),
                new SqlParameter("@namhoc",lhp.Namhoc),
                new SqlParameter("@hocki",lhp.Hocki)

            };
            return DataProvider.GetDatadk("xemlichgiangday", para);
        }
        //THÊM GIẢNG VIÊN
        public static int ThemGiangVien(Object_GiangVien gv,Object_Khoa kh)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@magv",gv.MaGV),
                new SqlParameter("@tengv",gv.TenGV),
                new SqlParameter("@gioitinhgv",gv.GioiTinhGV),
                new SqlParameter("@sdt",gv.Sdt),
                new SqlParameter("@tenkhoa",kh.TenKhoa)
            };
            return DataProvider.ExecuteNonQuery("Themgiangvien", para);
        }
        //SỬA GV
        public static int SuaGiangVien(Object_GiangVien gv,Object_Khoa kh)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@magv",gv.MaGV),
                new SqlParameter("@tengv",gv.TenGV),
                new SqlParameter("@gioitinhgv",gv.GioiTinhGV),
                new SqlParameter("@sdt",gv.Sdt),
                new SqlParameter("@tenkhoa",kh.TenKhoa)
            };
            return DataProvider.ExecuteNonQuery("suagv", para);
        }
        //XÓA GV
        public static int XoaGiangVien(Object_GiangVien gv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@magv",gv.MaGV)
            };
            return DataProvider.ExecuteNonQuery("xoagiangvien", para);
        }

        // -------------------ADMIN BẢNG ĐIỂM-----------------
        //select bảng điểm
        public static DataTable GetDiem_LHP(Object_LopHocPhan lhp)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@malhp",lhp.Malhp)
            };
            return DataProvider.GetDatadk("CapNhatDiem", para);
        }
        //Sửa Bảng Điểm
        public static int CapNhatDiem(Object_BangDiem bd)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter ("@malhp",bd.MaLHP),
                new SqlParameter ("@masv",bd.MaSV),
                new SqlParameter ("@diem_01",bd.Diem_01),
                new SqlParameter ("@diem_02",bd.Diem_02),
                new SqlParameter ("@diem_07",bd.Diem_07)
            };
            return DataProvider.ExecuteNonQuery("suadiem", para);
        }
        //Thống kê theo lhp
        public static DataTable ThongKeDiem_MaLHP(Object_LopHocPhan lhp)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter ("@malhp",lhp.Malhp)
            };
            return DataProvider.GetDatadk("thongkediem_malhp", para);
        }
        //Thống kê theo lớp 
        public static DataTable ThongKeDiem_MaLop(Object_Lop l)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter ("@malop",l.MaLop)
            };
            return DataProvider.GetDatadk("ThongKeDiem_lop", para);
        }
        // Thống kê điểm theo từng sinh viên
        public static DataTable ThongKeDiem_MaSV(Object_SinhVien sv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maSV",sv.MaSV)
            };
            return DataProvider.GetDatadk("ThongKeDiem_MaSV", para);
        }
        //lấy tên môn học: 
        public static DataTable GetTenMon_MaLHP(Object_LopHocPhan lhp)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@malhp",lhp.Malhp)
            };
            return DataProvider.GetDatadk("GetTenMon_malhp", para);
        }
        public static DataTable GetTenLop_MaLop(Object_Lop l)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@malop",l.MaLop)
            };
            return DataProvider.GetDatadk("GetTenLop_malop", para);
        }
        public static DataTable ThongKeDiem_MaSV_NamHoc_HocKi(Object_SinhVien sv,Object_LopHocPhan lhp)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter ("@masv",sv.MaSV),
                new SqlParameter ("@hocki",lhp.Hocki),
                new SqlParameter ("@namhoc",lhp.Namhoc)
            };
            return DataProvider.GetDatadk("ThongKeDiem_masv_hk_namhoc", para);
        }
        public static DataTable GetThongTinSV_ThongKe(Object_SinhVien sv, Object_LopHocPhan lhp)
        {
            SqlParameter[] para = new SqlParameter[]
   {
                new SqlParameter ("@masv",sv.MaSV),
                new SqlParameter ("@hocki",lhp.Hocki),
                new SqlParameter ("@namhoc",lhp.Namhoc)
   };
            return DataProvider.GetDatadk("getthongtinsv", para);
        }
        }
    }
