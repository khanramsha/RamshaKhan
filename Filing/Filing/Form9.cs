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
    public partial class Forma9 : Form
    {
        public Forma9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] b = new byte[100];
            char[] c = new char[100];
            string fname = comboBox1.Text + comboBox2.Text;
            FileStream fs = new FileStream(fname, FileMode.Open);
            fs.Read(b, 0, 99);
            Decoder D = Encoding.UTF8.GetDecoder();
            D.GetChars(b,0,b.Length,c,0);
            string s = new string(c);
            textBox1.Text = s;
                fs.Close();


        }

        private void Form9_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("READING DONE");
            Application.Exit();
        }
    }
}
