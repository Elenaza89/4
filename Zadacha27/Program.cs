//Ввести число и выдасть сумму всех чисел
Console.WriteLine("Введите число ");

if (!Int32.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine("Вы ввели не число!");
}

int res = GetSumma( number);
Console.WriteLine(res);

int GetSumma(int number)
{
    int sum = 0;
    char[] arr = number.ToString().ToCharArray ();

    foreach (var s in arr)
    {
        Int32.TryParse(s.ToString(), out int res);
        sum += res;
    }
    return sum;
}
