using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QUANLYBANHANG
{
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BUS_KHACHHANG.showListKhachHang();
            dgKH.DataSource = dt;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang(txtMa.Text, txtTen.Text, txtSDT.Text, txtEmail.Text, txtDiaChi.Text);
            BUS_KHACHHANG.InsertKH(kh);
            QuanLyKhachHang_Load(sender, e);
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang(txtMa.Text, txtTen.Text, txtSDT.Text, txtEmail.Text, txtDiaChi.Text);
            BUS_KHACHHANG.UpdateKH(txtMa.Text,kh);
            QuanLyKhachHang_Load(sender, e);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                BUS_KHACHHANG.DeleteKH(txtMa.Text);
                QuanLyKhachHang_Load(sender, e);

            }
        }
        int row;
        private void DgKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txtMa.Text = dgKH.Rows[row].Cells[0].Value.ToString();
                txtTen.Text = dgKH.Rows[row].Cells[1].Value.ToString();
                txtSDT.Text = dgKH.Rows[row].Cells[2].Value.ToString();
                txtEmail.Text = dgKH.Rows[row].Cells[3].Value.ToString();
                txtDiaChi.Text = dgKH.Rows[row].Cells[4].Value.ToString();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BUS_KHACHHANG.SearchKH(txtSearch.Text);
            dgKH.DataSource = dt;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            this.Hide();
            tc.Show();
        }
    }
}
