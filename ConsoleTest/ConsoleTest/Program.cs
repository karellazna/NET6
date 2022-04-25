// See https://aka.ms/new-console-template for more information

string Den_v_tydnu(int cislo_dne)
{

    switch (cislo_dne)
    {
        case 1:
            return "Pondeli";
            break;
        case 2:
            return "Utery";
            break;
        case 3:
            return "Streda";
            break;
        case 4:
            return "Ctvrtek";
            break;
        case 5:
            return "Patek";
            break;
        case 6:
            return "Sobota";
            break;
        case 7:
            return "Nedele";
            break;
            default: return "Chyba";
        
    }
}

Console.WriteLine(Den_v_tydnu(int.Parse(Console.ReadLine())));

