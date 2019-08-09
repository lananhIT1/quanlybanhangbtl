namespace QUANLYBANHANG
{
    partial class TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuanLySP = new System.Windows.Forms.Button();
            this.btnQLHD = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QUANLYBANHANG.Properties.Resources.Bannernew;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1111, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // btnQuanLySP
            // 
            this.btnQuanLySP.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnQuanLySP.Location = new System.Drawing.Point(121, 272);
            this.btnQuanLySP.Name = "btnQuanLySP";
            this.btnQuanLySP.Size = new System.Drawing.Size(169, 93);
            this.btnQuanLySP.TabIndex = 1;
            this.btnQuanLySP.Text = "Quản lý sản phẩm";
            this.btnQuanLySP.UseVisualStyleBackColor = false;
            this.btnQuanLySP.Click += new System.EventHandler(this.BtnQuanLySP_Click);
            // 
            // btnQLHD
            // 
            this.btnQLHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQLHD.Location = new System.Drawing.Point(401, 273);
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(169, 92);
            this.btnQLHD.TabIndex = 2;
            this.btnQLHD.Text = "Quản lý hóa đơn";
            this.btnQLHD.UseVisualStyleBackColor = false;
            this.btnQLHD.Click += new System.EventHandler(this.BtnQLHD_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnQLKH.Location = new System.Drawing.Point(698, 273);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(169, 94);
            this.btnQLKH.TabIndex = 3;
            this.btnQLKH.Text = "Quản Lý Khách Hàng";
            this.btnQLKH.UseVisualStyleBackColor = false;
            this.btnQLKH.Click += new System.EventHandler(this.BtnQLKH_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(121, 447);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 94);
            this.button4.TabIndex = 4;
            this.button4.Text = "Quản lý danh mục";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button5.Location = new System.Drawing.Point(401, 447);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 93);
            this.button5.TabIndex = 5;
            this.button5.Text = "Quản lý người dùng";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(698, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 92);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thống kê ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 593);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnQLKH);
            this.Controls.Add(this.btnQLHD);
            this.Controls.Add(this.btnQuanLySP);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQuanLySP;
        private System.Windows.Forms.Button btnQLHD;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
    }
}