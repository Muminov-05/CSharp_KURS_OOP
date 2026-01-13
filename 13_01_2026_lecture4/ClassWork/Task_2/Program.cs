
// Напишите рекурсивный Метод для вычисления чисел Фибоначчи.


int Fibonacci(int n)
{
    if (n == 0)
        return 0;
    if (n == 1)
        return 1;

    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

Console.WriteLine(Fibonacci(6));

