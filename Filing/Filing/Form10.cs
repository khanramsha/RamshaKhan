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
    public partial class Forma10 : Form
    {
        public Forma10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fpath = comboBox1.Text + "/" + textBox1.Text;

            if (!File.Exists(fpath))
            {
                byte[] b = new byte[100];
                char[] c = new char[100];
                FileStream fs = new FileStream(fpath, FileMode.OpenOrCreate);
                c = textBox2.Text.ToCharArray();
                Encoder en = Encoding.UTF8.GetEncoder();
                en.GetBytes(c, 0, c.Length, b, 0, true);
                fs.Write(b, 0, b.Length);
                MessageBox.Show("FILE CREATED");
            }
            else
            {
                MessageBox.Show("FILE ALREADY EXIST");
            }

            
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("C:\\");
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////DirectoryInfo fi = new DirectoryInfo(comboBox1.Text);
            //FileInfo[] files = fi.GetFiles();
            //foreach (FileInfo f in files)
            //{
            //    comboBox2.Items.Add(f.ToString());
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
