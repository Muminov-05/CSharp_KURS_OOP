                   
//Создайте список целых чисел и выведите все четные элементы. (используйте метод FindAll)                   

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.FindAll(numbers => numbers %2 == 0);
Console.WriteLine("The evenNumbers are:");
foreach (int number in evenNumbers)
{
    Console.WriteLine(number);
}
