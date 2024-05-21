namespace UngDungBanSach
{
    partial class ChitietPhieuNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbChiTietPhieuNhap = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.Label();
            this.cbSach = new System.Windows.Forms.ComboBox();
            this.txtGiaNhap = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgPhieuNhap = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, -36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chi tiết hóa đơn 1";
            // 
            // lbChiTietPhieuNhap
            // 
            this.lbChiTietPhieuNhap.AutoSize = true;
            this.lbChiTietPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTietPhieuNhap.Location = new System.Drawing.Point(453, 8);
            this.lbChiTietPhieuNhap.Name = "lbChiTietPhieuNhap";
            this.lbChiTietPhieuNhap.Size = new System.Drawing.Size(254, 32);
            this.lbChiTietPhieuNhap.TabIndex = 4;
            this.lbChiTietPhieuNhap.Text = "ChitietPhieuNhap";
            this.lbChiTietPhieuNhap.Click += new System.EventHandler(this.lbChiTietPhieuNhap_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTongTien);
            this.panel4.Controls.Add(this.cbSach);
            this.panel4.Controls.Add(this.txtGiaNhap);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtSoLuong);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Location = new System.Drawing.Point(36, 534);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1214, 158);
            this.panel4.TabIndex = 10;
            // 
            // txtTongTien
            // 
            this.txtTongTien.AutoSize = true;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(786, 87);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(162, 29);
            this.txtTongTien.TabIndex = 22;
            this.txtTongTien.Text = "Tổng Tiền: 0";
            // 
            // cbSach
            // 
            this.cbSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSach.FormattingEnabled = true;
            this.cbSach.Location = new System.Drawing.Point(176, 11);
            this.cbSach.Name = "cbSach";
            this.cbSach.Size = new System.Drawing.Size(386, 33);
            this.cbSach.TabIndex = 21;
            this.cbSach.SelectedIndexChanged += new System.EventHandler(this.cbSach_SelectedIndexChanged);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.BackColor = System.Drawing.Color.Transparent;
            this.txtGiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Location = new System.Drawing.Point(1016, 11);
            this.txtGiaNhap.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(181, 36);
            this.txtGiaNhap.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(908, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Giá Nhập";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(735, 11);
            this.txtSoLuong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(118, 36);
            this.txtSoLuong.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(609, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Số Lượng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên Sách";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(262, 87);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(155, 35);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(469, 87);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 35);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(55, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgPhieuNhap
            // 
            this.dgPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhieuNhap.Location = new System.Drawing.Point(36, 73);
            this.dgPhieuNhap.Name = "dgPhieuNhap";
            this.dgPhieuNhap.RowHeadersWidth = 62;
            this.dgPhieuNhap.RowTemplate.Height = 28;
            this.dgPhieuNhap.Size = new System.Drawing.Size(1214, 426);
            this.dgPhieuNhap.TabIndex = 8;
            this.dgPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhieuNhap_CellClick);
            // 
            // ChitietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 698);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgPhieuNhap);
            this.Controls.Add(this.lbChiTietPhieuNhap);
            this.Controls.Add(this.label1);
            this.Name = "ChitietPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChitietPhieuNhap";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbChiTietPhieuNhap;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txtTongTien;
        private System.Windows.Forms.ComboBox cbSach;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtGiaNhap;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgPhieuNhap;
    }
}