//Создайте класс `Circle`, который имеет следующие поля:
//- `radius`: типа `double`
//- `PI`: типа `final double` и инициализировано значением `3.14159`
//Класс должен иметь следующие методы и конструктори:
//-**Конструктор * *: Принимает радиус окружности в качестве аргумента.
//- **Конструктор без аргументов**: Устанавливает поле `radius` в значение `0.0`.
//- **SetRadius**: Метод для поля `radius`.
//- **GetRadius**: Метод для поля `radius`.
//- **GetArea**: Возвращает площадь окружности, которая вычисляется по формуле `area = PI * radius * radius`.
//- **GetDiameter**: Возвращает диаметр окружности, который вычисляется по формуле `diameter = radius * 2`.
//- **GetCircumference**: Возвращает длину окружности, которая вычисляется по формуле `circumference = 2 * PI * radius`.
//Напишите программу, которая демонстрирует класс `Circle`, запрашивая у пользователя радиус окружности,
//создавая объект `Circle`, а затем выводит площадь, диаметр и длину окружности.    

Circle circle = new Circle();
Console.Write("Radius : ");
circle.Radius = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Ego Ploshad : {circle.GetArea()}");
Console.WriteLine($"Ego Diametr : {circle.GetDiameter()}");
Console.WriteLine($"Ego Okrujnost : {circle.GetCircumference()}");

class Circle
{
    public double Radius { get; set; }
    public double PI = 3.1415;

    public Circle() { this.Radius = 0.0; }
    public Circle(double Radius)
    {
        this.Radius = Radius;
    }
    public void SetRadius(double radius)
    {
        this.Radius = radius;
    }
    public double GetRadius()
    {
        return Radius;
    }
    public double GetArea()
    {
        return double.Pi * Radius * Radius;
    }
    public double GetDiameter()
    {
        return 2 * Radius;
    }
    public double GetCircumference()
    {
        return 2*PI * Radius;
    }
}

