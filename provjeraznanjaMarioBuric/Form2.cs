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
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Osoba osoba =(new { Ime = textBox1.Text, Prezime = textBox2.Text, OIB = textBox3.Text, phoneNum = dateTimePicker1.Text });
            
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
