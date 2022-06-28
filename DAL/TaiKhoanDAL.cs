using CuaHangBanXeMay.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CuaHangDienThoaiAPI.Utils;
using CuaHangBanXeMay.DAL.InterfaceService;
using Entity;

namespace CuaHangBanXeMay.DAL
{
    internal class TaiKhoanDAL : ITaiKhoanDAL
    {
       

        public int Add(TaiKhoan taiKhoan)
        {
            String query =
                $"insert into TaiKhoan values(N'{taiKhoan.TenDangNhap}',N'{taiKhoan.MatKhau}',N'{taiKhoan.LoaiTK}')";
            return DBHelper.NonQuery(query, null);
        }

        public string DangNhap(string TenDangNhap, string MatKhau)
        {
            String query = $"select * from TaiKhoan where TenDangNhap = N'{TenDangNhap}' and MatKhau = N'{MatKhau}'";
            DataTable table = DBHelper.Query(query, null);
            if (table.Rows.Count < 1)
            {
                return "";
            }
            else
            {
                TaiKhoan taiKhoan = null;
                foreach (DataRow row in table.Rows)
                {
                    taiKhoan = new TaiKhoan()
                    {
                        TenDangNhap = row["TenDangNhap"].ToString(),
                        MatKhau = row["MatKhau"].ToString(),
                        LoaiTK = row["LoaiTK"].ToString()
                    };
                }

                return taiKhoan.LoaiTK;
            }
        }

        public int Delete(string id)
        {
            String query = $"delete from TaiKhoan where TenDangNhap =N'{id}'";
            return DBHelper.NonQuery(query, null);
        }

        public List<TaiKhoan> GetAll()
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            String query = "select * from TaiKhoan";
            DataTable dataTable = DBHelper.Query(query, null);
            foreach (DataRow row in dataTable.Rows)
            {
                TaiKhoan taiKhoan = new TaiKhoan()
                {
                    TenDangNhap = row["TenDangNhap"].ToString(),
                    MatKhau = row["MatKhau"].ToString(),
                    LoaiTK = row["LoaiTK"].ToString()
                };
                taiKhoans.Add(taiKhoan);
            }

            return taiKhoans;
        }

        public TaiKhoan GetTaiKhoan(string TenDangNhap)
        {
            TaiKhoan taiKhoan = null;
            String query = $"select * from TaiKhoan where TenDangNhap = N'{TenDangNhap}'";
            DataTable dataTable = DBHelper.Query(query, null);
            foreach (DataRow row in dataTable.Rows)
            {
                taiKhoan = new TaiKhoan()
                {
                    TenDangNhap = row["TenDangNhap"].ToString(),
                    MatKhau = row["MatKhau"].ToString(),
                    LoaiTK = row["LoaiTK"].ToString()
                };
            }

            return taiKhoan;
        }

        public int Update(TaiKhoan taiKhoan)
        {
            String query =
                $"update TaiKhoan set TenDangNhap = N'{taiKhoan.TenDangNhap}',MatKhau = N'{taiKhoan.MatKhau}',LoaiTK =N'{taiKhoan.LoaiTK}' where TenDangNhap = N'{taiKhoan.TenDangNhap}'";
            return DBHelper.NonQuery(query, null);
        }
    }
}