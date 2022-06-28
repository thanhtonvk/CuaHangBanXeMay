using Entity;
using CuaHangBanXeMay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanXeMay.DAL.InterfaceService
{
    internal interface INhanVienDAL
    {
        int Add(NhanVien nhanVien);
        int Update(NhanVien nhanVien);
        int Delete(int id);
        List<NhanVien> GetAll();
        NhanVien GetNhanVien(int id);
    }
}