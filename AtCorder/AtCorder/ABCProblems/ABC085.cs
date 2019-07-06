using System;
using AtCorder.ABCProblems.Base;

namespace AtCorder.ABCProblems
{
    public class ABC085 : ABC
    {
        public ABC085()
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

        public override void C()
        {
            //ABC085C
            var NY = ReadSplitInt();
            var N = NY[0];
            var Y = NY[1];


            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= N - i; j++)
                {
                    var k = N - i - j;
                    bool p = Y == ((10000 * i) + (5000 * j) + (1000 * (k)));
                    if (p)
                    {
                        Console.WriteLine($"{i} {j} {k}");
                        return;
                    }

                }
            }

            Console.WriteLine("-1 -1 -1");
        }

        public override void D()
        {
            throw new NotImplementedException();
        }
    }
}
