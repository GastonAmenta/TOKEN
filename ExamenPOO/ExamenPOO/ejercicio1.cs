using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO
{
    internal class ejercicio1
    {
        static void Main(string[] args)
        {
            int cantSup = 0;
            int pentagonos;
            bool resultado;
            do
            {
                Console.WriteLine("Ingrese la cantidad de pentagonos");
                resultado = int.TryParse(Console.ReadLine(), out pentagonos);
                if (!resultado) Console.WriteLine("Error, debe ingresar un numero");
            } while (!resultado);
            pentagono[] objPent = new pentagono[pentagonos];
            
            for(int i = 0;i < pentagonos; i++)
            {
                objPent[i] = new pentagono();
            }
            
            for(int i = 0; i < pentagonos; i++)
            {
                Console.WriteLine("Ingrese el lado");
                objPent[i].lados = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la apotema");
                objPent[i].apotema = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < pentagonos; i++)
            {
                cantSup = cantSup + (objPent[i].lados * objPent[i].apotema/2);
                Console.WriteLine("El pentagono {0} ",(i + 1));
                
                objPent[i].calcPer();
                objPent[i].calcSup();
                
            }
            cantSup = cantSup / pentagonos;
            objPent[0].calcProm(cantSup);
            

        }
    }
    public class pentagono
    {
        public pentagono() { 
        }
        public int lados;
        public int apotema;
    
        public void mostrar()
        {
            Console.WriteLine(" sus lados miden {0} y su apotema mide {1}",lados,apotema);
        }
        public void calcPer()
        {
            Console.WriteLine("su perimetro es de {0} ",lados*5);
        }
        public void calcSup()
        {
 
            Console.WriteLine("su superficie es de {0}", (lados*apotema/2));
        }
        public void calcProm(int cantSup)
        { 
            Console.WriteLine("El promedio de las superficies es {0}",cantSup);
        }
    }

}
