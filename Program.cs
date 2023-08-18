using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARACION DE VARIABLES

            //Declaración de variables de tipo texto con captura de consola

            string? universidad = "";

            //Declarar variables de tipo texto con asignacion desde codigo

            string facultad = "Ingenieria y Arquitectura";
            string profesion = "Tecnico en Desarrollo de Software";

            //Declaración de variables entera captura desde consola

            int edadIngreso = 20;
            int edadEgreso = 22;
            int anioIngreso = 2023;

            //Declaración de variable de tipo double asignando valor desde consola

            double cuotaUniversidad = 0.0;

            //Declaración de variables decimales asignando valores

            double gastoTransporte = 35.50;

            //CAPTURA DE DATOS DESDE CONSOLE

            Console.WriteLine("\n***************************************************");
            Console.WriteLine("\n--------- Capturando datos de tipo texto ----------");
            Console.WriteLine("Ingrese el nombre de la universidad donde estudia: ");
            universidad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("------- Fin de captura de tipo de texto ------------");

            Console.WriteLine("\n-------- Capturando datos de tipo enteros ---------");
            Console.WriteLine("Ingrese el año que inicio la universidad: ");
            anioIngreso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------Fin de captura de tipo enteros-----------");

            Console.WriteLine("\n--------Capturando datos de tipo decimal---------");
            Console.WriteLine("Ingrese la cuota de la universidad: ");
            cuotaUniversidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------Fin de captura de tipo decimal ----------");

            //IMPRESION DE DATOS EN CONSOLA

            Console.WriteLine("\n**************************************************\n\n");
            Console.WriteLine("IMPRESION DE DATOS DE TIPO TEXTO");
            Console.WriteLine("\n La universidad en la que estudia es >> " + universidad);
            Console.WriteLine("\n Pertenece a la facultad de >> " + facultad);
            Console.WriteLine("\n Estudiando la carrera de >> " + profesion);
            Console.WriteLine("\n**************************************************");

            Console.WriteLine("\n**************************************************\n\n");
            Console.WriteLine("IMPRESION DE DATOS DE TIPO ENTERO");
            Console.WriteLine("\n El año que ingreso a la universidad fue >> " + anioIngreso);
            Console.WriteLine("\n La edad cuando inicio sus estudios es >> " + edadIngreso + " años");
            Console.WriteLine("\n La edad cuando finalice sus estudios sera >> " + edadEgreso + " años");
            Console.WriteLine("\n**************************************************");

            Console.WriteLine("\n**************************************************\n\n");
            Console.WriteLine("IMPRESION DE DATOS DE TIPO DOUBLE");
            Console.WriteLine("\n La cuota de su universidad es >> " + "$" + cuotaUniversidad);
            Console.WriteLine("\n Su gasto en transporte es >> " + "$" + gastoTransporte);
            Console.WriteLine("\n**************************************************");

            Console.ReadKey();


        }
    }
}