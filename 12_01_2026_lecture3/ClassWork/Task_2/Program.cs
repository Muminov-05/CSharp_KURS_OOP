
/*
Разверните метод **Sum(int a, int b, int c, int d)** в шаблоне упражнения, чтобы он вычислял и
возвращал сумму чисел, заданных в качестве параметров.
*/

int Sum(int a, int b, int c, int d)
{
    int sum = a + b + c + d;
    return sum;
}

Console.WriteLine(Sum(15, 25, 35, 45));