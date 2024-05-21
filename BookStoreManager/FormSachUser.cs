using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungBanSach
{
    public partial class FormSachUser : Form
    {
        int maKhachHang = 01;
        public FormSachUser(int maHang)
        {
            this.maKhachHang = maHang;
            InitializeComponent();
            intit();
        }

        private void intit()
        {
            LoadDgSach();
            
        }
        DataProvider dataProvider = new DataProvider();
        private void LoadDgSach()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT ma_sach as [Mã sách] ");
            query.Append(", ten_sach as [Tên sách]");
            query.Append(", ten_loai_sach as [Tên loại sách]");
            query.Append(", tac_gia as [Tác giả]");
            query.Append(", so_luong as [Còn lại]");
            query.Append(", gia_ban as [Giá] ");

            query.Append("FROM sach inner join loai_sach ON loai_sach.ma_loai_sach = sach.ma_loai_sach ");


            dt = dataProvider.execQuery(query.ToString());
            dgSach.DataSource = dt;

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private int maSach;
        private void dgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            if (id < 0) id = 0;
            if (id == dgSach.RowCount - 1) id = id - 1;

            DataGridViewRow row = dgSach.Rows[id];

            maSach = Convert.ToInt32(row.Cells[0].Value);
            txtSachTenSach.Text = row.Cells[1].Value.ToString();
            txtTheLoai.Text = row.Cells[2].Value.ToString();
            txtSachTacGia.Text = row.Cells[3].Value.ToString();
            
            txtGia.Text = row.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gia = Int32.Parse(txtGia.Text);
            int thanhTien = (int)txtSoLuong.Value * gia;
            StringBuilder query = new StringBuilder("EXEC proc_add_gioHang");
            query.Append(" @ma_khach_hang = " + maKhachHang);
            query.Append(" ,@ten_sach = N'" + txtSachTenSach.Text+"'");
            query.Append(" ,@tac_gia = N'" + txtSachTacGia.Text + "'");
            query.Append(" ,@gia = " + gia);
            query.Append(" ,@soLuong = " + txtSoLuong.Value );
            query.Append(" ,@ThanhTien = "+ thanhTien);
            query.Append(" ,@ngay_them = '" + dateNgayLap.Value + "'");

            int result = dataProvider.execNonQuery(query.ToString());
            if (result > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            }
            else
            {
                MessageBox.Show("Thêm sách không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiemTin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT ma_sach as [Mã sách] ");
            query.Append(", ten_sach as [Tên sách]");
            query.Append(", ten_loai_sach as [Tên loại sách]");
            query.Append(", tac_gia as [Tác giả]");
            query.Append(", so_luong as [Còn lại]");
            query.Append(", gia_ban as [Giá] ");

            query.Append("FROM sach inner join loai_sach ON loai_sach.ma_loai_sach = sach.ma_loai_sach ");
            query.Append("Where ten_loai_sach  COLLATE Latin1_General_CI_AI LIKE '%" + txtTimKiem.Text + "%'" );

            dt = dataProvider.execQuery(query.ToString());
            dgSach.DataSource = dt;

            txtSachTenSach.Text = "";
            txtTheLoai.Text = "";
            txtSachTacGia.Text = "";

            txtGia.Text = "";

        }

        private void btnTimKiemHuy_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            LoadDgSach();
        }
    }
}
