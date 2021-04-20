using System;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creando Objetos
            Persona objPersona = new Persona(); //Crear Objeto Persona
            Curso objCurso = new Curso(); //Crear Objeto Curso

            //Accediendo a los Objetos
            Console.WriteLine("Mi nombre es: " + objPersona.nombre);
           // Console.WriteLine("Mi edad es: " + objPersona.edad.ToString());


            //Llamando a metodos desde la clase principal

            bool rendimiento = objPersona.BuenRendimiento();
            Console.WriteLine(objPersona.promedioNotas());
            if(rendimiento==true)
            {
                Console.WriteLine("La persona esta aprobada");
            }
            else
            {
                Console.WriteLine("La persona esta desaprobada");
            }
            Console.ReadKey();
         }
    }
}
