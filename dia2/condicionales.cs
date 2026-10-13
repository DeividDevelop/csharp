using System;

Console.Write("Ingrese su edad");
int edad = Convert.ToInt32(Console.ReadLine());
if (edad >= 18)
{
    Console.WriteLine("Bienvenido al Party - Gorilazz");
    if (edad >= 20)
    {
        Console.WriteLine("Desea una bebida?");

    }else
    {
        Console.WriteLine("Desea una coca cola?");
    }
}
else
{
    Console.WriteLine("Acceso denegado");
}