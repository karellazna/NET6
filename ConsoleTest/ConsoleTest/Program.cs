int konecne_cislo = 0;

do
{
    int cislo = int.Parse(Console.ReadLine());
    konecne_cislo += cislo;
}
while (Console.ReadLine() != "Q");
 
Console.WriteLine(konecne_cislo);










enum denVTydnu
{
    PONDELI,
    UTERY,
    STREDA,
    CTVRTEK,
    PATEK,
    SOBOTA,
    NEDELE
}
