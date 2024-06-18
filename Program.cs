using System.Collections.Generic;

//Создайте два интерфейса: IPerson с методом Speak и IWorker с методом Work, который наследуется от IPerson. Затем создайте класс Employee, который реализует интерфейс IWorker.

//Требования:

//Интерфейс IPerson должен содержать метод void Speak().
//Интерфейс IWorker должен содержать метод void Work() и наследовать IPerson.
//Класс Employee должен реализовывать методы Speak и Work, выводя соответствующие сообщения в консоль.



Employee empl = new Employee();
empl.Speak();
empl.Work();
Console.WriteLine("------------------------------------");

List<IDisplayable> list = new List<IDisplayable>();
Product apple = new Product();
Service cosmetics = new Service();
list.Add(apple);
list.Add(cosmetics);
foreach (var l in list)
{
    l.Display();
}
Console.WriteLine("-------------------------------------");


Grid grid = new Grid(10, 8);

try
{
    grid.SetValue(11, 11, 21);
    grid.SetValue(5, 5, 11);
    Console.WriteLine($"grid[1,1] = {grid.GetValue(1, 1)}");
    Console.WriteLine($"grid[5,5] = {grid.GetValue(5, 5)}");
    Console.WriteLine($"grid[11,11] = {grid.GetValue(11, 11)}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("----------------------------------------");

Circle circle = new Circle(15);
Rectangle rect = new Rectangle(10, 8);
Triangle triangle = new Triangle(3, 4, 5);

List<IShape> shapes = new List<IShape>();
shapes.Add(circle);
shapes.Add(rect);
shapes.Add(triangle);
double AllArea = 0;
double AllPerimeter = 0;
foreach (var sh in shapes)
{
    AllArea += sh.Area();
    AllPerimeter += sh.Perimeter();
}
Console.WriteLine($"суммарную площадь = {AllArea}");
Console.WriteLine($"периметр всех фигур = {AllPerimeter}");
Console.WriteLine("------------------------------------------------");



Product1[] product1s = new Product1[]
{
    new Product1("apple", 65),
    new Product1("cherry", 25),
    new Product1("limon", 55),
    new Product1("mango", 125)
};
Print(product1s);
Array.Sort(product1s);
Console.WriteLine();
Print(product1s);
void Print(Product1[] product1s)
{
    foreach (var p in product1s)
    {
        Console.WriteLine($"название продукта - {p.Name}, цена - {p.Price}");
    }
}




interface IPerson
{
    void Speak();
}

interface IWorker : IPerson
{
    void Work();
}

class Employee : IWorker
{
    public void Speak()
    {
        Console.WriteLine("Hello."); ;
    }

    public void Work()
    {
        Console.WriteLine("I am worker.");
    }
}

//Описание: Создайте интерфейс IDisplayable с методом Display. Затем создайте два класса Product и Service, которые реализуют этот интерфейс.
//Напишите программу, которая хранит коллекцию объектов этих классов и вызывает метод Display для каждого объекта.

//Требования:

//Интерфейс IDisplayable должен содержать метод void Display().
//Класс Product должен реализовывать метод Display, выводя информацию о продукте.
//Класс Service должен реализовывать метод Display, выводя информацию о сервисе.
//Программа должна использовать коллекцию List<IDisplayable> для хранения объектов и вызывать метод Display для каждого объекта в коллекции.



interface IDisplayable
{
    void Display();
}
class Product : IDisplayable
{
    public void Display()
    {
        Console.WriteLine("This is a product. Buy it.");
    }
}
class Service : IDisplayable
{
    public void Display()
    {
        Console.WriteLine("The service provides cosmetology services.");
    }
}



//Создайте интерфейс IGrid с методами SetValue(int x, int y, int value) и GetValue(int x, int y). Затем создайте класс Grid, который реализует
//этот интерфейс и использует двумерный массив для хранения значений.

//Требования:

//Интерфейс IGrid должен содержать методы void SetValue(int x, int y, int value) и int GetValue(int x, int y).
//Класс Grid должен реализовывать интерфейс IGrid и использовать двумерный массив для хранения значений.
//В классе Grid должны быть реализованы методы SetValue и GetValue, которые будут изменять и возвращать значения в массиве.

interface IGrid
{
    void SetValue(int x, int y, int value);
    int GetValue(int x, int y);
}
class Grid : IGrid
{
    int SizeX;
    int SizeY;
    public int[,] mas;
    public Grid(int sizeX, int sizeY)
    {
        SizeX = sizeX;
        SizeY = sizeY;
        mas = new int[sizeX, sizeY];
    }
    public int GetValue(int x, int y)
    {
        if (x > SizeX || y > SizeY)
            throw new Exception("Невозможно получить значение. вылезли за границы массива.");
        return mas[x,y];
    }

    public void SetValue(int x, int y, int value)
    {
        if (x > SizeX || y > SizeY)
        {
            Console.WriteLine("значение не установленно.вылезли за границы массива.");
        }
        else
            mas[x, y] = value;
    }
}

//Создайте интерфейс IShape с методами Area() и Perimeter(). Затем создайте классы Circle, Rectangle и Triangle, которые реализуют этот интерфейс. 
//    Напишите программу, которая хранит коллекцию объектов типа IShape и вычисляет суммарную площадь и периметр всех фигур.

//Требования:

//Интерфейс IShape должен содержать методы double Area() и double Perimeter().
//Класс Circle должен реализовывать интерфейс IShape, методы Area и Perimeter должны вычислять площадь и периметр круга.
//Класс Rectangle должен реализовывать интерфейс IShape, методы Area и Perimeter должны вычислять площадь и периметр прямоугольника.
//Класс Triangle должен реализовывать интерфейс IShape, методы Area и Perimeter должны вычислять площадь и периметр треугольника.
//Программа должна использовать коллекцию List<IShape> для хранения объектов и вычислять суммарную площадь и периметр всех фигур.

interface IShape
{
    double Area();
    double Perimeter();
}
class Circle : IShape
{
    public double Radius;
    public Circle(double radius)
    {
        Radius = radius;
    }
    public double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Rectangle :IShape
{
    public double Width;
    public double Lenght;
    public Rectangle (double w, double l)
    {
        Width = w;
        Lenght = l;
    }
    public  double Area()
    {
        return Width * Lenght;
    }

    public double Perimeter()
    {
        return (Width + Lenght)*2;
    }
}

class Triangle : IShape
{
    public double a;
    public double b;
    public double c;

    public Triangle(double num1, double num2, double num3)
    {
        a = num1;
        b = num2;
        c = num3;
    }
    private double P { get => a + b + c; }
    public double Area()
    {
        double pivP = P / 2;
        return Math.Sqrt(pivP * (pivP - a) * (pivP - b) * (pivP - c));
    }
  
    public double Perimeter()
    {
        return P;
    }
}


//Создайте интерфейс IComparableItem с методом CompareTo. Затем создайте класс Product с полями Name и Price, 
//    который реализует этот интерфейс для сравнения продуктов по цене. Напишите программу, которая сортирует массив объектов Product по возрастанию цены.

//Требования:

//Интерфейс IComparableItem должен содержать метод int CompareTo(object obj).
//Класс Product должен содержать поля string Name и double Price, а также реализовывать метод CompareTo для сравнения продуктов по цене.
//Программа должна создавать массив объектов Product и сортировать его по возрастанию цены с использованием метода Array.Sort.

interface IComparableItem
{
    int CompareTo(object obj);
}

class Product1 : IComparable
{
    public string Name;
    public double Price;

    public Product1(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public int CompareTo(object obj)
    {
        if (obj is Product1 product)
        {
            return Price.CompareTo(product.Price);
        }

        else throw new Exception("Это не продукт");
    }
}