using System;
namespace Sorts
{
    public class Selection
    {
        private static void SelectionSort<T>(ref T[] arr) where T: IComparable<T>
        {
            int len = arr.Length;
            int min = 0;
            for (int i = 0; i < len-1; i++)
            {
                for (int j = i+1; j < len; j++)
                {
                    if (arr[j].CompareTo(arr[min])>-1) continue;
                    min = j;
                }
                Utils.Swap(ref arr[i],ref arr[min]);
            }
        }
    }
}