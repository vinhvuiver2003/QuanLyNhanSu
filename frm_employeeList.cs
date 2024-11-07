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
    public partial class frm_employeeList : Form
    {
        public frm_employeeList()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_employeeList_Load(object sender, EventArgs e)
        {
            KetNoi ketNoi = new KetNoi();
            String query = "Select * from tb_nhanvien JOIN tb_chucvu on tb_nhanvien.ID_chucvu = tb_chucvu.ID_chucvu Join tb_phongban on tb_phongban.ID_phongban=tb_nhanvien.ID_phongban";
            DataTable dt = new DataTable();
            dt = ketNoi.ExscutedQuerry(query, null);
            dataGridView1.DataSource = dt;
        }
    }
}
