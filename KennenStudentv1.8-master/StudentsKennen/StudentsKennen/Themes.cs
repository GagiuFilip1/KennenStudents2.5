using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace StudentsKennen
{
    public partial class Themes : Form
    {
        public Themes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Themes_Load(object sender, EventArgs e)
        {
            timer1.Interval = 8000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form D = new KennenS();
            D.Show();
        }
    }
}
