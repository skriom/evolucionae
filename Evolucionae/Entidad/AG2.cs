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
        private List<Dictionary<Curso, int>> distribucion;
        private List<Persona> personas;
        /// <summary>
        /// solucionesIndependientes[i] es una lista con las soluciones
        /// (ordenadas de mejor a peor) para personas[i]
        /// </summary>
        private List<List<int[]>> solucionesIndependientes;
        /// <summary>
        /// Diccionario que mapea cada tipo de curso (e.g. "inglés", "matemáticas")
        /// a la lista de cursos de ese tipo disponibles.
        /// <example>
        /// Si se tiene la siguiente lista de cursos:
        /// ("mate",lunes,13),("mate",lunes,11),("ciencias",martes,10)
        /// una vez construida la estructura cursosTipo, la siguiente línea de código
        /// <code>
        /// cursosTipo["mate"]
        /// </code>
        /// debe devolver la lista:
        /// ("mate",lunes,13),("mate",lunes,11)
        /// </example>
        /// </summary>
        /// <remarks>Esta estructura se construye una vez se sepa la lista de
        /// cursos disponibles. Dar la base para construir esta estructura es el único 
        /// propósito de la lista de cursos.
        /// </remarks>
        Dictionary<string, List<Curso>> cursosTipo;
        /// <summary>
        /// Número de cursos disponibles
        /// </summary>
        private int numCursos;
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
        /// <param name="cursosTipo">Conjunto de pares (tipoCurso, listaOpciones)</param>
        public AG2(List<Persona> personas, List<List<int[]>> soluciones, Dictionary<string, List<Curso>> cursosTipo)
        {
            this.soluciones = new List<int[]>();
            this.cursosTipo = cursosTipo;
            this.generadorDeAleatorios = new Random(DateTime.Now.Millisecond);
            this.personas = personas;
            this.distribucion = new List<Dictionary<Curso, int>>();
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
        /// un valor real en [0, 100] que representa la aptitud de 
        /// <paramref name="individuo"/>individuo
        /// </returns>
        private double fitness(int[] individuo)
        {
            double resultado = 0;
            //primero calificamos si rebasa el cupo de los cursos. Este rubro vale 40%
            //¿Cuál es el peor caso de personas asignadas a un curso a? Pues que rebase el cupo máximo de a
            //en this.personas.Count - a.cupo (o sea, que rebase en lo máximo que se puede rebasar!)
            //Entonces el peor de los casos de este rubro es que ocurra esa violación para todos los cursos!
            //De modo que vale 40/numCursos el no violar este rubro
            return resultado;
        }
        /**
         * Indica cuántos cursos fueron asignados
         */
        private int numCursosAsignados(int[] solucionIndependiente)
        {
            int resultado = 0;

            return resultado;
        }
        /// <summary>
        /// Inserta una nueva solución en this.soluciones generada
        /// aleatoriamente con semántica correcta y la distribución de cursos
        /// asociada en this.distribucion
        /// Una solución es un arreglo de this.personas.Count enteros donde
        /// solucion[i] indica la solución independiente asignada a la persona
        /// personas[i]. Además, para la solucion s, en this.distribucion[i] incrementa en 1 el valor de toda
        /// llave k tal que existe Curso c tal que k = this.personas.cursosQueNecesita[j] y
        /// s[i][j] != -1
        /// </summary>
        private void generarSolucionAleatoria()
        {
            int[] resultado = new int[this.personas.Count];
            //llenar cada entrada de resultado con un valor semánticamente correcto
            for (int p = 0; p < resultado.Length; ++p)
            {
                resultado[p] = this.generadorDeAleatorios.Next(this.solucionesIndependientes[p].Count);
            }
            this.soluciones.Add(resultado);
            this.setDistribucion(resultado);
        }
        /// <summary>
        /// Calcula e inserta en this.distribucion[this.distribucion.Count - 1] la distribucion de cursos
        /// para un individuo dado. Es decir, calcula un Dictionary<Curso, int> apropiado y lo pone de último
        /// en la lista de diccionarios distribucion.
        /// </summary>
        /// <param name="individuo">individuo para quien se ha de calcular la distribución de cursos, es
        /// decir, el número de personas que asigna a cada curso.</param>
        /// <remarks>
        /// Este fue un método muy difícil de implementar!!
        /// </remarks>
        private void setDistribucion(int[] individuo)
        {
            Curso cursoAlQueSeRefiere;
            this.distribucion.Add(new Dictionary<Curso, int>());
            //iterar por cada persona
            for (int p = 0; p < individuo.Length; ++p)
            {
                //iterar por cada entrada del vector solución para la persona p. O sea, por cada curso asignado
                //a la persona p
                for (int c = 0; c < this.solucionesIndependientes[p][individuo[p]].Length; ++c)
                {
                    //mucho ojo, que aquí está la clave de todo:
                    //individuo[p] es la solución independiente asignada a la persona p. Es un int
                    //solucionesIndependientes[p][individuo[p]][c] es un número que indica el curso asignado. Es decir que se asignó
                    //solucionesIndependientes[p][individuo[p]][c] de los cursos de tipo personas[p].cursosQueNecesita[c]
                    cursoAlQueSeRefiere = this.cursosTipo[this.personas[p].cursosQueNecesita[c]][solucionesIndependientes[p][individuo[p]][c]];
                    if (!this.distribucion[this.distribucion.Count - 1].ContainsKey(cursoAlQueSeRefiere))
                    {
                        this.distribucion[this.distribucion.Count - 1].Add(cursoAlQueSeRefiere, 0);
                    }
                    this.distribucion[this.distribucion.Count - 1][cursoAlQueSeRefiere] += 1;
                }
            }
        }
    }
}
