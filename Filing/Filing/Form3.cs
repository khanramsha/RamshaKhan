using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Filing
{
    public partial class Forma4 : Form
    {
        public Forma4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = comboBox1.Text + comboBox2.Text + "\\" + textBox1.Text + "." + textBox2.Text;
            if (File.Exists(path))
            {
                MessageBox.Show("File exists!");
            }
            else
                MessageBox.Show("File does not exist!");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] Folder = dir.GetDirectories();
            comboBox2.DataSource = Folder;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;
          
            comboBox1.Items.Add("C:\\");
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");

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
