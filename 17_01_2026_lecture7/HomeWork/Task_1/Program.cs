
//Создайте класс под названием `Rectangle`со следующими характеристиками:

//***Width * *: целое число, представляющее ширину прямоугольника.
//* **Height**: целое число, представляющее высоту прямоугольника.
//* **Color**: строка, представляющая цвет прямоугольника.
//* **GetArea()**: возвращает площадь прямоугольника.
//* **GetPerimeter()**: возвращает периметр прямоугольника.

Rectangle rectangle = new Rectangle();

Console.Write(" Width : ");
rectangle.Width = Convert.ToInt32(Console.ReadLine());
Console.Write(" Height : ");
rectangle.Height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" Square ({rectangle.Width} , {rectangle.Height} ) : {rectangle.GetArea()}");
Console.WriteLine($" GetPerimeter ({rectangle.Width} , {rectangle.Height} ) : {rectangle.GetPerimeter()}\n");

Console.WriteLine("Vtoroi Primer ");
Rectangle new_rec = new Rectangle(6,4);
Console.WriteLine($" Square ({new_rec.Width} , {new_rec.Height} ) : {new_rec.GetArea()}");
Console.WriteLine($" GetPerimeter ({new_rec.Width} , {new_rec.Height} ) : {new_rec.GetPerimeter()}");

class Rectangle
{
    public int Width;
    public int Height;
    public string Color;

    public Rectangle() {}
    public Rectangle(int  x, int y)
    {
        Width = x; 
        Height = y;
    }

    public int GetArea()
    {
        return Width * Height;
    }
    public int GetPerimeter()
    {
        return 2 *( Width +  Height );
    }

}
