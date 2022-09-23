/*Ejercicio 1
Variables Escribe un programa que reciba datos de una persona y genera un mensaje, 
usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.*/

Console.WriteLine("Indique su nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine("Indique su apellido: ");
string apellido = Console.ReadLine();

Console.WriteLine("Indique su edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Indique si sabe programar (SI/NO): ");
string sabeProgramar = Console.ReadLine();

string resultado = "Su nombre es " + nombre + " y su apellido " + apellido + ". Tiene " + edad + " años de edad y " + sabeProgramar + " sabe programar.";

Console.WriteLine(resultado);
