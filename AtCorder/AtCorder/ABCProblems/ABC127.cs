using System;
using AtCorder.ABCProblems.Base;

namespace AtCorder.ABCProblems
{
    public class ABC127 : ABC
    {
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
            var NM = ReadSplitLong();
            var N = NM[0];
            var M = NM[1];


            var LR = ReadSplitLongLines(M);

            var min = LR.Max(x => x[0]);
            var max = LR.Min(x => x[1]);

            var a = max - min + 1;
            Console.WriteLine(a < 1 ? 0 : a);
        }

        public override void D()
        {
            throw new NotImplementedException();
        }
    }
}
