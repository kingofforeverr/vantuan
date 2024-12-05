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
    public partial class frmCaculator : Form
    {
        public frmCaculator()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            //lấy giá trị số 1
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            //lấy giá trị só 2
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            //cộng
            decimal dKQ = dSo1 + dSo2;
            //hiển thị kết quả

            txtKetQua.Text = dKQ.ToString();
        }

        private void frmCaculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            
        }
    }
}
