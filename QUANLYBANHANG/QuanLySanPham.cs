using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QUANLYBANHANG
{
    public partial class QuanLySanPham : Form
    {
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            DataTable sp = new DataTable();
            DataTable cat = new DataTable();
            DataTable ncc = new DataTable();

            sp = BUS_SANPHAM.LoadListSP();
            cat = BUS_DANHMUC.loadListCategory();
            ncc = BUS_NCC.loadListNCC();
            dgSP.DataSource = sp;
            dgSanPham.DataSource = sp;
            dgSearchSP.DataSource = sp;

            cmbDM.DataSource = cat;
            cmbDM.DisplayMember = "tenDM";
            cmbDM.ValueMember = "maDM";

            cmbNCC.DataSource = ncc;
            cmbNCC.DisplayMember = "tenNCC";
            cmbNCC.ValueMember = "maNCC";
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable sp = new DataTable();
            DataTable cat = new DataTable();
            DataTable ncc = new DataTable();

            sp = BUS_SANPHAM.LoadListSP();
            cat = BUS_DANHMUC.loadListCategory();
            ncc = BUS_NCC.loadListNCC();
            if (tabControl1.SelectedIndex == 0)
            {
                dgSP.DataSource = sp;
                cmbDM.DataSource = cat;
                cmbDM.DisplayMember = "tenDM";
                cmbDM.ValueMember = "maDM";
                cmbNCC.DataSource = ncc;
                cmbNCC.DisplayMember = "tenNCC";
                cmbNCC.ValueMember = "maNCC";
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                dgSanPham.DataSource = sp;
                cmbDanhMuc.DataSource = cat;
                cmbDanhMuc.DisplayMember = "tenDM";
                cmbDanhMuc.ValueMember = "maDM";
                cmbNhaCC.DataSource = ncc;
                cmbNhaCC.DisplayMember = "tenNCC";
                cmbNhaCC.ValueMember = "maNCC";

            }
            else
            {
                //cmbSearch.DataSource = cat;
                //cmbSearch.DisplayMember = "tenDM";
               // cmbSearch.ValueMember = "maDM";
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "" && txtTen.Text != "" && txtDG.Text != "" && txtSLT.Text != "")
            {

                try
                {
                    SP sp = new SP(txtMa.Text, txtTen.Text, (float)Convert.ToDouble(txtDG.Text), Convert.ToInt32(txtSLT.Text), dpNN.Value.ToString("yyyy-MM-dd"), cmbDM.SelectedValue.ToString(), cmbNCC.SelectedValue.ToString());
                    if (BUS_SANPHAM.GetMaSP(txtMa.Text))
                    {
                        BUS_SANPHAM.InsertSP(sp);
                        QuanLySanPham_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Trùng mã rồi kìa!", "Cảnh báo");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Bạn nhập sai kiểu dữ liệu");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi kết nối!");
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống ", "Thông báo");
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text != "" && txtDonGia.Text != "" && txtSoLuongTon.Text != "")
            {

                try
                {
                    SP sp = new SP(txtMaSP.Text, txtTenSP.Text, (float)Convert.ToDouble(txtDonGia.Text), Convert.ToInt32(txtSoLuongTon.Text), dpNgayNhap.Value.ToString("yyyy-MM-dd"), cmbDanhMuc.SelectedValue.ToString(), cmbNhaCC.SelectedValue.ToString());
                    BUS_SANPHAM.UpdateSP(txtMaSP.Text, sp);
                    DataTable dt = new DataTable();
                    dt = BUS_SANPHAM.LoadListSP();
                    dgSanPham.DataSource = dt;

                }
                catch (FormatException)
                {
                    MessageBox.Show("Bạn nhập sai kiểu dữ liệu");
                }

            }
            else
            {
                MessageBox.Show("Không được bỏ trống ", "Thông báo");
            }
        }
        int row;
        private void DgSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txtMaSP.Text = dgSanPham.Rows[row].Cells[0].Value.ToString();
                txtTenSP.Text = dgSanPham.Rows[row].Cells[1].Value.ToString();
                txtDonGia.Text = dgSanPham.Rows[row].Cells[2].Value.ToString();
                txtSoLuongTon.Text = dgSanPham.Rows[row].Cells[3].Value.ToString();
                dpNgayNhap.Text = dgSanPham.Rows[row].Cells[4].Value.ToString();
                cmbDanhMuc.Text = dgSanPham.Rows[row].Cells[5].Value.ToString();
                cmbNhaCC.Text = dgSanPham.Rows[row].Cells[6].Value.ToString();
                txtMaSP.Enabled = false;
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                BUS_SANPHAM.DeleteSP(txtMaSP.Text);
                DataTable dt = new DataTable();
                dt = BUS_SANPHAM.LoadListSP();
                dgSanPham.DataSource = dt;
            }
        }

        private void TabPage_Click(object sender, EventArgs e)
        {

        }
    }
}
