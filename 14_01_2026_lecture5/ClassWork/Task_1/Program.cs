
// (Напишите функцию **int FindMin(int a, int b, int c)**, которая находит среднее из трех заданных чисел.) 

int FindMin(int a, int b, int c)
{
    if( a <= b && b <= c)
    {
        return b;
    }
    else if ( b <= a && a <= c)
    {
        return a;
    } else
    {
        return c;
    }
}
Console.WriteLine(FindMin(4, 7, 8));
