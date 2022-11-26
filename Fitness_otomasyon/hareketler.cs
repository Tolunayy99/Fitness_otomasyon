using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_otomasyon
{
    public partial class hareketler : Form
    {
        public hareketler()
        {
            InitializeComponent();
        }

        
        gogushareketi f3= new gogushareketi();
        private void button1_Click(object sender, EventArgs e)
        {
            f3.Show();
        }
        bacakhareketi f4= new bacakhareketi();
        private void button6_Click(object sender, EventArgs e)
        {
            f4.Show();
        }
        sırthareketi f5=new sırthareketi();
        private void button4_Click(object sender, EventArgs e)
        {
            f5.Show();
        }
        bicepshareketi f6=new bicepshareketi(); 
        private void button3_Click(object sender, EventArgs e)
        {
            f6.Show();
        }
        arkakolhareketi f7=new arkakolhareketi();
        private void button2_Click(object sender, EventArgs e)
        {
            f7.Show();
        }
        omuzhareketi f8= new omuzhareketi();    
        private void button5_Click(object sender, EventArgs e)
        {
            f8.Show();
        }
    }
}
