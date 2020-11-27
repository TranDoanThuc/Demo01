using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nguyenthaison
{
    public partial class NguyenTo : Form
    {
        public NguyenTo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtA.Clear();
            txtB.Text = "";
            txtB.Clear();
            txtKq.Text = "";
            txtKq.Clear();
            txtA.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Boolean kiemTraSonguyenTo(Double n)
        {
            if (n < 2)
            {
                return false;
            }
            else {
                Double can2 = (Double)Math.Sqrt(n);
                for (int i = 0; i < can2; i++)
                {
                    if (n % i == 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            
        }

        public Double UCLN(Double a, Double b) { 
            return b == 0 ? a : UCLN(b, a % b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Double soA = Convert.ToDouble(txtA.Text);
                Double soB = Convert.ToDouble(txtB.Text);
                if (kiemTraSonguyenTo(soA) == true && kiemTraSonguyenTo(soB) == true) {
                    if (UCLN(soA, soB) == 1)
                    {
                        txtKq.Text = soA + " và " + soB + " là số nguyên tố cùng nhau";
                    }
                    else {
                        txtKq.Text = soA + " và " + soB + " không là số nguyên tố cùng nhau";
                    }
                }

            } catch(Exception) {
                MessageBox.Show("Hãy nhập đầy đủ thông tin và đúng định dạng");
            }
        }
    }
}
