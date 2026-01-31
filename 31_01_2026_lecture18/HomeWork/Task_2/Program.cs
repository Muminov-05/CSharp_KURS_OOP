//### Task 2:
// 🔍 Давайте рассмотрим статический класс для работы с геометрическими фигурами:
//1.Круг:
//   -Метод `CalcCircleArea(radius)`: Принимает радиус круга и вычисляет его площадь                                            
//     по формуле πr², где π - математическая константа, а r - радиус.                                  
//   - Метод `CalcCirclePerimeter(radius)`: Принимает радиус круга и вычисляет его периметр по формуле 2πr.
//2. Прямоугольник:
//   -Метод `CalcRectangleArea(length, width)`: Принимает длину и ширину прямоугольника и                            
//      вычисляет его площадь по формуле A = l * w, где l - длина, w - ширина.                                 
//   - Метод `CalcRectanglePerimeter(length, width)`:                                                             
//      Принимает длину и ширину прямоугольника и вычисляет его периметр по формуле P = 2(l + w).                                                       
//3. Треугольник:
//   -Метод `CalcTriangleArea(base, height)`: Принимает основание и высоту треугольника и                                                                                
//      вычисляет его площадь по формуле A = 0.5 * b * h, где b - основание, h - высота.                                                             
//   - Метод `CalcTrianglePerimeter(side1, side2, side3)`: Принимает длины трех сторон треугольника и                                                         
//    вычисляет его периметр по формуле P = a + b + c, где a, b, c - стороны треугольника.                                                        
//В этом статическом классе вы можете вызывать эти методы, передавая соответствующие параметры,
//и получать площадь и периметр соответствующей геометрической фигуры без необходимости создавать экземпляр класса.                            

Shape.CalcCircleArea(5);
Shape.CalcCirclePerimeter(5);

Shape.CalcRectangleArea(5, 4);
Shape.CalcRectanglePerimeter(5,4);

Shape.CalcTriangleArea(10, 5);
Shape.CalcTrianglePerimeter(3, 7, 6);

static class Shape
{
    private static double Pi = 3.14;
    public static void CalcCircleArea(double radius)
    {
        Console.WriteLine($" The Area of Circle with radius {radius} is : {Pi*radius*radius}");
    }

    public static void CalcCirclePerimeter(double radius)
    {
        Console.WriteLine($" The Perimetr of Circle with radius {radius} is : {2 * Pi * radius}");
    }

    public static void CalcRectangleArea(double length, double width)
    {
        Console.WriteLine($" The Area of Rectangle with length={length}, width={width} is : {length * width}");
    }

    public static void CalcRectanglePerimeter(double length, double width)
    {
        Console.WriteLine($" The Perimetr of Rectangle with length={length}, width={width} is : {length * width}");
    }

    public static void CalcTriangleArea(double bases, double height)
    {
        Console.WriteLine($" The Area of Triangle with bases={bases}, height={height} is : {0.5*bases*height}");
    }

    public static void CalcTrianglePerimeter(double side1, double side2, double side3)
    {
        Console.WriteLine($" The perimetr of Triangle with lengths :({side1},{side2},{side3}) is : {side1+side2+side3}");
    }
}