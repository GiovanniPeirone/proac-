Console.Write("Numero");
int num = int.Parse(Console.ReadLine());

for ( int i = 0; i < 11; i++ ){
    Console.WriteLine($"{num} x {i} = {num * i}");
}