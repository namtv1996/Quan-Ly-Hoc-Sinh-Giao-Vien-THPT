using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinhVien.USERCONTROL;

namespace SinhVien
{
    public partial class GiangVien : Form
    {
        public GiangVien()
        {
            InitializeComponent();
        }

        private void GiangVien_Load(object sender, EventArgs e)
        {

        }
        private void ShowControl(System.Windows.Forms.Control object_control)
        {
            splitContainer1.Panel2.Controls.Clear();
            object_control.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(object_control);
        }
        private void btn_hosogiangvien_Click(object sender, EventArgs e)
        {
            User_GiangVien us = new User_GiangVien();
            ShowControl(us);
        }

        private void btn_xemlichday_Click(object sender, EventArgs e)
        {
            User_XemLichGiangDay us = new User_XemLichGiangDay();
            ShowControl(us);
        }

        private void GiangVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = Application.OpenForms["DangNhap"];
            f.Show();
        }

        private void btn_huongdangv_Click(object sender, EventArgs e)
        {
            User_HuongdanGV us = new User_HuongdanGV();
            ShowControl(us);
        }
    }
}
