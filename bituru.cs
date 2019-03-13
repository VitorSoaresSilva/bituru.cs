public static int Abs(int x)
{
    int t = x >> 31;
    return x + (x * (t+t));
}
public static float Lerp(float x, float y,float f)
{
    return x + ((y-x) * f);
}
public static int Clamp(int min, int max, int value)
{
    int difMax = (max - value);
    int difMin = (value - min);
    return (value - (difMax * (difMax >> 31)) + (difMin * (difMin >> 31)));
}
private static void BubbleSort<T>(ref T[] arr) where T: IComparable<T>
{
    bool changed;
    do
    {
        changed = false;
        for (int i = 0;i<arr.Length-1;i++)
        {
            if (arr[i].CompareTo(arr[i+1]) < 1) continue;
            Swap(ref arr[i],ref arr[i+1]);
            changed = true;
        }
    } while (changed);
}
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
        Swap(ref arr[i],ref arr[min]);
    }
}
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
        Swap(ref arr[i],ref arr[j]);
    }
    Swap(ref arr[i+1],ref arr[high]);
    return i + 1;
}
private static void Swap<T>(ref T i,ref T j) 
{
    T temp = i;
    i = j;
    j = temp;
}