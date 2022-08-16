int max = Max(5,7);
Console.WriteLine(max);
max = Max(2,10);
Console.WriteLine(max);
int max2 = Max(-9, -3);
Console.WriteLine(max2);

int Max(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}