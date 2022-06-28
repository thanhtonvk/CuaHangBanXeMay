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
    internal class TaiKhoanBLL:ITaiKhoanBLL
    {
        ITaiKhoanDAL dal = new TaiKhoanDAL();

        public string Add(TaiKhoan taiKhoan)
        {
            int rs = dal.Add(taiKhoan);
            if (rs > 0) return "Thành công";
            return "Thất bại";
        }

        public string DangNhap(string TenDangNhap, string MatKhau)
        {
            return dal.DangNhap(TenDangNhap, MatKhau);
        }

        public string Delete(string id)
        {
            int rs = dal.Delete(id);
            if (rs > 0) return "Thành công";
            return "Thất bại"; ;
        }

        public List<TaiKhoan> GetAll(string TimKiem)
        {
            if (string.IsNullOrEmpty(TimKiem))
            {
                return dal.GetAll();
            }
            return dal.GetAll().Where(
                x => x.TenDangNhap.ToLower().Contains(TimKiem.ToLower())).ToList();
        }

        public TaiKhoan GetTaiKhoan(string id)
        {
            return dal.GetTaiKhoan(id);
        }

        public string Update(TaiKhoan taiKhoan)
        {
            int rs = dal.Update(taiKhoan);
            if (rs > 0) return "Thành công";
            return "Thất bại"; ;
        }
    }
}
