// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int CalculateDigitSum(int number)
{
    int sum = 0;
    while (number != 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }
    return sum;
}


System.Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());

int sum = CalculateDigitSum(number);
Console.WriteLine($"Сумма цифр: " + sum);