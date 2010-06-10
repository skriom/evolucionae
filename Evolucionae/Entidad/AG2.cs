using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evolucionae
{
    /// <summary>
    /// La clase AG2 usa un algoritmo genético para encontrar y optmizar
    /// asignación de personas a cursos de manera global, dada una lista de
    /// soluciones independientes para cada persona.
    /// </summary>
    class AG2
    {
        private List<int[]> soluciones;
        /// <summary>
        /// distribucion[i] contiene un Diccionario que asocia cursos al
        /// número de alumnos asignados según soluciones[i]. En este diccionario
        /// se basan los criterios para obtener el fitness de solucion[i]
        /// </summary>
        private Dictionary<Curso, int>[] distribución;
        private List<Persona> personas;
        /// <summary>
        /// solucionesIndependientes[i] es una lista con las soluciones
        /// (ordenadas de mejor a peor) para personas[i]
        /// </summary>
        private List<List<int[]>> solucionesIndependientes;
        private Random generadorDeAleatorios;
        /// <summary>
        /// Crea un objeto AG2 indicándole la lista de personas y la lista de
        /// soluciones independientes para cada persona
        /// </summary>
        /// <param name="personas">Lista de personas</param>
        /// <param name="soluciones">Lista de soluciones independientes.
        /// <paramref name="soluciones"/>soluciones[i] es una lista con las 
        /// soluciones para personas[i], ordenadas de mejor a peor, ninguna
        /// repetida.</param>
        public AG2(List<Persona> personas, List<List<int[]>> soluciones)
        {
            this.soluciones = new List<int[]>();
            this.generadorDeAleatorios = new Random(DateTime.Now.Millisecond);
            this.personas = personas;
            this.solucionesIndependientes = soluciones;
        }
        /// <summary>
        /// Califica una solución asignándole un valor en [0, 100] siguiendo
        /// las siguientes reglas:
        /// <list type="bullet">
        /// <item>
        /// El fitness de un individuo que a un curso le asigna más personas
        /// que las permitidas por el cupo, debe ser menor que el de un curso
        /// que no rebasa este límite
        /// </item>
        /// <item>
        /// Si dos soluciones empatan en el punto anterior, ha de tener mayor
        /// fitness una que satisfaga la necesidad de todas las personas que
        /// una que no
        /// </item>
        /// <item>
        /// Si dos individuos empatan en los puntos anteriores, debe tener mayor
        /// fitness uno que no deje cursos vaciós que uno que sí
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="?">individuo a evaluar su fitness</param>
        /// <returns>
        /// un valor real en [0, 1] que representa la aptitud de 
        /// <paramref name="individuo"/>individuo
        /// </returns>
        private double fitness(int[] individuo)
        {
            
        }
        /// <summary>
        /// Inserta una nueva solución en this.soluciones generada
        /// aleatoriamente con semántica correcta y la distribución de cursos
        /// asociada en this.distribucion
        /// Una solución es un arreglo de this.personas.Count enteros donde
        /// solucion[i] indica la solución independiente para la persona
        /// personas[i]
        /// </summary>
        private void generarSolucionAleatoria()
        {
            int[] resultado = new int[this.personas.Count];
            //llenar cada entrada de resultado con un valor semánticamente correcto
            for (int p = 0; p < resultado.Length; ++p)
            {
                resultado[i] = this.generadorDeAleatorios.Next(this.solucionesIndependientes[p].Count);
            }
            int[] solucionIndependienteActual;
            for (int p = 0; p < resultado.Length; ++p)
            { 
                //for(int sol = 0; sol < )
            }
        }
    }
}
