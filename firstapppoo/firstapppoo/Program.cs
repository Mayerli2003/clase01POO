using firstapppoo.Humano;
using firstapppoo.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapppoo
{
    class Program
    {
        static void Main(string[] args)
        {


        


            ClsSaludo Saludo = new ClsSaludo();


            ClsHumano humano = new ClsHumano();
            humano.Nombre = "William";

          

            Console.WriteLine(Saludo.Saludossssss(humano));
            Console.ReadLine();

        }
    }
}
