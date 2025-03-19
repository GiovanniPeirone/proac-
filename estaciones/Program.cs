
Console.Write("Estaciones del año \n 1 - Verano \n 2 - Otoño \n 3 - Invierno \n 4 -  Primavera \n");
int opcion = Convert.ToInt32(Console.ReadLine());

switch(opcion){
    case 1:
        Console.WriteLine("Verano");
        Console.WriteLine("Del 21 de diciembre a 20 de marzo");
        break;
    case 2:
        Console.WriteLine("Otoño");
        Console.WriteLine("Del 21 de marzo a 20 de junio");
        break;
    case 3:
        Console.WriteLine("Del 21 de junio a 20 de septiembre");
        break;
    case 4:
        Console.WriteLine("Del 21 de septiembre a 20 de diciembre");
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
}