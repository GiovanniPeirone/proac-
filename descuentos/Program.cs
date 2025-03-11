Console.WriteLine("Ingrese el precio del producto: ");
float precio = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el Descuento: ");
float descuento = float.Parse(Console.ReadLine());
precio = precio * (1 - descuento / 100);
Console.WriteLine("El precio final es: " + precio);
