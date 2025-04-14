string[,] alumnosArray = {
    { "Juan", "7" },
    { "Pedro", "8" },
    { "Maria", "9" },
    { "Ana", "10" }
};

for (int i = 0; i < alumnosArray.GetLength(0); i++)
{
    Console.WriteLine("Nombre: " + alumnosArray[i, 0]);
    Console.WriteLine("Nota: " + alumnosArray[i, 1]);
}