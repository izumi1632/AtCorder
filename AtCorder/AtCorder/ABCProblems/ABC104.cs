using System;
using AtCorder.ABCProblems.Base;

namespace AtCorder.ABCProblems
{
    public class ABC104C : ABC
    {
        public ABC104C()
        {
        }

        public override void A()
        {
            throw new NotImplementedException();
        }

        public override void B()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// AllGreen
        /// </summary>
        public override void C()
        {
            //ABC104C
            var DG = ReadSplitInt();
            var D = DG[0];
            var G = DG[1];

            var pc = ReadSplitIntLines(D);
            var minCnt = int.MaxValue;

            for (int i = 0; i < (1 << D); i++)
            {
                var cnt = 0;
                var point = 0;

                // ボーナス取得可否判定
                for (int j = 0; j < D; j++)
                {
                    // piを完全回答
                    if ((i & (1 << j)) != 0)
                    {
                        point += (pc[j][0] * ((j + 1) * 100)) + pc[j][1];
                        cnt += pc[j][0];
                    }
                }

                if (point >= G)
                {
                    minCnt = Math.Min(minCnt, cnt);
                }
                else
                {
                    var doBreak = false;
                    for (int k = D - 1; 0 <= k; k--)
                    {
                        if ((i & (1 << k)) == 0)
                        {
                            for (int l = 0; l < pc[k][0]; l++)
                            {
                                point += (100 * (k + 1));
                                cnt++;
                                if (point >= G)
                                {
                                    minCnt = Math.Min(minCnt, cnt);
                                    doBreak = true;
                                    break;
                                }
                            }
                        }
                        if (doBreak)
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(minCnt);


        }

        public override void D()
        {
            throw new NotImplementedException();
        }
    }
}
