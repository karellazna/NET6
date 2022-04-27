using ConsoleTest.Model;
using ConsoleTest.Data;

Point2D p1 = RandomPointGenerator.GetRandomPoint();
Console.WriteLine(p1);
Point2D p2 = new Point2D(100, -100);
Console.WriteLine(p2);

Point2D vetsi = Math2D.MaxAreaFromOrigin(p1, p2);
Console.WriteLine($"větší obsah má bod {vetsi}");

Auto vw = new Auto();
vw.Znacka = "VW";
vw.SPZ = "3U2-6666";
vw.Barva = "modra";
vw.NajeteKM = 5000;

bool stolen = CarManagment.OverSPZ(vw.SPZ);

if (stolen)
{
    Console.WriteLine("kradene");
}
else
{
    Console.WriteLine("neni kradene"); 
}
CarManagment.LoadStolenCars(@"C:\Users\Karel LAZNA\source\repos\karellazna\NET6\ConsoleTest\ConsoleTest\soubor.txt"); 