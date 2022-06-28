using System.Collections.Generic;
using Entity;
using CuaHangBanXeMay.Models;

namespace CuaHangBanXeMay.BLL.InterfaceService
{
    public interface IDaiLyBLL
    {
        string Add(DaiLy daiLy);
        string Update(DaiLy daiLy);
        string Delete(int id);
        List<DaiLy> GetAll(string TimKiem);
        DaiLy GetDaiLy(int id);
    }
}