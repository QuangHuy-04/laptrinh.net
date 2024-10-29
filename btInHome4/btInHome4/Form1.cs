using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btInHome4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grbChucNang_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int x=int.Parse(txtNhap.Text);
            lstSo.Items.Add(x);
            txtNhap.Text = "";
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int Tong = 0;
            foreach(int i in lstSo.Items)
            {
                Tong += i;
            }
            MessageBox.Show("tong cua danh sach la:"+Tong);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoaDC_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count == 0)
            {
                lstSo.Items.RemoveAt(0);
               
            }
            else
            {
                lstSo.Items.RemoveAt(0);
                lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
            }
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            while(lstSo.SelectedIndex != -1)
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndex);
            }
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++) {
                Console.WriteLine(lstSo.Items[i]);
                int k = (int)lstSo.Items[i] + 2;
                lstSo.Items[i] = k;
            }
        }

        private void btnBP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                Console.WriteLine(lstSo.Items[i]);
                int k = (int)lstSo.Items[i] * (int)lstSo.Items[i];
                lstSo.Items[i] = k;
            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int k = (int)lstSo.Items[i];
                if(k%2 == 0)
             
                    lstSo.SelectedIndex = i;

            }
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int k = (int)lstSo.Items[i];
                if (k % 2 != 0)

                    lstSo.SelectedIndex = i;

            }
        }
    }
}
