using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    /* Ejercicio 1
Desarrolle una clase para la carga de información de personas contemplando los atributos
nombre, apellido y edad.
Instancie la clase y permita que el usuario cargue información para 3 persona mostrando la
misma con un método de la clase.
Al finalizar muestre el promedio de edad.

Ejercicio 2
Desarrolle una clase para la carga de información de lados de un rectángulo. Debe comprobar
que los valores ingresados califiquen como rectángulo y al finalizar muestre información de la
forma:

“ha ingresado un rectángulo de lado1 por lado2”

Donde los lado1 y lado2 serán las medidas de sus lados teniendo en cuenta que los cuatro
lados no pueden ser iguales ya que en ese caso sería un cuadrado */
    internal class Program
    {
        static void Main(string[] args)
        {
            int promedio = 0;
            Console.WriteLine("Ingrese la cantidad de personas que quiere cargar");
            int cantPer = Convert.ToInt32(Console.ReadLine());

            personas[] objPers = new personas[cantPer];
            for (int i = 0; i < cantPer; i++) objPers[i] = new personas();
            //ingreso de datos
            for (int i = 0; i< cantPer; i++)
            {
                Console.WriteLine("ingrese el nombre de la persona");
                objPers[i].nombre = Console.ReadLine();
            }
        }
    }
    public class personas
    {
        public personas()
        {

        }
        public string nombre;
        public string apellido;
        public string edad;

        public void mostrar()
        {
            Console.WriteLine("La persona se llama {} {} y tiene {} años",nombre,apellido,edad);
        }
    }
   

}
