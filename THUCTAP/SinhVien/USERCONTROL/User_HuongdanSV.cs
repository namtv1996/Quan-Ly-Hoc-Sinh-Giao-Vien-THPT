using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVien.USERCONTROL
{
    public partial class User_HuongdanSV : UserControl
    {
        public User_HuongdanSV()
        {
            InitializeComponent();
            webBrowser2.Navigate(@"C:\Users\namtv1996\Desktop\GITHUB-PROJECT\Phần mềm quản lý học sinh, giáo viên của trường THPT\Quan-Ly-Hoc-Sinh-Giao-Vien-THPT\THUCTAP\SinhVien\Resources\Huongdansv.htm");
        }
    }
}
