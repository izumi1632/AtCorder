using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCorder.bit全探索
{
    public class bitAllSearch
    {
        /// <summary>
        /// bit全探索
        /// </summary>
        public static void bitAll()
        {
            int n = 5;
            for (int bit = 0; bit < (1 << n); bit++) 
            {
                List<int> S = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    // 左シフト
                    if ((bit & (1 << i)) != 0)
                    {
                        S.Add(i);
                    }
                }

                Console.Write(bit + ":{");
                foreach (var item in S)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine("}");
            }
        }
    }
}
