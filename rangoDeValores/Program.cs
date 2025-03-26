Console.WriteLine("Ingrese un rango de 2 valores");
Console.Write("n1> ");
int v1 = int.Parse(Console.ReadLine());
Console.Write("n2> ");
int v2 = int.Parse(Console.ReadLine());

if (v1 == null || v2 == null){
    Console.WriteLine("Valor no valido");
}else{
    for ( int i = v1 ; i < v2 + 1 ; i++){
        Console.WriteLine(i);
    }
}