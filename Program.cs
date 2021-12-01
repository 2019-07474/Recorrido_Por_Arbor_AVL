using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Recorridos_por_árboles_Post_orden
{
    class Program
    {
        static void Main(string[] args)
        {
            AMM Miarbolito = new AMM();
            Miarbolito.insertar('9');
            Miarbolito.insertar('8');
            Miarbolito.insertar('7');
            Miarbolito.insertar('5');
            Miarbolito.insertar('4');
            Miarbolito.insertar('3');
            Miarbolito.insertar('2');
            Miarbolito.insertar('1');
            Miarbolito.insertar('0');


            Miarbolito.preordenrecursivo();
            Miarbolito.inordenrecursivo();
            Miarbolito.postOrdenrecursivo();


            Console.WriteLine("El programa concluyo preciona cualquier tecla para salir,");
            Console.ReadKey();
        }
    }
}
