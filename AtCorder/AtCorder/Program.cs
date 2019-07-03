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

            var NM = ReadSplitInt();
            var n = NM[0];
            var m = NM[1];
            var a = ReadSplitLongLines(m);

            var dp = new long[n + 1];
            var instrusion = new bool[n + 1];

            // 1段目への移動方法数
            dp[0] = 1;

            // 侵入負荷の段数設定（trueが侵入負荷）
            for (long i = 0; i < m; i++)
            {
                instrusion[a[i][0]] = true;
            }

            for (long i = 0; i <= n; i++)
            {
                // 1段か2段先へ移動
                for (long j = 1; j <= 2; j++)
                {
                    if (i + j <= n)
                    {
                        // 侵入不可への移動はできない
                        if (instrusion[i + j] != true)
                        {
                            // i番目からi+j番目への移動
                            dp[i + j] += dp[i];
                            dp[i + j] %= 1000000007;
                        }
                    }
                }
            }


            //Console.WriteLine(dp[n] % 1000000007); // ←ループ内で行わずにここだけで割るとエラー
            Console.WriteLine(dp[n]);


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
