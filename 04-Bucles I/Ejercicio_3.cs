/*Ejercicio 3 - For

Escribe un programa que realice estos pasos:

Reciba 3 datos:

ancho

alto

relleno o no

Dibuje en consola con un mismo caracter, por ejemplo *, 
un rectángulo de las dimensiones introducidas y use el tercer 
dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.

En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

Reto: Extiende el programa anterior para recibir otro número que sea 
el número de cuadrados o rectángulos que se deben dibujar en la pantalla.Ejemplos:

Input: 2,2,2, relleno = true

Output:

** **

** **

Input: 3, 4, 1, relleno = false

Output:

***

* *

* *

***
*/

int ancho;
int alto;
int relleno;
bool rellenoBool;
const char a = '*';

Console.WriteLine("Ingrese ancho: ");
ancho = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese alto: ");
alto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Si está relleno ingrese 2, de lo contrario ingrese 1: ");
relleno = Convert.ToInt32(Console.ReadLine());

while (relleno != 1 && relleno != 2)
{
    Console.WriteLine("Ingresó un numero incorrecto. \n Si está relleno ingrese 2, de lo contrario ingrese 1: ");
    relleno = Convert.ToInt32(Console.ReadLine());
}

if (relleno == 2)
{
    rellenoBool = true;
} else
{
    rellenoBool = false;
}


for (int j = 0; j < alto; j++)
{
    for (int i = 0; i < ancho; i++)
    {
    if (rellenoBool == true)
        {
            Console.Write( "{0}{1} ", a, a);
            
    } else
        {
            Console.Write( a + " ");
            
    }
    }
    Console.WriteLine("\n");
}
