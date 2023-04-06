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
    }
}