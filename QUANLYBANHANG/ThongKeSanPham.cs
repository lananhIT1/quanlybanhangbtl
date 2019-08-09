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
namespace QUANLYBANHANG
{
    public partial class ThongKeSanPham : Form
    {
        public ThongKeSanPham()
        {
            InitializeComponent();
        }

        private void DpNL_ValueChanged(object sender, EventArgs e)
        {
            int thang = dpNL.Value.Month;
            int total = 0;
            DataTable dt = new DataTable();
            dt = BUS_HOADON.GetTotalSale(thang);
            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["thanhTien"].ToString() != null)
                    {
                        total = Convert.ToInt32(row["thanhTien"].ToString());
                    }
                    else
                    {
                        txtTotal.Text = "0";
                    }


                }

                txtTotal.Text = total.ToString();
            }catch(FormatException)
            {
                MessgageBox.Show("Sai kiểu dữ liệu");
            }
               
            


        }
    }
}
