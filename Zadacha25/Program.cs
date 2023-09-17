// Ввод 2х чисел А и В, выывести А в степени В, если B=0, то 1
Console.WriteLine("Введите число A");

Int32.TryParse(Console.ReadLine(), out int A);
Console.WriteLine("Введите число B");

Int32.TryParse(Console.ReadLine(), out int B);

long res = GetStepen(A, B);
Console.WriteLine(res);

long GetStepen(int a, int b)
{
    long res = 1;
    for (int i = 0; i < b; i++)
        res *= a;
    return res;
}