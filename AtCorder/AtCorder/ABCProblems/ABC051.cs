using System;
using AtCorder.ABCProblems.Base;

namespace AtCorder.ABCProblems
{
    public class ABC051 : ABC
    {
        public ABC051()
        {
        }

        public override void A()
        {
            throw new NotImplementedException();
        }

        public override void B()
        {
            //ABC051B
            var KS = ReadSplitInt();
            var K = KS[0];
            var S = KS[1];
            int cnt = 0;
            for (int i = 0; i <= K; i++)
            {
                for (int j = 0; j <= K; j++)
                {
                    var k = S - i - j;
                    if (k >= 0 && K >= k)
                    {
                        cnt++;
                    }
                }
            }
            Console.WriteLine(cnt);
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
