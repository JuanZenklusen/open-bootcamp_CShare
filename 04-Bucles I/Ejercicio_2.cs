/* Ejercicio 2 - Do while

Escribe un programa que realice estos pasos:

Reciba al menos un número por consola

Determine si el número es positivo o negativo

Presente un contador para cada tipo (positivo y negativo).

Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. 
Tienes completa libertad para elegir el formato de la salida.*/

int num;
Console.WriteLine("Indique un número: ");
num = Convert.ToInt32(Console.ReadLine());
do
{
    if(num > 0)
    {
        Console.WriteLine("Numero Positivo");
        break;
    } else {
        if (num < 0) {
            Console.WriteLine("Numero negativo");
            break;
        } else
        {
            Console.WriteLine("El numero es 0, no es positivo ni nengativo");
            break;
        }
    
    }

} while (num != 0);
