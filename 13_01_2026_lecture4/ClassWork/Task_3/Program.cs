
//Реализуйте рекурсивный метод для проверки, является ли число палиндромом.

bool Palindrom(int n , int left , int right)
{
    string str = Convert.ToString(n);
    if (left >= right)
        return true;
    if (str[left] != str[right])
        return false;

    return Palindrom(n, left+1, right-1);
}

Console.WriteLine("Input : ");
int n = Convert.ToInt32(Console.ReadLine());

string str = Convert.ToString(n);

if ( Palindrom(n,0,str.Length-1) )
{
     Console.WriteLine($" {n} is  Palindrom");
} else
{
     Console.WriteLine($" {n} is not Palindrom");
}