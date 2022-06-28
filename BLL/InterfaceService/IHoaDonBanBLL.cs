using Entity;
using CuaHangBanXeMay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanXeMay.BLL.InterfaceService
{
    internal interface IHoaDonBanBLL
    {
        string Add(HoaDonBan hoaDonBan);
        string Update(HoaDonBan hoaDonBan);
        string Delete(int id);
        List<GetHoaDonBan_Result> GetAll(string TimKiem);
        HoaDonBan GetHoaDonBan(int id);
    }
}
