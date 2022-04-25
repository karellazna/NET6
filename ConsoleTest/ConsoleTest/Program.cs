// See https://aka.ms/new-console-template for more information


string a = Console.ReadLine();
string b = Console.ReadLine();
string c = Console.ReadLine();

int a_parse = int.Parse(a);
int b_parse = int.Parse(b);
int c_parse = int.Parse(c);

if (a_parse > b_parse)
{
    if(a_parse > c_parse)
    {
        Console.WriteLine("nejvetsi je a:" + a_parse);
    }
} else if (b_parse > c_parse)
{
    Console.WriteLine("Nejvetsi je b:" + b_parse);
} else
{
    Console.WriteLine("Nejvetsi je c:" + c_parse);
}