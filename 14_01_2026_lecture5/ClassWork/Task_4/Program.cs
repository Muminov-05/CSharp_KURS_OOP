
// Напишите программу на C# Sharp, чтобы проверять, является ли данная строка палиндромом или нет, используя рекурсию. 

bool Polindrom(string str,int left,int right)
{
    if (left >= right)
        return true;
    if (str[left] != str[right])
        return false;
    return Polindrom(str, ++left, --right);
}

Console.WriteLine(" Vvedite Stroku :");
string str = Console.ReadLine();
int len = str.Length;

if (Polindrom(str,0,len-1))
{
    Console.WriteLine(" The string is Polindrom ");
} else
{
    Console.WriteLine(" The string is not Polindrom ");
}