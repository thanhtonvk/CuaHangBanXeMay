using System.Collections.Generic;
using Entity;
using CuaHangBanXeMay.Models;

namespace CuaHangBanXeMay.DAL.InterfaceService
{
    public interface IDaiLyDAL
    {
        int Add(DaiLy daiLy);
        int Update(DaiLy daiLy);
        int Delete(int id);
        List<DaiLy> GetAll();
        DaiLy GetDaiLy(int id);
    }
}