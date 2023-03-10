using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_2
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }


        public ThietBi(string maThietBi, string tenThietBi, string nuocSanXuat, int donGia, int soLuong)
        {
            MaThietBi = maThietBi;
            TenThietBi = tenThietBi;
            NuocSanXuat = nuocSanXuat;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public int ThanhTien()
        {
            return DonGia * SoLuong;
        }

        public string HienThi()
        {
            return string.Format($"{MaThietBi} || {TenThietBi} || {NuocSanXuat} || {DonGia} USD || {SoLuong}");
        }
    }
}
