
//Напишите метод **char CheckGrade(int grade)**, которая принимает на вход целое число, представляющее оценку ученика, и выводит, 
//является ли она A, B, C, D или F, используя операторы if-else.

char CheckGrade(int grade)
{
    if(grade <= 100  && grade >= 90)
    {
        return 'A';
    } 
    else if (grade <= 89 && grade >= 80)
    {
        return 'B';
    }
    else if (grade <= 79 && grade >= 70)
    {
        return 'C';
    }
    else if (grade <= 69 && grade >= 60)
    {
        return 'D';
    }
    else if (grade <= 59 && grade >= 0)
    {
        return 'F';
    }
    return 'a';
}

Console.Write(" Grade = ");
int grade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckGrade(grade));