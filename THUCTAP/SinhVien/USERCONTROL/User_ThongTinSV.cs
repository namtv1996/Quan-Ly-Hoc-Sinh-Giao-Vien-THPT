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

namespace SinhVien
{
    public partial class User_ThongTinSV : UserControl
    {
        public User_ThongTinSV()
        {
            InitializeComponent();
        }
        BindingSource bdsource = new BindingSource();
        //LOAD USER
        private void User_ThongTinSV_Load(object sender, EventArgs e)
        {
            dgr_thongtinsinhvien.DataSource = Bus.GetListSinhVien();
            bdsource.DataSource = Bus.GetListSinhVien();
        }

        //THAO TAC TREN DATADGRIDVIEW
        private void dgr_thongtinsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgr_thongtinsinhvien.CurrentCell.Selected = true;
            lbl_ma1.Text = dgr_thongtinsinhvien.CurrentRow.Cells["masv"].Value.ToString();
            lbl_ten1.Text = dgr_thongtinsinhvien.CurrentRow.Cells["tensv"].Value.ToString();
            lbl_ngaysinh1.Text = dgr_thongtinsinhvien.CurrentRow.Cells["ngaysinh"].Value.ToString();
            lbl_gioitinh1.Text = dgr_thongtinsinhvien.CurrentRow.Cells["gioitinhsv"].Value.ToString();
            lbl_quequan1.Text = dgr_thongtinsinhvien.CurrentRow.Cells["quequan"].Value.ToString();
            lbl_lop1.Text = dgr_thongtinsinhvien.CurrentRow.Cells["tenlop"].Value.ToString();
        }
        //TIM KIEM
        private void lbl_tim_Click(object sender, EventArgs e)
        {
            txt_timkiemsv.Focus();
        }
        private void txt_timkiemsv_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiemsv.Text == "")
            {
                lbl_tim.Visible = Enabled;
            }
            else
                lbl_tim.Hide();
            string str = "tensv like '%" + txt_timkiemsv.Text + "%'";
            bdsource.Filter = str;
            dgr_thongtinsinhvien.DataSource = bdsource;
        }

     

       
    }
}
