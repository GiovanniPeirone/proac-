const int cantidadDeEmpleados = 5;
string[,] empleados = new string[cantidadDeEmpleados, 4]; // 4 columnas: nombre, apellido, edad, sexo

for (int i = 0; i < cantidadDeEmpleados; i++)
{
    Console.Write("Ingrese el nombre del empleado: ");
    empleados[i, 0] = Console.ReadLine();

    Console.Write("Ingrese el apellido del empleado: ");
    empleados[i, 1] = Console.ReadLine();

    Console.Write("Ingrese la edad del empleado: ");
    empleados[i, 2] = Console.ReadLine();

    Console.Write("Ingrese el sexo del empleado: ");
    empleados[i, 3] = Console.ReadLine();

    Console.WriteLine("El empleado ha sido registrado con éxito.");
    Console.WriteLine("Presione una tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}

// Ejemplo de impresión:
Console.WriteLine("Lista de empleados registrados:");
for (int i = 0; i < cantidadDeEmpleados; i++)
{
    Console.WriteLine($"Empleado {i + 1}: {empleados[i, 0]} {empleados[i, 1]}, Edad: {empleados[i, 2]}, Sexo: {empleados[i, 3]}");
}