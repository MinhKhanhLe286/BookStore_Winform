namespace UngDungBanSach
{
    partial class FormGioHangUser
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
            this.dgGioHang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dateGioHang = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbGiaTien = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbTogtien = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgGioHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgGioHang
            // 
            this.dgGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGioHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgGioHang.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgGioHang.Location = new System.Drawing.Point(0, 0);
            this.dgGioHang.Name = "dgGioHang";
            this.dgGioHang.RowHeadersWidth = 62;
            this.dgGioHang.RowTemplate.Height = 28;
            this.dgGioHang.Size = new System.Drawing.Size(1189, 389);
            this.dgGioHang.TabIndex = 2;
            this.dgGioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGioHang_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.lbTogtien);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lbGiaTien);
            this.panel1.Controls.Add(this.lbSoLuong);
            this.panel1.Controls.Add(this.lbTenSach);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateGioHang);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 246);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(186)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(947, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 50);
            this.button1.TabIndex = 31;
            this.button1.Text = "Thanh Toán";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateGioHang
            // 
            this.dateGioHang.Location = new System.Drawing.Point(844, 0);
            this.dateGioHang.Name = "dateGioHang";
            this.dateGioHang.Size = new System.Drawing.Size(345, 26);
            this.dateGioHang.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Thông tin giỏ hàng";
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.Location = new System.Drawing.Point(77, 75);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(74, 20);
            this.lbTenSach.TabIndex = 34;
            this.lbTenSach.Text = "Tên sách";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(77, 130);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(78, 20);
            this.lbSoLuong.TabIndex = 35;
            this.lbSoLuong.Text = "Số Lượng";
            // 
            // lbGiaTien
            // 
            this.lbGiaTien.AutoSize = true;
            this.lbGiaTien.Location = new System.Drawing.Point(77, 180);
            this.lbGiaTien.Name = "lbGiaTien";
            this.lbGiaTien.Size = new System.Drawing.Size(64, 20);
            this.lbGiaTien.TabIndex = 36;
            this.lbGiaTien.Text = "Giá tiền";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(186)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(947, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 50);
            this.button2.TabIndex = 40;
            this.button2.Text = "Xóa Đơn hàng này";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbTogtien
            // 
            this.lbTogtien.AutoSize = true;
            this.lbTogtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(186)))));
            this.lbTogtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTogtien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTogtien.Location = new System.Drawing.Point(616, 164);
            this.lbTogtien.Name = "lbTogtien";
            this.lbTogtien.Size = new System.Drawing.Size(147, 29);
            this.lbTogtien.TabIndex = 41;
            this.lbTogtien.Text = "Tổng số tiền";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(646, 30);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(34, 20);
            this.lbID.TabIndex = 42;
            this.lbID.Text = "ID: ";
            // 
            // FormGioHangUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 663);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgGioHang);
            this.Name = "FormGioHangUser";
            this.Text = "FormGioHangUser";
            ((System.ComponentModel.ISupportInitialize)(this.dgGioHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgGioHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateGioHang;
        private System.Windows.Forms.Label lbGiaTien;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbTogtien;
        private System.Windows.Forms.Label lbID;
    }
}