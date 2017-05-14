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
    public partial class User_thoikhoabieu : UserControl
    {
        public User_thoikhoabieu()
        {
            InitializeComponent();
        }
        BindingSource bdsource = new BindingSource();
        private void User_thoikhoabieu_Load(object sender, EventArgs e)
        {
    
        }

        private void DoiTen()
        {
            //dgr_thoikhoabieu.Columns[0].HeaderText = "Mã môn học";
            dgr_thoikhoabieu.Columns[1].HeaderText = "Môn học";
            dgr_thoikhoabieu.Columns[2].HeaderText = "TC";
            dgr_thoikhoabieu.Columns[3].HeaderText = "Mã LHP";
            dgr_thoikhoabieu.Columns[4].HeaderText = "Thời gian";
            dgr_thoikhoabieu.Columns[5].HeaderText = "Giảng đường";
            dgr_thoikhoabieu.Columns[6].HeaderText = "Học kì";
            dgr_thoikhoabieu.Columns[7].HeaderText = "Năm học";

        }
        private void btn_xem_Click(object sender, EventArgs e)
        {
            Object_SinhVien sv = new Object_SinhVien();
            sv.MaSV = txt_timkiemsv.Text;
            dgr_thoikhoabieu.DataSource = Bus.GetThoiKhoaBieu(sv);
            dgr_thoikhoabieu.AutoResizeRows();
            dgr_thoikhoabieu.AutoResizeColumns();
            DoiTen();
        }

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
            dgr_thoikhoabieu.DataSource = bdsource;
        }

    }
}
