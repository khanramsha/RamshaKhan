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
    public partial class Forma6 : Form
    {
        public Forma6()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo di in d) { comboBox2.Items.Add(di.ToString()); }
        }
        

        private void Form6_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;
            
            comboBox1.Items.Add("C:\\");
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dpath = comboBox1.Text + comboBox2.Text + "\\" + textBox1.Text;
            if (File.Exists(dpath))
            {

                File.Delete(dpath);
                MessageBox.Show("File has been deleted.");
            }
            else
                MessageBox.Show("File Not Found");
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
