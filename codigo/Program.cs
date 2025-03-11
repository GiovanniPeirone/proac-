Console.Write($"letra {i}>");
char letra1 = Console.ReadLine();
Console.Write($"letra {i}>");
char letra2 = Console.ReadLine();
Console.Write($"letra {i}>");
char letra3 = Console.ReadLine();
Console.Write($"letra {i}>");
char letra4 = Console.ReadLine();
Console.Write("¿Opcion 1 o 2?>");
int opcion = Console.Read();
if ( opcion <= 1)
{
    Console.WriteLine(letra1 + letra2 + letra3);
}
else if (opcion >= 2)
{
    Console.WriteLine(letra1 + letra2 + letra3 + letra4);
}
else
{
    Console.WriteLine("valor no valido");
}