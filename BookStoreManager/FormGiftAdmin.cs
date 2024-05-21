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
    public partial class FormGiftAdmin : Form
    {
        public FormGiftAdmin()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            loadDG();
        }
        private void loadDG()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT ma_gift_code as [Mã Gift_code] ");
            query.Append(", ma_code as [Mã Code]");
            query.Append(", gia_tri as [Giá Trị]");
            query.Append("FROM giftcode ");


            dt = dataProvider.execQuery(query.ToString());
            dgLoaiMa.DataSource = dt;

        }
        int maGiftcode;
        private void dgLoaiMa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            if (id < 0) id = 0;
            if (id == dgLoaiMa.RowCount - 1) id = id - 1;

            DataGridViewRow row = dgLoaiMa.Rows[id];

            maGiftcode = (int)row.Cells[0].Value;

            label6.Text = "Mã Giftcode: " + maGiftcode;
        }
        private DataProvider dataProvider = new DataProvider();
        private void btntao_Click(object sender, EventArgs e)
        {
            int giaTri = Int32.Parse(txtGiaTri.Text);
            StringBuilder query = new StringBuilder("EXEC proc_add");
            query.Append(" @ma_code = N'" + txtma.Text + "'");
            query.Append(" ,@giaTri = " + giaTri );

            int result = dataProvider.execNonQuery(query.ToString());
            if (result > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadDG();
            }
            else
            {
                MessageBox.Show("Thêm loại sách không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int solitu = (int)txtSoLuog.Value;
            String macode = RandomString(solitu);
            txtma.Text = macode;
        }
        private string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            char[] stringChars = new char[length];

            for (int i = 0; i < length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(stringChars);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn xóa " + maGiftcode + " này  không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                string query = "DELETE From giftcode where ma_gift_code = " + maGiftcode;
                int result = dataProvider.execNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Xóa Gift_code có " + maGiftcode + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    loadDG();
                }
                else
                {
                    MessageBox.Show("Xóa Gift_code có  " + maGiftcode + " không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
