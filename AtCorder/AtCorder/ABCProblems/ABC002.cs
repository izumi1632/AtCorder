using System;
using System.Collections.Generic;
using System.Linq;
using AtCorder.ABCProblems.Base;

namespace AtCorder.ABCProblems
{
    public class ABC002 : ABC
    {
        public ABC002()
        {
        }

        public override void A()
        {
            //ABC002A//
            Console.WriteLine(ReadSplitLong().Max());
        }

        public override void B()
        {
            throw new NotImplementedException();
        }

        public override void C()
        {
            throw new NotImplementedException();
        }

        public override void D()
        {
            // ABC002C

            var NM = ReadSplitInt();
            var N = NM[0];
            var M = NM[1];

            var xy = ReadSplitIntLines(M);
            var dic = new List<KeyValuePair<int, int>>();
            foreach (var item in xy)
            {
                dic.Add(new KeyValuePair<int, int>(item[0], item[1]));
                dic.Add(new KeyValuePair<int, int>(item[1], item[0]));
            }

            long max = 0;
            for (int i = 0; i < (1 << N); i++)
            {
                // 現在のループで調べる議員
                var a = new List<int>();
                for (int j = 0; j < N; j++)
                {
                    if ((i & (1 << j)) != 0)
                    {
                        // 調査対象の議員番号
                        a.Add(j + 1);
                    }
                }

                bool judge = true;
                foreach (var item in a)
                {
                    if (!a.Except(new int[] { item })
                        .All(x => dic.Where(y => y.Key == item).Any(y => y.Value == x)))
                    {
                        judge = false;
                        break;
                    }
                }

                if (judge)
                {
                    max = Math.Max(max, a.Count);
                }

            }
            Console.WriteLine(max);
        }
    }
}
