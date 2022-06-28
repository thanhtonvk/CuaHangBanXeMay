using Entity;
using CuaHangBanXeMay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanXeMay.BLL.InterfaceService
{
    internal interface ITaiKhoanBLL
    {
        string Add(TaiKhoan taiKhoan);
        string Update(TaiKhoan taiKhoan);
        string Delete(string id);
        List<TaiKhoan> GetAll(string TimKiem);
        TaiKhoan GetTaiKhoan(string TenDangNhap);
        string DangNhap(string TenDangNhap, string MatKhau);
    }
}
