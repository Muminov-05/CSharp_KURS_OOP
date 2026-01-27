
//Создайте список логических значений и проверьте, все ли элементы в списке верны. (используйте метод «Все»)                         

List<bool> values = new List<bool> { true, false, true };
bool allTrue = values.All(x => x == true);
Console.WriteLine("Are all the values in the list true? " + allTrue);
