using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_otomasyon
{
    public partial class BMI_HESAPLA : Form
    {
        public BMI_HESAPLA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kilo;
            Double boy;
            float sonuç;
            kilo = Convert.ToInt32(textBox2.Text);
            boy = Convert.ToDouble(textBox1.Text);
            sonuç = (float)(kilo / (boy * boy));

            if (sonuç < 18)
            {
                label4.Text = "BMI Sonucunuz = " + sonuç + " " + "zayıfsınız sağlıklı bir şekilde kilo almalısınız...";
            }
            else if (sonuç > 18 && sonuç < 25)
            {
                label4.Text = "BMI Sonucunuz = " + sonuç + " " + "İdeal kiloya sahipsiniz...";
            }
            else if (sonuç > 25)
            {
                label4.Text = "BMI Sonucunuz = " + sonuç + " " + "Fazla kilolarınız bulunmaktadır diyete başlamalısınız...";
            }
        }
    }
}
