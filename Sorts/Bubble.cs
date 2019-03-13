using System;
namespace Sorts
{
    public class Bubble
    {
        private static void BubbleSort<T>(ref T[] arr) where T: IComparable<T>
        {
            bool changed;
            do
            {
                changed = false;
                for (int i = 0;i<arr.Length-1;i++)
                {
                    if (arr[i].CompareTo(arr[i+1]) < 1) continue;
                    Utils.Swap(ref arr[i],ref arr[i+1]);
                    changed = true;
                }
            } while (changed);
        }
    }
}