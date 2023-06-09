using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    { //está incompleto
        static void Main(string[] args)
        {

            int pacientes;
            int especialistas;
            bool resultado;
            //Carga de especialistas
            do
            {
                Console.WriteLine("Ingrese la cantidad de especialistas");
                resultado = int.TryParse(Console.ReadLine(), out especialistas);
                if (!resultado) Console.WriteLine("Error, debe ingresar un numero");
            } while (!resultado);
            especialistas[] objEsp = new especialistas[especialistas];

            for (int i = 0; i < especialistas; i++)
            {
                objEsp[i] = new especialistas();
            }
            //Carga de datos
            for (int i = 0; i < especialistas; i++)
            {
                Console.WriteLine("Ingrese el nombre del especialista {0}",(i+1));
                objEsp[i].nombre = (Console.ReadLine());
                Console.WriteLine("Ingrese la especialidad");
                objEsp[i].especialidad = (Console.ReadLine());
                Console.WriteLine("Ingrese el turno");
                objEsp[i].turno = (Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de pacientes");
                objEsp[i].cantidadPac = Convert.ToInt32(Console.ReadLine());
                pacientes = objEsp[i].cantidadPac;
                objEsp[i].definirPacientes(pacientes);
                for (int x = 0; x < pacientes; x++)
                {
                 
                    
                   
                    Console.WriteLine("Ingrese la edad del paciente {0}",(x+1));
                    objEsp[i].edad[x] = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Ingrese el peso del paciente");
                    objEsp[i].peso[x] = Convert.ToInt32(Console.ReadLine());
                    
              
                }
                
                for (int x = 0;x < pacientes; x++)
                {
                    objEsp[i].mostrarEspe();
                    Console.WriteLine("El paciente numero {0} tiene {1} años y pesa {2}",(x+1),objEsp[i].edad[x], objEsp[i].peso[x]);
                        
                }
                
            }
            }
    }
    public class especialistas
    {
        public especialistas()
        {

        }
        public string nombre;
        public string especialidad;
        public string turno;
        public int cantidadPac;
        public int[] edad;
        public int[] peso;

        public void definirPacientes(int cantPac)
        {
            // instanciacion
           edad = new int[cantPac];
           peso = new int[cantPac]; 
        }
        public void mostrarEspe()
        {
            Console.WriteLine("El especicalista se llama {0}, su especialidad es {1}, trabaja en el turno {2} y tiene {3} pacientes",nombre,especialidad,turno,cantidadPac);
        } 
        public void mostrarPac()
        {
            Console.WriteLine("El paciente tiene {0} años y pesa {1}",edad,peso);
        }
    }
}
