namespace QUANLYBANHANG
{
    partial class QuanLySanPham
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
            this.label17 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cmbNhaCC = new System.Windows.Forms.ComboBox();
            this.cmbDanhMuc = new System.Windows.Forms.ComboBox();
            this.dpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgSearchSP = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.dgSP = new System.Windows.Forms.DataGridView();
            this.maSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmbNCC = new System.Windows.Forms.ComboBox();
            this.cmbDM = new System.Windows.Forms.ComboBox();
            this.dpNN = new System.Windows.Forms.DateTimePicker();
            this.txtSLT = new System.Windows.Forms.TextBox();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgSanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSP)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 281);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 32);
            this.label17.TabIndex = 2;
            this.label17.Text = "Danh mục";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(565, 269);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 46);
            this.btnXoa.TabIndex = 47;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Info;
            this.btnSua.Location = new System.Drawing.Point(565, 194);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 46);
            this.btnSua.TabIndex = 46;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // cmbNhaCC
            // 
            this.cmbNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhaCC.FormattingEnabled = true;
            this.cmbNhaCC.Location = new System.Drawing.Point(264, 323);
            this.cmbNhaCC.Name = "cmbNhaCC";
            this.cmbNhaCC.Size = new System.Drawing.Size(189, 34);
            this.cmbNhaCC.TabIndex = 45;
            // 
            // cmbDanhMuc
            // 
            this.cmbDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDanhMuc.FormattingEnabled = true;
            this.cmbDanhMuc.Location = new System.Drawing.Point(264, 269);
            this.cmbDanhMuc.Name = "cmbDanhMuc";
            this.cmbDanhMuc.Size = new System.Drawing.Size(189, 34);
            this.cmbDanhMuc.TabIndex = 44;
            // 
            // dpNgayNhap
            // 
            this.dpNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpNgayNhap.Location = new System.Drawing.Point(264, 224);
            this.dpNgayNhap.Name = "dpNgayNhap";
            this.dpNgayNhap.Size = new System.Drawing.Size(200, 32);
            this.dpNgayNhap.TabIndex = 43;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTon.Location = new System.Drawing.Point(264, 173);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(189, 32);
            this.txtSoLuongTon.TabIndex = 42;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(264, 128);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(189, 32);
            this.txtDonGia.TabIndex = 41;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(264, 80);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(189, 32);
            this.txtTenSP.TabIndex = 40;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(264, 22);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(189, 32);
            this.txtMaSP.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nhà cung cấp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 26);
            this.label9.TabIndex = 37;
            this.label9.Text = "Danh mục";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 26);
            this.label10.TabIndex = 36;
            this.label10.Text = "Ngày nhập";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(46, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 26);
            this.label11.TabIndex = 35;
            this.label11.Text = "Số Lượng Tồn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(46, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 26);
            this.label13.TabIndex = 33;
            this.label13.Text = "Tên SP";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(46, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 26);
            this.label14.TabIndex = 32;
            this.label14.Text = "Mã SP";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgSearchSP);
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Controls.Add(this.txtSearch);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.cmbSearch);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Location = new System.Drawing.Point(4, 41);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1360, 641);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tìm kiếm";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgSearchSP
            // 
            this.dgSearchSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearchSP.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgSearchSP.Location = new System.Drawing.Point(450, 3);
            this.dgSearchSP.Name = "dgSearchSP";
            this.dgSearchSP.RowTemplate.Height = 28;
            this.dgSearchSP.Size = new System.Drawing.Size(907, 635);
            this.dgSearchSP.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(144, 447);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(169, 69);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(218, 354);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 39);
            this.txtSearch.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 361);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 32);
            this.label19.TabIndex = 7;
            this.label19.Text = "Từ khóa";
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(218, 281);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(193, 40);
            this.cmbSearch.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtFrom);
            this.groupBox1.Controls.Add(this.txtTo);
            this.groupBox1.Location = new System.Drawing.Point(26, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 165);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giá";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(239, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 32);
            this.label18.TabIndex = 6;
            this.label18.Text = "To";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 32);
            this.label16.TabIndex = 5;
            this.label16.Text = "From";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(93, 56);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 39);
            this.txtFrom.TabIndex = 3;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(303, 56);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 39);
            this.txtTo.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 32);
            this.label15.TabIndex = 0;
            this.label15.Text = "Tìm kiếm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(46, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 26);
            this.label12.TabIndex = 34;
            this.label12.Text = "Đơn giá";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1368, 686);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.dgSP);
            this.tabPage.Controls.Add(this.btnThem);
            this.tabPage.Controls.Add(this.cmbNCC);
            this.tabPage.Controls.Add(this.cmbDM);
            this.tabPage.Controls.Add(this.dpNN);
            this.tabPage.Controls.Add(this.txtSLT);
            this.tabPage.Controls.Add(this.txtDG);
            this.tabPage.Controls.Add(this.txtTen);
            this.tabPage.Controls.Add(this.txtMa);
            this.tabPage.Controls.Add(this.label8);
            this.tabPage.Controls.Add(this.label7);
            this.tabPage.Controls.Add(this.label6);
            this.tabPage.Controls.Add(this.label5);
            this.tabPage.Controls.Add(this.label4);
            this.tabPage.Controls.Add(this.label3);
            this.tabPage.Controls.Add(this.label2);
            this.tabPage.Location = new System.Drawing.Point(4, 41);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(1360, 641);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Thêm sản phẩm";
            this.tabPage.UseVisualStyleBackColor = true;
            this.tabPage.Click += new System.EventHandler(this.TabPage_Click);
            // 
            // dgSP
            // 
            this.dgSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSP,
            this.tenSP,
            this.donGia,
            this.soLuongTon,
            this.ngayNhap,
            this.tenDM,
            this.tenNCC});
            this.dgSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgSP.Location = new System.Drawing.Point(3, 368);
            this.dgSP.Name = "dgSP";
            this.dgSP.RowTemplate.Height = 28;
            this.dgSP.Size = new System.Drawing.Size(1354, 270);
            this.dgSP.TabIndex = 32;
            // 
            // maSP
            // 
            this.maSP.DataPropertyName = "maSP";
            this.maSP.HeaderText = "Mã SP";
            this.maSP.Name = "maSP";
            // 
            // tenSP
            // 
            this.tenSP.DataPropertyName = "tenSP";
            this.tenSP.HeaderText = "Tên SP";
            this.tenSP.Name = "tenSP";
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.Name = "donGia";
            // 
            // soLuongTon
            // 
            this.soLuongTon.DataPropertyName = "soLuongTon";
            this.soLuongTon.HeaderText = "Tồn";
            this.soLuongTon.Name = "soLuongTon";
            // 
            // ngayNhap
            // 
            this.ngayNhap.DataPropertyName = "ngayNhap";
            this.ngayNhap.HeaderText = "Ngày nhập";
            this.ngayNhap.Name = "ngayNhap";
            // 
            // tenDM
            // 
            this.tenDM.DataPropertyName = "tenDM";
            this.tenDM.HeaderText = "Danh Mục";
            this.tenDM.Name = "tenDM";
            this.tenDM.Width = 150;
            // 
            // tenNCC
            // 
            this.tenNCC.DataPropertyName = "tenNCC";
            this.tenNCC.HeaderText = "Nhà cung cấp";
            this.tenNCC.Name = "tenNCC";
            this.tenNCC.Width = 150;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Info;
            this.btnThem.Location = new System.Drawing.Point(575, 199);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 46);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // cmbNCC
            // 
            this.cmbNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNCC.FormattingEnabled = true;
            this.cmbNCC.Location = new System.Drawing.Point(274, 328);
            this.cmbNCC.Name = "cmbNCC";
            this.cmbNCC.Size = new System.Drawing.Size(189, 34);
            this.cmbNCC.TabIndex = 29;
            // 
            // cmbDM
            // 
            this.cmbDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDM.FormattingEnabled = true;
            this.cmbDM.Location = new System.Drawing.Point(274, 274);
            this.cmbDM.Name = "cmbDM";
            this.cmbDM.Size = new System.Drawing.Size(189, 34);
            this.cmbDM.TabIndex = 28;
            // 
            // dpNN
            // 
            this.dpNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpNN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpNN.Location = new System.Drawing.Point(274, 229);
            this.dpNN.Name = "dpNN";
            this.dpNN.Size = new System.Drawing.Size(200, 32);
            this.dpNN.TabIndex = 27;
            // 
            // txtSLT
            // 
            this.txtSLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLT.Location = new System.Drawing.Point(274, 178);
            this.txtSLT.Name = "txtSLT";
            this.txtSLT.Size = new System.Drawing.Size(189, 32);
            this.txtSLT.TabIndex = 26;
            // 
            // txtDG
            // 
            this.txtDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDG.Location = new System.Drawing.Point(274, 133);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(189, 32);
            this.txtDG.TabIndex = 25;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(274, 85);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(189, 32);
            this.txtTen.TabIndex = 24;
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(274, 41);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(189, 32);
            this.txtMa.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 26);
            this.label8.TabIndex = 22;
            this.label8.Text = "Nhà cung cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 26);
            this.label7.TabIndex = 21;
            this.label7.Text = "Danh mục";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ngày nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Số Lượng Tồn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã SP";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgSanPham);
            this.tabPage2.Controls.Add(this.btnXoa);
            this.tabPage2.Controls.Add(this.btnSua);
            this.tabPage2.Controls.Add(this.cmbNhaCC);
            this.tabPage2.Controls.Add(this.cmbDanhMuc);
            this.tabPage2.Controls.Add(this.dpNgayNhap);
            this.tabPage2.Controls.Add(this.txtSoLuongTon);
            this.tabPage2.Controls.Add(this.txtDonGia);
            this.tabPage2.Controls.Add(this.txtTenSP);
            this.tabPage2.Controls.Add(this.txtMaSP);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1360, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sửa, Xóa sản phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgSanPham
            // 
            this.dgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgSanPham.Location = new System.Drawing.Point(3, 382);
            this.dgSanPham.Name = "dgSanPham";
            this.dgSanPham.RowTemplate.Height = 28;
            this.dgSanPham.Size = new System.Drawing.Size(1354, 256);
            this.dgSanPham.TabIndex = 48;
            this.dgSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgSanPham_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maSP";
            this.Column1.HeaderText = "Mã SP";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenSP";
            this.Column2.HeaderText = "Tên SP";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "donGia";
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "soLuongTon";
            this.Column4.HeaderText = "Tồn";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ngayNhap";
            this.Column5.HeaderText = "Ngày nhập";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tenDM";
            this.Column6.HeaderText = "Danh mục";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "tenNCC";
            this.Column7.HeaderText = "Nhà cung cấp";
            this.Column7.Name = "Column7";
            this.Column7.Width = 170;
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 633);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "QuanLySanPham";
            this.Text = "QuanLySanPham";
            this.Load += new System.EventHandler(this.QuanLySanPham_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSP)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cmbNhaCC;
        private System.Windows.Forms.ComboBox cmbDanhMuc;
        private System.Windows.Forms.DateTimePicker dpNgayNhap;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgSearchSP;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.DataGridView dgSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmbNCC;
        private System.Windows.Forms.ComboBox cmbDM;
        private System.Windows.Forms.DateTimePicker dpNN;
        private System.Windows.Forms.TextBox txtSLT;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}