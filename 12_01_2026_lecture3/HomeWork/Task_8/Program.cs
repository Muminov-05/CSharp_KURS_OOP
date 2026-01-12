
//Напишите Метод **int MinNumber(int a, int b, int c, int d)** находящую наименьшее из четырех данных чисел. 

int MinNumber(int a, int b, int c, int d)
{
    int minEl = a < b ? a : b;
    minEl = minEl < c ? minEl : c;
    minEl = minEl < d ? minEl : d;
    return minEl;
}

Console.WriteLine($" min( 14 , 28 , 8 , 12) : {MinNumber(14, 28, 8, 12)}");