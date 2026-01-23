
//Создайте список строк и объедините все строки в одну строку.                      

List<string> words = new List<string> { "hello", "world", "!" };
string concat="";
foreach (var word in words)
{
    concat = concat + word + " ";
}
Console.WriteLine("The concatenated string is: " + concat);

// vtoroi sposob 
string newStr = string.Join(" ", words);
Console.WriteLine("The concatenated string is: " + newStr);