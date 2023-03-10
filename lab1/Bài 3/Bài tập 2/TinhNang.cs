using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_2
{
    internal class TinhNang
    {
        public void NoiChuoi(string ho, string ten, ref string s)
        {
            s = ho + ten;
        }

        public long GiaiThua(int n)
        {
            long kq = 1;
            for (int i = 1; i <= n; i++)
            {
                kq *= i;
            }
            return kq;

        }
    }
}
