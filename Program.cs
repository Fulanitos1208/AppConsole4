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
                a[i].Nombre = "Rubi";
                a[i].Lada = "+52";
                a[i].Numero = "866-109-79-06";
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
