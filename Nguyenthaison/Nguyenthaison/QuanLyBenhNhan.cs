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
    public partial class QuanLyBenhNhan : Form
    {
        public QuanLyBenhNhan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLyBenhNhan_Load(object sender, EventArgs e)
        {
            QuanLyBenhNhanDataContext db = new QuanLyBenhNhanDataContext();
            var q = db.dichvus.Select(p => p.tendichvu );
            var c = db.benhnhans.Select(k => new { k.hoten });
            comboBox1.ValueMember = "hoten";
            comboBox1.DataSource = c;
            listBox1.DataSource = q;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
