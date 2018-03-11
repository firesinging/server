using System;
using System.Threading;


namespace Libraries.helpers.random
{

    /// <summary>
    /// Static and thread safe random object
    /// </summary>
    public static class StaticRandom
    {

        private static int Seed;

        private static ThreadLocal<Random> ThreadLocal = new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref Seed)));

        public static Random Instance
        {

            get
            {

                return ThreadLocal.Value;

            }

        }

        /// <summary>
        /// Fill the buffer with random value
        /// </summary>
        /// <param name="buffer">The buffer to fill.</param>
        public static void NextBytes(byte[] buffer) => StaticRandom.Instance.NextBytes(buffer);

        /// <summary> 
        /// Return positive random value. 
        /// </summary>
        public static int Next()
        {

            return StaticRandom.Instance.Next();

        }

        /// <summary> 
        /// Return positive random value which is smaller than max.
        /// </summary>
        /// <param name="max">The maximum.</param>
        public static int Next(int max)
        {

            return StaticRandom.Instance.Next(max);

        }

        /// <summary> 
        /// Return positive random value which is smaller than max.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        public static int Next(int min, int max)
        {

            return StaticRandom.Instance.Next(min, max);

        }

        /// <summary>
        /// Return double between 0.0 and 1.0
        /// </summary>
        /// <remarks>Does not include 1.0</remarks>
        public static double Double()
        {

            return StaticRandom.Instance.NextDouble();

        }           

        /// <summary>
        /// Return long value
        /// </summary>
        public static long NextLong()
        {

            return NextLong(0, long.MaxValue);

        }

        /// <summary>
        /// Return long value which is smaller than max
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        public static long NextLong(long min, long max)
        {

            byte[] Buffer = new byte[sizeof(long)];

            NextBytes(Buffer);

            long Value = BitConverter.ToInt64(Buffer, 0);

            return Math.Abs(Value % (max - min)) + min;

        }

    }

}
