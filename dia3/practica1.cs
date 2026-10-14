using System;

double CalcularSubtotal(double precio, int cantidad)
{
    return precio * cantidad;
}

double AplicarDescuento(double monto, int porcentaje)
{
    return monto - monto * porcentaje/100;
}

double subTotal = CalcularSubtotal(10000, 2);
double descuento;
descuento = AplicarDescuento(subTotal, 5);
Console.WriteLine($"Subtotal = {subTotal}");
Console.WriteLine($"Con descuento del 5% = {descuento}");

