using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;

namespace UngDungBanSach
{
    public partial class FormGiifUser : Form
    {
        int makhachHang;
        int newSoTien;
        int oldSotien;
        private DataProvider dataProvider = new DataProvider();

        public FormGiifUser(int maKhachHang1, int oldSotien1)
        {
            makhachHang = maKhachHang1;
            oldSotien = oldSotien1;
            InitializeComponent();
            this.oldSotien = oldSotien;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtGiaTri.Text = "";
            txtMa.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mathe = txtMa.Text;
            if (!int.TryParse(txtGiaTri.Text, out int giatri))
            {
                MessageBox.Show("Giá trị mã phải là một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool check = CheckCredentials(mathe, giatri);
                if (check)
                {
                    MessageBox.Show("Nạp thẻ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    newSoTien = Convert.ToInt32(txtGiaTri.Text);
                    setSodu();
                    xoaGift(mathe, giatri);
                }
                else
                {
                    MessageBox.Show("Nạp thẻ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi kiểm tra tài khoản: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setSodu()
        {
            StringBuilder query = new StringBuilder("update khach_hang ");
            query.Append(" set so_du = " + (oldSotien + newSoTien));
            query.Append(" where ma_khach_hang = "+makhachHang);
            

            int result = dataProvider.execNonQuery(query.ToString());
            
        }
        private void xoaGift(string mathe, int giatri)
        {
            StringBuilder query = new StringBuilder(" delete giftcode ");

            query.Append(" where ma_code = '" + mathe + "'and gia_tri = "+ giatri);


            int result = dataProvider.execNonQuery(query.ToString());
        }
        
        private String connectString = "Data Source=DESKTOP-ENHGL7D\\SQLEXPRESS;Initial Catalog=UngDungSach;Integrated Security=True";

        private bool CheckCredentials(string mathe, int giaTri)
        {
            string query = "SELECT ma_code FROM giftcode WHERE ma_code = @username AND gia_tri = @password";

            using (SqlConnection con = new SqlConnection(connectString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", mathe);
                    cmd.Parameters.AddWithValue("@password", giaTri);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.Read();
                    }
                }
            }
        }
    }
}
