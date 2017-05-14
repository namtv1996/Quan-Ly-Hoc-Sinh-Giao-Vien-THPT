using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinhVien.Object;
using SinhVien.BLL;
using System.Text.RegularExpressions;


namespace SinhVien
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        //public delegate void CtrlCHandler(object sender, EventArgs info);
        //public event CtrlCHandler CtrC;

        BindingSource bdsoure = new BindingSource();
        private void Admin_Load(object sender, EventArgs e)
        {
            // hồ sơ sinh viên

            dgr_hososv.DataSource = Bus.GetListSinhVien();
            cbx_lop.DataSource = Bus.GestListTenLop();
            bdsoure.DataSource = Bus.GetListSinhVien();
            cbx_lop.DisplayMember = "tenlop";
            cbx_lop.ValueMember = "tenlop";
            dgr_hososv.AutoResizeRows();
            dgr_hososv.AutoResizeColumns();
            DoiTen();

            //ho so giang vien
            dgr_hosogv.DataSource = Bus.GetGiangVien();
            //dgr_hosogv.AutoResizeRows();
            //dgr_hosogv.AutoResizeColumns();



        }



        //-------------------SINH VIÊN-----------------------
        //---------------------------------------------------
        //đánh STT
        private void dgr_hososv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgr_hososv.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        //đổi tên dgr_hososv
        public void DoiTen()
        {
            dgr_hososv.Columns[1].HeaderText = "Mã SV";
            dgr_hososv.Columns[2].HeaderText = "Họ Tên";
            dgr_hososv.Columns[3].HeaderText = "Ngày Sinh";
            dgr_hososv.Columns[4].HeaderText = "Giới Tính";
            dgr_hososv.Columns[5].HeaderText = "Quê Quán";
            dgr_hososv.Columns[6].HeaderText = "Lớp";
        }
        // datagridview sinh viên
        private void dgr_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgr_hososv.CurrentCell.Selected = true;
                txt_masv.Text = dgr_hososv.CurrentRow.Cells["masv"].Value.ToString();
                txt_tensv.Text = dgr_hososv.CurrentRow.Cells["tensv"].Value.ToString();
                dtp_ngaysinh.Value = Convert.ToDateTime(dgr_hososv.CurrentRow.Cells["ngaysinh"].Value.ToString());
                if (dgr_hososv.CurrentRow.Cells["gioitinhsv"].Value.ToString() == "")
                {
                    rbt_nam.Checked = false;
                    rbt_nu.Checked = false;
                }
                else
                {

                    if (dgr_hososv.CurrentRow.Cells["gioitinhsv"].Value.ToString() == "Nam")
                    {
                        rbt_nam.Checked = true;
                    }
                    else rbt_nu.Checked = true;
                }
                txt_quequan.Text = dgr_hososv.CurrentRow.Cells["quequan"].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warnning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        //thêm
        private void btn_them_Click(object sender, EventArgs e)
        {
            foreach (Control item in grb_thongtin.Controls)
            {
                txt_masv.ResetText();
                txt_tensv.ResetText();
                txt_quequan.ResetText();
                dtp_ngaysinh.ResetText();
            }
        }
        //lưu
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_masv.Text == "" || txt_tensv.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            Object_SinhVien sv = new Object_SinhVien();
            // gan cac thuoc tinh cho cac control tren form sinhvien
            sv.MaSV = txt_masv.Text.ToString();
            sv.TenSV = txt_tensv.Text.ToString();
            sv.NgaySinh = dtp_ngaysinh.Value;
            sv.GioiTinhSV = rbt_nam.Checked ? "Nam" : "Nữ";
            sv.QueQuan = txt_quequan.Text;
            sv.MaLop = cbx_lop.SelectedValue.ToString();
            // int b = Bus.themSV(sv);
            if (MessageBox.Show(string.Format("Thêm sinh viên {0}, mã SV {1}", sv.TenSV, sv.MaSV), "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Bus.themSV(sv) > 0)
                {
                    MessageBox.Show("Thêm Thành Công!");
                    Admin_Load(sender, e);
                }
                else MessageBox.Show("Thêm Thất Bại!");
            }
        }
        //sửa
        private void btn_sua_Click(object sender, EventArgs e)
        {
            Object_SinhVien sv = new Object_SinhVien();
            sv.MaSV = txt_masv.Text;
            sv.TenSV = txt_tensv.Text;
            sv.NgaySinh = dtp_ngaysinh.Value;
            sv.GioiTinhSV = rbt_nam.Checked ? "Nam" : "Nữ";
            sv.QueQuan = txt_quequan.Text;
            sv.MaLop = cbx_lop.SelectedValue.ToString();
            if (MessageBox.Show(string.Format("Sửa sinh viên có mã {0}", sv.MaSV), "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Bus.SuaSV(sv) > 0)
                {
                    MessageBox.Show("Sửa Thành Công!");
                    Admin_Load(sender, e);
                }
                else MessageBox.Show("Sửa Thất Bại!");
            }
        }
        //xóa
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Object_SinhVien sv = new Object_SinhVien();
            sv.MaSV = txt_masv.Text;
            if (MessageBox.Show(string.Format("Xóa sinh viên có mã sv{0}", sv.MaSV), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {

                if (Bus.XoaSV(sv) > 0)
                {
                    MessageBox.Show("Xóa Thành Công!");
                    Admin_Load(sender, e);
                }
                else MessageBox.Show("Xóa Thất Bại!");

            }
        }
        //tìm kiếm
        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                lbl_goiytimkiem.Visible = Enabled;
            }
            else
            {
                lbl_goiytimkiem.Hide();
                string str = "tensv like '%" + txt_timkiem.Text + "%'";
                bdsoure.Filter = str;
                dgr_hososv.DataSource = bdsoure;
            }

        }

        private void lbl_goiytimkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Focus();
        }
        // ---------------------------GIẢNG VIÊN------------------------
        //--------------------------------------------------------------
        // ĐÁNH STT
        private void dgr_hosogv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgr_hosogv.Rows[e.RowIndex].Cells["STT1"].Value = e.RowIndex + 1;
        }
        // đổi tên 
        public void DoiTenGV()
        {
            dgr_hososv.Columns[1].HeaderText = "Mã GV";
            dgr_hososv.Columns[2].HeaderText = "Họ Tên";
            dgr_hososv.Columns[3].HeaderText = "Giới Tính";
            dgr_hososv.Columns[4].HeaderText = "SĐT";
            dgr_hososv.Columns[5].HeaderText = "Khoa";

        }
        // datagridview giang vien
        private void dgr_hosogv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgr_hosogv.CurrentCell.Selected = true;
            txt_magv.Text = dgr_hosogv.CurrentRow.Cells[1].Value.ToString();
            txt_tengv.Text = dgr_hosogv.CurrentRow.Cells[2].Value.ToString();
            txt_sdt.Text = dgr_hosogv.CurrentRow.Cells[4].Value.ToString();
            txt_khoa.Text = dgr_hosogv.CurrentRow.Cells[5].Value.ToString();
            if (dgr_hosogv.CurrentRow.Cells[3].Value.ToString() == "Nam")
            {
                rbt_nam1.Checked = true;
            }
            else rbt_nu1.Checked = true;

        }
        // thêm
        private void btn_them1_Click(object sender, EventArgs e)
        {

            foreach (Control item in grb_thongtin1.Controls)
            {
                txt_magv.ResetText();
                txt_tengv.ResetText();
                txt_sdt.ResetText();
                // dtp_ngaysinh.ResetText();
            }
        }
        // sửa 
        private void btn_sua1_Click(object sender, EventArgs e)
        {
            Object_Khoa kh = new Object_Khoa();
            Object_GiangVien gv = new Object_GiangVien();
            gv.MaGV = txt_magv.Text;
            gv.TenGV = txt_tengv.Text;
            gv.Sdt = txt_sdt.Text;
            gv.GioiTinhGV = rbt_nam1.Checked ? "Nam" : "Nữ";
            kh.TenKhoa = txt_khoa.Text;

            if (MessageBox.Show(string.Format("Sửa giảng viên có mã {0}", gv.MaGV), "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Bus.SuaGiangVien(gv, kh) > 0)
                {
                    MessageBox.Show("Sửa Thành Công!");
                    Admin_Load(sender, e);
                }
                else MessageBox.Show("Sửa Thất Bại!");
            }

        }
        //Xóa
        private void btn_xoa1_Click(object sender, EventArgs e)
        {
            Object_GiangVien gv = new Object_GiangVien();
            gv.MaGV = txt_magv.Text;
            if (MessageBox.Show(string.Format("Xóa giảng viên có mã {0}", gv.MaGV), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {

                if (Bus.XoaGiangVien(gv) > 0)
                {
                    MessageBox.Show("Xóa Thành Công!");
                    Admin_Load(sender, e);
                }
                else MessageBox.Show("Xóa Thất Bại!");

            }

        }
        // Lưu
        private void btn_luu1_Click(object sender, EventArgs e)
        {
            Object_Khoa kh = new Object_Khoa();
            Object_GiangVien gv = new Object_GiangVien();
            gv.MaGV = txt_magv.Text;
            gv.TenGV = txt_tengv.Text;
            gv.Sdt = txt_sdt.Text;
            gv.GioiTinhGV = rbt_nam1.Checked ? "Nam" : "Nu";
            kh.TenKhoa = txt_khoa.Text;
            if (MessageBox.Show(string.Format("Thêm giảng viên có mã {0}", gv.MaGV), "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Bus.ThemGiangVien(gv, kh) > 0)
                {
                    MessageBox.Show("Thêm Thành Công!");
                    Admin_Load(sender, e);
                }
                else MessageBox.Show("Thêm Thất Bại!");
            }

        }


        //------------------BẢNG ĐIỂM---------------------------
        //------------------------------------------------------

        // đánh stt
        private void dgr_bangdiem_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgr_bangdiem.Rows[e.RowIndex].Cells["STT2"].Value = e.RowIndex + 1;
        }


        // click button capnhat 
        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            Object_LopHocPhan lhp = new Object_LopHocPhan();
            lhp.Malhp = txt_malhp.Text;
            dgr_bangdiem.DataSource = Bus.GetDiem_LHP(lhp);
        }


        private void btn_luu2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Object_BangDiem bd = new Object_BangDiem();
                DataGridViewRow row = dgr_bangdiem.CurrentRow;
                for (int i = 0; i < dgr_bangdiem.Rows.Count - 1; i++)
                {
                    bd.MaLHP = txt_malhp.Text;
                    // if(dgr_bangdiem.Rows[i].Cells["diem_01"].Value==null)
                    if (dgr_bangdiem.Rows[i].Cells["masv"].Value.ToString().Length != 0) { bd.MaSV = dgr_bangdiem.Rows[i].Cells["masv"].Value.ToString(); }
                    else bd.MaSV = null;
                    if (dgr_bangdiem.Rows[i].Cells["diem_01"].Value.ToString() == "")
                    { continue;
                        //bd.Diem_01 = Convert.ToDouble(null);
                    }
                    else bd.Diem_01 = Convert.ToDouble(dgr_bangdiem.Rows[i].Cells["diem_01"].Value);
                    if (dgr_bangdiem.Rows[i].Cells["diem_02"].Value.ToString() == "")
                    {// bd.Diem_02 = Convert.ToDouble(null);
                        continue;
                    }
                    else bd.Diem_02 = Convert.ToDouble(dgr_bangdiem.Rows[i].Cells["diem_02"].Value);
                    if (dgr_bangdiem.Rows[i].Cells["diem_07"].Value.ToString() == "")
                    {// bd.Diem_07 = Convert.ToDouble(null);
                        continue;
                    }
                    else bd.Diem_07 = Convert.ToDouble(dgr_bangdiem.Rows[i].Cells["diem_07"].Value);

                    int val = Bus.CapNhatDiem(bd);
                }

                MessageBox.Show("Cập nhật thành công!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }


        }

        private void btn_xem1_Click(object sender, EventArgs e)
        {
            Object_LopHocPhan lhp = new Object_LopHocPhan();
            lhp.Malhp = txt_malhp1.Text;
            dgr_bangdiem.DataSource = Bus.ThongKeDiem_MaLHP(lhp);

        }
        private void btn_xem2_Click(object sender, EventArgs e)
        {
            Object_Lop l = new Object_Lop();
            l.MaLop = txt_malop.Text;
            dgr_bangdiem.DataSource = Bus.ThongKeDiem_MaLop(l);

        }

        private void btn_xem3_Click(object sender, EventArgs e)
        {
            Object_SinhVien sv = new Object_SinhVien();
            sv.MaSV = txt_masv1.Text;
            dgr_bangdiem.DataSource = Bus.ThongKeDiem_MaSV(sv);
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = Application.OpenForms["DangNhap"];
            f.Show();
            
        }

        //-----------------------THỐNG KÊ----------------------

        private void btn_in1_Click(object sender, EventArgs e)
        {
            try
            {
                Object_LopHocPhan lhp = new Object_LopHocPhan();
                lhp.Malhp = txt_malhp2.Text;
                DataTable dt = Bus.GetTenMon_MaLHP(lhp);
                label6.ResetText(); label7.ResetText(); label8.ResetText(); label9.ResetText(); label10.ResetText(); label11.ResetText();

                label7.Text = "Lớp Học Phần ";
                label8.ResetText(); label8.Text = DateTime.Now.ToShortDateString();

                label6.Text += "Môn học:  " + dt.Rows[0].Field<string>("TenMH");
                label9.Text += "Học kì:  " + dt.Rows[0].Field<string>("hocki");
                label10.Text += "Năm học:  " + dt.Rows[0].Field<string>("namhoc");


                dgr_thongkediem.DataSource = Bus.ThongKeDiem_MaLHP(lhp);



                Export ex = new Export();
                ex.ExportExcel_MaLHP(Bus.ThongKeDiem_MaLHP(lhp), "lớp học phần " + txt_malhp2.Text, "      Bảng Điểm Lớp Học Phần " + txt_malhp2.Text + " - " + label6.Text+"\n      "+label9.Text+" - "+label10.Text+"\n      Giảng viên: "+dt.Rows[0].Field<string>(3));

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi biên dịch\nKiểm tra dữ liệu nhập vào!");
            }
        }

        private void btn_in2_Click(object sender, EventArgs e)
        {
            try
            {
                Object_Lop l = new Object_Lop();
                l.MaLop = txt_malop2.Text;
                DataTable dt = Bus.GetTenLop_MaLop(l);
                label6.ResetText(); label7.ResetText(); label8.ResetText(); label9.ResetText(); label10.ResetText(); label11.ResetText();
                label7.Text = "Lớp ";
                label8.Text = DateTime.Now.ToShortDateString();
                label6.Text = "Lớp:  " + dt.Rows[0].Field<string>("tenlop");

                dgr_thongkediem.DataSource = Bus.ThongKeDiem_MaLop(l);
                Export ex = new Export();
                ex.ExportExcel_MaLop(Bus.ThongKeDiem_MaLop(l), "lớp " + txt_malop2.Text+" - " + dt.Rows[0].Field<string>("tenlop"), "Kết quả học tập " + label6.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi biên dịch \nKiểm tra dữ liệu nhập ");
            }
        }

        private void btn_in3_Click(object sender, EventArgs e)
        {
            Object_SinhVien sv = new Object_SinhVien();
            Object_LopHocPhan lhp = new Object_LopHocPhan();
            DataTable dt = new DataTable();

            string pattern = @"([0-9]{4,4}[\s][-][\s][0-9])";
            Regex myregex = new Regex(pattern);
            if (string.IsNullOrEmpty(txt_masv2.Text))
            {
                MessageBox.Show("Nhập vào mã sinh viên!");
            }
            else
            if (string.IsNullOrEmpty(txt_namhoc2.Text))
            {
                MessageBox.Show("Nhập vào năm học!");
            }
            else
                if (cbo_hocki2.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn học kì!");
            }
            else
            if (!myregex.IsMatch(txt_namhoc2.Text))
            {
                MessageBox.Show("Nhập đúng định dạng : yyyy - yyyy");
            }
            else
                try
                {
                    sv.MaSV = txt_masv2.Text;
                    lhp.Namhoc = txt_namhoc2.Text;
                    lhp.Hocki = cbo_hocki2.SelectedItem.ToString();
                    dt = Bus.GetThongTinSV_ThongKe(sv, lhp);
                    dgr_thongkediem.DataSource = Bus.ThongKeDiem_MaSV_NamHoc_HocKi(sv, lhp);

                    label6.ResetText(); label7.ResetText(); label8.ResetText(); label9.ResetText(); label10.ResetText(); label11.ResetText();
                    label8.Text = DateTime.Now.ToShortDateString();
                    label7.Text = "Sinh Viên ,Học Kì " + cbo_hocki2.SelectedItem.ToString() + ", Năm học " + txt_namhoc2.Text;
                    label6.Text = "Sinh Viên:  " + dt.Rows[0].Field<string>("tensv");

                    //label9.Text = "Số TC Nợ:  " + Convert.ToSingle( dt.Rows[0].Field<int?>("tcno"));
                    //label10.Text = "TB Học Kì:  " +Convert.ToDouble( dt.Rows[0].Field<float>("tbhk"));
                    //label11.Text = "Điểm Tích Lũy:  " +Convert.ToDouble (dt.Rows[0].Field<float>("diemtichluy"));
                    if (dt.Rows[0].Field<int?>(2) == null)
                    {
                        label9.Text = "Số TC Nợ:  0"; 
                    }
                    else

                    label9.Text = "Số TC Nợ:  " + dt.Rows[0].Field<int?>(2);
                    label10.Text = "TB Học Kì:  " + dt.Rows[0].Field<double?>(3);
                    label11.Text = "Điểm Tích Lũy:  " + dt.Rows[0].Field<double?>(1);

                    Export ex = new Export();
                    ex.ExportExcel_MaSV(Bus.ThongKeDiem_MaSV_NamHoc_HocKi(sv, lhp),txt_masv2.Text,string.Format(label7.Text+"\n"+ label6.Text +"\n"+ label10.Text +"\n"+ label9.Text+"\n"+ label11.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void txt_masv2_TextChanged(object sender, EventArgs e)
        {
            string pattern1 = @"[a-zA-Z]";
            if ((new Regex(pattern1).IsMatch(txt_masv2.Text)) == true)
            {
                errorProvider1.SetError(txt_masv2, "chỉ được nhập số");
            }
            else
            {
                errorProvider1.SetError(txt_masv2, "");
            }
        }

        // sự kiện phím tắt trên tabcontrol sinh viên
        private void tco_admin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == (Keys.S | Keys.Control))
            {
                if (MessageBox.Show("Bạn có muốn lưu bản ghi không?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (txt_masv.Text == "" || txt_tensv.Text == "")
                    {
                        MessageBox.Show("Chưa nhập đủ thông tin");
                        return;
                    }
                    Object_SinhVien sv = new Object_SinhVien();
                    // gan cac thuoc tinh cho cac control tren form sinhvien
                    sv.MaSV = txt_masv.Text.ToString();
                    sv.TenSV = txt_tensv.Text.ToString();
                    sv.NgaySinh = dtp_ngaysinh.Value;
                    sv.GioiTinhSV = rbt_nam.Checked ? "Nam" : "Nữ";
                    sv.QueQuan = txt_quequan.Text;
                    sv.MaLop = cbx_lop.SelectedValue.ToString();
                    // int b = Bus.themSV(sv);
                    if (MessageBox.Show(string.Format("Thêm sinh viên {0}, mã SV {1}", sv.TenSV, sv.MaSV), "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (Bus.themSV(sv) > 0)
                        {
                            MessageBox.Show("Thêm Thành Công!");
                            Admin_Load(sender, e);
                        }
                        else MessageBox.Show("Thêm Thất Bại!");
                    }
                }
            }
        }

        private void dgr_bangdiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //string pattern = @"[0-9]{1}[.][0-9]{2}";
            //Regex myrg = new Regex(pattern);
            //if (!myrg.IsMatch(dgr_bangdiem.CurrentCell.Value.ToString()))
            //{
            //    errorProvider1.SetError(dgr_bangdiem, "Nhập theo định dạng 2.92");
            //    MessageBox.Show("Nhập theo định dạng 2.92");
            //}
        }

        private void dgr_thongkediem_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgr_thongkediem.Rows[e.RowIndex].Cells["STT4"].Value = e.RowIndex + 1;
        }

        // xử lý định dạng khi nhập
        private void dgr_bangdiem_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;
            if (txt != null)
            {
                // txt.KeyPress -= new KeyPressEventHandler(txt_KeyPress);
                txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            }
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Kim tra cot
            TextBox txt = (TextBox)sender;
            //if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            //e.Handled = true;
            //if (txt.Text.Length > 3 && !Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}

            if (((Char.IsDigit(e.KeyChar) || Convert.ToInt16(e.KeyChar) == 46) && (txt.Text.Length < 3)) || Char.IsControl(e.KeyChar))
            {
                if (txt.Text.Length == 0 && Convert.ToInt16(e.KeyChar) == 46)
                {
                    e.Handled = true;
                }
                else if ((txt.Text.Length == 1) && (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || Convert.ToInt16(e.KeyChar) == 46))
                {

                    if (Convert.ToInt16(e.KeyChar) == 46 || (txt.Text[0] == '1' && Convert.ToInt16(e.KeyChar) == 48) || Char.IsControl(e.KeyChar)) { }
                    else e.Handled = true;
                }
                else if ((txt.Text.Length == 2) && !(Char.IsControl(e.KeyChar) || (txt.Text[1] != '0' && Convert.ToInt16(e.KeyChar) != 46)))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

