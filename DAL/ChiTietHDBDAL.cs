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
    internal class ChiTietHDBDAL : IChiTietHDBDAL
    {
       
        public int Add(ChiTietHDB chiTietHDB)
        {
            string querry =
                $"insert into ChiTietHDB(MaHD,MaSP,GiaBan,SoLuong) values({chiTietHDB.MaHD},{chiTietHDB.MaSP},{chiTietHDB.GiaBan},{chiTietHDB.SoLuong})";
            return DBHelper.NonQuery(querry, null);
        }

        public int Delete(int id)
        {
            string query = $"delete from ChiTietHDB where id = {id}";
            return DBHelper.NonQuery(query, null);
        }

        public List<getChiTietHoaDonBan_Result> GetAll(int idHDB)
        {
            string query = $"getChiTietHoaDonBan {idHDB}";
            List<getChiTietHoaDonBan_Result> chiTietHoaDonBanResults = new List<getChiTietHoaDonBan_Result>();
            DataTable table = DBHelper.Query(query, null);
            getChiTietHoaDonBan_Result ctx = null;
            foreach (DataRow row in table.Rows)
            {
                ctx = new getChiTietHoaDonBan_Result()
                {
                    GiaBan = row["GiaBan"] as int?,
                    ID = row["ID"] as int? ?? 0,
                    SoLuong = row["SoLuong"] as int? ?? 0,
                    TenSP = row["TenSP"] as string,
                    Thành_tiền = row["Thành tiền"] as int? ?? 0
                };
                chiTietHoaDonBanResults.Add(ctx);
            }

            return chiTietHoaDonBanResults;
        }

        public ChiTietHDB GetChiTietHDB(int id)
        {
            string query = $"select * from ChiTietHDB where ID = {id}";
            DataTable table = DBHelper.Query(query, null);
            ChiTietHDB ctx = null;
            foreach (DataRow row in table.Rows)
            {
                ctx = new ChiTietHDB()
                {
                    GiaBan = row["GiaBan"] as int?,
                    ID = row["ID"] as int? ?? 0,
                    MaHD = row["MaHD"] as int? ?? 0,
                    MaSP = row["MaSP"] as int? ?? 0,
                    SoLuong = row["SoLuong"] as int?,
                    ThanhTien = row["ThanhTien"] as int?
                };
            }

            return ctx;
        }
    }
}