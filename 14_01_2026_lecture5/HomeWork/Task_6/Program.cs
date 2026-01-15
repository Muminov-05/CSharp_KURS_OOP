
// Дано число N и массив из N чисел. Выведите повторяющиеся элементы заданного массива. 

void PrintRepetitiveNumber(int[] arr, int j = 0 )
{
    int digit = arr[j];
    bool friend = false;
    int[] new_massiv = [];
    for( int i=1; i<arr.Length; i++)
    {
        bool b = true;
        for( int k=0; k<new_massiv.Length; k++)
        {
            if (arr[i] == new_massiv[k])
                b = false;
        }
        if( digit == arr[i] && b==false)
        {
            Console.Write(arr[i] + "   ");
            d = true;
        }
        if (d)
        {
            Console.Write(arr[j] + "  ");
            int[] new_massiv = { new_massiv ,  digit };
        }
    }
}

Console.Write(" Vvedite razmer massiva : ");
int n = Convert.ToInt32(Console.ReadLine());

int[] massiv = new int[n];
Console.WriteLine($"Vvedite elementu massiva : ");
for (int i = 0; i < n; i++)
{
    massiv[i] = Convert.ToInt32(Console.ReadLine());
}
 PrintRepetitiveNumber(massiv);