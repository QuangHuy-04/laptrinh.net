using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void lblKhoa_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbbGioiTInh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ma = int.Parse(txtMa.Text);
            sv.Ten = txtTen.Text;
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.DiaChi = txtDiaChi.Text;
            sv.Email = txtEmail.Text;
            sv.SDT=int.Parse(txtSDT.Text);
            sv.GioiTinh = cboGioiTinh.Text;
            sv.Khoa=cboKhoa.Text;

            string s = sv.Ma + " - " + sv.Ten + " - " +sv.NgaySinh + " - " +sv.DiaChi + " - " +sv.Email + " - " +sv.SDT + " - " +sv.GioiTinh + " - " +sv.Khoa;
            lstDanhSach.Items.Add(s);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            while (lstDanhSach.SelectedIndex != -1)
            {
                lstDanhSach.Items.RemoveAt(lstDanhSach.SelectedIndex);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void lstDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
