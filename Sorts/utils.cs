namespace Sorts
{
    public static class Utils
    {
        public static void Swap<T>(ref T i,ref T j) 
        {
            T temp = i;
            i = j;
            j = temp;
        }
    }
}