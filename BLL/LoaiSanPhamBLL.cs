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
    internal class LoaiSanPhamBLL : ILoaiSanPhamBLL
    {
        ILoaiSanPhamDAL dal = new LoaiSanPhamDAL();

        public string Add(LoaiSanPham loaiSanPham)
        {
            int rs = dal.Add(loaiSanPham);
            if (rs > 0) return "Thành công";
            return "Thất bại";
        }

        public string Delete(int id)
        {
            int rs = dal.Delete(id);
            if (rs > 0) return "Thành công";
            return "Thất bại"; ;
        }

        public List<LoaiSanPham> GetAll(string TimKiem)
        {
            if (string.IsNullOrEmpty(TimKiem))
            {
                return dal.GetAll();
            }
            return dal.GetAll().Where(
                x => x.TenLoai.ToLower().Contains(TimKiem.ToLower())
            || x.MaLoai.ToString().ToLower().Contains(TimKiem.ToLower())).ToList();
        }

        public LoaiSanPham GetLoaiSanPham(int id)
        {
            return dal.GetLoaiSanPham(id);
        }

        public string Update(LoaiSanPham loaiSanPham)
        {
            int rs = dal.Update(loaiSanPham);
            if (rs > 0) return "Thành công";
            return "Thất bại"; ;
        }
    }
}
