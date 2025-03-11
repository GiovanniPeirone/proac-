Console.Write("Antigüedad del empleado> ");
int antiguedad = int.Parse(Console.ReadLine());

Console.Write("Salario del empleado> ");
double salario = double.Parse(Console.ReadLine());

double nuevoSalario = salario;

if (salario < 50000 && antiguedad > 10)
{
    nuevoSalario = salario * 1.2;
}
else if (salario < 70000 && antiguedad >= 5 && antiguedad <= 10)
{
    nuevoSalario = salario * 1.1;
}
else if (salario < 30000 && antiguedad < 5)
{
    nuevoSalario = salario * 1.05;
}

Console.WriteLine($"El nuevo salario es: {nuevoSalario:F2}");