Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Mi sistema de delivery");
Console.WriteLine("Como te llamas");
string cliente = Console.ReadLine();
Console.WriteLine("Hola " + cliente + ". ¿Que deseas ordenar?");
Console.WriteLine("1. Hamburguesa");
string producto1 = Console.ReadLine();
Console.WriteLine("Anotado: " + producto1 + " para " + cliente + ".");
 