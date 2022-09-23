/*Ejercicio 2
Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
Coche: puertas, ruedas, marca, ITV vigente
Mesa: peso, largo, material, color
Nota: puedes escribir estos datos por consola si prefieres verlos. 
La idea del ejercicio es almacenar los datos en los tipos más adecuados.*/

Console.WriteLine("Para coche: ");
Console.WriteLine("Defina cantidad de puertas: ");
int cantidadPuertas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Defina cantidad de ruedas: ");
int cantidadRuedas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese marca: ");
string marca = (Console.ReadLine()); 
Console.WriteLine("¿Tiene ITV vigente (TRUE/FALSE): ");
bool itv = Convert.ToBoolean(Console.ReadLine());
string resultadoAuto = "Puertas: " + cantidadPuertas + " - Ruedas: " + cantidadRuedas + " - Marca: " + marca + " - ITV Vigente: " + itv;
Console.WriteLine(resultadoAuto);


Console.WriteLine("Para mesa: ");
Console.WriteLine("Defina peso: ");
double peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Defina largo: ");
double largo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese material: ");
string material = Console.ReadLine();
Console.WriteLine("Color: ");
string color = Console.ReadLine();
string resultadoMesa = "Peso: " + peso + " - Largo: " + largo + " - Material: " + material + " - Color: " + color;
Console.WriteLine(resultadoMesa);
