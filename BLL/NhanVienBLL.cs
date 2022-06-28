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
    internal class NhanVienBLL:INhanVienBLL
    {
        INhanVienDAL dal = new NhanVienDAL();

        public string Add(NhanVien nhanVien)
        {
            int rs = dal.Add(nhanVien);
            if (rs > 0) return "Thành công";
            return "Thất bại";
        }

        public string Delete(int id)
        {
            int rs = dal.Delete(id);
            if (rs > 0) return "Thành công";
            return "Thất bại"; ;
        }

        public List<NhanVien> GetAll(string TimKiem)
        {
            if (string.IsNullOrEmpty(TimKiem))
            {
                return dal.GetAll();
            }
            return dal.GetAll().Where(
                x => x.TenNV.ToLower().Contains(TimKiem.ToLower())
            || x.DiaChi.ToString().ToLower().Contains(TimKiem.ToLower())).ToList();
        }

        public NhanVien GetNhanVien(int id)
        {
            return dal.GetNhanVien(id);
        }

        public string Update(NhanVien nhanVien)
        {
            int rs = dal.Update(nhanVien);
            if (rs > 0) return "Thành công";
            return "Thất bại"; ;
        }
    }
}
