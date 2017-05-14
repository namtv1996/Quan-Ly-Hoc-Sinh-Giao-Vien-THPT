using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinhVien.BLL;
using SinhVien.Object;

 namespace SinhVien
{
    public partial class User_XemLichGiangDay : UserControl
    {
        public User_XemLichGiangDay()
        {
            InitializeComponent();
        }

        private void User_XemLichGiangDay_Load(object sender, EventArgs e)
        {
            
        }
        public void DoiTen()
        {
            dgr_lichgiangday.Columns[0].HeaderText = "Mã môn học";
            dgr_lichgiangday.Columns[1].HeaderText = "Môn học";
            dgr_lichgiangday.Columns[2].HeaderText = "Mã LHP";
            dgr_lichgiangday.Columns[3].HeaderText = "Thời gian";
            dgr_lichgiangday.Columns[4].HeaderText = "Giảng đường";
        }
        private void btn_xem_Click(object sender, EventArgs e)
        {
            if (txt_nhapmagv.Text == "" || txt_nhapnamhoc.Text == "" || txt_nhaphocki.Text == "")
            {
                MessageBox.Show("Mời bạn điền đủ thông tin!");
            }
            else
            {
                try {
                    Object_GiangVien gv = new Object_GiangVien();
                    Object_LopHocPhan lhp = new Object_LopHocPhan();
                    gv.MaGV = txt_nhapmagv.Text;
                    lhp.Namhoc = txt_nhapnamhoc.Text;
                    lhp.Hocki = txt_nhaphocki.Text;
                    dgr_lichgiangday.DataSource = Bus.GetLichDay(gv, lhp);
                    dgr_lichgiangday.AutoResizeColumns();
                    dgr_lichgiangday.AutoResizeRows();
                    DoiTen();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("record empty!");
                }
               
            }

           
        }

        private void dgr_lichgiangday_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_goiynam_Click(object sender, EventArgs e)
        {
            txt_nhapnamhoc.Focus();
            lbl_goiynam.Hide();
        }

        private void txt_nhapnamhoc_TextChanged(object sender, EventArgs e)
        {
            if (txt_nhapnamhoc.Text == "")
            {
                lbl_goiynam.Visible = Enabled;
            }
            else
            lbl_goiynam.Hide();
        }

        private void txt_nhaphocki_TextChanged(object sender, EventArgs e)
        {
            if (txt_nhaphocki.Text == "")
            {
                lbl_goiyhocki.Visible = Enabled;
            }
            else
            lbl_goiyhocki.Hide();
        }

        private void lbl_goiyhocki_Click(object sender, EventArgs e)
        {
            txt_nhaphocki.Focus();
        }
    }
}
