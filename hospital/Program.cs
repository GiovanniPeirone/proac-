
float Ginecología = 40f;
float Pediatría = 30f;
float Traumatología = 30f;
Console.Write("Monto de dinero del hospital: ");
int monto = Convert.ToInt32(Console.ReadLine());
float montoGinecoloía = monto * Ginecología / 100;
Console.WriteLine(montoGinecoloía);
float montoPediatria = monto * Pediatría / 100;
Console.WriteLine(montoPediatria);
float montoTraumatología = monto * Traumatología / 100;
Console.WriteLine(montoTraumatología);