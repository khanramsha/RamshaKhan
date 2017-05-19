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
    public partial class Forma3 : Form
    {
        public Forma3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
             DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo di in d)
            { 
                comboBox2.Items.Add(di.ToString()); 
            }

            }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = comboBox1.Text + comboBox2.Text +"\\"+textBox1.Text;
            if (!File.Exists(path))
            {
                File.Create(path);
                MessageBox.Show("File Is Created");
            }
            else
                MessageBox.Show("File Already Exists");
        }

        private void Form2_Load(object sender, EventArgs e)
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
            MessageBox.Show("THANK U FOR CREATING FILE");
            Application.Exit();
        }

        }

        
}
