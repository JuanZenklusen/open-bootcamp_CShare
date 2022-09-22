/*Ejercicio 2
Escribe un programa que tome la hora y la escriba por pantalla.*/

string horaActual = DateTime.Now.ToString("hh:mm:ss tt");
Console.WriteLine("La hora actual es: " + horaActual);
