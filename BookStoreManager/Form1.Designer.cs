namespace UngDungBanSach
{
    partial class Form1
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPhieuNhapChiTiet = new System.Windows.Forms.Button();
            this.datePhieuNhap = new System.Windows.Forms.DateTimePicker();
            this.txtPhieuNhapTenNhaCungCap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhieuNhapNhaCungCap = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPhieuNhapSua = new System.Windows.Forms.Button();
            this.btnPhieuNhapXoa = new System.Windows.Forms.Button();
            this.btnPhieuNhapAdd = new System.Windows.Forms.Button();
            this.dgPhieuNhap = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoaiSachSearch = new System.Windows.Forms.TextBox();
            this.btnLoaiSachHuyTim = new System.Windows.Forms.Button();
            this.btnLoaiSachTimKiem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLoaiSachTenLoaiSach = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLoaiSachSua = new System.Windows.Forms.Button();
            this.btnLoaiSachXoa = new System.Windows.Forms.Button();
            this.btnLoaiSachThem = new System.Windows.Forms.Button();
            this.dgLoaiSach = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSachTacGia = new System.Windows.Forms.TextBox();
            this.txtSachTenSach = new System.Windows.Forms.TextBox();
            this.cbSachLoaiSach = new System.Windows.Forms.ComboBox();
            this.txtSachGiaBan = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSachSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSachSua = new System.Windows.Forms.Button();
            this.btnSachXoa = new System.Windows.Forms.Button();
            this.btnSachAdd = new System.Windows.Forms.Button();
            this.dgSach = new System.Windows.Forms.DataGridView();
            this.dtHoaDon = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieuNhap)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoaiSach)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSachGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSachSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).BeginInit();
            this.dtHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.dgPhieuNhap);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1478, 790);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Phiếu nhập";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPhieuNhapChiTiet);
            this.panel4.Controls.Add(this.datePhieuNhap);
            this.panel4.Controls.Add(this.txtPhieuNhapTenNhaCungCap);
            this.panel4.Controls.Add(this.txtPhieuNhapNhaCungCap);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.btnPhieuNhapSua);
            this.panel4.Controls.Add(this.btnPhieuNhapXoa);
            this.panel4.Controls.Add(this.btnPhieuNhapAdd);
            this.panel4.Location = new System.Drawing.Point(16, 620);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1442, 144);
            this.panel4.TabIndex = 3;
            // 
            // btnPhieuNhapChiTiet
            // 
            this.btnPhieuNhapChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuNhapChiTiet.Location = new System.Drawing.Point(748, 81);
            this.btnPhieuNhapChiTiet.Name = "btnPhieuNhapChiTiet";
            this.btnPhieuNhapChiTiet.Size = new System.Drawing.Size(149, 35);
            this.btnPhieuNhapChiTiet.TabIndex = 16;
            this.btnPhieuNhapChiTiet.Text = "Chi tiết";
            this.btnPhieuNhapChiTiet.UseVisualStyleBackColor = true;
            this.btnPhieuNhapChiTiet.Click += new System.EventHandler(this.btnPhieuNhapChiTiet_Click);
            // 
            // datePhieuNhap
            // 
            this.datePhieuNhap.Location = new System.Drawing.Point(239, 13);
            this.datePhieuNhap.Name = "datePhieuNhap";
            this.datePhieuNhap.Size = new System.Drawing.Size(401, 35);
            this.datePhieuNhap.TabIndex = 15;
            // 
            // txtPhieuNhapTenNhaCungCap
            // 
            this.txtPhieuNhapTenNhaCungCap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhieuNhapTenNhaCungCap.DefaultText = "";
            this.txtPhieuNhapTenNhaCungCap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhieuNhapTenNhaCungCap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhieuNhapTenNhaCungCap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhieuNhapTenNhaCungCap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhieuNhapTenNhaCungCap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhieuNhapTenNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhieuNhapTenNhaCungCap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhieuNhapTenNhaCungCap.Location = new System.Drawing.Point(958, 10);
            this.txtPhieuNhapTenNhaCungCap.Name = "txtPhieuNhapTenNhaCungCap";
            this.txtPhieuNhapTenNhaCungCap.PasswordChar = '\0';
            this.txtPhieuNhapTenNhaCungCap.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhieuNhapTenNhaCungCap.PlaceholderText = "";
            this.txtPhieuNhapTenNhaCungCap.SelectedText = "";
            this.txtPhieuNhapTenNhaCungCap.Size = new System.Drawing.Size(228, 36);
            this.txtPhieuNhapTenNhaCungCap.TabIndex = 8;
            // 
            // txtPhieuNhapNhaCungCap
            // 
            this.txtPhieuNhapNhaCungCap.AutoSize = true;
            this.txtPhieuNhapNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhieuNhapNhaCungCap.Location = new System.Drawing.Point(743, 21);
            this.txtPhieuNhapNhaCungCap.Name = "txtPhieuNhapNhaCungCap";
            this.txtPhieuNhapNhaCungCap.Size = new System.Drawing.Size(170, 25);
            this.txtPhieuNhapNhaCungCap.TabIndex = 7;
            this.txtPhieuNhapNhaCungCap.Text = "Tên nhà cung cấp";
            this.txtPhieuNhapNhaCungCap.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Ngày Lập phiếu nhập";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnPhieuNhapSua
            // 
            this.btnPhieuNhapSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuNhapSua.Location = new System.Drawing.Point(385, 81);
            this.btnPhieuNhapSua.Name = "btnPhieuNhapSua";
            this.btnPhieuNhapSua.Size = new System.Drawing.Size(155, 35);
            this.btnPhieuNhapSua.TabIndex = 2;
            this.btnPhieuNhapSua.Text = "Sửa";
            this.btnPhieuNhapSua.UseVisualStyleBackColor = true;
            this.btnPhieuNhapSua.Click += new System.EventHandler(this.btnPhieuNhapSua_Click);
            // 
            // btnPhieuNhapXoa
            // 
            this.btnPhieuNhapXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuNhapXoa.Location = new System.Drawing.Point(569, 81);
            this.btnPhieuNhapXoa.Name = "btnPhieuNhapXoa";
            this.btnPhieuNhapXoa.Size = new System.Drawing.Size(149, 35);
            this.btnPhieuNhapXoa.TabIndex = 1;
            this.btnPhieuNhapXoa.Text = "Xóa";
            this.btnPhieuNhapXoa.UseVisualStyleBackColor = true;
            this.btnPhieuNhapXoa.Click += new System.EventHandler(this.btnPhieuNhapXoa_Click);
            // 
            // btnPhieuNhapAdd
            // 
            this.btnPhieuNhapAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuNhapAdd.Location = new System.Drawing.Point(181, 81);
            this.btnPhieuNhapAdd.Name = "btnPhieuNhapAdd";
            this.btnPhieuNhapAdd.Size = new System.Drawing.Size(150, 35);
            this.btnPhieuNhapAdd.TabIndex = 0;
            this.btnPhieuNhapAdd.Text = "Thêm";
            this.btnPhieuNhapAdd.UseVisualStyleBackColor = true;
            this.btnPhieuNhapAdd.Click += new System.EventHandler(this.btnPhieuNhapAdd_Click);
            // 
            // dgPhieuNhap
            // 
            this.dgPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhieuNhap.Location = new System.Drawing.Point(16, 16);
            this.dgPhieuNhap.Name = "dgPhieuNhap";
            this.dgPhieuNhap.RowHeadersWidth = 62;
            this.dgPhieuNhap.RowTemplate.Height = 28;
            this.dgPhieuNhap.Size = new System.Drawing.Size(1442, 588);
            this.dgPhieuNhap.TabIndex = 2;
            this.dgPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhieuNhap_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dgLoaiSach);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1478, 790);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loại sách";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtLoaiSachSearch);
            this.panel3.Controls.Add(this.btnLoaiSachHuyTim);
            this.panel3.Controls.Add(this.btnLoaiSachTimKiem);
            this.panel3.Location = new System.Drawing.Point(667, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 281);
            this.panel3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tìm Loại Sách:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLoaiSachSearch
            // 
            this.txtLoaiSachSearch.Location = new System.Drawing.Point(257, 44);
            this.txtLoaiSachSearch.Name = "txtLoaiSachSearch";
            this.txtLoaiSachSearch.Size = new System.Drawing.Size(369, 35);
            this.txtLoaiSachSearch.TabIndex = 7;
            // 
            // btnLoaiSachHuyTim
            // 
            this.btnLoaiSachHuyTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiSachHuyTim.Location = new System.Drawing.Point(407, 125);
            this.btnLoaiSachHuyTim.Name = "btnLoaiSachHuyTim";
            this.btnLoaiSachHuyTim.Size = new System.Drawing.Size(155, 35);
            this.btnLoaiSachHuyTim.TabIndex = 2;
            this.btnLoaiSachHuyTim.Text = "Cancel";
            this.btnLoaiSachHuyTim.UseVisualStyleBackColor = true;
            this.btnLoaiSachHuyTim.Click += new System.EventHandler(this.btnLoaiSachHuyTim_Click);
            // 
            // btnLoaiSachTimKiem
            // 
            this.btnLoaiSachTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiSachTimKiem.Location = new System.Drawing.Point(232, 125);
            this.btnLoaiSachTimKiem.Name = "btnLoaiSachTimKiem";
            this.btnLoaiSachTimKiem.Size = new System.Drawing.Size(150, 35);
            this.btnLoaiSachTimKiem.TabIndex = 0;
            this.btnLoaiSachTimKiem.Text = "Search ";
            this.btnLoaiSachTimKiem.UseVisualStyleBackColor = true;
            this.btnLoaiSachTimKiem.Click += new System.EventHandler(this.btnLoaiSachTimKiem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtLoaiSachTenLoaiSach);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnLoaiSachSua);
            this.panel2.Controls.Add(this.btnLoaiSachXoa);
            this.panel2.Controls.Add(this.btnLoaiSachThem);
            this.panel2.Location = new System.Drawing.Point(667, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 148);
            this.panel2.TabIndex = 2;
            // 
            // txtLoaiSachTenLoaiSach
            // 
            this.txtLoaiSachTenLoaiSach.Location = new System.Drawing.Point(338, 14);
            this.txtLoaiSachTenLoaiSach.Name = "txtLoaiSachTenLoaiSach";
            this.txtLoaiSachTenLoaiSach.Size = new System.Drawing.Size(369, 35);
            this.txtLoaiSachTenLoaiSach.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(129, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tên Loại Sách";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLoaiSachSua
            // 
            this.btnLoaiSachSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiSachSua.Location = new System.Drawing.Point(338, 77);
            this.btnLoaiSachSua.Name = "btnLoaiSachSua";
            this.btnLoaiSachSua.Size = new System.Drawing.Size(155, 35);
            this.btnLoaiSachSua.TabIndex = 2;
            this.btnLoaiSachSua.Text = "Sửa";
            this.btnLoaiSachSua.UseVisualStyleBackColor = true;
            this.btnLoaiSachSua.Click += new System.EventHandler(this.btnLoaiSachSua_Click);
            // 
            // btnLoaiSachXoa
            // 
            this.btnLoaiSachXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiSachXoa.Location = new System.Drawing.Point(522, 77);
            this.btnLoaiSachXoa.Name = "btnLoaiSachXoa";
            this.btnLoaiSachXoa.Size = new System.Drawing.Size(149, 35);
            this.btnLoaiSachXoa.TabIndex = 1;
            this.btnLoaiSachXoa.Text = "Xóa";
            this.btnLoaiSachXoa.UseVisualStyleBackColor = true;
            this.btnLoaiSachXoa.Click += new System.EventHandler(this.btnLoaiSachXoa_Click);
            // 
            // btnLoaiSachThem
            // 
            this.btnLoaiSachThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiSachThem.Location = new System.Drawing.Point(134, 77);
            this.btnLoaiSachThem.Name = "btnLoaiSachThem";
            this.btnLoaiSachThem.Size = new System.Drawing.Size(150, 35);
            this.btnLoaiSachThem.TabIndex = 0;
            this.btnLoaiSachThem.Text = "Thêm";
            this.btnLoaiSachThem.UseVisualStyleBackColor = true;
            this.btnLoaiSachThem.Click += new System.EventHandler(this.btnLoaiSachThem_Click);
            // 
            // dgLoaiSach
            // 
            this.dgLoaiSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoaiSach.Location = new System.Drawing.Point(19, 6);
            this.dgLoaiSach.Name = "dgLoaiSach";
            this.dgLoaiSach.RowHeadersWidth = 62;
            this.dgLoaiSach.RowTemplate.Height = 28;
            this.dgLoaiSach.Size = new System.Drawing.Size(625, 758);
            this.dgLoaiSach.TabIndex = 1;
            this.dgLoaiSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLoaiSach_CellClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgSach);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1478, 790);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sách";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSachTacGia);
            this.panel1.Controls.Add(this.txtSachTenSach);
            this.panel1.Controls.Add(this.cbSachLoaiSach);
            this.panel1.Controls.Add(this.txtSachGiaBan);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSachSoLuong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSachSua);
            this.panel1.Controls.Add(this.btnSachXoa);
            this.panel1.Controls.Add(this.btnSachAdd);
            this.panel1.Location = new System.Drawing.Point(19, 594);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1442, 200);
            this.panel1.TabIndex = 1;
            // 
            // txtSachTacGia
            // 
            this.txtSachTacGia.Location = new System.Drawing.Point(152, 77);
            this.txtSachTacGia.Name = "txtSachTacGia";
            this.txtSachTacGia.Size = new System.Drawing.Size(210, 30);
            this.txtSachTacGia.TabIndex = 17;
            // 
            // txtSachTenSach
            // 
            this.txtSachTenSach.Location = new System.Drawing.Point(152, 24);
            this.txtSachTenSach.Name = "txtSachTenSach";
            this.txtSachTenSach.Size = new System.Drawing.Size(348, 30);
            this.txtSachTenSach.TabIndex = 16;
