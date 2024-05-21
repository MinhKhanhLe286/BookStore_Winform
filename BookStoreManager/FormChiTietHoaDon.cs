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
    public partial class FormChiTietHoaDon : Form
    {
        DataProvider dataProvider = new DataProvider();
        public FormChiTietHoaDon(int maHoaDOn)
        {
            InitializeComponent();
            this.lbChiTietHoaDon.Text = "Chi Tiết Hóa Đơn "+ maHoaDOn;
            init();
        }

        private void init()
        {
            loadCbSach();
        }

        private void loadCbSach()
        {
            DataTable dt = new DataTable();
            dt = dataProvider.execQuery("SELECT * FROM sach");
            cbSach.DisplayMember = "ten_sach";
            cbSach.ValueMember = "ma_sach";

            cbSach.DataSource = dt;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
