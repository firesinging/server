using System;
using System.Linq;
using System.Text;


namespace Libraries.helpers.random
{
    /// <summary>
    ///  Random extention methods
    /// </summary>
    /// <seealso cref="https://github.com/Zaczero/RandomEx/blob/master/RandomEx/RandomEx.cs"/>
    public class RandomEx : Random
    {

        public RandomEx() : base()
        {

        }

        public RandomEx(int seed) : base(seed)
        {

        }

        public long NextLong()
        {

            return NextLong(0, long.MaxValue);

        }

        public long NextLong(long maxValue)
        {

            return NextLong(0, maxValue);

        }

        public long NextLong(long minValue, long maxValue)
        {

            byte[] randomLongBytes = new byte[sizeof(long)];

            NextBytes(randomLongBytes);

            long randomLong = BitConverter.ToInt64(randomLongBytes, 0);

            return Math.Abs(randomLong % (maxValue - minValue)) + minValue;

        }

        public int NextPerc(params int[] percs)
        {

            var sum = percs.Sum();

            int rnd;

            if (sum < 100)
            {

                rnd = Next(0, 101);

            }
            else
            {

                rnd = Next(0, sum + 1);

            }

            if (rnd > sum)
            {

                return -1;

            }

            var range = 0;

            for (var i = 0; i < percs.Length; i++)
            {

                range += percs[i];

                if (rnd > range)
                {

                    continue;

                }

                return i;

            }

            throw new InvalidOperationException();
        }

    }

}
