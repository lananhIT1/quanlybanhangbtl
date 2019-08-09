namespace QUANLYBANHANG
{
    partial class HoaDon
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgHD = new System.Windows.Forms.DataGridView();
            this.dpNL1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDG1 = new System.Windows.Forms.TextBox();
            this.txtSL1 = new System.Windows.Forms.TextBox();
            this.cmbSP1 = new System.Windows.Forms.ComboBox();
            this.cmbKH1 = new System.Windows.Forms.ComboBox();
            this.txtMaHD1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgHD2 = new System.Windows.Forms.DataGridView();
            this.dpNL2 = new System.Windows.Forms.DateTimePicker();
            this.txtSL2 = new System.Windows.Forms.TextBox();
            this.txtDG2 = new System.Windows.Forms.TextBox();
            this.cmbSP2 = new System.Windows.Forms.ComboBox();
            this.cmbKH2 = new System.Windows.Forms.ComboBox();
            this.txtMaHD2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgHD3 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHD)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHD2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHD3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1102, 607);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Controls.Add(this.dgHD);
            this.tabPage1.Controls.Add(this.dpNL1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtDG1);
            this.tabPage1.Controls.Add(this.txtSL1);
            this.tabPage1.Controls.Add(this.cmbSP1);
            this.tabPage1.Controls.Add(this.cmbKH1);
            this.tabPage1.Controls.Add(this.txtMaHD1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1094, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thêm hóa đơn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.Location = new System.Drawing.Point(384, 205);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 41);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // dgHD
            // 
            this.dgHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgHD.Location = new System.Drawing.Point(3, 267);
            this.dgHD.Name = "dgHD";
            this.dgHD.RowTemplate.Height = 28;
            this.dgHD.Size = new System.Drawing.Size(1088, 295);
            this.dgHD.TabIndex = 12;
            // 
            // dpNL1
            // 
            this.dpNL1.Location = new System.Drawing.Point(604, 140);
            this.dpNL1.Name = "dpNL1";
            this.dpNL1.Size = new System.Drawing.Size(248, 35);
            this.dpNL1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày lập";
            // 
            // txtDG1
            // 
            this.txtDG1.Location = new System.Drawing.Point(604, 16);
            this.txtDG1.Name = "txtDG1";
            this.txtDG1.Size = new System.Drawing.Size(174, 35);
            this.txtDG1.TabIndex = 9;
            // 
            // txtSL1
            // 
            this.txtSL1.Location = new System.Drawing.Point(604, 77);
            this.txtSL1.Name = "txtSL1";
            this.txtSL1.Size = new System.Drawing.Size(174, 35);
            this.txtSL1.TabIndex = 8;
            // 
            // cmbSP1
            // 
            this.cmbSP1.FormattingEnabled = true;
            this.cmbSP1.Location = new System.Drawing.Point(187, 132);
            this.cmbSP1.Name = "cmbSP1";
            this.cmbSP1.Size = new System.Drawing.Size(174, 37);
            this.cmbSP1.TabIndex = 7;
            this.cmbSP1.SelectedIndexChanged += new System.EventHandler(this.CmbSP1_SelectedIndexChanged);
            // 
            // cmbKH1
            // 
            this.cmbKH1.FormattingEnabled = true;
            this.cmbKH1.Location = new System.Drawing.Point(187, 69);
            this.cmbKH1.Name = "cmbKH1";
            this.cmbKH1.Size = new System.Drawing.Size(174, 37);
            this.cmbKH1.TabIndex = 6;
            // 
            // txtMaHD1
            // 
            this.txtMaHD1.Location = new System.Drawing.Point(187, 10);
            this.txtMaHD1.Name = "txtMaHD1";
            this.txtMaHD1.Size = new System.Drawing.Size(174, 35);
            this.txtMaHD1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnXoa);
            this.tabPage2.Controls.Add(this.btnSua);
            this.tabPage2.Controls.Add(this.dgHD2);
            this.tabPage2.Controls.Add(this.dpNL2);
            this.tabPage2.Controls.Add(this.txtSL2);
            this.tabPage2.Controls.Add(this.txtDG2);
            this.tabPage2.Controls.Add(this.cmbSP2);
            this.tabPage2.Controls.Add(this.cmbKH2);
            this.tabPage2.Controls.Add(this.txtMaHD2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1094, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sửa, Xóa hóa đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(537, 218);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 47);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Turquoise;
            this.btnSua.Location = new System.Drawing.Point(381, 218);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 47);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // dgHD2
            // 
            this.dgHD2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHD2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgHD2.Location = new System.Drawing.Point(3, 290);
            this.dgHD2.Name = "dgHD2";
            this.dgHD2.RowTemplate.Height = 28;
            this.dgHD2.Size = new System.Drawing.Size(1088, 272);
            this.dgHD2.TabIndex = 12;
            this.dgHD2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgHD2_CellClick);
            // 
            // dpNL2
            // 
            this.dpNL2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpNL2.Location = new System.Drawing.Point(779, 166);
            this.dpNL2.Name = "dpNL2";
            this.dpNL2.Size = new System.Drawing.Size(200, 35);
            this.dpNL2.TabIndex = 11;
            // 
            // txtSL2
            // 
            this.txtSL2.Location = new System.Drawing.Point(779, 97);
            this.txtSL2.Name = "txtSL2";
            this.txtSL2.Size = new System.Drawing.Size(200, 35);
            this.txtSL2.TabIndex = 10;
            // 
            // txtDG2
            // 
            this.txtDG2.Location = new System.Drawing.Point(779, 24);
            this.txtDG2.Name = "txtDG2";
            this.txtDG2.Size = new System.Drawing.Size(200, 35);
            this.txtDG2.TabIndex = 9;
            // 
            // cmbSP2
            // 
            this.cmbSP2.FormattingEnabled = true;
            this.cmbSP2.Location = new System.Drawing.Point(167, 158);
            this.cmbSP2.Name = "cmbSP2";
            this.cmbSP2.Size = new System.Drawing.Size(188, 37);
            this.cmbSP2.TabIndex = 8;
            this.cmbSP2.SelectedIndexChanged += new System.EventHandler(this.CmbSP2_SelectedIndexChanged);
            // 
            // cmbKH2
            // 
            this.cmbKH2.FormattingEnabled = true;
            this.cmbKH2.Location = new System.Drawing.Point(167, 88);
            this.cmbKH2.Name = "cmbKH2";
            this.cmbKH2.Size = new System.Drawing.Size(188, 37);
            this.cmbKH2.TabIndex = 7;
            // 
            // txtMaHD2
            // 
            this.txtMaHD2.Location = new System.Drawing.Point(167, 24);
            this.txtMaHD2.Name = "txtMaHD2";
            this.txtMaHD2.Size = new System.Drawing.Size(188, 35);
            this.txtMaHD2.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(624, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 29);
            this.label12.TabIndex = 5;
            this.label12.Text = "Ngày lập";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(623, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 29);
            this.label11.TabIndex = 4;
            this.label11.Text = "Số lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(623, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 29);
            this.label10.TabIndex = 3;
            this.label10.Text = "Đơn giá";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "Sản phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "Khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã hóa đơn";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.txtSearch);
            this.tabPage3.Controls.Add(this.dgHD3);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1094, 565);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tìm kiếm";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(625, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(385, 93);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 35);
            this.txtSearch.TabIndex = 2;
            // 
            // dgHD3
            // 
            this.dgHD3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHD3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgHD3.Location = new System.Drawing.Point(3, 180);
            this.dgHD3.Name = "dgHD3";
            this.dgHD3.RowTemplate.Height = 28;
            this.dgHD3.Size = new System.Drawing.Size(1088, 382);
            this.dgHD3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFilter);
            this.groupBox1.Location = new System.Drawing.Point(30, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo:";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Tên sản phẩm",
            "Tên khách hàng",
            "Mã Hóa Đơn",
            "Tổng tiền"});
            this.cmbFilter.Location = new System.Drawing.Point(45, 61);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 37);
            this.cmbFilter.TabIndex = 0;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Location = new System.Drawing.Point(32, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "< Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 610);
            this.Controls.Add(this.tabControl1);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHD)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHD2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHD3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgHD;
        private System.Windows.Forms.DateTimePicker dpNL1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDG1;
        private System.Windows.Forms.TextBox txtSL1;
        private System.Windows.Forms.ComboBox cmbSP1;
        private System.Windows.Forms.ComboBox cmbKH1;
        private System.Windows.Forms.TextBox txtMaHD1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgHD2;
        private System.Windows.Forms.DateTimePicker dpNL2;
        private System.Windows.Forms.TextBox txtSL2;
        private System.Windows.Forms.TextBox txtDG2;
        private System.Windows.Forms.ComboBox cmbSP2;
        private System.Windows.Forms.ComboBox cmbKH2;
        private System.Windows.Forms.TextBox txtMaHD2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgHD3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button2;
    }
}