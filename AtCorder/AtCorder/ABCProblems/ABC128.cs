using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtCorder.ABCProblems.Base;

namespace AtCorder.ABCProblems
{
    public class ABC128 : ABC
    {
        public override void A()
        {
            throw new NotImplementedException();
        }

        public override void B()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// switches
        /// </summary>
        public override void C()
        {
            var NM = ReadSplitInt();
            var N = NM[0];
            var M = NM[1];
            var k = ReadSplitIntLines(M);
            var p = ReadSplitInt();

            long res = 0;

            // 0001 0010 0011
            for (int bit = 0; bit < (1 << N); bit++)
            {
                bool ok = true;
                for (int i = 0; i < M; i++)
                {
                    int con = 0;
                    foreach (var item in k[i].Skip(1))
                    {
                        // 0001をどれだけずらすか。
                        // 入力が1のときはずらさないので-1しとく　　
                        if ((bit & (1 << (item - 1))) != 0)
                        {
                            // 0以外ならスイッチオン
                            // オンの数を数える
                            con++;
                        }
                    }

                    // 偶奇一致判定
                    if (con % 2 != p[i])
                    {
                        ok = false;
                    }
                }

                // m行検査してなお偶奇の判定を満たしてるなら
                // 組み合わせの個数をカウントアップ
                if (ok)
                {
                    res++;
                }
            }

            Console.WriteLine(res);
        }


        public override void D()
        {
            throw new NotImplementedException();
        }
    }
}
