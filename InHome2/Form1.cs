namespace InHome2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (chkAn.Checked == true)
                Console.WriteLine("co thích an");
            else
                Console.WriteLine("thich ăn không check");
            if (chkNghi.Checked)
            {
                Console.WriteLine("yeu");
            }
        }

        private void chkAn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(chkAn.Checked == true)
            { Console.WriteLine("thich ăn không check");
            Console.ReadLine();
                }
        }
    }
}
