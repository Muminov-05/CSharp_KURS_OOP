
//Напишите программу на C#, которая принимает на вход два целых числа. Если они имеют одинаковый знак,  
//выведите «**True**», иначе выведите «**False**»;

bool chaked(int a, int b)
{
    if( (a>=0 && b>=0) || (a<0 && b<0))
            return true;
    return false;
}

Console.WriteLine(chaked(8, 12));