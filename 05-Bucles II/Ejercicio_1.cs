/*Ejercicio 1 - If

Escribe un programa que:

Pida datos a un cliente: Nombre, email, cupón

Determine si un cliente tiene un cupon descuento

Muestre un precio rebajado en función del descuento

Muestre el precio de un producto sin descuento si no hay cupón

Nota: puedes poner un precio fijo de un producto o uno variable.*/

double precio = 100;
double precioAPagar;

Console.WriteLine("Ingrese su nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese su email: ");
string email = Console.ReadLine();
Console.WriteLine("Tiene cupon de descuento? [true/false]: ");
bool cupon = Convert.ToBoolean(Console.ReadLine());

if (cupon == true)
{
    precioAPagar = precio * .9;
    Console.WriteLine("El valor a pagar por el artículo es {0} (incluye descuento por cupon).", precioAPagar);
} else
{
    Console.WriteLine("El valor a pagar por el artículo es {0} (no incluye descuento por cupon).", precio);
}
