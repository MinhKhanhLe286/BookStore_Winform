namespace UngDungBanSach
{
    partial class FormSachUser
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
            this.dgSach = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSachTacGia = new System.Windows.Forms.TextBox();
            this.txtSachTenSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiemTin = new System.Windows.Forms.Button();
            this.btnTimKiemHuy = new System.Windows.Forms.Button();
            this.dateNgayLap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSach
            // 
            this.dgSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSach.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgSach.Location = new System.Drawing.Point(12, 137);
            this.dgSach.Name = "dgSach";
            this.dgSach.RowHeadersWidth = 62;
            this.dgSach.RowTemplate.Height = 28;
            this.dgSach.Size = new System.Drawing.Size(673, 511);
            this.dgSach.TabIndex = 1;
            this.dgSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSach_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateNgayLap);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtTheLoai);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.txtSachTacGia);
            this.panel1.Controls.Add(this.txtSachTenSach);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(691, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 636);
            this.panel1.TabIndex = 2;
            // 
            // txtSachTacGia
            // 
            this.txtSachTacGia.Location = new System.Drawing.Point(178, 251);
            this.txtSachTacGia.Name = "txtSachTacGia";
            this.txtSachTacGia.Size = new System.Drawing.Size(292, 26);
            this.txtSachTacGia.TabIndex = 22;
            // 
            // txtSachTenSach
            // 
            this.txtSachTenSach.Location = new System.Drawing.Point(178, 198);
            this.txtSachTenSach.Name = "txtSachTenSach";
            this.txtSachTenSach.Size = new System.Drawing.Size(292, 26);
            this.txtSachTenSach.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Số Lượng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tác giả";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên Sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(192, 368);
            this.txtSoLuong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(68, 36);
            this.txtSoLuong.TabIndex = 24;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(178, 317);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(292, 26);
            this.txtGia.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Giá";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(179, 142);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(291, 26);
            this.txtTheLoai.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Thể loại";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(186)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(261, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 69);
            this.button1.TabIndex = 29;
            this.button1.Text = "Thêm Vào Giỏ Hàng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(173, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "Thông tin của Sách";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 29);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tìm kiếm:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(183, 24);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(357, 35);
            this.txtTimKiem.TabIndex = 32;
            // 
            // btnTimKiemTin
            // 
            this.btnTimKiemTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(186)))));
            this.btnTimKiemTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemTin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiemTin.Location = new System.Drawing.Point(267, 70);
            this.btnTimKiemTin.Name = "btnTimKiemTin";
            this.btnTimKiemTin.Size = new System.Drawing.Size(98, 51);
            this.btnTimKiemTin.TabIndex = 31;
            this.btnTimKiemTin.Text = "Tìm ";
            this.btnTimKiemTin.UseVisualStyleBackColor = false;
            this.btnTimKiemTin.Click += new System.EventHandler(this.btnTimKiemTin_Click);
            // 
            // btnTimKiemHuy
            // 
            this.btnTimKiemHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(186)))));
            this.btnTimKiemHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiemHuy.Location = new System.Drawing.Point(422, 72);
            this.btnTimKiemHuy.Name = "btnTimKiemHuy";
            this.btnTimKiemHuy.Size = new System.Drawing.Size(98, 51);
            this.btnTimKiemHuy.TabIndex = 33;
            this.btnTimKiemHuy.Text = "Hủy";
            this.btnTimKiemHuy.UseVisualStyleBackColor = false;
            this.btnTimKiemHuy.Click += new System.EventHandler(this.btnTimKiemHuy_Click);
            // 
            // dateNgayLap
            // 
            this.dateNgayLap.Location = new System.Drawing.Point(189, 607);
            this.dateNgayLap.Name = "dateNgayLap";
            this.dateNgayLap.Size = new System.Drawing.Size(297, 26);
            this.dateNgayLap.TabIndex = 32;
            // 
            // FormSachUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 663);
            this.Controls.Add(this.btnTimKiemHuy);
            this.Controls.Add(this.btnTimKiemTin);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgSach);
            this.Name = "FormSachUser";
            this.Text = "FormSachUser";
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSachTacGia;
        private System.Windows.Forms.TextBox txtSachTenSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtSoLuong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiemTin;
        private System.Windows.Forms.Button btnTimKiemHuy;
        private System.Windows.Forms.DateTimePicker dateNgayLap;
    }
}