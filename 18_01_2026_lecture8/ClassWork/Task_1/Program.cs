//Напишите программу на C#, которая запрашивает у пользователя два числа и одну операцию (`+`, `-`, `*`, `/`).  
//Затем она выполнит указанную операцию и отобразит результат на экране. 

//### Инструкции

//1. Создайте публичный класс `Calculator`.

//2. Создайте конструктор, который инициализирует первое число и второе число: `Calculator(firstNum, secondNum)`.

//3.Создайте бесконечный цикл в классе `Program`.

//4. Создайте следующие методы в классе `Calculator`:      
//    a. `Sum()` (Сложение)
//    b. `Subtract()` (Вычитание)
//    c. `Multiplication()` (Умножение)
//    d. `Division()` (Деление)  

Calculator calculate = new Calculator();
Console.Write("The first number is : ");
calculate.firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("The operation is : ");
char a = Convert.ToChar(Console.ReadLine());
switch (a)
{
    case '+':
        {
            Console.Write("The second number is : ");
            calculate.secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{calculate.firstNum} + {calculate.secondNum} = {calculate.Sum()}");
            break;
        }
    case '-':
        {
            Console.Write("The second number is : ");
            calculate.secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{calculate.firstNum} - {calculate.secondNum} = {calculate.Subtract()}");
            break;
        }
    case '*':
        {
            Console.Write("The second number is : ");
            calculate.secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{calculate.firstNum} * {calculate.secondNum} = {calculate.Multiplication()}");
            break;
        }
    case '/':
        {
            Console.Write("The second number is : ");
            calculate.secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{calculate.firstNum} / {calculate.secondNum} = {calculate.Division()}");
            break;
        }
    default: {
            Console.WriteLine("Неверный выбор.Попробуйте сного.");
            break;
        }
}


class Calculator
{
    public int firstNum {  get; set; }
    public int secondNum { get; set; }

    public Calculator() {}
    public Calculator(int firstNum , int secondNum)
    {
        this.firstNum = firstNum;  
        this.secondNum = secondNum;
    }

    public int Sum()
    {
        return firstNum + secondNum;
    }
    public int Subtract()
    {
        return firstNum - secondNum;
    }
    public int Multiplication()
    {
        return secondNum * firstNum;
    }
    public int Division()
    {
        return firstNum / secondNum;
    }
}