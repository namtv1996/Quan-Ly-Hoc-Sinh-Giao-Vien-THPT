using SinhVien.USERCONTROL;
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
    public partial class portalsinhvien : Form
    {
        public portalsinhvien()
        {
            InitializeComponent();
        }
        //LOAD FORM

        private void portalsinhvien_Load(object sender, EventArgs e)
        {

        }
        //SHOW USER_CONTROL
        private void ShowControl(System.Windows.Forms.Control object_control)
        {
            splitContainer1.Panel2.Controls.Clear();
            object_control.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(object_control);
        }
        //CLICK 
        private void btn_hososinhvien_Click(object sender, EventArgs e)
        {
            User_ThongTinSV us = new User_ThongTinSV();
            ShowControl(us);
        }

        private void btn_xemthoikhoabieu_Click(object sender, EventArgs e)
        {
            User_thoikhoabieu us = new User_thoikhoabieu();
            ShowControl(us);
        }

        private void btn_ketquahoctap_Click(object sender, EventArgs e)
        {
            User_BangDiem us = new User_BangDiem();
            ShowControl(us);
        }

        private void portalsinhvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form f = Application.OpenForms["DangNhap"];
            f.Show();
        }

        private void btn_huogndansv_Click(object sender, EventArgs e)
        {
            User_HuongdanSV us = new User_HuongdanSV();
            ShowControl(us);
        }
    }
}
