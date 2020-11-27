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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nguyênTôCungNhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NguyenTo frmNguyenTo = new NguyenTo();
            frmNguyenTo.Show();
        }

        private void quanLyBênhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyBenhNhan frmQuanLy = new QuanLyBenhNhan();
            frmQuanLy.Show();
        }
    }
}
