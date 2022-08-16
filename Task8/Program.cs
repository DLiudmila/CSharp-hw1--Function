int x = new Random().Next(1, 51);
Console.Write(x+" -> ");
string number = Parity(x);

int x = number[i];

System.Console.WriteLine(number);

string Parity (int a)
{
    string result = "";
   if (a>1)
   {
     result = "2";
   }
    for (int i = 3; i <= a; i++)
    {
        if (i % 2 == 0)
        {
           result = result + "," + i;
        }  
    }
    return result;  
}