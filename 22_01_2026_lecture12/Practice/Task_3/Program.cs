
// Напишите программу на C# Sharp для удаления элементов из списка с помощью фильтров. 

var listInt = new List<int> { 1, 2, 3, 4, 5, 6 };
listInt.RemoveAll(n => n % 2 == 1);

foreach (var item in listInt)
{
    Console.WriteLine(item);
}
