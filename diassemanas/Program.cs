Console.Write("Ingrese el número de días: ");
int dias = int.Parse(Console.ReadLine());
int semanas = dias / 7;
int diasRestantes = dias % 7;
Console.WriteLine($"{dias} días equivalen a {semanas} semanas y {diasRestantes} días.");