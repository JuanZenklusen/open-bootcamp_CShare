/*Ejercicio 1

Crea una estructura de datos para un cliente con estos campos:

Nombre completo
Teléfono
Dirección
Email
Si es nuevo cliente

Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)*/

//Prueba:
//Cliente primerCliente = new Cliente("Juan Zenklusen", 34921564325, "ciudadlinda 23", "juanzenklusen@gmail.com", true);
//Console.WriteLine(primerCliente);
public struct Cliente
{
    public Cliente(string nombreCompleto, long telefono, string direccion, string email, bool esNuevoCliente)
    {
        _nombreCompleto = nombreCompleto;
        _telefono = telefono;
        _direccion = direccion;
        _email = email;
        _esNuevoCliente = esNuevoCliente;
    }
    public string _nombreCompleto { get; set; }
    public long _telefono { get; set; }
    public string _direccion { get; set; }
    public string _email { get; set; }
    public bool _esNuevoCliente { get; set; }

    public override string ToString() => $"{_nombreCompleto} - {_telefono} - {_direccion} - {_email} - {_esNuevoCliente}";
}
