
Console.Write("Ingrese su salario: ");
int salario = Convert.ToInt32(Console.ReadLine());
float aumento = 1.25f;
float salario_anterior = salario / aumento;
Console.WriteLine($"El salario anterior es: {salario_anterior}");
Console.WriteLine($"El salario actual es: {salario}");
Console.WriteLine($"El aumento es: {aumento}");


