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
    public partial class User_HuongdanGV : UserControl
    {
        public User_HuongdanGV()
        {
            InitializeComponent();
            webBrowser2.Navigate(@"C:\Users\namtv1996\Downloads\Nhóm 8 Quảng Chiến Nam -- Quản lý điểm SV\btl_ngonngu\btl_ngonngu2\THUCTAP\SinhVien\Resources\Huongdangv.htm");
        }
    }
}
