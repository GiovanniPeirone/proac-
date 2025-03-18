

using System.Xml.Serialization;

string[] opciones = {
    "Opcion 1 : directorio",
    "Opcion 2 : time",
    "Opcion 3 : date",
    "Opcion 4 : exit"
};


while (true)
{
    MostrarMenu(opciones);
    Console.Write(">");
    
    int opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Directorio actual: " + Directory.GetCurrentDirectory());
            break;
        case 2:
            Console.WriteLine("Hora actual: " + DateTime.Now.ToString("HH:mm:ss"));
            break;
        case 3:
            Console.WriteLine("Fecha actual: " + DateTime.Now.ToString("dd/MM/yyyy"));
            break;
        case 4:
            Console.WriteLine("Saliendo...");
            break;
    }       
    if (opcion == 4)
    {
            break;
    }
}

void MostrarMenu(string[] opciones)
{
    for (int i = 0; i < opciones.Length; i++)
    {
        Console.WriteLine(opciones[i]);
    }
}