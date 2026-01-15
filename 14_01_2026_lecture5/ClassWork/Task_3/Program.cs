
//Задача — найти среднюю цифру данного числа N. Если в числе две средние цифры, выведите первую среднюю цифру. 

int middleNumber(int n, int left = 0)
{
    string str = n.ToString();
    int middle = str.Length / 2;
    middle = str.Length % 2 == 1 ? middle : middle - 1;
    if (left == middle)
        return str[left] - '0';

    return middleNumber(n, left + 1);
}


Console.Write(" N = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(middleNumber(n));