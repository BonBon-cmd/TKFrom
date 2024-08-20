using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKF_BT2
{
    internal class TinhToan
    {
        public static int CongHaiSo(int a, int b)
        {
            int s;
            s = a + b;
            return s;
        }
        public static int TongDaySo(int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += i;
            }
            return tong;
        }
    }
}
