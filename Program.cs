using System;

namespace AppConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            celular[] a= new celular[3];
            for (int i = 0; i < a.Length; i++)
             {
                a[i] = new celular() ;
                Console.WriteLine("Nombre del contacto");
                a[i].Nombre ="";
                a[i].Nombre = Console.ReadLine();
                a[i].Lada = "+52";
                Console.WriteLine("Numero de telefono");
                a[i].Numero = "";
                a[i].Numero = Console.ReadLine();
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i].ToString());
            }
            {
                
                Console.ReadKey();
            }
           
        }
    }
}
