using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCorder.ABCProblems.Base
{
    public abstract class ABC
    {


        #region MyRegion

        abstract public void A();
        abstract public void B();
        abstract public void C();
        abstract public void D();

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
