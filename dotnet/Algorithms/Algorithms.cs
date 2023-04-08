namespace Algorithms
{
    public static class Algorithms
    {
        public static bool LinearSearch(int[] haystack, int needle)
        {
            for (int i = 0; i < haystack.Length; ++i)
            {
                if (haystack[i] == needle)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool BinarySearch(int[] haystack, int needle)
        {
            int low = 0;
            int high = haystack.Length;

            do
            {
                var middle = (int)Math.Floor((double)(low + (high - low) / 2));
                var value = haystack[middle];
                if( value == needle)
                {
                    return true;
                }
                else if(value > needle)
                {
                    high = middle;
                }
                else
                {
                    low = middle + 1;
                }

            } while (low < high);

            return false;
        }

        public static int TwoCrystalBalls(bool[] breaks)
        {
            var jumpAmount = (int)Math.Floor(Math.Sqrt(breaks.Length));
            var i = jumpAmount;

            while(i < breaks.Length)
            {
                if (breaks[i])
                {
                    return i;
                }

                i += jumpAmount;
            }

            i -= jumpAmount;

            for (var j = 0; j < jumpAmount && i < breaks.Length; ++j, ++i)
            {
                if (breaks[i])
                {
                    return i;
                }
            }

            return -1;
        }

        public static void BubbleSort(int[] values)
        {
            for(var i = 0; i < values.Length; ++i)
            {
                for(var j = 0; j < values.Length - 1 - i; ++j)
                {
                    if (values[j] > values[j + 1])
                    {
                        var temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
            }
        }
    }
}