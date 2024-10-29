using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            if (txtTK.Text == "admin" && txtMK.Text == "12345")
            {
                DialogResult result = MessageBox.Show("dang nhap thanh cong");
            }
            else
            {
                DialogResult result = MessageBox.Show("dang nhap that bai, ban co tiep tuc dang nhap khong",
                "comfirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
                if (result == DialogResult.No) { Close(); }
            }
        }
    }
}
