{
int max = MaxCount(new int[3]{2, 3, 7});
Console.WriteLine(max);
max = MaxCount(new int[3]{44, 5, 78});
Console.WriteLine(max);
max = MaxCount(new int[3]{22, 3, 9});
Console.WriteLine(max);

int [] array = new int [3];
array[0]=1;
array[1]=10;
array[2]=100;
max = MaxCount(array);
Console.WriteLine(max);


max = MaxCountInt(2, 3, 7);
Console.WriteLine(max);
max = MaxCountInt(44, 5, 78);
Console.WriteLine(max);
max = MaxCountInt(22, 3, 9);
Console.WriteLine(max);

}

int MaxCountInt (int a, int b, int c)
{
    int maximum;
    maximum = a;
    if (b > maximum) maximum = b;
    if (c > maximum) maximum = c;
    return maximum;
}

int MaxCount (int[] array)
{
    int maximum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maximum)
        {
            maximum = array[i];
        }
        
    }
    return maximum;
}