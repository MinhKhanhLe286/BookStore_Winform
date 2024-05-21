using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungBanSach
{
    public partial class FormHoaDonQL : Form
    {
        private DataProvider dataProvider = new DataProvider();

        public FormHoaDonQL()
        {
            InitializeComponent();
            initHoaDon();
        }
        private void initHoaDon()
        {
            LoadHD();
        }
        private void FormHoaDonQL_Load(object sender, EventArgs e)
        {

        }
        private void LoadHD()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT ma_hoa_don as [Mã hóa đơn] ");
            query.Append(", ngay_lap_hoa_don as [Ngày lập hóa đơn]");
            query.Append(", ten_khach_hang as [Tên khách hàng]");
            query.Append(", sdt_khach_hang as [Số điện thoại khách hàng]");
           
            query.Append("FROM hoa_don ");


            dt = dataProvider.execQuery(query.ToString());
            dataHoaDn.DataSource = dt;
        }
        private int maHoaDon;
        private void dataHoaDn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            if (id < 0) id = 0;
            if (id == dataHoaDn.RowCount - 1) id = id - 1;

            DataGridViewRow row = dataHoaDn.Rows[id];

            maHoaDon = (int)row.Cells[0].Value;
            dateHoaDonNgayLap.Value = DateTime.Parse(row.Cells[1].Value.ToString());
            txtHoaDpnTenKhachHang.Text = row.Cells[2].Value.ToString();
            txtHoaSonSDT.Text = row.Cells[3].Value.ToString();

        }

        private void btnHoaDonThem_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_them_hoa_don ");
           
            query.Append(" @ngayLapHoaDon = '" + dateHoaDonNgayLap.Value + "'");
            query.Append(" ,@tenKhachHang = N'" + txtHoaDpnTenKhachHang.Text + "'");
            query.Append(" ,@sdtKhachHang = " + txtHoaSonSDT.Text);

            int result = dataProvider.execNonQuery(query.ToString());
            if (result > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadHD();
            }
            else
            {
                MessageBox.Show("Thêm sách không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoaDonSua_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_hoa_don");
            query.Append(" @maHoaDon = " + maHoaDon);
            query.Append(" ,@ngayLapHoaDon = '" + dateHoaDonNgayLap.Value + "'");
            query.Append(" ,@tenKhachHang = N'" + txtHoaDpnTenKhachHang.Text + "'");
            query.Append(" ,@sdtKhachHang = " + txtHoaSonSDT.Text);

            int result = dataProvider.execNonQuery(query.ToString());
            if (result > 0)
            {
                MessageBox.Show("Sửa dữ liệu thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadHD();
            }
            else
            {
                MessageBox.Show("Sửa dữ liệu không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoaDonXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn xóa hóa đơn có mã " + maHoaDon + "không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                string query = "DELETE From hoa_don where ma_hoa_don = " + maHoaDon;
                int result = dataProvider.execNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Xóa hóa đơn của " + txtHoaDpnTenKhachHang.Text + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadHD();
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn của " + txtHoaDpnTenKhachHang.Text + " không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHoaDonTim_Click(object sender, EventArgs e)
        {
            

            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT ma_hoa_don as [Mã hóa đơn] ");
            query.Append(", ngay_lap_hoa_don as [Ngày lập hóa đơn]");
            query.Append(", ten_khach_hang as [Tên khách hàng]");
            query.Append(", sdt_khach_hang as [Số điện thoại khách hàng]");

            query.Append("FROM hoa_don ");
            query.Append("Where ten_khach_hang COLLATE Latin1_General_CI_AI LIKE '%" + txtHoaDonNhapTen.Text + "%'");


            dt = dataProvider.execQuery(query.ToString());
            dataHoaDn.DataSource = dt;
        }

        private void btnHoaDnHuy_Click(object sender, EventArgs e)
        {
            txtHoaDonNhapTen.Text = "";
            LoadHD();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormChiTietHoaDon fohd = new FormChiTietHoaDon(maHoaDon);
            fohd.ShowDialog();
        }
    }
}
