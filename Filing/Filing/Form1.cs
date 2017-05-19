using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filing
{
    public partial class Forma3 : Form
    {
        public Forma3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forma3 f2 = new Forma3();
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Forma4 f3 = new Forma4();
            f3.Show();
            this.Hide();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forma4 f4 = new Forma4();
            f4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forma5 f5 = new Forma5();
            f5.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;
            this.button1.FlatStyle = FlatStyle.Popup;
            this.button1.BackColor = Color.LightSlateGray;
            this.button1.ForeColor = Color.White;

            this.button2.FlatStyle = FlatStyle.Popup;
            this.button2.BackColor = Color.LightSlateGray;
            this.button2.ForeColor = Color.White;


            this.button6.FlatStyle = FlatStyle.Popup;
            this.button6.BackColor = Color.LightSlateGray;
            this.button6.ForeColor = Color.White;
        
            this.button3.FlatStyle = FlatStyle.Popup;
            this.button3.BackColor = Color.LightSlateGray;
            this.button3.ForeColor = Color.White;

            this.button4.FlatStyle = FlatStyle.Popup;
            this.button4.BackColor = Color.LightSlateGray;
            this.button4.ForeColor = Color.White;

            this.button5.FlatStyle = FlatStyle.Popup;
            this.button5.BackColor = Color.LightSlateGray;
            this.button5.ForeColor = Color.White;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Forma6 f6 = new Forma6();
            f6.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
