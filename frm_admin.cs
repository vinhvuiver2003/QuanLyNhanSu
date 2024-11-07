using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class frm_admin : Form
    {
        frm_employeeList form2;
        public frm_admin()
        {
            InitializeComponent();
        }
        private bool sideBarExpand;
        private Button curButton;
        private void siteBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand) {
                sideBar.Width -= 10;
               
                if (sideBar.Width == sideBar.MinimumSize.Width)
                { 
                sideBarExpand = false;
                    siteBarTimer.Stop();
                }

            }
            else
            {
                sideBar.Width += 10;
               
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    siteBarTimer.Stop();
                }
            }
        }
        private void ActButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (curButton != (Button)btnSender)
                {
                    DisableButton();
                    curButton = (Button)btnSender;
                    curButton.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                }
            }
                
        }

        private void DisableButton()
        {
            foreach (Control preButton in sideBar.Controls)
            {
                if (preButton.GetType() == typeof(Button)) {

                    preButton.Font= new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            siteBarTimer.Start();
        }

        private void btn_qlnv_Click(object sender, EventArgs e)
        {
            ActButton(sender);
            form2 = new frm_employeeList();
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None; // Không hiển thị viền của Form2
            form2.Dock = DockStyle.Fill;
            panel2.Controls.Add(form2);
            form2.Show();

        }

        private void btn_qlcv_Click(object sender, EventArgs e)
        {
            ActButton(sender);
            form2.Close();

        }

        private void btn_qlpb_Click(object sender, EventArgs e)
        {
            ActButton(sender);
        }

        private void btn_qlluong_Click(object sender, EventArgs e)
        {
            ActButton(sender);
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            ActButton(sender);

        }

        private void btn_chamcong_Click(object sender, EventArgs e)
        {
            ActButton(sender);
        }

        private void menuButton_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, menuButton.Width, menuButton.Height);
            menuButton.Region = new Region(path);


        }

        private void frm_admin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
