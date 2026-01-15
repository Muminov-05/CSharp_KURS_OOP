
//Создайте класс под названием "Rectangle" с свойствами для ширины и высоты. Включите метод,
//который вычисляет площадь прямоугольника. Затем создайте объект класса "Rectangle" и установите               
//его свойства. Вызовите метод для вычисления площади и распечатайте ее в консоли.               
//Затем измените значения свойств ширины и высоты и пересчитайте площадь.             
//Распечатайте новый результат в консоли.. 


Rectangle rectangle = new Rectangle();
rectangle.SetValue();
Console.WriteLine(" Square : " + rectangle.Square());

rectangle.SetValue();
Console.WriteLine(" Square : " + rectangle.Square()); ;

class Rectangle
{
    public int width;
    public int height;

    public void SetValue()
    {
        Console.Write(" Width : ");
        width = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Height :  ");
        height = Convert.ToInt32(Console.ReadLine());
    }

    public int Square()
    {
        return width * height;
    }
}