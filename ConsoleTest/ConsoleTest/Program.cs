using ConsoleTest.Model;
using ConsoleTest.Data;

Point2D p1 = RandomPointGenerator.GetRandomPoint();
Console.WriteLine(p1);
Point2D p2 = new Point2D(100, -100);
Console.WriteLine(p2);

Point2D vetsi = Math2D.MaxAreaFromOrigin(p1, p2);
Console.WriteLine($"větší obsah má bod {vetsi}");