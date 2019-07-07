using System;
using AtCorder.ABCProblems.Base;

namespace AtCorder.ABCProblems
{
    public class ARC029 :ABC
    {
        public ARC029()
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
            //ARC029A
            var N = ReadInt();
            var t = ReadSplitIntLines(N);

            var minT = int.MaxValue;

            // Nbit探索
            for (int i = 0; i < (1 << N); i++)
            {
                var t1 = 0;
                var t2 = 0;


                for (int j = 0; j < N; j++)
                {
                    // 肉焼き機１
                    if ((i & (1 << j)) != 0)
                    {
                        t1 += t[j][0];
                    }
                    // 肉焼き機２
                    else
                    {
                        t2 += t[j][0];
                    }
                }

                minT = Math.Min(minT, Math.Max(t1, t2));
            }

            Console.WriteLine(minT);
        }

        public override void D()
        {
            throw new NotImplementedException();
        }
    }
}
