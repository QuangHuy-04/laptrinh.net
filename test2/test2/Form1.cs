using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ban co muon thoat khong",
                "comfirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) { Close(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radVang.Checked = true;
            chkNghieng.Checked = true;
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            lbKQ.Text = txtNhap.Text;
        }

        private void radVang_CheckedChanged(object sender, EventArgs e)
        {
            if (radVang.Checked) {
                lbKQ.ForeColor = radVang.ForeColor;
            }
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                lbKQ.ForeColor = radRed.ForeColor;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                lbKQ.ForeColor = radBlue.ForeColor;
            }
        }

        private void chkDam_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(lbKQ.Font.Name);
            Console.WriteLine(lbKQ.Font.Size);
            lbKQ.Font=new Font(
                lbKQ.Font.Name,
                lbKQ.Font.Size,
                lbKQ.Font.Style ^FontStyle.Bold);
        }

        private void chkNghieng_CheckedChanged(object sender, EventArgs e)
        {
            lbKQ.Font = new Font(
                lbKQ.Font.Name,
                lbKQ.Font.Size,
                lbKQ.Font.Style ^ FontStyle.Italic);
        }

        private void chkchan_CheckedChanged(object sender, EventArgs e)
        {
            lbKQ.Font = new Font(
                lbKQ.Font.Name,
                lbKQ.Font.Size,
                lbKQ.Font.Style ^ FontStyle.Underline);
        }
    }
}
