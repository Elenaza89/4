
// задача 29.  Ввести массив 8 элементов и ывести его на консоль
int[] arr = new int[8];

arr = GetArray();
Console.Write ("[ ");
for (int i = 0; i < arr.Length-1; i++)
{
    
    Console.Write($"{arr[i]}, ");
}
Console.WriteLine ($"{arr[arr.Length - 1]} ]");

int[] GetArray()
{
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine("Введите число ");        
        int num= GetNum();
        arr[i] = num;
    }
    return arr;
}


int GetNum( )
{
    
    if (!Int32.TryParse(Console.ReadLine(), out int number))
    {
        Console.WriteLine("Вы ввели не число! Введите число");
        return GetNum();
    }
    return number;
}
