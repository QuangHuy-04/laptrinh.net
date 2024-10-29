using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InHome4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstBox.Items.Add("duongsh272k4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=lstBox.Items.Count;
            MessageBox.Show("so phan tu trong list box la:" + a);
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lstBox.Items[0].ToString());
        }

        private void BtnRemoveAt_Click(object sender, EventArgs e)
        {
            lstBox.Items.RemoveAt(0);
        }

        private void butSelectedIndices_Click(object sender, EventArgs e)
        {
            foreach (int i in lstBox.SelectedIndices) {
                Console.WriteLine(i);  
            }
            //dem
            Console.WriteLine(lstBox.SelectedIndices.Count);
        }

        private void btnGan_Click(object sender, EventArgs e)
        {
            lstBox.Items[0] = "phan tu moi";
        }

        private void btnSelectedIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show("index item duoc chon la:"+ lstBox.SelectedIndex);
        }
    }
}
