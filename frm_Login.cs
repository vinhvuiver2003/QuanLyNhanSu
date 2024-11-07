
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            btn_exit.FlatAppearance.BorderColor = Color.FromArgb(255, 235, 207);
            panel2.BackColor = Color.FromArgb(255, 140, 0);
            label1.ForeColor = Color.FromArgb(92, 84, 84);
            panel1.BackColor = Color.FromArgb(255, 140, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 255);
            txtPass.PasswordChar = '*';
            btn_Signin.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }

        }

    

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = cb_showPass.Checked ? '\0' : '*';

        }
        bool testInput(String x)
        {
            return String.IsNullOrWhiteSpace(x);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (testInput(txtUser.Text))
            {
                MessageBox.Show("Chưa nhập tên đăng nhập", "Thông báo");
                txtUser.Focus();
                return;
            }
            if (testInput(txtPass.Text))
            {
                MessageBox.Show("Chưa nhập mật khẩu", "Thông báo");
                txtPass.Focus();
                return;
            }
            string query = "SELECT * FROM tb_account WHERE ID_nhanvien =@user AND password=@pass";
            try
            {
                KetNoi connection = new KetNoi();
                
                SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@user",SqlDbType.VarChar){Value=txtUser.Text.Trim()},
                new SqlParameter("@pass",SqlDbType.VarChar){Value = txtPass.Text.Trim()}
                };
               
               DataTable dt = connection.ExscutedQuerry(query, parameters);
                if (dt.Rows.Count >= 1)
                {
                    foreach (DataRow dr in dt.Rows) {
                        if (dr["permission"].ToString().Equals("admin"))
                        {
                            frm_admin frm_Admin = new frm_admin();
                            frm_Admin.ShowDialog();
                            this.Close();
                            break;
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai tên tài khoản hoặc mật khẩu");
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi đăng nhập");
            }

        }


    }
    }
