
//Напишите программу на C# Sharp, чтобы проверять, является ли данная строка палиндромом или нет, используя рекурсию.

 bool Palindrom( string str , int left  , int right )
{
    if (left >= right)
        return true;
    if (str[left] != str[right])
        return false;

    return Palindrom(str, left+1, right-1);
}

Console.WriteLine("Input : ");
string str = Console.ReadLine();
int len = str.Length;

if (Palindrom(str , 0 , len-1))
{
    Console.WriteLine(" The string is Polindrom ");
}
else
{
    Console.WriteLine("The string is not Polindrom");
}
