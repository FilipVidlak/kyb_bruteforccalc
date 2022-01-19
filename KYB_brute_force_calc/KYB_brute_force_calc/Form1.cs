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
            try
            {
                label4.Text = "";
                int pocetznaku = Int32.Parse(textBox1.Text);
                int pocetpokusu = Int32.Parse(textBox2.Text);
                double kombinace = 0;
                double year = 0, month = 0, day = 0, hour = 0, min = 0, second = 0;
                if (checkBox1.Checked == true)
                {
                    kombinace += 26;
                }
                if (checkBox2.Checked == true)
                {
                    kombinace += 26;
                }
                if (checkBox3.Checked == true)
                {
                    kombinace += 10;
                }
                if (checkBox4.Checked == true)
                {
                    kombinace += 33;
                }
                kombinace = Math.Round(Math.Pow(kombinace, pocetznaku) / pocetpokusu);
                if (kombinace >= 60) { min = Math.Floor(kombinace / 60); kombinace -= min * 60; second = kombinace; }
                if (min >= 60) { hour = Math.Floor(min / 60); min -= hour * 60; }
                if (hour >= 24) { day = Math.Floor(hour / 60); hour -= day * 60; }
                if (day >= 30) { month = Math.Floor(day / 60); day -= month * 60; }
                if (month >= 12) { year = Math.Floor(month / 60); month -= year * 60; }
                if (year >= 10000) { label4.Text = "Nikdy nerozluštíš prostě, i kvantovej počítač je na to krátkej"; }
                else
                {
                    label4.Text = year.ToString() + " rok/y/ů " + month.ToString() + " měsíc/e/ů " + hour.ToString() + " hodin/a/y " + min.ToString() + " minut/a/y " + second.ToString() + " vteřin/a/y ";
                }
            } 
            catch
            {
                MessageBox.Show("Nezadal jsi žádnou hodnotu nebo jsi zadal špatnou hodnotu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            foreach (Control objekt in this.Controls)
            {
                if (objekt is CheckBox)
                {
                    (objekt as CheckBox).Checked = false;
                }
            }
        }
    }
}
