using CuaHangBanXeMay.BLL;
using CuaHangBanXeMay.BLL.InterfaceService;
using CuaHangBanXeMay.Models;
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
    public partial class AdminFrm : Form
    {
        public AdminFrm()
        {
            InitializeComponent();
        }
        ITaiKhoanBLL bll = new TaiKhoanBLL();
        INhanVienBLL nhanVienBLL = new NhanVienBLL();

        private void AdminFrm_Load(object sender, EventArgs e)
        {
            dgv_taikhoan.DataSource = bll.GetAll("");
            dgv_taikhoan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_taikhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            dgv_nv.DataSource = nhanVienBLL.GetAll("");
            dgv_nv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_nv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan()
            {
                TenDangNhap = tb_tendangnhap.Text.Trim(),
                MatKhau = tb_matkhau.Text.Trim(),
                LoaiTK = tb_loaitk.Text.Trim()
            };
            string rs = bll.Add(taiKhoan);
            MessageBox.Show(rs);
            dgv_taikhoan.DataSource = bll.GetAll("");
        }

        private void dgv_taikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_taikhoan.SelectedRows)
            {
                tb_tendangnhap.Text = row.Cells[0].Value.ToString();
                tb_matkhau.Text = row.Cells[1].Value.ToString();
                tb_loaitk.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan()
            {
                TenDangNhap = tb_tendangnhap.Text.Trim(),
                MatKhau = tb_matkhau.Text.Trim(),
                LoaiTK = tb_loaitk.Text.Trim()
            };
            string rs = bll.Update(taiKhoan);
            MessageBox.Show(rs);
            dgv_taikhoan.DataSource = bll.GetAll("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string rs = bll.Delete(tb_tendangnhap.Text.Trim());
            MessageBox.Show(rs);
            dgv_taikhoan.DataSource = bll.GetAll("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgv_taikhoan.DataSource = bll.GetAll(tb_tim_tk.Text.Trim());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien()
            {
                TenNV = tb_tennv.Text.Trim(),
                DiaChi = tb_diachi.Text.Trim(),
                SDT = tb_sdt.Text.Trim()
            };
            string rs = nhanVienBLL.Add(nhanVien);
            MessageBox.Show(rs);
            dgv_nv.DataSource = nhanVienBLL.GetAll("");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien()
            {
                MaNV = int.Parse(lb_manv.Text.Trim()),
                TenNV = tb_tennv.Text.Trim(),
                DiaChi = tb_diachi.Text.Trim(),
                SDT = tb_sdt.Text.Trim()
            };
            string rs = nhanVienBLL.Update(nhanVien);
            MessageBox.Show(rs);
            dgv_nv.DataSource = nhanVienBLL.GetAll("");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string rs = nhanVienBLL.Delete(int.Parse(lb_manv.Text.Trim()));
            MessageBox.Show(rs);
            dgv_nv.DataSource = nhanVienBLL.GetAll("");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgv_nv.DataSource = nhanVienBLL.GetAll(tb_tk_nv.Text);
        }

        private void dgv_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_nv.SelectedRows)
            {
                lb_manv.Text = row.Cells[0].Value.ToString();
                tb_tennv.Text = row.Cells[1].Value.ToString();
                tb_diachi.Text = row.Cells[3].Value.ToString();
                tb_sdt.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
