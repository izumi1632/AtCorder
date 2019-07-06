using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCorder
{
    class Program
    {
        static void Main(string[] args)
        {

            // ARC061A


            var S = Console.ReadLine();
            var k = S.Count() - 1;
            int a = 0;

            for (int i = 0; i < (1 << k); i++)
            {
                int s = int.Parse(S[0].ToString());

                for (int j = 0; j < k; j++)
                {
                    // 前からjからjけた目の右側にプラスにが存在するかどうかを論理積とって判断する。
                    if ((i & (1 << j)) != 0)
                    {
                        a += s;
                        s = 0;
                    }

                    // + が存在しない場合は数字を積み上げるので１０倍し、合計に足さないで保持して次のけたの数字と連結
                    // ↑で＋されている場合は０なので単純に次けたの数値を取得しているだけ。
                    s += s * 10 + int.Parse(S[j + 1].ToString());

                }

                a += s;
            }
            Console.WriteLine(a);

            Console.ReadKey();
        }



        #region MyRegion

        public static int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// 空白区切の数値を取得する
        /// </summary>
        /// <returns>The read split int.</returns>
        public static int[] ReadSplitInt()
        {
            return Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        }

        /// <summary>
        /// 空白区切の数値を取得
        /// </summary>
        /// <returns>The read split long.</returns>
        public static long[] ReadSplitLong()
        {
            return Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
        }


        public static int[][] ReadSplitIntLines(int n)
        {
            return Enumerable.Range(0, n).Select(x => ReadSplitInt()).ToArray();
        }

        public static long[][] ReadSplitLongLines(int n)
        {
            return Enumerable.Range(0, n).Select(x => ReadSplitLong()).ToArray();
        }

        public static long[][] ReadSplitLongLines(long n)
        {
            var ret = new List<long[]>();
            for (long i = 0; i < n; i++)
            {
                ret.Add(ReadSplitLong().ToArray());
            }

            return ret.ToArray();
        }

        #endregion

    }
}
