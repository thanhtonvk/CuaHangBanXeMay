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
    internal class HoaDonBanDAL : IHoaDonBanDAL
    {
        public int Add(HoaDonBan hoaDonBan)
        {
            string query =
                $"insert into HoaDonBan(NgayBan,TenKhach,SDT,DiaChi,MaNV) values('{hoaDonBan.NgayBan.Value.ToString("yyyy/MM/dd")}',N'{hoaDonBan.TenKhach}','{hoaDonBan.SDT}',N'{hoaDonBan.DiaChi}',{hoaDonBan.MaNV})";
           
            return DBHelper.NonQuery(query, null);
        }

        public int Delete(int id)
        {
            string query = $"delete from HoaDonBan where MaHD = {id}";
            return DBHelper.NonQuery(query, null);
        }

        public List<GetHoaDonBan_Result> GetAll()
        {
            string query = "GetHoaDonBan";
            List<GetHoaDonBan_Result> hoaDonBanResults = new List<GetHoaDonBan_Result>();
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                GetHoaDonBan_Result hoaDonBanResult = new GetHoaDonBan_Result()
                {
                    DiaChi = row["DiaChi"] as string,
                    MaHD = row["MaHD"] as int? ?? 0,
                    NgayBan = row["NgayBan"] as DateTime?,
                    SDT = row["SDT"] as string,
                    TenKhach = row["TenKhach"] as string,
                    TenNV = row["TenNV"] as string,
                    Tổng_tiền = row["Tổng tiền"] as int?
                };
                hoaDonBanResults.Add(hoaDonBanResult);
            }

            return hoaDonBanResults;
        }

        public HoaDonBan GetHoaDonBan(int id)
        {
            HoaDonBan hoaDonBan = null;
            string query = $"select * from HoaDonBan where MaHD = {id}";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                hoaDonBan = new HoaDonBan()
                {
                    DiaChi = row["DiaChi"] as string,
                    MaHD = row["MaHD"] as int? ?? 0,
                    MaNV = row["MaNV"] as int? ?? 0,
                    NgayBan = row["NgayBan"] as DateTime?,
                    SDT = row["SDT"] as string,
                    TenKhach = row["TenKhach"] as string,
                    TongTien = row["Tongtien"] as int? ?? 0
                };
            }

            return hoaDonBan;
        }

        public int Update(HoaDonBan hoaDonBan)
        {
            string query =
                $"update HoaDonBan set DiaChi = N'{hoaDonBan.DiaChi}',MaNV = {hoaDonBan.MaNV}, NgayBan = '{hoaDonBan.NgayBan.Value.ToString("yyyy/MM/dd")}',SDT = '{hoaDonBan.SDT}',TenKhach = N'{hoaDonBan.TenKhach}'";
            return DBHelper.NonQuery(query, null);
        }
        public int GetLast()
        {
            int id = -1;
            string query = $"select * from HoaDonBan where MaHD =  (select max(MaHD) from HoaDonBan)";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                id = int.Parse(row["MaHD"].ToString());
            }
            return id;
        }
    }
}