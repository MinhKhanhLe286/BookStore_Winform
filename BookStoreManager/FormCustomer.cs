using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungBanSach
{
    public partial class FormCustomer : Form
    {
        DataProvider dataProvider = new DataProvider();
        public FormCustomer()
        {
            InitializeComponent();
            init();


        }

        private void init()
        {
            LoadData();
            comboRole.SelectedIndex = 0;
        }
        private void LoadData()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT ma_khach_hang as [Mã khách hàng] ");
            query.Append(", ten_khach_hang as [Tên Khách hàng]");
            query.Append(", dia_chi as [Địa chỉ]");
            query.Append(", sdt_khach_hang  as [Số điện thoại]");
            query.Append(", so_du as [Số dư] ");
            query.Append(", tai_khoan as [UserName]");
            query.Append(", mat_khau as [Password] ");
            query.Append(", phan_quyen as [Role] ");
            query.Append("FROM khach_hang");


            dt = dataProvider.execQuery(query.ToString());
            dgKhachHang.DataSource = dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int SoDu = Int32.Parse(txtSoDuTaiKhoa.Text);
            int role = Int32.Parse(comboRole.Text);
            String pass = createPass(txtPass.Text);
            StringBuilder query = new StringBuilder("EXEC proc_them_khach_hang");
            query.Append(" @tenKhachhang = N'" + txtTenKhachHang.Text + "'");
            query.Append(" ,@soDT = N'" + txtSoDienThoai.Text + "'");
            query.Append(" ,@diaChi = N'" + txtDiaChi.Text + "'");
            query.Append(" ,@soDu = " + SoDu);
            query.Append(" ,@tai_khoan = N'" + txtUssername.Text + "'");
            query.Append(" ,@mat_khau = N'" + pass + "'");
            query.Append(" , @phan_quyen = " + role);

            int result = dataProvider.execNonQuery(query.ToString());
            if (result > 0)
            {
                MessageBox.Show("Thêm Khách hàng thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm khach hàng không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string createPass(String pa)
        {
            MD5 md = MD5.Create();
            byte[] inputString = System.Text.Encoding.ASCII.GetBytes(pa);
            byte[] hash = md.ComputeHash(inputString);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        private int makhachHang;
        private void dgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            if (id < 0) id = 0;
            if (id == dgKhachHang.RowCount - 1) id = id - 1;

            DataGridViewRow row = dgKhachHang.Rows[id];

            makhachHang = (int)row.Cells[0].Value;
            txtTenKhachHang.Text = row.Cells[1].Value.ToString();
            txtDiaChi.Text = row.Cells[2].Value.ToString();
            txtSoDienThoai.Text = row.Cells[3].Value.ToString();
            txtSoDuTaiKhoa.Text = row.Cells[4].Value.ToString();
            txtUssername.Text = row.Cells[5].Value.ToString();
            txtPass.Text = row.Cells[6].Value.ToString();
            comboRole.Text = row.Cells[7].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int SoDu = Int32.Parse(txtSoDuTaiKhoa.Text);
            int role = Int32.Parse(comboRole.Text);
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_khach_hang");
            query.Append(" @tenKhachhang = N'" + txtTenKhachHang.Text + "'");
            query.Append(" ,@soDT = N'" + txtSoDienThoai.Text + "'");
            query.Append(" ,@diaChi = N'" + txtDiaChi.Text + "'");
            query.Append(" ,@soDu = " + SoDu);
            query.Append(" ,@tai_khoan = N'" + txtUssername.Text + "'");
            query.Append(" ,@mat_khau = N'" + txtPass.Text + "'");
            query.Append(" , @phan_quyen = " + role);
            query.Append(" ,@maKhachHang =" + makhachHang);

            int result = dataProvider.execNonQuery(query.ToString());
            if (result > 0)
            {
                MessageBox.Show("Cập nhật Khách hàng thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadData();
            }
            else
            {
                MessageBox.Show("TCập nhật Khách hàng không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn xóa " + txtTenKhachHang.Text + "không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                string query = "DELETE From khach_hang where ma_khach_hang = " + makhachHang;
                int result = dataProvider.execNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Xóa " + txtTenKhachHang.Text + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa " + txtTenKhachHang.Text + " không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
