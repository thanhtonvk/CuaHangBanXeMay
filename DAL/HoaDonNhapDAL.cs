using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CuaHangDienThoaiAPI.Utils;
using Entity;
using CuaHangBanXeMay.DAL.InterfaceService;
using CuaHangBanXeMay.Models;

namespace CuaHangBanXeMay.DAL
{
    public class HoaDonNhapDAL : IHoaDonNhapDAL
    {
        public int Add(HoaDonNhap hoaDonNhap)
        {
            string query =
                $"insert into HoaDonNhap(NgayNhap,MaDL) values ('{hoaDonNhap.NgayNhap.Value.ToString("yyyy/MM/dd")}',{hoaDonNhap.MaDL})";
            return DBHelper.NonQuery(query, null);
        }

        public int Update(HoaDonNhap hoaDonNhap)
        {
            string query =
                $"update HoaDonNhap set NgayNhap ='{hoaDonNhap.NgayNhap.Value.ToString("yyyy/MM/dd")}', MaDL = {hoaDonNhap.MaDL} where MaHD = {hoaDonNhap.MaHD}";
            return DBHelper.NonQuery(query, null);
        }

        public int Delete(int id)
        {
            string query = $"delete from HoaDonNhap where MaHD = {id}";
            return DBHelper.NonQuery(query, null);
        }

        public List<GetHoaDonNhap_Result> GetAll()
        {
            List<GetHoaDonNhap_Result> hoaDonNhapResults = new List<GetHoaDonNhap_Result>();
            string query = "GetHoaDonNhap";
            DataTable dataTable = DBHelper.Query(query, null);
            foreach (DataRow row in dataTable.Rows)
            {
                GetHoaDonNhap_Result hoaDonNhapResult = new GetHoaDonNhap_Result()
                {
                    MaHD = row["MaHD"] as int? ?? 0,
                    NgayNhap = row["NgayNhap"] as DateTime? ?? default,
                    TenDL = row["TenDL"] as string,
                    Tổng_tiền = row["Tổng tiền"] as int? ?? 0
                };
                hoaDonNhapResults.Add(hoaDonNhapResult);
            }

            return hoaDonNhapResults;
        }

        public HoaDonNhap GetHoaDonNhap(int id)
        {
            HoaDonNhap hoaDonNhap = null;
            string query = $"select * from HoaDonNhap where MaHD ={id}";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                hoaDonNhap = new HoaDonNhap()
                {
                    MaDL = row["MaDL"] as int?,
                    MaHD = row["MaHD"] as int? ?? 0,
                    NgayNhap = row["NgayNhap"] as DateTime? ?? default,
                    TongTien = row["TongTien"] as int?
                };
            }

            return hoaDonNhap;
        }
        public int GetLast()
        {
            int id = -1;
            string query = $"select * from HoaDonNhap where MaHD =  (select max(MaHD) from HoaDonNhap)";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                id = int.Parse(row["MaHD"].ToString());
            }
            return id;
        }
    }
}