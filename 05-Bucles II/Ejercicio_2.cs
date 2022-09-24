/*Ejercicio 2 - Switch

Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. 
Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. 
Presenta el resultado en consola.

Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.*/

Console.WriteLine("Lista de lenguajes de programacion: \n" +
    "a) C# \n" +
    "b) Java \n" +
    "c) C++ \n" +
    "d) Pyton\n\n");
Console.WriteLine("Introduzca la letra del lenguaje seleccionado: ");
string eleccion = Console.ReadLine().ToLower();

switch (eleccion)
{
    case "a":
        Console.WriteLine("Hola Mundo");
        break;
    case "b":
        Console.WriteLine("Java");
        break;
    case "c":
        Console.WriteLine("C++");
        break;
    case "d":
        Console.WriteLine("Pyton");
        break;
    default:
        Console.WriteLine("No ingreso una opcion viable.");
        break;
}
