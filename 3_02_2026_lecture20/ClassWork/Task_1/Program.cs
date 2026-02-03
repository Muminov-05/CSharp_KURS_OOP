
//Напишите программу, которая запрашивает у пользователя два числа и выводит результат их деления.                                                                        
//Однако, если пользователь вводит некорректные данные (например, буквы вместо чисел), программа должна                                              
//обрабатывать это и выводить сообщение об ошибке вместо результата деления.   

try
{
    Console.Write("Vvedite pervoe chislo : ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Vvedite vtoroe chislo : ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int result = num1 / num2;
    Console.WriteLine(result);
}
catch (Exception e)
{
    Console.WriteLine($" One of the num is not good : {e.Message}");
}
finally
{
    Console.WriteLine($"The 'try catch' is finished. ");
}
