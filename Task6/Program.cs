{
    int x = new Random().Next(1, 1000);
    Console.WriteLine(x);
    string number = Parity(x);
    Console.WriteLine(number);

}

string Parity (int a)
{
    string res;
    switch (a % 2)
    {
        case 0:
        res = "Да";
        break;
        case 1:
        res = "Нет";
        break; 
        default:
        res = "Ошибка";
        break;
    }
    return res;
}