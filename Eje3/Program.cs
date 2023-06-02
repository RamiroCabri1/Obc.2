Clientes rama = new Clientes("Cabri Ramiro", "25 de mayo 960", "cabriramiro@gmail.com","No","293262741");
Console.WriteLine("Datos del cliente  :" + rama.Telefono +" "+ rama.Nombre + " " + rama.Cliente + " " + rama.Direccion + " " + rama.Email);
/* La estructura clientes, permite armar el objeto cliente, luego como se puede observar, para motivos de ejemplo creo un objeto clientes con el nombre rama y le paso los datos*/



public struct Clientes
{
    public Clientes(string nombre, string direccion, string email, string cliente, string telefono)
    {
        Nombre = nombre;
        Direccion   =  direccion;
        Email = email;
        Cliente = cliente;
        Telefono = telefono;
    }


    public string Nombre { get; }
    
    public string Direccion { get; }

    public string Email { get; }

    public string Cliente { get; }

    public string Telefono { get; }




}