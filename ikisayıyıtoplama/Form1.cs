namespace ikisayıyıtoplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2;
            int sonuc;

            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);

            sonuc = sayı1 + sayı2;
            txtsonuc.Text = sonuc.ToString();
        }
    }
}
