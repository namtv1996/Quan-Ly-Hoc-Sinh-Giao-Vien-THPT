using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVien
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {
            if (txt_matkhau.Text == "")
            {
                lbl_password.Visible = true;
                errorProvider1.SetError(this.txt_matkhau, "Nhập mật khẩu!");
            }
            else
            {
                errorProvider1.SetError(this.txt_matkhau, "");

                lbl_password.Hide();
            }
             
        }


        private void txt_taikhoan_TextChanged(object sender, EventArgs e)
        {
            if (txt_taikhoan.Text == "")
            {
                lbl_username.Visible = Enabled;
                errorProvider1.SetError(this.txt_taikhoan, "Nhập tên tài khoản!");
            }

            else
            {
                errorProvider1.SetError(this.txt_taikhoan, "");
                lbl_username.Hide();
            }
            
        }

        private void lbl_username_Click_1(object sender, EventArgs e)
        {
            txt_taikhoan.Focus();
        }

        private void lbl_password_Click_1(object sender, EventArgs e)
        {
            txt_matkhau.Focus();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
        // CLICK ĐĂNG NHẬP
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_taikhoan.Text))
            {
                MessageBox.Show("Nhập vào tài khoản");
            }
            else
            if (string.IsNullOrEmpty(txt_matkhau.Text))
            {
                MessageBox.Show("Nhập vào mật khẩu");
            }
            else
            if (txt_taikhoan.Text == "sv" && txt_matkhau.Text == "sv")
            {
                this.Hide();
                portalsinhvien p = new portalsinhvien();
                p.Show();
                
            }
            else
            if (txt_taikhoan.Text == "gv" && txt_matkhau.Text == "gv")
            {
                this.Hide();
                GiangVien g = new GiangVien();
                g.Show();
            }
            else
            if (txt_taikhoan.Text == "admin" && txt_matkhau.Text == "admin")
            {
                this.Hide();
                Admin a = new Admin();
                a.Show();
            }
            else MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!");
        }

    }
}
