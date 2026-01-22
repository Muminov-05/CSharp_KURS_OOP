
// Напишите программу C# Sharp для создания списка из заданного списка целых чисел.
//В этой программе каждое целое значение прибавляется к 2, а полученное значение умножается на 5.

var listInt = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var newListInteger = listInt.Select( n => (n+2)*5  ).ToList();

foreach (var item in newListInteger)
{
    Console.WriteLine(item);
}
