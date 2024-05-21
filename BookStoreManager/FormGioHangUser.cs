using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungBanSach
{
    public partial class FormGioHangUser : Form
    {
        int makhachhang;
        private DataProvider dataProvider = new DataProvider();

        public FormGioHangUser(int makhachHang, int soDu1)
        {
            InitializeComponent();
            this.makhachhang = makhachHang;
            init();
            this.soDu = soDu1;
            
        }

        private void init()
        {
            LoadDgGioHang();
        }
        private void LoadDgGioHang()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT ma_gio_hang as [Mã Thêm] ");
            query.Append(" ,ten_sach as [Tên sách]");
            query.Append(", tac_gia as [Tác giả]");
            
            query.Append(", gia_tien as [Giá Tiền] ");
            query.Append(", so_luong as [Số Lượng]");
            query.Append(", thanh_tien as [Thành tiền]");
            query.Append(", ngay_them as [Ngày thêm]");

            query.Append("FROM gio_hang Where ma_khach_hang = " + makhachhang);


            dt = dataProvider.execQuery(query.ToString());
            dgGioHang.DataSource = dt;

        }
        int soDu;
        int maGioHang;
        int SoLuong;
        int GiaTien;
        int tongTien;
        String tensach;
        private void dgGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            if (id < 0) id = 0;
            if (id == dgGioHang.RowCount - 1) id = id - 1;

            DataGridViewRow row = dgGioHang.Rows[id];
            maGioHang = (int)row.Cells[0].Value;
            SoLuong = (int)row.Cells[4].Value;
            GiaTien = (int)row.Cells[3].Value;
            tongTien= (int)row.Cells[5].Value;
            tensach = row.Cells[1].Value.ToString();

            lbTenSach.Text = "Tên Sach: " + tensach;
            lbSoLuong.Text = "Số lượng: " + SoLuong;
            lbGiaTien.Text = "Giá Tiền: " + GiaTien;
            lbTogtien.Text = "Tổng tiền thanh toán: " + tongTien;
            lbID.Text = "ID: " + maGioHang;
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if(tongTien > soDu)
            {
                MessageBox.Show("không du tiên" + " không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                MessageBox.Show( " xu li o đay ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            removeCart(maGioHang);

        }
        private void removeCart(int maGioHang)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn đơn hàng có mã là:  " + maGioHang + " không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                string query = "DELETE From gio_hang where ma_gio_hang = " + maGioHang + "AND ma_khach_hang = " + makhachhang;
                int result = dataProvider.execNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Xóa đơn hàng có mã : " + maGioHang + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadDgGioHang();
                }
                else
                {
                    MessageBox.Show("Xóa đơn hàng có mã : " + maGioHang + " không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
