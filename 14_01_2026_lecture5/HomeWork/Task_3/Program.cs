
// Вводится число N, а затем N цифр. Выведите количество положительных, отрицательных, нулей… 

void PosNegZero(int[] arr)
{
    int pos= 0, neg= 0 , zero = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            pos++;
        }
        else if (arr[i] < 0)
        {
            neg++;
        }
        else
        {
            zero++;
        }
    }
    Console.WriteLine(" Positive : " + pos);
    Console.WriteLine(" Negative : " + neg);
    Console.WriteLine(" Zero : " + zero);
}

void EvenOdd(int[] arr)
{
    int even = 0, odd = 0;
    for(int i = 0;i < arr.Length;i++)
    {
        if(arr[i] % 2 == 0  && arr[i] != 0)
        {
            even++;
        }
        if (arr[i] % 2 == 1)
        {
            odd++;
        }
    }
    Console.WriteLine(" Even : " + even);
    Console.WriteLine(" Odd : " + odd);
}

void MaxMin_sumDigit(int[] arr)
{
    int max = arr[0] , min = arr[0] , sum = 0 ;
    for (int i = 1; i < arr.Length;i++)
    {
        if ( min >  arr[i] )
        {
            min = arr[i];
        }
        if (max < arr[i])
        {
            max = arr[i];
        }
        sum += arr[i];
    }
    Console.WriteLine(" Min : " + min);
    Console.WriteLine(" Max : " + max);
    Console.WriteLine(" Sum : " + sum);
}

Console.Write(" N = ");
int n = Convert.ToInt32(Console.ReadLine());

int[] massiv = new int[n];
Console.WriteLine($"Vvedite {n} chislo : ");
for (int i = 0; i < n; i++)
{
    massiv[i] = Convert.ToInt32(Console.ReadLine());
}

PosNegZero(massiv);
EvenOdd(massiv);
MaxMin_sumDigit(massiv);