using Entity;
using CuaHangBanXeMay.BLL.InterfaceService;
using CuaHangBanXeMay.DAL;
using CuaHangBanXeMay.DAL.InterfaceService;
using CuaHangBanXeMay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanXeMay.BLL
{
    internal class HoaDonBanBLL : IHoaDonBanBLL
    {
        IHoaDonBanDAL dal = new HoaDonBanDAL();
        public string Add(HoaDonBan hoaDonBan)
        {
            int rs = dal.Add(hoaDonBan);
            if (rs > 0) return "Thành công";
            return "Thất bại";
        }

        public string Delete(int id)
        {
            int rs = dal.Delete(id);
            if (rs > 0) return "Thành công";
            return "Thất bại";
        }

        public List<GetHoaDonBan_Result> GetAll(string TimKiem)
        {
            if (string.IsNullOrEmpty(TimKiem))
            {
                return dal.GetAll();
            }
            return dal.GetAll().Where(
                 x => x.TenKhach.ToLower().Contains(TimKiem.ToLower())
             || x.DiaChi.ToLower().Contains(TimKiem.ToLower())
             || x.SDT.Contains(TimKiem.ToLower()) ||
             x.TenNV.ToLower().Contains(TimKiem.ToLower())).ToList();
        }

        public HoaDonBan GetHoaDonBan(int id)
        {
            return dal.GetHoaDonBan(id);
        }

        public string Update(HoaDonBan hoaDonBan)
        {
            int rs = dal.Update(hoaDonBan);
            if (rs > 0) return "Thành công";
            return "Thất bại";
        }
    }
}
