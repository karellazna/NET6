using ConsoleTest.Model;
using ConsoleTest.Data;

for (int i = 0; i < 10; i++)
{
    Point2D rnd = RandomPointGenerator.GetRandomPoint();
    Console.WriteLine(rnd);
}