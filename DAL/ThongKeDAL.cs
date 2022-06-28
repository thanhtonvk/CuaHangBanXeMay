using CuaHangDienThoaiAPI.Utils;
using CuaHangBanXeMay.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanXeMay.DAL
{
    internal class ThongKeDAL
    {
        public List<ThongKeTheoNgay> thongKeTheoNgay()
        {
            string query = "ThongKeTheoNgay";
            List<ThongKeTheoNgay> thongKeTheoNgays = new List<ThongKeTheoNgay>();

            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow dt in table.Rows)
            {
                ThongKeTheoNgay tk = new ThongKeTheoNgay()
                {
                    NgayBan = (DateTime)(dt["NgayBan"]),
                    TongTien = dt["TongTien"] as int? ?? 0
                };
                thongKeTheoNgays.Add(tk);

            }
            return thongKeTheoNgays;
        }
        public List<SanPhamBanChay> sanPhamBanChays()
        {
            string query = "ThongKeSPBanChay";
            List<SanPhamBanChay> sanPhamBanChays = new List<SanPhamBanChay>();
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow dt in table.Rows)
            {
                SanPhamBanChay sanPhamBanChay = new SanPhamBanChay()
                {
                    TenSP = dt["TenSP"] as string,
                    DonGia = dt["DonGia"] as int? ?? 0,
                    SoLuongBan = dt["SoLuongBan"] as int? ??0
                };
                sanPhamBanChays.Add(sanPhamBanChay);
            }
            return sanPhamBanChays;
        }

    }
}
