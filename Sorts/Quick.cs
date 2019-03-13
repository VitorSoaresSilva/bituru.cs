using System;
namespace Sorts
{
    public class Quick
    {
        private static void QuickSort<T>(ref T[] arr,int low,int high) where T : IComparable<T>
        {
            if (low < high)
            {
                int pi = Partition(ref arr, low, high);
                QuickSort(ref arr,low,pi-1);
                QuickSort(ref arr,pi+1,high);
            }
        }
        private static int Partition<T>(ref T[] arr,int low,int high) where T: IComparable<T>
        {
            T pivot = arr[high];
            int i = low - 1;
            for (int j = low ; j < high; j++)
            {
                if (arr[j].CompareTo(pivot)>-1) continue;
                i++;
                Utils.Swap(ref arr[i],ref arr[j]);
            }
            Utils.Swap(ref arr[i+1],ref arr[high]);
            return i + 1;
        }
    }
}