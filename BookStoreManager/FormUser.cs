using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace UngDungBanSach
{
    public partial class FormUser : Form
    {
        String username, password, ten;
        int maKhachHang;
        private String connectString = "Data Source=DESKTOP-ENHGL7D\\SQLEXPRESS;Initial Catalog=UngDungSach;Integrated Security=True";
        public FormUser(String username, String password, String Ten)
        {
            this.username = username;
            this.password = password;
            this.ten = GetTen(username, password);
            this.maKhachHang = getmakhachhang(username);
            InitializeComponent();
            init();
        }

        public string GetTen(string username, string password)
        {
            string ten = null;

            string query = "SELECT ten_khach_hang FROM khach_hang WHERE tai_khoan = @username AND mat_khau = @password";

            using (SqlConnection con = new SqlConnection(connectString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ten = reader.GetString(reader.GetOrdinal("ten_khach_hang"));
                        }
                    }
                }
            }

            return ten;
        }
        public int getmakhachhang(string username)
        {
            int soDu = 0;

            string query = "SELECT ma_khach_hang FROM khach_hang WHERE tai_khoan = @username AND mat_khau = @password";

            using (SqlConnection con = new SqlConnection(connectString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            soDu = reader.GetInt32(reader.GetOrdinal("ma_khach_hang"));
                        }
                    }
                }
            }

            return soDu;
        }
        public int GetSoDu(string username)
        {
            int soDu = 0;

            string query = "SELECT so_du FROM khach_hang WHERE tai_khoan = @username AND mat_khau = @password";

            using (SqlConnection con = new SqlConnection(connectString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            soDu = reader.GetInt32(reader.GetOrdinal("so_du"));
                        }
                    }
                }
            }

            return soDu;
        }

        private void init()
        {
            loadTop();
        }
        private void loadTop()
        {
            lbName.Text = "Hello: " + ten;
            lbSoDu.Text = "Số Dư: " + GetSoDu(username) + "VND";
            lbID.Text = "ID: " + maKhachHang;

        }
        private Form currentFormChild;
        private void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();

            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm; ;
            childForm.BringToFront();
            childForm.Show();

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();

            }
            loadTop();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            int ma = getmakhachhang(username);
            openChildForm(new FormSachUser(ma));
            lbTieuDe.Text = "Cửa hàng "+ btnSach.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ma = getmakhachhang(username);
            openChildForm(new FormGioHangUser(ma, GetSoDu(username)));
            lbTieuDe.Text =   button1.Text ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận đăng xuất ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Hide();
                Login f = new Login();
                f.ShowDialog();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận đăng xuất ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Hide();
                Login f = new Login();
                f.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ma = getmakhachhang(username);
            openChildForm(new FormGiifUser(ma , GetSoDu(username)));
            lbTieuDe.Text = button2.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
