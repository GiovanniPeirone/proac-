
while (true)
{
    Console.WriteLine("Calculadora");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");
    Console.Write(">");

    int opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + (num1 + num2));
            break;
        case 2:
            Console.Write("Ingrese el primer número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + (num1 - num2));
            break;
        case 3:
            Console.Write("Ingrese el primer número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + (num1 * num2));
            break;
        case 4:
            Console.Write("Ingrese el primer número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + (num1 / num2));
            break;
        case 5:
            Console.WriteLine("Saliendo...");
            break;
    }
    if (opcion == 5)
    {
        break;
    }
}


