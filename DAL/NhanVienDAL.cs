using System.Collections.Generic;
using System.Data;
using System.Linq;
using CuaHangDienThoaiAPI.Utils;
using Entity;
using CuaHangBanXeMay.DAL.InterfaceService;
using CuaHangBanXeMay.Models;

namespace CuaHangBanXeMay.DAL
{
    public class NhanVienDAL : INhanVienDAL
    {
      

        public int Add(NhanVien nhanVien)
        {
            string query =
                $"insert into NhanVien(TenNV,DiaChi,SDT) values(N'{nhanVien.TenNV}',N'{nhanVien.DiaChi}','{nhanVien.SDT}')";
            return DBHelper.NonQuery(query, null);
        }

        public int Update(NhanVien nhanVien)
        {
            string query =
                $"update NhanVien set TenNV = N'{nhanVien.TenNV}',DiaChi = N'{nhanVien.DiaChi}',SDT = N'{nhanVien.SDT}' where MaNV = {nhanVien.MaNV}";
            return DBHelper.NonQuery(query, null);
        }

        public int Delete(int id)
        {
            string query = $"delete from NhanVien where MaNV = {id}";
            return DBHelper.NonQuery(query, null);
        }

        public List<NhanVien> GetAll()
        {
            List<NhanVien> nhanVienList = new List<NhanVien>();
            string query = "select * from NhanVien";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                NhanVien nhanVien = new NhanVien()
                {
                    DiaChi = row["DiaChi"] as string,
                    MaNV = row["MaNV"] as int? ?? 0,
                    SDT = row["SDT"] as string,
                    TenNV = row["TenNV"] as string
                };
                nhanVienList.Add(nhanVien);
            }

            return nhanVienList;
        }

        public NhanVien GetNhanVien(int id)
        {
            NhanVien nhanVien = null;
            string query = $"select * from NhanVien where MaNV = {id}";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                nhanVien = new NhanVien()
                {
                    DiaChi = row["DiaChi"] as string,
                    MaNV = row["MaNV"] as int? ?? 0,
                    SDT = row["SDT"] as string,
                    TenNV = row["TenNV"] as string
                };
            }

            return nhanVien;
        }
    }
}