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
    public partial class User_GiangVien : UserControl
    {
        public User_GiangVien()
        {
            InitializeComponent();
        }
        BindingSource bdsource = new BindingSource();
        //LOAD USER
        private void User_GiangVien_Load(object sender, EventArgs e)
        {
            dgr_thongtingiangvien.DataSource = Bus.GetGiangVien();
            dgr_thongtingiangvien.AutoResizeRows();
            //dgr_thongtingiangvien.AutoResizeColumns();
            DoiTen();
            bdsource.DataSource = Bus.GetGiangVien();
        }
        
        public void DoiTen()
        {
            dgr_thongtingiangvien.Columns[0].HeaderText = "Mã GV";
            dgr_thongtingiangvien.Columns[1].HeaderText = "Họ tên";
            dgr_thongtingiangvien.Columns[2].HeaderText = "Giới tính";
            dgr_thongtingiangvien.Columns[3].HeaderText = "SĐT";
            dgr_thongtingiangvien.Columns[4].HeaderText = "Khoa";
        }

        private void txt_timkiemgv_TextChanged(object sender, EventArgs e)
        {

            if (txt_timkiemgv.Text == "")
            {
                lbl_tim.Visible = Enabled;
            }
            else
                lbl_tim.Hide();
            string str = "TenGV like '%" + txt_timkiemgv.Text + "%'";
            bdsource.Filter = str;
            dgr_thongtingiangvien.DataSource = bdsource;
        }

        private void dgr_thongtingiangvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgr_thongtingiangvien.CurrentCell.Selected = true;
            lbl_ma1.Text = dgr_thongtingiangvien.CurrentRow.Cells[0].Value.ToString();
            lbl_ten1.Text = dgr_thongtingiangvien.CurrentRow.Cells[1].Value.ToString();
            lbl_gioitinh1.Text = dgr_thongtingiangvien.CurrentRow.Cells[2].Value.ToString();
            lbl_sdt1.Text = dgr_thongtingiangvien.CurrentRow.Cells[3].Value.ToString();
            lbl_khoa1.Text = dgr_thongtingiangvien.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
