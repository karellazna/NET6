// See https://aka.ms/new-console-template for more information

string uzivatel = Console.ReadLine();
int cislo = int.Parse(uzivatel);
int konecne_cislo = 0;

for (int i = 0; i < cislo; i++)
{
    konecne_cislo += i;
}

Console.WriteLine(konecne_cislo);


/*string uzivatel = Console.ReadLine();
int cislo_dne = int.Parse(uzivatel);
switch (cislo_dne)
{
    case 1:
        Console.WriteLine("Pondeli");
        break;
    case 2:
        Console.WriteLine("Utery");
        break;
    case 3:
        Console.WriteLine("Streda");
        break;
    case 4:
        Console.WriteLine("Ctvrtek");
        break;
    case 5:
        Console.WriteLine("Patek");
        break;
    case 6:
        Console.WriteLine("Sobota");
        break;
    case 7:
        Console.WriteLine("Nedele");
        break;
}
if (cislo_dne == 6 || cislo_dne == 7)
{
    Console.WriteLine("Jedná se o víkend");
}else
{
    Console.WriteLine("Jedná se o pracovní den");
}*/

