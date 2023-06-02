

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Datos rama = new Datos("pedo", "caca");
            Console.WriteLine("hola "+ rama.X)
            public struct Datos
           {
            public Datos(string x, string y)
            {
                X = x;
                Y = y;
            }


            public string X { get; }
            public string X { get; }
          
           }        
        }
    }
}