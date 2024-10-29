using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt2InHome4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv=new SinhVien();
            sv.Ma=int.Parse(txtMa.Text);
            sv.Ten=txtTen.Text; 
            string s= sv.Ma+" - "+ sv.Ten;
            lstDanhSach.Items.Add(s);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.Clear();
        }
    }
}
