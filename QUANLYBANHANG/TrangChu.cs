using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnQuanLySP_Click(object sender, EventArgs e)
        {
            QuanLySanPham qlsp = new QuanLySanPham();
            Hide();
            qlsp.Show();
        }

        private void BtnQLHD_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            this.Hide();
            hd.Show();
        }

        private void BtnQLKH_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang qlkh = new QuanLyKhachHang();
            this.Hide();
            qlkh.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ThongKeSanPham tk = new ThongKeSanPham();
            this.Hide();
            tk.Show();
        }
    }
}
