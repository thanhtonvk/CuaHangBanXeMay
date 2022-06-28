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
    internal class ChiTietHDNDAL : IChiTietHDNDAL
    {
        public int Add(ChiTietHDN chiTietHoaDonNhap)
        {
            string query =
                $"insert into ChiTietHDN(MaHD,MaSP,GiaNhap,SoLuong) values({chiTietHoaDonNhap.MaHD},{chiTietHoaDonNhap.MaSP},{chiTietHoaDonNhap.GiaNhap},{chiTietHoaDonNhap.SoLuong})";
            return DBHelper.NonQuery(query, null);
        }

        public int Delete(int id)
        {
            string query = $"delete from ChiTietHDN where ID = {id}";
            return DBHelper.NonQuery(query, null);
        }

        public List<GetChiTietHoaDonNhap_Result> GetAll(int idHDN)
        {
            string query = $"GetChiTietHoaDonNhap {idHDN}";
            DataTable table = DBHelper.Query(query, null);
            List<GetChiTietHoaDonNhap_Result> chiTietHoaDonNhapResults = new List<GetChiTietHoaDonNhap_Result>();
            foreach (DataRow row in table.Rows)
            {
                GetChiTietHoaDonNhap_Result chiTietHoaDonNhapResult = new GetChiTietHoaDonNhap_Result()
                {
                    ID = row["ID"] as int? ?? 0,
                    GiaNhap = row["GiaNhap"] as int? ?? 0,
                    MaSP = row["MaSP"] as int? ?? 0,
                    SoLuong = row["SoLuong"] as int? ?? 0,
                    Thành_tiền = row["Thành tiền"] as int?
                };
                chiTietHoaDonNhapResults.Add(chiTietHoaDonNhapResult);
            }

            return chiTietHoaDonNhapResults;
        }


        public ChiTietHDN GetCTHDN(int id)
        {
            string query = $"select * from ChiTietHDN where ID = {id}";
            DataTable table = DBHelper.Query(query, null);
            ChiTietHDN ccTietHdn = null;
            foreach (DataRow row in table.Rows)
            {
                ccTietHdn = new ChiTietHDN()
                {
                    GiaNhap = row["GiaNhap"] as int? ?? 0,
                    ID = row["ID"] as int? ?? 0,
                    MaHD = row["MaHD"] as int? ?? 0,
                    MaSP = row["MaSP"] as int? ?? 0,
                    SoLuong = row["SoLuong"] as int? ?? 0,
                    ThanhTien = row["ThanhTien"] as int? ?? 0
                };
            }

            return ccTietHdn;
        }
    }
}