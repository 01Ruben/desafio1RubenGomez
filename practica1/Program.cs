using System.Diagnostics;

namespace practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Ruben";
            string apellido = "Gomez";
            int dni = 25264164;
            int edad = 47;
            float altura = 1.68f;

            Console.WriteLine("mi nombre es " + nombre +" "+ apellido + " con dni " + dni + " tengo " + edad + " años y mi altura es " + altura);


            int numero1 = 25;
            int numero2 = 30;

            Console.WriteLine("La suma de los dos numeros es "+numero1 + numero2);
            Console.WriteLine("mi nombre es "+ nombre + " Destego " + apellido);
            Console.ReadKey();
        }
    }
}
