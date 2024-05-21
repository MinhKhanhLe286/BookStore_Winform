namespace UngDungBanSach
{
    partial class FormGiftAdmin
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
            this.dgLoaiMa = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntao = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuog = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoaiMa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLoaiMa
            // 
            this.dgLoaiMa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLoaiMa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoaiMa.Location = new System.Drawing.Point(41, 112);
            this.dgLoaiMa.Name = "dgLoaiMa";
            this.dgLoaiMa.RowHeadersWidth = 62;
            this.dgLoaiMa.RowTemplate.Height = 28;
            this.dgLoaiMa.Size = new System.Drawing.Size(625, 758);
            this.dgLoaiMa.TabIndex = 2;
            this.dgLoaiMa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLoaiMa_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(122, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh Sách mã giftcode";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btntao);
            this.panel1.Controls.Add(this.btnRandom);
            this.panel1.Controls.Add(this.txtma);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtGiaTri);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSoLuog);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(730, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 734);
            this.panel1.TabIndex = 4;
            // 
            // btntao
            // 
            this.btntao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(186)))));
            this.btntao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntao.Location = new System.Drawing.Point(122, 410);
            this.btntao.Name = "btntao";
            this.btntao.Size = new System.Drawing.Size(172, 54);
            this.btntao.TabIndex = 31;
            this.btntao.Text = "Create";
            this.btntao.UseVisualStyleBackColor = false;
            this.btntao.Click += new System.EventHandler(this.btntao_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(186)))));
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRandom.Location = new System.Drawing.Point(357, 410);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(172, 54);
            this.btnRandom.TabIndex = 30;
            this.btnRandom.Text = "Ramdom";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // txtma
            // 
            this.txtma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.Location = new System.Drawing.Point(282, 215);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(252, 39);
            this.txtma.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mã code";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTri.Location = new System.Drawing.Point(282, 284);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(252, 39);
            this.txtGiaTri.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giá trị :";
            // 
            // txtSoLuog
            // 
            this.txtSoLuog.BackColor = System.Drawing.Color.Transparent;
            this.txtSoLuog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuog.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuog.Location = new System.Drawing.Point(282, 137);
            this.txtSoLuog.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoLuog.Name = "txtSoLuog";
            this.txtSoLuog.Size = new System.Drawing.Size(252, 46);
            this.txtSoLuog.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lương kí tự:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(845, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thông tin mã giftcode";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(186)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(344, 642);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(172, 54);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Remove";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 651);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 32);
            this.label6.TabIndex = 33;
            this.label6.Text = "Mã Giftcode:";
            // 
            // FormGiftAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 882);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgLoaiMa);
            this.Name = "FormGiftAdmin";
            this.Text = "FormGiftAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgLoaiMa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLoaiMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtSoLuog;
        private System.Windows.Forms.Button btntao;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
    }
}