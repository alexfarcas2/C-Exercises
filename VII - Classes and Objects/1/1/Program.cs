public class Point
{
    public double X { get; private set; }
    public double Y { get; private set; }

    // Constructor for initialization
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Copy constructor
    public Point(Point point) : this(point.X, point.Y) { }

    // Method to calculate the distance between two points
    public static double CalculateDistance(Point a, Point b)
    {
        return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
public class Triangle
{
    public Point Point1 { get; private set; }
    public Point Point2 { get; private set; }
    public Point Point3 { get; private set; }

    // Constructor for the class
    public Triangle(Point point1, Point point2, Point point3)
    {
        Point1 = point1;
        Point2 = point2;
        Point3 = point3;
    }

    // Method to calculate the perimeter of the triangle
    public double CalculatePerimeter()
    {
        return Point.CalculateDistance(Point1, Point2) +
               Point.CalculateDistance(Point2, Point3) +
               Point.CalculateDistance(Point3, Point1);
    }

    // Method to calculate the area of the triangle
    public double CalculateArea()
    {
        double halfPerimeter = CalculatePerimeter() / 2;
        return Math.Sqrt(halfPerimeter *
                         (halfPerimeter - Point.CalculateDistance(Point1, Point2)) *
                         (halfPerimeter - Point.CalculateDistance(Point2, Point3)) *
                         (halfPerimeter - Point.CalculateDistance(Point3, Point1)));
    }

    public override string ToString()
    {
        return $"Triangle with points {Point1}, {Point2}, and {Point3}";
    }
}
class Program
{
    static void Main()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(1, 0);
        Point p3 = new Point(0, 1);

        Triangle triangle = new Triangle(p1, p2, p3);

        Console.WriteLine(triangle);
        Console.WriteLine($"Perimeter: {triangle.CalculatePerimeter()}");
        Console.WriteLine($"Area: {triangle.CalculateArea()}");
    }
}
