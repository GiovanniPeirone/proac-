
Console.Write("Ingrese el número de estudiantes: ");
int numeroDeEstudiantes = Convert.ToInt32(Console.ReadLine());

int[] notas = new int[numeroDeEstudiantes];

for (int i = 0; i < numeroDeEstudiantes; i++)
{
    Console.Write($"Ingrese la nota del estudiante {i + 1}: ");
    notas[i] = Convert.ToInt32(Console.ReadLine());
}

int promedio = notas.Sum() / numeroDeEstudiantes;
Console.WriteLine($"El promedio de notas es: {promedio}");