//            this.txtSachTenSach.TextChanged += new System.EventHandler(this.txtSachTenSach_TextChanged);
            // 
            // cbSachLoaiSach
            // 
            this.cbSachLoaiSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSachLoaiSach.FormattingEnabled = true;
            this.cbSachLoaiSach.Location = new System.Drawing.Point(750, 17);
            this.cbSachLoaiSach.Name = "cbSachLoaiSach";
            this.cbSachLoaiSach.Size = new System.Drawing.Size(385, 33);
            this.cbSachLoaiSach.TabIndex = 15;
            this.cbSachLoaiSach.SelectedIndexChanged += new System.EventHandler(this.cbSachLoaiSach_SelectedIndexChanged);
            // 
            // txtSachGiaBan
            // 
            this.txtSachGiaBan.BackColor = System.Drawing.Color.Transparent;
            this.txtSachGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSachGiaBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSachGiaBan.Location = new System.Drawing.Point(864, 77);
            this.txtSachGiaBan.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtSachGiaBan.Name = "txtSachGiaBan";
            this.txtSachGiaBan.Size = new System.Drawing.Size(271, 36);
            this.txtSachGiaBan.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(751, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Giá bán";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSachSoLuong
            // 
            this.txtSachSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.txtSachSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSachSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSachSoLuong.Location = new System.Drawing.Point(617, 77);
            this.txtSachSoLuong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtSachSoLuong.Name = "txtSachSoLuong";
            this.txtSachSoLuong.Size = new System.Drawing.Size(84, 36);
            this.txtSachSoLuong.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số Lượng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(624, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Loại sách";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tác giả";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSachSua
            // 
            this.btnSachSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSachSua.Location = new System.Drawing.Point(337, 141);
            this.btnSachSua.Name = "btnSachSua";
            this.btnSachSua.Size = new System.Drawing.Size(155, 35);
            this.btnSachSua.TabIndex = 2;
            this.btnSachSua.Text = "Sửa";
            this.btnSachSua.UseVisualStyleBackColor = true;
            this.btnSachSua.Click += new System.EventHandler(this.btnSachSua_Click);
            // 
            // btnSachXoa
            // 
            this.btnSachXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSachXoa.Location = new System.Drawing.Point(521, 141);
            this.btnSachXoa.Name = "btnSachXoa";
            this.btnSachXoa.Size = new System.Drawing.Size(149, 35);
            this.btnSachXoa.TabIndex = 1;
            this.btnSachXoa.Text = "Xóa";
            this.btnSachXoa.UseVisualStyleBackColor = true;
            this.btnSachXoa.Click += new System.EventHandler(this.btnSachXoa_Click);
            // 
            // btnSachAdd
            // 
            this.btnSachAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSachAdd.Location = new System.Drawing.Point(133, 141);
            this.btnSachAdd.Name = "btnSachAdd";
            this.btnSachAdd.Size = new System.Drawing.Size(150, 35);
            this.btnSachAdd.TabIndex = 0;
            this.btnSachAdd.Text = "Thêm";
            this.btnSachAdd.UseVisualStyleBackColor = true;
            this.btnSachAdd.Click += new System.EventHandler(this.btnSachAdd_Click);
            // 
            // dgSach
            // 
            this.dgSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSach.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgSach.Location = new System.Drawing.Point(19, 19);
            this.dgSach.Name = "dgSach";
            this.dgSach.RowHeadersWidth = 62;
            this.dgSach.RowTemplate.Height = 28;
            this.dgSach.Size = new System.Drawing.Size(1442, 542);
            this.dgSach.TabIndex = 0;
            this.dgSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSach_CellClick);
            // 
            // dtHoaDon
            // 
            this.dtHoaDon.Controls.Add(this.tabPage1);
            this.dtHoaDon.Controls.Add(this.tabPage2);
            this.dtHoaDon.Controls.Add(this.tabPage4);
            this.dtHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHoaDon.Location = new System.Drawing.Point(12, 12);
            this.dtHoaDon.Name = "dtHoaDon";
            this.dtHoaDon.SelectedIndex = 0;
            this.dtHoaDon.Size = new System.Drawing.Size(1486, 832);
            this.dtHoaDon.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 842);
            this.Controls.Add(this.dtHoaDon);
            this.Name = "Form1";
            this.Text = "Quản Lý Bán Sách";
            this.tabPage4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieuNhap)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoaiSach)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSachGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSachSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).EndInit();
            this.dtHoaDon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLoaiSachSua;
        private System.Windows.Forms.Button btnLoaiSachXoa;
        private System.Windows.Forms.Button btnLoaiSachThem;
        private System.Windows.Forms.DataGridView dgLoaiSach;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtSachGiaBan;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtSachSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSachSua;
        private System.Windows.Forms.Button btnSachXoa;
        private System.Windows.Forms.Button btnSachAdd;
        private System.Windows.Forms.DataGridView dgSach;
        private System.Windows.Forms.TabControl dtHoaDon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker datePhieuNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtPhieuNhapTenNhaCungCap;
        private System.Windows.Forms.Label txtPhieuNhapNhaCungCap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPhieuNhapSua;
        private System.Windows.Forms.Button btnPhieuNhapXoa;
        private System.Windows.Forms.Button btnPhieuNhapAdd;
        private System.Windows.Forms.DataGridView dgPhieuNhap;
        private System.Windows.Forms.ComboBox cbSachLoaiSach;
        private System.Windows.Forms.TextBox txtSachTacGia;
        private System.Windows.Forms.TextBox txtSachTenSach;
        private System.Windows.Forms.TextBox txtLoaiSachTenLoaiSach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLoaiSachSearch;
        private System.Windows.Forms.Button btnLoaiSachHuyTim;
        private System.Windows.Forms.Button btnLoaiSachTimKiem;
        private System.Windows.Forms.Button btnPhieuNhapChiTiet;
    }
}

