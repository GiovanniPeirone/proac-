// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

Console.Write("Base del triangulo: ");
int baseTriangulo = Convert.ToInt32(Console.ReadLine());


Console.Write("Altura del Triangulo: ");
int AlturaTriangulo = Convert.ToInt32(Console.ReadLine());

int Perimetro = 0;

for (int i = 0; i < 3; i++)
{
    Console.Write($"Ingrese el lado {i + 1}");
    Perimetro = Perimetro + Convert.ToInt32(Console.ReadLine());
}

int Area = baseTriangulo * (AlturaTriangulo / 2);

Console.WriteLine($"El area del triangulo es: {Area}");
Console.WriteLine($"El perimetro del triangulo es: {Perimetro}");