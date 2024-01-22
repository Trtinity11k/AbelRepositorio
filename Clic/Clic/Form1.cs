namespace Clic
{
    public partial class Form1 : Form
    {
        int clic = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Botton_Click(object sender, EventArgs e)
        {
            clic++;
            listBox1.Items.Clear();
            listBox1.Items.Add(clic);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            clic = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }
    }
}
