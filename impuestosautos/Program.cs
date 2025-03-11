Console.Write("Ingrese el año del vehículo: ");
int anio = int.Parse(Console.ReadLine());

Console.Write("Ingrese el precio del vehículo: ");
double precio = double.Parse(Console.ReadLine());

double impuesto = 0;

if (anio < 2000 && precio < 200000)
{
    impuesto = 0.05;
else if (anio >= 2000 && anio <= 2015 && precio >= 200000 && precio <= 500000)
{
    impuesto = 0.10; 
}
else if (anio > 2015 || precio > 500000)
{
    impuesto = 0.15; 
}
else
{
    Console.WriteLine("El vehículo no paga impuesto.");
    return;
}

double montoImpuesto = precio * impuesto;
Console.WriteLine($"El impuesto a pagar es del {impuesto * 100}%: ${montoImpuesto:F2}");