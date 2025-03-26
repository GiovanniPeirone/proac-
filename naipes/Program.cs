

Console.Write("Escribe tu nombre: ");
string nombre = Console.ReadLine();


while (true)
{
    opciones();
    try
    {
        int opcion = Convert.ToInt32(Console.ReadLine());
    }


    int carta = new Random().Next(1, 12);

    if (carta => 21)
    {
        Console.WriteLine("Perdiste");
        break;
    }

    Console.WriteLine($"Hola {nombre}, tu carta es: {carta}");




}

void opciones()
{
    Console.WriteLine("1. Pedir carta");
    Console.WriteLine("2. Plantarse");
    Console.WriteLine("3. Salir");
    Console.Write("Elige una opción: ");
}

