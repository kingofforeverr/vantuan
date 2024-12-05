using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void máyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaculator maytinnh = new frmCaculator();
            //maytinnh.MdiParent = this;
            maytinnh.Show();
            this.Hide();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang kh    = new frmKhachHang();
            kh.Show();
        }
    }
}
