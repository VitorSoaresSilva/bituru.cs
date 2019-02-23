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