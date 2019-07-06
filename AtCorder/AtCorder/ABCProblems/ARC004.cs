using System;
using AtCorder.ABCProblems.Base;

namespace AtCorder.ABCProblems
{
    public class ARC004　:ABC
    {
        public ARC004()
        {
        }

        public override void A()
        {
            //ARC004A
            var N = ReadInt();
            var xy = ReadSplitIntLines(N);

            double max = 0;
            double distance = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    distance = Math.Sqrt(Math.Pow(xy[i][0] - xy[j][0], 2) + Math.Pow(xy[i][1] - xy[j][1], 2));

                    max = Math.Max(distance, max);
                }
            }

            Console.WriteLine(max);
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
