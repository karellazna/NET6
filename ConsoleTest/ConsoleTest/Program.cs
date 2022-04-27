using ConsoleTest.Model;
using ConsoleTest.Data;

int[] cisla = { 11, 2, 13, 44, -5, 6, 127, -99, 0, 256 };

var result = cisla.Where(x => -50 < x && x > 50);
foreach (int x in result)
{
    Console.WriteLine(x);
}