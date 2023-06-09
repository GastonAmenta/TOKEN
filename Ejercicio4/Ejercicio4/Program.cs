using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    /*Ejercicio 1
    Desarrolle una de las clases que haya definido en la Tarea003.Luego de la definición,
    corresponde instanciarla seguido de la carga de información, (dar valor a sus atributos), para un
    objeto y luego mostrar dicha información.

    Ejercicio 2
    Modifique el ejercicio 1 del presente Ejer004 para el uso de 4 objetos. */
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciacion
            celular objCel = new celular();
            //carga
            objCel.color = "negro";
            objCel.marca = "Samsung";
            objCel.mpx = 25;
            objCel.sistema = "Android";

            Console.WriteLine("Hola");
            objCel.mostrar();

            alumno objAl = new alumno();
        }
    }
    public class celular
    {
        //constructor
        public celular()
        {

        }
        //atributos
        public string color;
        public string marca;
        public int mpx;
        public string sistema;
        //metodos
        public void mostrar()
        {
            Console.WriteLine("el celular de color {0} de marca {1} tiene una camara de {2} mpx y su os es {3}", color,marca,mpx,sistema);
        }

    }
    //ejercicio 2
    public class alumno
    {
        public alumno()
        {

        }
        public string nombre;
        public string apellido;
        public int edad;

        public void mostrar()
        {
            Console.WriteLine("El alumno {0} {1} tiene {2} años",nombre,apellido,edad);
        }
    }
    public class clase
    {
        public clase()
        {

        }
        public int curso;
        public int division;
        public string seccion;

        public void mostrar()
        {
            Console.WriteLine("El curso {0} de division {1} pertenece a la seccion {2}",curso,division,seccion);
        }
    }
    public class identidad
    {
        public identidad()
        {

        }
        public int dni;
        public string nombre;
        public string apellido;
        public string fechaNac;
        public string domicilio;

        public void Mostrar()
        {
            Console.WriteLine("La persona de dni {0} se llama {1} {2}, nacio el {3} y vive en {4}", dni, nombre, apellido, fechaNac, domicilio);
        }
    }

}
