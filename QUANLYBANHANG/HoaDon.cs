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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BUS_HOADON.showListHoaDon();
            dgHD.DataSource = dt;
            dgHD2.DataSource = dt;
            DataTable sp = new DataTable();
            sp = BUS_SANPHAM.LoadListSP();
            cmbSP1.DataSource = sp;
            cmbSP1.DisplayMember = "tenSP";
            cmbSP1.ValueMember = "maSP";
            cmbSP2.DataSource = sp;
            cmbSP2.DisplayMember = "tenSP";
            cmbSP2.ValueMember = "maSP";
            DataTable kh = new DataTable();
            kh = BUS_KHACHHANG.showListKhachHang();
            cmbKH1.DataSource = kh;
            cmbKH1.DisplayMember = "tenKH";
            cmbKH1.ValueMember = "maKH";
            cmbKH2.DataSource = kh;
            cmbKH2.DisplayMember = "tenKH";
            cmbKH2.ValueMember = "maKH";
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD1.Text;
            string maKH = cmbKH1.SelectedValue.ToString();
            string maSP= cmbSP1.SelectedValue.ToString();
            float dg = (float)Convert.ToDouble(txtDG1.Text);
            Int32 slm = Convert.ToInt32(txtSL1.Text);
            
            if (maHD==""||cmbKH1.Text==""||cmbSP1.Text==""||txtSL1.Text=="")
            {
                MessageBox.Show("Không được bỏ trống");
            }
            else
            {
                try
                {
                    DataTable dup = new DataTable();
                    dup = BUS_HOADON.DuplicateHD(txtMaHD1.Text);
                    if(dup.Rows.Count>0)
                    {
                        MessageBox.Show("Trùng mã rồi kìa bạn ơi!");
                    }
                    else
                    { 
                        DataTable sp = new DataTable();
                        sp = BUS_SANPHAM.GetQTYSP(cmbSP1.SelectedValue.ToString());
                        Int32 ton = 0;

                        foreach (DataRow row in sp.Rows)
                        {
                            ton = Convert.ToInt32(row["soLuongTon"].ToString());
                        }
                        if (slm > ton)
                        {
                            MessageBox.Show("Không đủ hàng. Chỉ còn '" + ton + "' '" + cmbSP1.Text + "' trong kho");
                        }
                        else
                        {
                            HOADON hd = new HOADON(maHD, maKH, maSP, dg, slm, dpNL1.Value.ToString("yyyy-MM-dd"));
                            BUS_HOADON.InsertHD(hd);
                            BUS_SANPHAM.UpdateQTYSP(maSP, slm);
                            MessageBox.Show("Thêm hóa đơn thành công");
                            HoaDon_Load(sender, e);

                        }
                    }
                }catch(FormatException)
                {
                    MessageBox.Show("Bạn nhập sai kiểu dữ liệu rồi kìa!");
                }
            }
        }

        private void CmbSP1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSP = cmbSP1.SelectedValue.ToString();
            
            DataTable dt = new DataTable();
            dt = BUS_SANPHAM.GetGiaByMaSP(maSP);
            string gia = "";
            foreach (DataRow row in dt.Rows)
            {
                gia = row["donGia"].ToString();
           }
            txtDG1.Text = gia;
           // txtDG1.Text =dt.Rows[0][0].ToString();
           
            txtDG1.Enabled = false;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo);
            if(dlr==DialogResult.Yes)
            {
                BUS_HOADON.DeleteHD(txtMaHD2.Text);
                DataTable dt = new DataTable();
                dt = BUS_HOADON.showListHoaDon();
                dgHD2.DataSource = dt;
            }

        }
        int row;
        private void DgHD2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            txtSL2.Text= dgHD2.Rows[row].Cells[0].ToString();
            if (row>=0)
            {
                txtMaHD2.Text = dgHD2.Rows[row].Cells[0].Value.ToString();
                txtMaHD2.Enabled = false;
                cmbKH2.Text = dgHD2.Rows[row].Cells[1].Value.ToString();
                cmbSP2.Text = dgHD2.Rows[row].Cells[2].ToString();
                txtDG2.Text= dgHD2.Rows[row].Cells[4].Value.ToString();
                txtSL2.Text=dgHD2.Rows[row].Cells[3].Value.ToString();
                dpNL2.Text= dgHD2.Rows[row].Cells[5].Value.ToString();
            }
        }

        private void CmbSP2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSP = cmbSP2.SelectedValue.ToString();

            DataTable dt = new DataTable();
            dt = BUS_SANPHAM.GetGiaByMaSP(maSP);
            string gia = "";
            foreach (DataRow row in dt.Rows)
            {
                gia = row["donGia"].ToString();
            }
            txtDG2.Text = gia;
            // txtDG1.Text =dt.Rows[0][0].ToString();

            txtDG2.Enabled = false;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            string maKH = cmbKH2.SelectedValue.ToString();
            string maSP = cmbSP2.SelectedValue.ToString();
            float dg = (float)Convert.ToDouble(txtDG2.Text);
            Int32 slm = Convert.ToInt32(txtSL2.Text);
            
            if (cmbKH2.Text == "" || cmbSP2.Text == "" || txtSL2.Text == "")
            {
                MessageBox.Show("Không được bỏ trống");
            }
            else
            {
                try
                {
                    HOADON hd = new HOADON(txtMaHD2.Text, maKH, maSP, dg, slm, dpNL1.Value.ToString("yyyy-MM-dd"));
                    DataTable sp = new DataTable();
                    sp = BUS_SANPHAM.GetQTYSP(cmbSP2.SelectedValue.ToString());
                    Int32 ton = 0;
                    Int32 sltm = 0;
                    Int32 slc = 0;
                    DataTable spByMaHD = new DataTable();
                    spByMaHD = BUS_HOADON.DuplicateHD(txtMaHD2.Text);
                    foreach(DataRow r in spByMaHD.Rows)
                    {
                        slc = Convert.ToInt32(r["soLuong"].ToString());
                    }
                    foreach (DataRow row in sp.Rows)
                    {
                        ton = Convert.ToInt32(row["soLuongTon"].ToString());
                    }
                    sltm = ton - (slm - slc);
                    if (sltm<0)
                    {
                        MessageBox.Show("Không đủ hàng. Chỉ còn '" + ton + "' '" + cmbSP2.Text + "' trong kho");
                    }
                    else
                    {
                        BUS_HOADON.UpdateHD(txtMaHD2.Text,hd);
                        BUS_SANPHAM.UpdateQTYSP(maSP, sltm);
                        MessageBox.Show("Cập nhật hóa đơn thành công");
                        HoaDon_Load(sender, e);

                    }


                }
                catch (FormatException)
                {
                    MessageBox.Show("Bạn nhập sai kiểu dữ liệu rồi kìa!");
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.Compare(cmbFilter.Text, "Tên sản phẩm")==0) //tìm theo tên sp
            {
                MessageBox.Show("tìm theo tên sp");
                DataTable search = new DataTable();
                search = BUS_HOADON.SearchHDByTenSP(txtSearch.Text);
                dgHD3.DataSource = search;

            }
            else if (cmbFilter.Text == "Mã hóa đơn")//tìm theo mã hóa đơn
            {

            }
            else//trường hợp còn lại tìm theo ten khách hàng
            {

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            this.Hide();
            tc.Show();
        }
    }
}
