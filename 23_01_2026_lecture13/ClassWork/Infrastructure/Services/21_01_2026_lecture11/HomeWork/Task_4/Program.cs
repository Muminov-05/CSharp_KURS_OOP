
//Создайте список вещественных чисел и найдите среднее значение всех элементов в списке.                     

List<double> numbers = new List<double> { 3.5, 2.7, 6.9, 1.2 };
double sum = 0;
foreach (var x in numbers)
{
    sum += x;
}

double average = sum / (numbers.Count);
Console.WriteLine("The average value of all the elements in the list is: " + average);
