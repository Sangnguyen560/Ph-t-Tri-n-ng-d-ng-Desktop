using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3
{
    internal class HangHoa
    {
        public string MatHang { get; set; }
        public string TenHang { get; set; }
        public string DVT { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }

        public HangHoa()
        {

        }

        public string Xuat()
        {
            return string.Format("{0},{1},{2},{3},{4}", MatHang, TenHang, DVT, SoLuong, DonGia);
        }

    }
}
