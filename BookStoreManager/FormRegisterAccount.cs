using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace UngDungBanSach
{
    public partial class FormRegisterAccount : Form
    {
        public FormRegisterAccount()
        {
            InitializeComponent();
        }
        private DataProvider dataProvider = new DataProvider();
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if(txtHoTen.Text=="" || txtSDT.Text == "" || txtDiaChi.Text == "" || txtTenDangNhap.Text == "" || txtMatKhau.Text=="" || txtNhapLaiMatKhau.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập vào bị thiếu","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtMatKhau.Text.Equals(txtNhapLaiMatKhau.Text) == false)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp với mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pass = txtMatKhau.Text;
                String newPass = createPass(pass);
                int SoDu = 0;
                int role = 0;
                StringBuilder query = new StringBuilder("EXEC proc_them_khach_hang");
                query.Append(" @tenKhachhang = N'" + txtHoTen.Text + "'");
                query.Append(" ,@soDT = N'" + txtSDT.Text + "'");
                query.Append(" ,@diaChi = N'" + txtDiaChi.Text + "'");
                query.Append(" ,@soDu = " + SoDu);
                query.Append(" ,@tai_khoan = N'" + txtTenDangNhap.Text + "'");
                query.Append(" ,@mat_khau = N'" + newPass + "'");
                query.Append(" , @phan_quyen = " + role);

                int result = dataProvider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    MessageBox.Show("Đăng kí tài khoản thành công thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                }
                else
                {
                    MessageBox.Show("Thêm khach hàng không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        String pass;
        private string createPass(String pa)
        {
            MD5 md = MD5.Create();
            byte[] inputString = System.Text.Encoding.ASCII.GetBytes(pa);
            byte[] hash = md.ComputeHash(inputString);
            StringBuilder sb = new StringBuilder();

            for (int i=0; i<hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
