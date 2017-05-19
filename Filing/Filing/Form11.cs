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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("C:\\");
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo di in d) { comboBox2.Items.Add(di.ToString()); 
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = comboBox1.Text + comboBox2.Text + "\\" + textBox1.Text;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("DIRECTORY CREATED");
            }
            else
            {
                MessageBox.Show("DIRECTORY ALREADY EXIST");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forma3 f1 = new Forma3();
            f1.Show();
        }
    }
}
