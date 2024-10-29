namespace buoi10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbA_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tong;
            Console.WriteLine(txtA.Text);
            Console.WriteLine(txtB.Text);
            tong = int.Parse(txtA.Text) + int.Parse(txtB.Text);
            txtC.Text = txtA.Text + " + " + txtB.Text + " = " + tong + " ";
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            //ctrl+k+c && ctrl+K+U
            //DialogResult DR = MessageBox.Show(
            //    "ban co chac chac muon thoat?",
            //    "thoat",
            //    MessageBoxButtons.YesNo);
            //if (DR == DialogResult.Yes)
            //{
            //    Close();
            //}
            ////else if (DR == DialogResult.No)
            ////{
            ////    MessageBox.Show(
            ////    "vay thi tiep tuc dung"
            ////);
            ////}
        }

        private void lbC_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("ban co chac muon reset",
                "confirm",
                MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                txtA.Text = "";
                txtB.Text = "";
                txtC.Text = "";
            }

        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "testsssssssssssss",
                "thong bao",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information
            );
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult DR = MessageBox.Show("ban co chac muon thoat khong",
                "confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (DR == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
