using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;
using System.Data.SqlClient;
namespace UngDungBanSach
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel5.BackColor = SystemColors.Control;
            textBox2.BackColor=SystemColors.Control; 
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel5.BackColor= SystemColors.Control;
            panel3.BackColor= SystemColors.Control;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Hide();
                FormMain form = new FormMain("Admin");
                form.ShowDialog();
                Show(); // Hiển thị lại form cha sau khi form con đóng
            }
            else if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string username = textBox1.Text;
                string password = CreatePass(textBox2.Text); // Hàm này cần được định nghĩa trong mã của bạn

                try
                {
                    string tenKhachHang = CheckCredentials(username, password, 0);
                    if (tenKhachHang != null)
                    {
                        Hide();
                        FormUser form = new FormUser(username,password,tenKhachHang);
                        form.ShowDialog();
                        Show(); // Hiển thị lại form cha sau khi form con đóng
                    }
                    else
                    {
                        tenKhachHang = CheckCredentials(username, password, 1);
                        if (tenKhachHang != null)
                        {
                            Hide();
                            FormMain form = new FormMain(tenKhachHang);
                            form.ShowDialog();
                            Show(); // Hiển thị lại form cha sau khi form con đóng
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi kiểm tra tài khoản: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private String connectString = "Data Source=DESKTOP-ENHGL7D\\SQLEXPRESS;Initial Catalog=UngDungSach;Integrated Security=True";

        private string CheckCredentials(string username, string password, int permissionLevel)
        {
            string query = "SELECT ten_khach_hang FROM khach_hang WHERE tai_khoan = @username AND mat_khau = @password AND phan_quyen = @permissionLevel";

            using (SqlConnection con = new SqlConnection(connectString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@permissionLevel", permissionLevel);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["ten_khach_hang"].ToString();
                        }
                    }
                }
            }

            return null;
        }


        public string CreatePass(string input)
        {
            // Hàm này sẽ mã hóa mật khẩu của bạn, ví dụ sử dụng MD5
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRegisterAccount f = new FormRegisterAccount();
            f.ShowDialog();

        }
    }
}
