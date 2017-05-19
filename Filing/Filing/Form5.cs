using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Filing
{
    public partial class Forma5 : Form
    {
        public Forma5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo di in d) { comboBox2.Items.Add(di.ToString()); }
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox3.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo di in d) 
            { 
                comboBox4.Items.Add(di.ToString()); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String spath = comboBox1.Text + comboBox2.Text + "\\" + textBox1.Text;
            string dpath = comboBox3.Text + comboBox4.Text + "\\" + textBox1.Text;
            if (!File.Exists(dpath))
            {
                File.Copy(spath, dpath);
                MessageBox.Show("File Copied!");
            }
            else
                MessageBox.Show("File Already Existed!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forma3 f2 = new Forma3();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
