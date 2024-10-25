using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class frm_splash : Form
    {
        public frm_splash()
        {
            InitializeComponent();
        }

        private void frm_splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int countTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            countTime += 1;
            if (countTime >= 50)
            {
                timer1.Stop();
                frm_Login frm_Login = new frm_Login();
                this.Hide();
                frm_Login.Show();
            }
        }
    }
}
