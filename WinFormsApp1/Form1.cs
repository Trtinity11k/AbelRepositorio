using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int clic = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            clic++;
            listBox1.Items.Clear();
            listBox1.Items.Add(clic);



        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
