using System;
using System.Linq;
using AtCorder.ABCProblems.Base;

namespace AtCorder.ABCProblems
{
    public class ARC061 : ABC
    {
        public ARC061()
        {
        }

        public override void A()
        {  // ARC061A


            var S = Console.ReadLine();
            var k = S.Count() - 1;
            long total = 0;

            for (int i = 0; i < (1 << k); i++)
            {
                var s = long.Parse(S[0].ToString());

                for (int j = 0; j < k; j++)
                {
                    // 前からjからjけた目の右側にプラスにが存在するかどうかを論理積とって判断する。
                    if ((i & (1 << j)) != 0)
                    {
                        total += s;
                        s = 0;
                    }

                    // + が存在しない場合は数字を積み上げるので１０倍し、合計に足さないで保持して次のけたの数字と連結
                    // ↑で＋されている場合は０なので単純に次けたの数値を取得しているだけ。
                    s = ((s * 10) + (long.Parse(S[j + 1].ToString())));

                }

                total += s;
            }
            Console.WriteLine(total);
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
            throw new NotImplementedException();
        }
    }
}
