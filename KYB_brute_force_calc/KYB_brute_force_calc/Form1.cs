using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYB_brute_force_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
               int malapismena = 26;
            }
            if (checkBox2.Checked) {
                int velkapismena = 26;
            }
            if (checkBox3.Checked) {
                int cislice = 10;
            }
            if (checkBox4.Checked) {
                int specialznaky = 33;
            }
            int pocetznaku = Int32.Parse(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            foreach(Control objekt in this.Controls) {
                if(objekt is CheckBox) {
                    (objekt as CheckBox).Checked = false;
                }
            }
        }
    }
}
