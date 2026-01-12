
//(Напишите Методи * *int Reverse(int n) * *, которая принимает один параметр и возвращает его в обратном порядке.)

int Reverse1(int n)
{
    string str = "";
    while (n > 0)
    {
        int digit = n % 10;
        str += digit.ToString();
        n /= 10;
    }
    return Convert.ToInt32(str);
}

Console.WriteLine(Reverse1(155218));
