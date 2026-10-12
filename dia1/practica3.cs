Console.OutputEncoding = System.Text.Encoding.UTF8;
DateTime ahora = DateTime.Now;
Console.WriteLine("Fecha: " + ahora.ToString("dd/MM/yyyy"));
Console.WriteLine("Hora: " + ahora.ToString("HH:mm"));
Console.WriteLine("Día de la semana: " + ahora.DayOfWeek);
Console.WriteLine("Faltan " + (24 - ahora.Hour) + " horas para el cierre del sistema de delivery.");