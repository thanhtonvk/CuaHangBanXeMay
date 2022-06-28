using System.Collections.Generic;
using Entity;
using CuaHangBanXeMay.Models;

namespace CuaHangBanXeMay.BLL.InterfaceService
{
    public interface IHoaDonNhapBLL
    {
        string Add(HoaDonNhap hoaDonNhap);
        string Update(HoaDonNhap hoaDonNhap);
        string Delete(int id);
        List<GetHoaDonNhap_Result> GetAll(string TimKiem);
        HoaDonNhap GetHoaDonNhap(int id);
    }
}