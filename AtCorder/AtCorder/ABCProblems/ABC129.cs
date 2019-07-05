using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtCorder.ABCProblems.Base;

namespace AtCorder.ABCProblems
{
    public class ABC129 : ABC
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
        /// TypicalStairs
        /// </summary>
        public override void C()
        {
            var NM = ReadSplitInt();
            var n = NM[0];
            var m = NM[1];
            var a = ReadSplitLongLines(m);

            var dp = new long[n + 1];
            var instrusion = new bool[n + 1];

            // 1段目への移動方法数
            dp[0] = 1;

            // 侵入不可の段数設定（trueが侵入負荷）
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
                        }
                    }
                }
            }

            Console.WriteLine(dp[n] % 1000000007);

        }

        public override void D()
        {
            throw new NotImplementedException();
        }
    }
}
