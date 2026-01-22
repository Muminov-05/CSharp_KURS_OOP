
//Создайте список целых чисел и отобразите сумму всех элементов в списке.                

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}
Console.WriteLine("The sum of all the elements in the list is: " + sum);