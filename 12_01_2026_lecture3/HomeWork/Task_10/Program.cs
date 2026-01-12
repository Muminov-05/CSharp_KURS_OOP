
//Напишите Метод **int Max(int val1, int val2)**, который принимает два параметра и возвращает максимальное  значений. 

int Max(int val1, int val2)
{
    return val1 > val2 ? val1 : val2;
}

Console.WriteLine(" Вводите первое значение :");
int val1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Вводите второе значение :");
int val2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" max ({val1} , {val2}) = {Max(val1 ,val2)} ");