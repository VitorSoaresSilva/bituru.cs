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
            Console.WriteLine(arr[i].CompareTo(arr[i+1] )+" ");
            if (arr[i].CompareTo(arr[i+1]) < 1) continue;
            Switch(ref arr,i);
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
        Switch(ref arr,i,min);
    }
}
private static void Switch<T>(ref T[] arr,int i) 
{
    T temp = arr[i];
    arr[i] = arr[i + 1];
    arr[i + 1] = temp;
}
private static void Switch<T>(ref T[] arr,int i,int j) 
{
    T temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}