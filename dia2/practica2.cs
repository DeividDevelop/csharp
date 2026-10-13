Console.WriteLine("Conversion de Gs a dólares");
Console.WriteLine("---------------------------");
Console.Write("Escriba la cotización del dólar: ");
double cotizacion = Convert.ToDouble(Console.ReadLine());
Console.Write("Monto en guaraníes a convertir: ");
double guaranies = Convert.ToDouble(Console.ReadLine());
double dolares = guaranies / cotizacion;
Console.WriteLine($"Son {dolares:N2} dólares");