using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provjeraznanjaMarioBuric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUnesi_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
