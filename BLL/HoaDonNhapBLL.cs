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
    internal class HoaDonNhapBLL:IHoaDonNhapBLL
    {

        IHoaDonNhapDAL dal = new HoaDonNhapDAL();
        public string Add(HoaDonNhap hoaDonNhap)
        {
            int rs = dal.Add(hoaDonNhap);
            if (rs > 0) return "Thành công";
            return "Thất bại";
        }

        public string Delete(int id)
        {
            int rs = dal.Delete(id);
            if (rs > 0) return "Thành công";
            return "Thất bại";
        }

        public string Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<GetHoaDonNhap_Result> GetAll(string TimKiem)
        {
            if (string.IsNullOrEmpty(TimKiem))
            {
                return dal.GetAll();
            }
            return dal.GetAll().Where(
                 x => x.TenDL.ToLower().Contains(TimKiem.ToLower())
             || x.NgayNhap.ToString().ToLower().Contains(TimKiem.ToLower())).ToList();
        }

        public HoaDonNhap GetHoaDonNhap(int id)
        {
            return dal.GetHoaDonNhap(id);
        }

        public string Update(HoaDonNhap hoaDonNhap)
        {
            int rs = dal.Update(hoaDonNhap);
            if (rs > 0) return "Thành công";
            return "Thất bại";
        }

    }
}
