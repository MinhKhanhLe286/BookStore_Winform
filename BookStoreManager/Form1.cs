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
    public partial class Form1 : Form
    {
        private DataProvider dataProvider = new DataProvider();
        private int maLoaiSach;
        private int maSach;
        public Form1()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            initSach();
            initLoaiSach();
            initPhieuNhap();
        }
        private void initSach()
        {
            LoadDgSach();
            LoadCbSachLoaiSach();
        }
        private void LoadDgSach()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT ma_sach as [Mã sách] ");
            query.Append(", ten_sach as [Tên sách]");
            query.Append(", ten_loai_sach as [Tên loại sách]");
            query.Append(", tac_gia as [Tác giả]");
            query.Append(", so_luong as [Số lượng]");
            query.Append(", gia_ban as [Giá bán] ");
            query.Append("FROM sach inner join loai_sach ON loai_sach.ma_loai_sach = sach.ma_loai_sach ");


            dt = dataProvider.execQuery(query.ToString());
            dgSach.DataSource = dt;

        }
        private void LoadCbSachLoaiSach()
        {
            DataTable dt = new DataTable();
            dt = dataProvider.execQuery("SELECT * FROM loai_sach");
            cbSachLoaiSach.DisplayMember = "ten_loai_sach";
            cbSachLoaiSach.ValueMember = "ma_loai_sach";

            cbSachLoaiSach.DataSource = dt;
        }

        private void dgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            if (id < 0) id = 0;
            if (id == dgSach.RowCount - 1) id = id - 1;

            DataGridViewRow row = dgSach.Rows[id];

            maSach = (int)row.Cells[0].Value;
            txtSachTenSach.Text = row.Cells[1].Value.ToString();
            cbSachLoaiSach.Text = row.Cells[2].Value.ToString();    
            txtSachTacGia.Text = row.Cells[3].Value.ToString();
            txtSachSoLuong.Value = (int)row.Cells[4].Value;
            txtSachGiaBan.Value = Convert.ToInt32(row.Cells[5].Value);

            maLoaiSach = (int)dataProvider.execScaler("SELECT ma_loai_sach FROM loai_sach Where ten_loai_sach = N'"+ cbSachLoaiSach.Text + "'");
        }

        private void cbSachLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            maLoaiSach = (int)comboBox.SelectedValue;

        }

        private void btnSachAdd_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_them_sach");
            query.Append(" @tensach = N'"+txtSachTenSach.Text +"'");
            query.Append(" ,@maloaisach = " + maLoaiSach);
            query.Append(" ,@tacGia = N'"+ txtSachTacGia.Text + "'");
            query.Append(" ,@soLuong = "+ txtSachSoLuong.Value);
            query.Append(" ,@giaBan = "+txtSachGiaBan.Value);

            int result = dataProvider.execNonQuery(query.ToString());
            if(result > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công! ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                LoadAll();
            }
            else
            {
                MessageBox.Show("Thêm sách không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSachSua_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_sach");
            query.Append(" @maSach = " + maSach);
            query.Append(" ,@tensach = N'" + txtSachTenSach.Text + "'");
            query.Append(" ,@maloaisach = " + maLoaiSach);
            query.Append(" ,@tacGia = N'" + txtSachTacGia.Text + "'");
            query.Append(" ,@soLuong = " + txtSachSoLuong.Value);
            query.Append(" ,@giaBan = " + txtSachGiaBan.Value);

            int result = dataProvider.execNonQuery(query.ToString());
            if (result > 0)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadAll();
            }
            else
            {
                MessageBox.Show("Cập nhật sách không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSachXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn xóa "+ txtSachTenSach.Text +"không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(check == DialogResult.Yes)    
            {
                string query = "DELETE From sach where ma_sach = " + maSach;
                int result = dataProvider.execNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Xóa "+txtSachTenSach.Text+" thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadAll();
                }
                else
                {
                    MessageBox.Show("Xóa " + txtSachTenSach.Text + " không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void initLoaiSach()
        {
            loadDgLoaiSach();
        }

        private void loadDgLoaiSach()
        {
            DataTable dt =  new DataTable();

            StringBuilder query = new StringBuilder("SELECT ma_loai_sach as [Mã Loại Sách] ");
            query.Append(" ,ten_loai_sach as [Tên Loại Sach]");
            query.Append(" From loai_sach");

            dt = dataProvider.execQuery(query.ToString());
            dgLoaiSach.DataSource = dt;

            
        }

        
        private int maloaisachloaisach;
        private void dgLoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            if (id < 0) id = 0;
            if (id == dgLoaiSach.RowCount - 1) id = id - 1;

            DataGridViewRow row = dgLoaiSach.Rows[id];

            maloaisachloaisach = (int)row.Cells[0].Value;

            txtLoaiSachTenLoaiSach.Text = row.Cells[1].Value.ToString(); 
        
        }

        private void btnLoaiSachTimKiem_Click(object sender, EventArgs e)
        {
            txtLoaiSachTenLoaiSach.Text = "";
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT ma_loai_sach as [Mã Loại Sách] ");
            query.Append(" ,ten_loai_sach as [Tên Loại Sach]");
            query.Append(" From loai_sach Where ten_loai_sach COLLATE Latin1_General_CI_AI LIKE '%" + txtLoaiSachSearch.Text + "%'");

            dt = dataProvider.execQuery(query.ToString());
            dgLoaiSach.DataSource = dt;
        }
        // WHERE ten_loai_sach COLLATE Latin1_General_CI_AI LIKE '%văn%';
        private void btnLoaiSachHuyTim_Click(object sender, EventArgs e)
        {
            txtLoaiSachSearch.Text = "";
            loadDgLoaiSach();
        }

        private void btnLoaiSachSua_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_loai_sach");
            query.Append(" @maLoaiSach = " + maloaisachloaisach);
            query.Append(", @tenLoaiSach = N'" + txtLoaiSachTenLoaiSach.Text + "'");



            int result = dataProvider.execNonQuery(query.ToString());
            if (result > 0)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadAll();
            }
            else
            {
                MessageBox.Show("Cập nhật loại sách không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoaiSachXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn xóa " + txtLoaiSachTenLoaiSach.Text + "không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                string query = "DELETE From loai_sach where ma_loai_sach = " + maloaisachloaisach;
                int result = dataProvider.execNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Xóa " + txtSachTenSach.Text + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadAll();
                }
                else
                {
                    MessageBox.Show("Xóa " + txtSachTenSach.Text + " không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoaiSachThem_Click(object sender, EventArgs e)
        {
            
            StringBuilder query = new StringBuilder("EXEC proc_them_loai_sach");
            query.Append(" @tenLoaiSach = N'" + txtLoaiSachTenLoaiSach.Text + "'");


            int result = dataProvider.execNonQuery(query.ToString());
            if (result > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadAll();
            }
            else
            {
                MessageBox.Show("Thêm loại sách không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAll()
        {
            loadDgLoaiSach();
            LoadDgSach();
            LoadCbSachLoaiSach();
        }

        // Phieu Nhap 
        private void initPhieuNhap()
        {
            LoadPhieuNhap();
        }
        private void LoadPhieuNhap()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT ma_phieu_nhap as [Mã phiếu nhập] ");
            query.Append(" ,ngay_lap_phieu_nhap as [Ngày lập phiếu nhâp]");
            query.Append(" ,ten_nha_cung_cap as [Nhà cung cấp]");
            query.Append(" FROM phieu_nhap");


            dt = dataProvider.execQuery(query.ToString());

            dgPhieuNhap.DataSource = dt;
        }
        

        private int maPhieuNhap;
        private void dgPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            if (id < 0) id = 0;
            if (id == dgSach.RowCount - 1) id = id - 1;

            DataGridViewRow row = dgPhieuNhap.Rows[id];

            maPhieuNhap = (int)row.Cells[0].Value;
            datePhieuNhap.Value = DateTime.Parse(row.Cells[1].Value.ToString());
            txtPhieuNhapTenNhaCungCap.Text = row.Cells[2].Value.ToString();
            
        }
        private void btnPhieuNhapAdd_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_them_phieu_nhap");
            query.Append(" @tenNhaCungCap = N'" + txtPhieuNhapTenNhaCungCap.Text + "'");
            query.Append(", @ngayLapPhieNhap = '" + datePhieuNhap.Value +"'");

            int result = dataProvider.execNonQuery(query.ToString());
            if (result > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadPhieuNhap();
            }
            else
            {
                MessageBox.Show("Thêm phiếu nhập không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPhieuNhapSua_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_phieu_nhap");
            query.Append(" @tenNhaCungCap = N'" + txtPhieuNhapTenNhaCungCap.Text + "'");
            query.Append(", @ngayLapPhieNhap = '" + datePhieuNhap.Value + "'");
            query.Append(" ,@maPhieuNhap = " + maPhieuNhap);



            int result = dataProvider.execNonQuery(query.ToString());
            if (result > 0)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadPhieuNhap();
            }
            else
            {
                MessageBox.Show("Cập nhật phiếu nhập không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPhieuNhapXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn xóa phiếu nhập có mã là:  " + maPhieuNhap + " không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                string query = "DELETE From phieu_nhap where ma_phieu_nhap = " + maPhieuNhap;
                int result = dataProvider.execNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Xóa phiếu nhập có mã : " + maPhieuNhap + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadPhieuNhap();
                }
                else
                {
                    MessageBox.Show("Xóa phiếu nhập có mã : " + maPhieuNhap + " không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

<<<<<<< HEAD
=======
        private void txtSachTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPhieuNhapChiTiet_Click(object sender, EventArgs e)
        {
            ChitietPhieuNhap for1 = new ChitietPhieuNhap(maPhieuNhap);
            for1.ShowDialog();
        }
>>>>>>> 737dc03654b86573ca939b66cbebe151eaec4686
    }
}
