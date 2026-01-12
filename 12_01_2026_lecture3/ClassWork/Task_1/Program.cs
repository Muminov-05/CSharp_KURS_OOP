
/*
Создайте в шаблоне упражнения следующий метод **void PrintFromNumberToOne(int number).**                                                                                                                                                                                           
Он должен печатать числа от числа, переданного в качестве параметра, до единицы.
 */

void PrintFromNumberToOne(int number)
{
    if (number <= 0)
    {
        return;
    }
    Console.WriteLine(number);
    PrintFromNumberToOne(--number);
}

PrintFromNumberToOne(10);
