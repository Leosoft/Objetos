using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class Persona
    {
        public string nombre = "Leonardo Software"; //Se podra acceder a el desde cualquier parte del codigo(desde otra clase, en la misma clase, desde otro archivo, etc)
        private int edad = 34;//Solamente puede ser accedido dentro de la clase Persona
        protected double peso = 70.80; //Se puede acceder a este atributo desde la misma clase y tambien desde las clases que heredan o son hijas de esta clase
        internal int[] notas = { 5, 16, 8 }; //Solo se puede acceder desde el ensamblado donde se ha definido
        Curso miCurso; //si no se define modificador, el compilador entiende que solo se podra acceder desde la clase donde definio

        //Declaramos metodo - devuelve valor
       public double promedioNotas()
        {
            double suma = 0;
            for(int i = 0; i < notas.Length; i++)
            {
                suma += notas[i];
            }

            double promedio = suma / notas.Length;
            return promedio;
        }
        //declarando metodo - NO devuelve valor
       private void LimpiarNotas()
        {
            Array.Clear(notas, 0, notas.Length);
        }

        //Definiendo un metodo para ver si es bueno
        public bool BuenRendimiento()
        {
            double promedio = promedioNotas(); //Llamando promedios de notas que esta dentro de la misma clase y no necesita parametros
            if(promedio >= 13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
