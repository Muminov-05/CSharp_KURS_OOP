
// Напишите программу на C# Sharp, чтобы получить обратную строку с помощью рекурсии.   


string ReverseString( string str , int right)
{
    if (right < 0)
        return "";
     return str[right] + ReverseString(str, --right);
}

Console.WriteLine(" Vvedite Stroku :");
string str = Console.ReadLine();
int len = str.Length;

Console.WriteLine(ReverseString(str,len-1));