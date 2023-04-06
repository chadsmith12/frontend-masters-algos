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
    }
}