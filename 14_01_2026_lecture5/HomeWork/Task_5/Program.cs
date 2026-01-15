
// (Дан массив. Найдите количество элементов массива, которые больше, чем предыдущий элемент в этом массиве.) 

void Find(int[] arr )
{
    int count = 0;
    for ( int i = 1; i < arr.Length; i++)
    {
        if ( arr[i] > arr[i-1] )
            count++;
    }
    Console.WriteLine(" Kolichestvo elementov bolshe chem prededushiy element : " + count );
}

Console.Write(" Vvedite razmer massiva : ");
int n = Convert.ToInt32(Console.ReadLine());

int[] massiv = new int[n];
Console.WriteLine($"Vvedite elementu massiva : ");
for (int i = 0; i < n; i++)
{
    massiv[i] = Convert.ToInt32(Console.ReadLine());
}

Find(massiv);