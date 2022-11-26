namespace Fitness_otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        hareketler f2=new hareketler();
        private void button1_Click(object sender, EventArgs e)
        {
            f2.Show();
        }
        BMI_HESAPLA f10 = new BMI_HESAPLA();
        private void button2_Click(object sender, EventArgs e)
        {
            f10.Show();
        }
        kalorihesabý f11 = new kalorihesabý();
        private void button3_Click(object sender, EventArgs e)
        {
            f11.Show();
        }
    }
}