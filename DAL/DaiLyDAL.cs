using System.Collections.Generic;
using System.Data;
using System.Linq;
using CuaHangDienThoaiAPI.Utils;
using Entity;
using CuaHangBanXeMay.DAL.InterfaceService;
using CuaHangBanXeMay.Models;

namespace CuaHangBanXeMay.DAL
{
    public class DaiLyDAL : IDaiLyDAL
    {
        public int Add(DaiLy daiLy)
        {
            string query =
                $"insert into DaiLy(TenDL,SDT,Diachi) values(N'{daiLy.TenDL}','{daiLy.SDT}','{daiLy.DiaChi}')";
            return DBHelper.NonQuery(query, null);
        }

        public int Update(DaiLy daiLy)
        {
            string query =
                $"update DaiLy set TenDL = N'{daiLy.TenDL}', SDT = '{daiLy.SDT}',DiaChi = N'{daiLy.DiaChi}' where MaDL = {daiLy.MaDL}";
            return DBHelper.NonQuery(query, null);
        }

        public int Delete(int id)
        {
            string query = $"delete from DaiLy where MaDL = {id}";
            return DBHelper.NonQuery(query, null);
        }

        public List<DaiLy> GetAll()
        {
            List<DaiLy> daiLyList = new List<DaiLy>();
            string query = "select * from DaiLy";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                DaiLy daiLy = new DaiLy()
                {
                    DiaChi = row["DiaChi"] as string,
                    MaDL = row["MaDL"] as int? ?? 0,
                    SDT = row["SDT"] as string,
                    TenDL = row["TenDL"] as string
                };
                daiLyList.Add(daiLy);
            }

            return daiLyList;
        }

        public DaiLy GetDaiLy(int id)
        {
            DaiLy daiLy = null;
            string query = "select * from DaiLy";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                daiLy = new DaiLy()
                {
                    DiaChi = row["DiaChi"] as string,
                    MaDL = row["MaDL"] as int? ?? 0,
                    SDT = row["SDT"] as string,
                    TenDL = row["TenDL"] as string
                };
            }

            return daiLy;
        }
    }
}