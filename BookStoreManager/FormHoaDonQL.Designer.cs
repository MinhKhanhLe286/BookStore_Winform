namespace UngDungBanSach
{
    partial class FormHoaDonQL
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
            this.dataHoaDn = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnHoaDnHuy = new System.Windows.Forms.Button();
            this.btnHoaDonTim = new System.Windows.Forms.Button();
            this.txtHoaDonNhapTen = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnHoaDonSua = new System.Windows.Forms.Button();
            this.btnHoaDonXoa = new System.Windows.Forms.Button();
            this.btnHoaDonThem = new System.Windows.Forms.Button();
            this.txtHoaSonSDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateHoaDonNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtHoaDpnTenKhachHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDn)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataHoaDn
            // 
            this.dataHoaDn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHoaDn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoaDn.Location = new System.Drawing.Point(12, 12);
            this.dataHoaDn.Name = "dataHoaDn";
            this.dataHoaDn.RowHeadersWidth = 62;
            this.dataHoaDn.RowTemplate.Height = 28;
            this.dataHoaDn.Size = new System.Drawing.Size(742, 774);
            this.dataHoaDn.TabIndex = 4;
            this.dataHoaDn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHoaDn_CellClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.btnHoaDnHuy);
            this.panel5.Controls.Add(this.btnHoaDonTim);
            this.panel5.Controls.Add(this.txtHoaDonNhapTen);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.btnHoaDonSua);
            this.panel5.Controls.Add(this.btnHoaDonXoa);
            this.panel5.Controls.Add(this.btnHoaDonThem);
            this.panel5.Controls.Add(this.txtHoaSonSDT);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.dateHoaDonNgayLap);
            this.panel5.Controls.Add(this.txtHoaDpnTenKhachHang);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(760, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(672, 774);
            this.panel5.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(36, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(269, 32);
            this.label14.TabIndex = 28;
            this.label14.Text = "Thông tin hóa đơn:";
            // 
            // btnHoaDnHuy
            // 
            this.btnHoaDnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDnHuy.Location = new System.Drawing.Point(411, 175);
            this.btnHoaDnHuy.Name = "btnHoaDnHuy";
            this.btnHoaDnHuy.Size = new System.Drawing.Size(159, 45);
            this.btnHoaDnHuy.TabIndex = 27;
            this.btnHoaDnHuy.Text = "Hủy bỏ";
            this.btnHoaDnHuy.UseVisualStyleBackColor = true;
            this.btnHoaDnHuy.Click += new System.EventHandler(this.btnHoaDnHuy_Click);
            // 
            // btnHoaDonTim
            // 
            this.btnHoaDonTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonTim.Location = new System.Drawing.Point(207, 175);
            this.btnHoaDonTim.Name = "btnHoaDonTim";
            this.btnHoaDonTim.Size = new System.Drawing.Size(164, 45);
            this.btnHoaDonTim.TabIndex = 26;
            this.btnHoaDonTim.Text = "Tìm kiếm";
            this.btnHoaDonTim.UseVisualStyleBackColor = true;
            this.btnHoaDonTim.Click += new System.EventHandler(this.btnHoaDonTim_Click);
            // 
            // txtHoaDonNhapTen
            // 
            this.txtHoaDonNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoaDonNhapTen.Location = new System.Drawing.Point(308, 99);
            this.txtHoaDonNhapTen.Name = "txtHoaDonNhapTen";
            this.txtHoaDonNhapTen.Size = new System.Drawing.Size(358, 30);
            this.txtHoaDonNhapTen.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(48, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Nhập tên khách hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(254, 32);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tìm kiếm hóa đơn";
            // 
            // btnHoaDonSua
            // 
            this.btnHoaDonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonSua.Location = new System.Drawing.Point(279, 576);
            this.btnHoaDonSua.Name = "btnHoaDonSua";
            this.btnHoaDonSua.Size = new System.Drawing.Size(160, 49);
            this.btnHoaDonSua.TabIndex = 22;
            this.btnHoaDonSua.Text = "Sửa";
            this.btnHoaDonSua.UseVisualStyleBackColor = true;
            this.btnHoaDonSua.Click += new System.EventHandler(this.btnHoaDonSua_Click);
            // 
            // btnHoaDonXoa
            // 
            this.btnHoaDonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonXoa.Location = new System.Drawing.Point(472, 576);
            this.btnHoaDonXoa.Name = "btnHoaDonXoa";
            this.btnHoaDonXoa.Size = new System.Drawing.Size(146, 49);
            this.btnHoaDonXoa.TabIndex = 21;
            this.btnHoaDonXoa.Text = "Xóa";
            this.btnHoaDonXoa.UseVisualStyleBackColor = true;
            this.btnHoaDonXoa.Click += new System.EventHandler(this.btnHoaDonXoa_Click);
            // 
            // btnHoaDonThem
            // 
            this.btnHoaDonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonThem.Location = new System.Drawing.Point(84, 576);
            this.btnHoaDonThem.Name = "btnHoaDonThem";
            this.btnHoaDonThem.Size = new System.Drawing.Size(152, 49);
            this.btnHoaDonThem.TabIndex = 20;
            this.btnHoaDonThem.Text = "Thêm";
            this.btnHoaDonThem.UseVisualStyleBackColor = true;
            this.btnHoaDonThem.Click += new System.EventHandler(this.btnHoaDonThem_Click);
            // 
            // txtHoaSonSDT
            // 
            this.txtHoaSonSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoaSonSDT.Location = new System.Drawing.Point(389, 485);
            this.txtHoaSonSDT.Name = "txtHoaSonSDT";
            this.txtHoaSonSDT.Size = new System.Drawing.Size(277, 30);
            this.txtHoaSonSDT.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 485);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Số điện thoại khách hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tên Khách Hàng";
            // 
            // dateHoaDonNgayLap
            // 
            this.dateHoaDonNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateHoaDonNgayLap.Location = new System.Drawing.Point(265, 343);
            this.dateHoaDonNgayLap.Name = "dateHoaDonNgayLap";
            this.dateHoaDonNgayLap.Size = new System.Drawing.Size(401, 30);
            this.dateHoaDonNgayLap.TabIndex = 16;
            // 
            // txtHoaDpnTenKhachHang
            // 
            this.txtHoaDpnTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoaDpnTenKhachHang.Location = new System.Drawing.Point(265, 419);
            this.txtHoaDpnTenKhachHang.Name = "txtHoaDpnTenKhachHang";
            this.txtHoaDpnTenKhachHang.Size = new System.Drawing.Size(401, 30);
            this.txtHoaDpnTenKhachHang.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày lập hóa đơn:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(472, 675);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 49);
            this.button1.TabIndex = 29;
            this.button1.Text = "Chi Tiết";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormHoaDonQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 821);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dataHoaDn);
            this.Name = "FormHoaDonQL";
            this.Text = "FormHoaDonQL";
            this.Load += new System.EventHandler(this.FormHoaDonQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDn)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataHoaDn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnHoaDnHuy;
        private System.Windows.Forms.Button btnHoaDonTim;
        private System.Windows.Forms.TextBox txtHoaDonNhapTen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnHoaDonSua;
        private System.Windows.Forms.Button btnHoaDonXoa;
        private System.Windows.Forms.Button btnHoaDonThem;
        private System.Windows.Forms.TextBox txtHoaSonSDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateHoaDonNgayLap;
        private System.Windows.Forms.TextBox txtHoaDpnTenKhachHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}