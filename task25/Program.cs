// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

int Resault(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
       result *= a;
    }
    return result;
}

System.Console.WriteLine("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());

int exponentResult = Resault(a, b);
Console.WriteLine($"{a} в степени {b} равно: {exponentResult}");