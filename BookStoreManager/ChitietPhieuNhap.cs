using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungBanSach
{
    public partial class ChitietPhieuNhap : Form
    {
        DataProvider dataProvider = new DataProvider();

        private int maSach;
        private int maPhieuNhap;
        public ChitietPhieuNhap(int maPhieuNhap)
        {
            InitializeComponent();
            this.maPhieuNhap = maPhieuNhap;
            this.lbChiTietPhieuNhap.Text = "Chi Tiết Phiếu Nhập: " + maPhieuNhap;
            init();
            

        }
        private void init()
        {
            loadCbSach();
            loadDgPhieuNhap();
            loadTongTien();
        }

        private void loadDgPhieuNhap()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT sach.ten_sach as [Tên Sách] ");
            query.Append(", chi_tiet_phieu_nhap.so_luong as [Số Lương]");
            query.Append(", chi_tiet_phieu_nhap.gia_nhap as [Giá Nhập]");
            query.Append(" , chi_tiet_phieu_nhap.gia_nhap * chi_tiet_phieu_nhap.so_luong as [Thành Tiền]");

            query.Append("FROM sach,chi_tiet_phieu_nhap ");
            query.Append("Where sach.ma_sach = chi_tiet_phieu_nhap.ma_sach and ma_phieu_nhap = "+ maPhieuNhap);


            dt = dataProvider.execQuery(query.ToString());
            dgPhieuNhap.DataSource = dt;


        }

        private void loadTongTien()
        {
            
                // Thực hiện truy vấn và lấy kết quả
                object result = dataProvider.execScaler("SELECT SUM(so_luong * gia_nhap) FROM chi_tiet_phieu_nhap WHERE ma_phieu_nhap = " + maPhieuNhap);

                // Kiểm tra và chuyển đổi kết quả sang double
                double tongTien = 0;
                if (result != null && result != DBNull.Value)
                {
                    tongTien = Convert.ToDouble(result);
                }

                // Hiển thị kết quả trong TextBox
                txtTongTien.Text = "Tổng Tiền: " + tongTien.ToString("N2"); // Định dạng số để hiển thị đẹp hơn
        }


        private void loadCbSach()
        {
            DataTable dt = new DataTable();
            dt = dataProvider.execQuery("SELECT * FROM sach");
            cbSach.DisplayMember = "ten_sach";
            cbSach.ValueMember = "ma_sach";

            cbSach.DataSource = dt;
        }

        private void lbChiTietPhieuNhap_Click(object sender, EventArgs e)
        {

        }


        String tenSach;
        private void cbSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            maSach = (int)comboBox.SelectedValue;
            tenSach = comboBox.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int dem = (int)dataProvider.execScaler( " SELECT Count(*) From chi_tiet_phieu_nhap where ma_phieu_nhap = " + maPhieuNhap + "and ma_sach = "+ maSach);

            if(dem == 0)
            {
                StringBuilder query = new StringBuilder("EXEC proc_them_chi_tiet_phieu_nhap");
                query.Append(" @maPhieuNhap = " + maPhieuNhap);
                query.Append(", @maSach = " + maSach);
                query.Append(" ,@soLuong = " + txtSoLuong.Value);
                query.Append(" ,@giaNhap = " + txtGiaNhap.Value);

                int result = dataProvider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    MessageBox.Show("Thêm sách vào phiếu nhập thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //LoadPhieuNhap();
                    loadDgPhieuNhap();
                    loadTongTien();
                }
                else
                {
                    MessageBox.Show("Thêm sách vào phiếu nhập không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int dem1 = (int)dataProvider.execScaler(" SELECT Sum(so_luong) From chi_tiet_phieu_nhap where ma_phieu_nhap = " + maPhieuNhap + "and ma_sach = " + maSach);

                update(dem1);
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            update(0);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn xóa sách " + tenSach + "không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                string query = "DELETE From chi_tiet_phieu_nhap where ma_phieu_nhap = " + maPhieuNhap + " and ma_sach = "+maSach;
                int result = dataProvider.execNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Xóa " + tenSach + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    loadDgPhieuNhap();
                    loadTongTien();
                }
                else
                {
                    MessageBox.Show("Xóa " + tenSach + " không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void update(int soLuong)
        {
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_chi_tiet_phieu_nhap");
            query.Append(" @maPhieuNhap = " + maPhieuNhap);
            query.Append(", @maSach = " + maSach);
            query.Append(" ,@soLuong = " + (txtSoLuong.Value  + soLuong));
            query.Append(" ,@giaNhap = " + txtGiaNhap.Value);

            int result = dataProvider.execNonQuery(query.ToString());
            if (result > 0)
            {
                MessageBox.Show("Cập nhật sách vào phiếu nhập thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //LoadPhieuNhap();
                loadDgPhieuNhap();
                loadTongTien();
            }
            else
            {
                MessageBox.Show("Cập nhật sách vào phiếu nhập không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            if (id < 0) id = 0;
            if (id == dgPhieuNhap.RowCount - 1) id = id - 1;
           
            DataGridViewRow row = dgPhieuNhap.Rows[id];

            tenSach = row.Cells[0].Value.ToString();
            cbSach.Text = tenSach;
            txtSoLuong.Value = (int)row.Cells[1].Value;
            txtGiaNhap.Value = Convert.ToInt32(row.Cells[2].Value);

            maSach = (int)dataProvider.execScaler("SELECT ma_sach from sach where ten_sach = N'" + tenSach + "'");
    
        }
    }
}
