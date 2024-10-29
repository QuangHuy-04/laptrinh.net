using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InHome3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            bool check = true;
            errorProvider1.Clear();
            if (txtPhone.Text == "")
            {
                errorProvider1.SetError(txtPhone, "ban chua nhap phone;");
                check = false;
            }
            int Tuoi;
            if (int.TryParse(txtTuoi.Text, out Tuoi) == false)
            {
                errorProvider1.SetError(txtTuoi, "sai dinh dang !");
                check = false;
            }
            else {
                if (Tuoi < 17)
                {
                    errorProvider1.SetError(txtTuoi, "tuoi phai luon hon 17 tuoi");
                    check=false;
                }
            }

            if (dtpDate.Value.DayOfWeek == DayOfWeek.Monday) {
                errorProvider1.SetError(dtpDate, "ko dc vao thu 2");
                check=false;
            }
            if (check)
            {
                DialogResult result=MessageBox.Show("ban dang dang ky thanh cong","",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) { 
                    Close();
                }
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
