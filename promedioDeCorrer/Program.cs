Console.Write("cuantos minutos el Lunes: ");
int lunes = Convert.ToInt32(Console.ReadLine());
Console.Write("cuantos minutos el Miercoles: ");
int miercoles = Convert.ToInt32(Console.ReadLine());
Console.Write("cuantos minutos el Viernes: ");
int viernes = Convert.ToInt32(Console.ReadLine());
int promedio = (lunes + miercoles + viernes) / 3;
Console.WriteLine(promedio);