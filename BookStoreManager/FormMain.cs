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
    public partial class FormMain : Form
    {
        public FormMain(String name)
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void openChildForm( Form childForm)
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
        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1());
            label1.Text = button1.Text;
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận đăng xuất ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Hide();
                Login f = new Login();
                f.ShowDialog();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form1());
            label1.Text = button1.Text;
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
            lbDay.Text = DateTime.Now.ToLongDateString();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHoaDonQL());
            label1.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCustomer());
            label1.Text = button4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGiftAdmin());
            label1.Text = button6.Text;
        }
    }
}
