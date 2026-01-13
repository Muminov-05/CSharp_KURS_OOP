
//Напишите рекурсивный Метод для вычисления факториала числа.

int Factorial(int n)
{
    if(n <= 0)
    {
        return 1;
    }
    return n * Factorial(n - 1);
}

Console.WriteLine($" 7! = {Factorial(7)}");