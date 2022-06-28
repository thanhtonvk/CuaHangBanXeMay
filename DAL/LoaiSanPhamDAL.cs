using System.Collections.Generic;
using System.Data;
using System.Linq;
using CuaHangDienThoaiAPI.Utils;
using Entity;
using CuaHangBanXeMay.DAL.InterfaceService;
using CuaHangBanXeMay.Models;

namespace CuaHangBanXeMay.DAL
{
    public class LoaiSanPhamDAL : ILoaiSanPhamDAL
    {
      

        public int Add(LoaiSanPham loaiSanPham)
        {
            string query =
                $"insert into LoaiSanPham(TenLoai) values(N'{loaiSanPham.TenLoai}')";
            return DBHelper.NonQuery(query, null);
        }

        public int Update(LoaiSanPham loaiSanPham)
        {
            string query =
                $"update LoaiSanPham set TenLoai = N'{loaiSanPham.TenLoai}' where MaLoai = {loaiSanPham.MaLoai}";
            return DBHelper.NonQuery(query, null);
        }

        public int Delete(int id)
        {
            string query = $"delete from LoaiSanPham where MaLoai = {id}";
            return DBHelper.NonQuery(query, null);
        }

        public List<LoaiSanPham> GetAll()
        {
            string query = "select * from LoaiSanPham";
            DataTable table = DBHelper.Query(query, null);
            List<LoaiSanPham> list = new List<LoaiSanPham>();
            foreach (DataRow row in table.Rows)
            {
                LoaiSanPham loaiSanPham = new LoaiSanPham()
                {
                    MaLoai = row["MaLoai"] as int? ?? 0,
                    TenLoai = row["TenLoai"] as string
                };
                list.Add(loaiSanPham);
            }

            return list;
        }

        public LoaiSanPham GetLoaiSanPham(int id)
        {
            string query = $"select * from LoaiSanPham where MaLoai = {id}";
            DataTable table = DBHelper.Query(query, null);
            LoaiSanPham loaiSanPham = null;
            foreach (DataRow row in table.Rows)
            {
                loaiSanPham = new LoaiSanPham()
                {
                    MaLoai = row["MaLoai"] as int? ?? 0,
                    TenLoai = row["TenLoai"] as string
                };
            }

            return loaiSanPham;
        }
    }
}