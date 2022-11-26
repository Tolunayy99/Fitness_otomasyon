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
    public partial class kalorihesabı : Form
    {
        public kalorihesabı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kilo, boy, yaş;
            ;
            float sonuç,bmh;
            boy = Convert.ToInt32(textBox1.Text);
            kilo = Convert.ToInt32(textBox2.Text);
            yaş= Convert.ToInt32(textBox3.Text);


            if (radioButton3.Checked == true)
            {

                if (radioButton1.Checked == true)
                {
                    //erkek için
                    bmh = (float)((10 * kilo) + (6.25 * boy) - (5 * yaş) + 5);
                    sonuç = (float)(bmh * 1.2);
                    label5.Text = "Günlük kalori ihtiyacınız = " + sonuç;
                }
                else 
                {
                    //kadın için
                    bmh = (float)((10 * kilo) + (6.25 * boy) - (5 * yaş) - 161);
                    sonuç = (float)(bmh * 1.2);
                    label5.Text = "Günlük kalori ihtiyacınız = " + sonuç;
                }
            }
             else if(radioButton4.Checked== true)
            {
                if (radioButton1.Checked == true)
                {
                    //erkek için
                    bmh = (float)((10 * kilo) + (6.25 * boy) - (5 * yaş) + 5);
                    sonuç = (float)(bmh * 1.6);
                    label5.Text = "Günlük kalori ihtiyacınız = " + sonuç;
                }
                else if (radioButton2.Checked == true)
                {
                    //kadın için
                    bmh = (float)((10 * kilo) + (6.25 * boy) - (5 * yaş) - 161);
                    sonuç = (float)(bmh * 1.55);
                    label5.Text = "Günlük kalori ihtiyacınız = " + sonuç;
                }
            }
            else if(radioButton5.Checked== true)
            {
                if (radioButton1.Checked == true)
                {
                    //erkek için
                    bmh = (float)((10 * kilo) + (6.25 * boy) - (5 * yaş) + 5);
                    sonuç = (float)(bmh * 1.8);
                    label5.Text = "Günlük kalori ihtiyacınız = " + sonuç;
                }
                else if (radioButton2.Checked ==true)
                {
                    //kadın için
                    bmh = (float)((10 * kilo) + (6.25 * boy) - (5 * yaş) - 161);
                    sonuç = (float)(bmh * 1.8);
                    label5.Text = "Günlük kalori ihtiyacınız = " + sonuç;
                }
            }
            
        }

      
    }
}
