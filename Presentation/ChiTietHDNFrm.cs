using CuaHangBanXeMay.BLL;
using CuaHangBanXeMay.BLL.InterfaceService;
using CuaHangBanXeMay.Models;
using CuaHangBanXeMay.Utils;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangBanXeMay.Presentation
{
    public partial class ChiTietHDNFrm : Form
    {
        public ChiTietHDNFrm()
        {
            InitializeComponent();
        }
        IChiTietHDNBLL chiTietHDNBLL = new ChiTietHDNBLL();
        private void button1_Click(object sender, EventArgs e)
        {
            string masp = textBox1.Text;
            int giaban = int.Parse(textBox2.Text);
            int soluong = int.Parse(textBox3.Text);
            ChiTietHDN chiTietHDN = new ChiTietHDN()
            {
                MaHD = Common.MaHDN,
                MaSP = int.Parse(masp),
                GiaNhap= giaban,
                SoLuong= soluong,
            };
            string rs = chiTietHDNBLL.Add(chiTietHDN);
            MessageBox.Show(rs);
            dataGridView1.DataSource = chiTietHDNBLL.GetAll(Common.MaHDN);
        }

        private void ChiTietHDNFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = chiTietHDNBLL.GetAll(Common.MaHDN);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mahd = int.Parse(label5.Text);
            chiTietHDNBLL.Delete(mahd);
            dataGridView1.DataSource = chiTietHDNBLL.GetAll(Common.MaHDN);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                label5.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();

            }
        }
    }
}
