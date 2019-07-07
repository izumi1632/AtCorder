using System;
using System.Linq;
using AtCorder.ABCProblems.Base;

namespace AtCorder.ABCProblems
{
    public class ABC079 : ABC
    {
        public ABC079()
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
        /// TrainTicket
        /// </summary>
        public override void C()
        {
            // ABC079C
            var ABCD = Console.ReadLine().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();

            // ３ビット分の総当たりを実施したい
            for (int i = 0; i < (1 << 3); i++)
            {

                long calc = ABCD[0];
                string str = ABCD[0].ToString();
                for (int j = 0; j < 3; j++)
                {
                    if ((i & (1 << j)) != 0)
                    {
                        calc += ABCD[j + 1];
                        str += "+" + ABCD[j + 1].ToString();
                    }
                    else
                    {
                        calc -= ABCD[j + 1];
                        str += "-" + ABCD[j + 1].ToString();
                    }
                }

                if (calc == 7)
                {
                    Console.WriteLine(str + "=7");
                    return;
                }
            }
        }

        public override void D()
        {
            throw new NotImplementedException();
        }
    }
}
