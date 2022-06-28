using Entity;
using CuaHangBanXeMay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanXeMay.BLL.InterfaceService
{
    internal interface IChiTietHDBBLL
    {
        string Add(ChiTietHDB chiTietHDB);
        string Delete(int id);
        List<getChiTietHoaDonBan_Result> GetAll(int idHDB);
        ChiTietHDB GetChiTietHDB(int id);
    }
}
