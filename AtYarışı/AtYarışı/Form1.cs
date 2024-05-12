using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birsol, ikisol, üçsol;
        Random rast=new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            birsol = pictureBox1.Left;
            ikisol = pictureBox2.Left;
            üçsol = pictureBox3.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birgeniş=pictureBox1.Width;
            int ikigeniş=pictureBox2.Width;
            int üçgeniş= pictureBox3.Width;

            pictureBox1.Left += rast.Next(5, 17);
            pictureBox2.Left += rast.Next(5, 17);
            pictureBox3.Left += rast.Next(5, 17);

            int bitis = label5.Left;
            if (birgeniş + pictureBox1.Left >= bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 Numaralı At Kazandı");
            }
            if (ikigeniş + pictureBox2.Left >= bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 Numaralı At Kazandı");
            }
            if (üçgeniş + pictureBox3.Left >= bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 Numaralı At Kazandı");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
