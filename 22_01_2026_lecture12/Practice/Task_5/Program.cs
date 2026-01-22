
// Напишите программу C# Sharp для вставки дополнительного значения в массив (отсортированный список).
var listDouble = new List<double> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
double newValue = 5.5;
listDouble.Add(newValue);
listDouble.Sort();

foreach ( var item in listDouble )
{
    Console.WriteLine( item );
}
