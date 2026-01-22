
// Напишите программу на C# Sharp для отображения списка элементов массива по длине строки, а затем по имени в порядке возрастания. 

var listStr = new List<string> { "123456", "258", "12345", "123", "1234567" };
Console.WriteLine("Po dline strok");
var list1 = listStr.OrderBy(s => s.Length);
foreach (var s in list1)
{
    Console.WriteLine(s);
}

Console.WriteLine();
Console.WriteLine("Po imeni");
listStr.Sort();
foreach (var n in listStr)
{
    Console.WriteLine(n);
}