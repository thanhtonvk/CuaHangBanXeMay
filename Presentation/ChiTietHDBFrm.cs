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
    public partial class ChiTietHDBFrm : Form
    {
        public ChiTietHDBFrm()
        {
            InitializeComponent();
        }
        ISanPhamBLL sanPhamBLL = new SanPhamBLL();
        ChiTietHDBBLL chiTietHDBBLL = new ChiTietHDBBLL();
        private void ChiTietHDBFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = chiTietHDBBLL.GetAll(Common.MaHDB);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comboBox1.DataSource = sanPhamBLL.GetAll("");
            comboBox1.DisplayMember = "TenSP";
            comboBox1.ValueMember = "MaSP";
        }
        string masp = "-1";
        private void button1_Click(object sender, EventArgs e)
        {
            ChiTietHDB chiTietHDB = new ChiTietHDB()
            {
                MaHD = Common.MaHDB,
                MaSP = int.Parse(masp),
                SoLuong = int.Parse(textBox1.Text),
                GiaBan = int.Parse(textBox2.Text)
            };
            chiTietHDBBLL.Add(chiTietHDB);
            dataGridView1.DataSource = chiTietHDBBLL.GetAll(Common.MaHDB);

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            masp = cb.SelectedValue.ToString();
            int index = cb.SelectedIndex;
            SanPham sp = sanPhamBLL.GetAll("")[index];
            textBox2.Text = sp.DonGia.ToString();
        }
        int idhd;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                idhd = int.Parse(row.Cells[0].Value.ToString());
                comboBox1.Text = row.Cells[1].Value.ToString();
                textBox1.Text = row.Cells[2].Value.ToString();
                textBox2.Text = row.Cells[3].Value.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chiTietHDBBLL.Delete(idhd);
            dataGridView1.DataSource = chiTietHDBBLL.GetAll(Common.MaHDB);
        }
    }
}
