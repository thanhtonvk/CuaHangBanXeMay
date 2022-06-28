using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanXeMay.Models
{
    internal class SanPhamBanChay
    {
        [DisplayName("Tên sản phẩm")]
        public string TenSP { get; set; }
        [DisplayName("Đơn giá")]
        public int DonGia { get; set; }
        [DisplayName("Số lượng bán")]
        public int SoLuongBan { get; set; }
    }
}
