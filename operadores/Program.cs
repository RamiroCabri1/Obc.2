using System;

namespace operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Escriba su nombre y apellido: ");

            string? nombre = Console.ReadLine();

            Console.WriteLine("Escriba su Edad: ");

            string? edad = Console.ReadLine();

            Console.WriteLine("Sabe programar?: ");

            string? programinSkills = Console.ReadLine();

            Console.WriteLine(" Su nombre es : " + nombre + ". Su edad es " + edad + ". Usted " + programinSkills + " sabe programar");

            Console.WriteLine("/////////////////////////");

            Console.WriteLine("Coche");
            Console.WriteLine("Cuantas puertas tiene?");
            int puertas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuantas ruedas tiene?");
            int ruedas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cual es la marca de su auto?");
            string? marca = Console.ReadLine();
            Console.WriteLine("Cual es su ITV Vigente?");
            int itv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mesa");
            Console.WriteLine("Cuanto pesa la misma?");
            int peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cual es su largo?");
            int largo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cual es el material del que esta compuesto?");
            string? material = Console.ReadLine();
            Console.WriteLine("Cual es su color?");
            string? color = Console.ReadLine();

            Console.WriteLine("Auto>>>>>" + puertas + " puertas, " + ruedas + " ruedas, " + " de la marca " + marca + ", con el IVT " + itv + ".");
           */

            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("Veamos si el numero que ingrese es mas grande que 18");
            int numerobase = 18;
            int numero = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("el numero elegido es mas grande que el numero 18 =  " + (numero > numerobase));
            Console.WriteLine("el numero elegido es mas pequeño que el numero 18 =  " + (numero < numerobase));
            Console.WriteLine("el numero elegido es igual que el numero 18 =  " + (numero == numerobase));
            
            char letra = 'A';


            Console.WriteLine((numerobase == 18 && numerobase > 10));
            Console.WriteLine((numerobase == 18 || numerobase == 10));



        }


    }
}