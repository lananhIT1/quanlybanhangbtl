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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Username Không được để trống");
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Password Không được để trống");
            }
            else
            {
                
                DataTable dt = new DataTable();
               dt = BUS_DANGNHAP.checkLogin2(txtUser.Text, txtPass.Text);
               if (dt.Rows.Count==0)
                {
                    MessageBox.Show("Sai");
                }
                else
                {
                    
                    TrangChu tc = new TrangChu();
                    tc.Show();
                    Hide();
                }
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
