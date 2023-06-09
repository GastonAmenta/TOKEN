using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año2 = 0;
            char delimitador = '-';
            int alumnos;
            bool resultado;
            do
            {
                Console.WriteLine("Ingrese la cantidad de alumnos");
                resultado = int.TryParse(Console.ReadLine(), out alumnos);
                if (!resultado) Console.WriteLine("Error, debe ingresar un numero");
            } while (!resultado);
            alumno[] objAlu = new alumno[alumnos];

            for (int i = 0; i < alumnos; i++)
            {
                objAlu[i] = new alumno();
            }
            //Ingreso de datos
            for (int i = 0; i < alumnos; i++)
            {
                Console.WriteLine("Ingrese el apellido");
                objAlu[i].apellido = (Console.ReadLine());
                Console.WriteLine("Ingrese el nombre");
                objAlu[i].nombre = (Console.ReadLine());
                Console.WriteLine("Ingrese el dni");
                objAlu[i].dni = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el peso");
                objAlu[i].peso = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la fecha de nacimiento, separandolo con guiones y ordenado en año-mes-dia");
                objAlu[i].añoNac = (Console.ReadLine());

                string[] añoS = objAlu[i].añoNac.Split(delimitador);

                año2 = Convert.ToInt32(añoS[0]);
                objAlu[i].añoBis(año2);
                objAlu[i].mostrar();
            } 

        }
    }
    public class alumno
    {
        //constructor
        public alumno()
        {
            Console.WriteLine("Instancia realizada");
        }
        public string apellido;
        public string nombre;
        public int dni;
        public int peso;
        public string añoNac;
        public void mostrar()
        {
            Console.WriteLine("El alumno se llama {0} {1}, su dni es {2}, pesa {3} y nacio el {4}", nombre, apellido, dni, peso, añoNac);
        }
        public void añoBis(int año2)
        {
            if (año2 % 400 == 0 || (año2 % 4 == 0 && año2 % 100 != 0))
            {
                Console.WriteLine("{0} es un año bisiesto", año2);
            }
            else { 
                Console.WriteLine("{0} no es un año bisiesto", año2);
            }
        }
    }
} 
