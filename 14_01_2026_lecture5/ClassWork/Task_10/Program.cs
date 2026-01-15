
// Напишите рекурсивную функцию для нахождения всех перестановок заданной строки. 


     void Permutations(string str, string current = "")
{
    if (str.Length == 0)
    {
        Console.WriteLine(current);
        return;
    }

    for (int i = 0; i < str.Length; i++)
    {
        char ch = str[i];
        string remaining =
            str.Substring(0, i) + str.Substring(i + 1);

        Permutations(remaining, current + ch);
    }
}

        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        Permutations(input);
    

