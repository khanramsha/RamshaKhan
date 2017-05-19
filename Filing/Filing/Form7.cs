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
    public partial class Forma7 : Form
    {
        public Forma7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fpath = comboBox1.Text + comboBox2.Text;
            StreamReader Sr = new StreamReader(fpath);
            textBox1.Text = Sr.ReadToEnd();
            Sr.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("C:\\");
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo fi = new DirectoryInfo(comboBox1.Text);
            FileInfo[] files = fi.GetFiles();
            foreach (FileInfo f in files) 
            { 
                comboBox2.Items.Add(f.ToString());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
