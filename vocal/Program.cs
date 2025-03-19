

Console.Write("Escriba una vocal: ");
char vocal = Console.ReadLine()[0];

switch (vocal)
{
    case 'a':
        Console.WriteLine("avión ");
        break;
    case 'e':
        Console.WriteLine("elefante ");
        break;
    case 'i':
        Console.WriteLine("iglesia ");
        break;
    case 'o':
        Console.WriteLine("oso ");
        break;
    case 'u':
        Console.WriteLine("uva ");
        break;
    default:
        Console.WriteLine("No es una vocal");
        break;
}



