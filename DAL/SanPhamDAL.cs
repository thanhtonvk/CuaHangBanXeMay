using CuaHangBanXeMay.DAL.InterfaceService;
using CuaHangBanXeMay.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuaHangDienThoaiAPI.Utils;
using Entity;

namespace CuaHangBanXeMay.DAL
{
    internal class SanPhamDAL : ISanPhamDAL
    {
       

        public int Add(SanPham sanPham)
        {
            string query =
                $"insert into SanPham(TenSP,MaLoai,NgaySX,ThongSoKyThuat,SoLo,DonGia) values(N'{sanPham.TenSP}',{sanPham.MaLoai},'{sanPham.NgaySX.Value.ToString("yyyy/MM/dd")}','{sanPham.ThongSoKyThuat}',{sanPham.SoLo},{sanPham.DonGia})";
            return DBHelper.NonQuery(query, null);
        }

        public int Update(SanPham sanPham)
        {
            string query =
                $"update SanPham set TenSP = N'{sanPham.TenSP}',MaLoai = {sanPham.MaLoai},NgaySX = '{sanPham.NgaySX.Value.ToString("yyyy/MM/dd")}',ThongSoKyThuat = '{sanPham.ThongSoKyThuat}',SoLo = '{sanPham.SoLo}',DonGia = '{sanPham.DonGia}' where MaSP ={sanPham.MaSP}";
            return DBHelper.NonQuery(query, null);
        }

        public int Delete(int id)
        {
            string query = $"delete from SanPham where MaSP = {id}";
            return DBHelper.NonQuery(query, null);
        }

        public List<SanPham> GetAll()
        {
            List<SanPham> sanPhamList = new List<SanPham>();
            string query = "select * from SanPham";
            DataTable dataTable = DBHelper.Query(query, null);
            foreach (DataRow row in dataTable.Rows)
            {
                SanPham sanPham = new SanPham()
                {
                    DonGia = row["DonGia"] as int?,
                    ThongSoKyThuat = row["ThongSoKyThuat"] as string,
                    MaLoai = row["MaLoai"] as int? ?? 0,
                    MaSP = row["MaSP"] as int? ?? 0,
                    NgaySX = row["NgaySX"] as DateTime?,
                    SoLo = row["SoLo"] as int?,
                    TenSP = row["TenSP"] as string
                };
                sanPhamList.Add(sanPham);
            }

            return sanPhamList;
        }

        public SanPham GetSanPham(int id)
        {
            SanPham sanPham = null;
            string query = $"select * from SanPham where MaSP = {id}";
            DataTable dataTable = DBHelper.Query(query, null);
            foreach (DataRow row in dataTable.Rows)
            {
                sanPham = new SanPham()
                {
                    DonGia = row["DonGia"] as int?,
                    ThongSoKyThuat = row["ThongSoKyThuat"] as string,
                    MaLoai = row["MaLoai"] as int? ?? 0,
                    MaSP = row["MaSP"] as int? ?? 0,
                    NgaySX = row["NgaySX"] as DateTime?,
                    SoLo = row["SoLo"] as int?,
                    TenSP = row["TenSP"] as string
                };
            }

            return sanPham;
        }
    }
}