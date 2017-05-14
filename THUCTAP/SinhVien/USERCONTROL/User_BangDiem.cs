using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinhVien.Object;
using SinhVien.BLL;

namespace SinhVien
{
    public partial class User_BangDiem : UserControl
    {
        public User_BangDiem()
        {
            InitializeComponent();
        }
        BindingSource bdsource = new BindingSource();

        //USERCONTROL_LOAD

        private void User_BangDiem_Load(object sender, EventArgs e)
        {

        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            Object_SinhVien sv = new Object_SinhVien();
            //
            sv.MaSV = txt_timkiemsv.Text;
            dgr_bangdiem.DataSource = Bus.GetBangDiem(sv);
            dgr_bangdiem.AutoResizeRows();
            dgr_bangdiem.AutoResizeColumns();
      
            try {
                DataTable dt = Bus.GetThongTinSV(sv);
                int a = dt.Columns.Count;
                lbl_masv1.Text = ": " + dt.Rows[0].Field<string>("masv");
                lbl_sinhvien1.Text = ": " + dt.Rows[0].Field<string>("tensv");
                lbl_namhoc1.Text = ": " + dt.Rows[0].Field<double?>("diemtichluy");
                //lbl_hocki1.Text = ": " + dt.Rows[0].Field<string>("hocki");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Record empty!");
            }
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
            dgr_bangdiem.DataSource = bdsource;
        }

        private void dgr_bangdiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
