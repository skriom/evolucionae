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
            this.initNumCursos();
            this.generarPoblacionInicial();
        }
        /// <summary>
        /// Calcula el número de cursos disponibles y lo almacena en this.numCursos
        /// </summary>
        private void initNumCursos()
        {
            this.numCursos = 0;
            foreach (string tipoCurso in this.cursosTipo.Keys)
            {
                this.numCursos += this.cursosTipo[tipoCurso].Count;
            }
        }
        /// <summary>
        /// Produce 21 soluciones aleatoriamente (junto con su distribución de cursos asociada, en
        /// this.distribuciones) y las guarda en this.soluciones
        /// </summary>
        private void generarPoblacionInicial()
        {
            for (int i = 0; i < 21; i++)
            {
                this.generarSolucionAleatoria();
            }
        }
        /// <summary>
        /// Modifica la lista de soluciones, insertando en ella elementos cada vez mejores
        /// según la función de fitness, todo esto siguiendo un modelo de algoritmo genético.
        /// Se efectúan 30 iteraciones (o hasta converger), en cada una de las cuales se hace lo siguiente:
        /// <list type="bullet">
        /// <item>
        /// Se calcula el fitness de cada elemento de la población actual
        /// </item>
        /// <item>
        /// Se asocia una probabilidad a cada elemento de la población actual, proporcional a
        /// su fitness
        /// </item>
        /// <item>
        /// Se escogen aleatoriamente (sin reemplazo, de modo que puedan salir repetidos, esa
        /// es la idea) this.soluciones.Count/2 elementos, según la probabilidad asociada de cada
        /// uno (de modo que se repitan más aquellos con mayor fitness)
        /// </item>
        /// <item>
        /// Los elementos escogidos se agrupan en
        /// </item>
        /// </list>
        /// </summary>
        public void evolucionar()
        {
            //fitness[i] = aptitud de la i-ésima solución
            double[] fitness = new double[1];
            //suma de todas las aptitudes. Se usa para calcular la proba de ser electo
            double sumatoriaFitness = 0;
            //temporal que tiene el fitness del individuo actual en un ciclo
            //se usa solo para optimizar, para no calcular el fitness más de una vez
            double fitnessTemp;
            //arreglo con los cortes en [0,1] usandos para seleccionar a cada individuo
            double[] vectorProbabilidades;
            //a partir de donde se toman genes del padre y a partir de donde se
            //toman de la madre en el cruce
            int corte;
            //siguiente generación. Al final del ciclo grande this.soluciones
            //se convierte en nuevaPoblacion
            List<int[]> nuevaPoblacion = new List<int[]>();
            //aleatorio que determina cuál elemento tomar en la selección...
            //es como el dardo que se lanza a la ruleta
            double dardo;
            //media del fitness de la población. Se usa solo para calcular desvStd
            double media = 0;
            //desviación estándar de los fitness. Conforme tiende a 0, el 
            //algoritmo genético converge
            double desvStd = double.MaxValue; //algún valor bien grande
            //repetimos 30 veces o hasta que el cambio (medido con desvStd) sea menor que un cierto umbral
            for (int generaciones = 0; generaciones < 50 && desvStd > 5; ++generaciones)
            {
                 fitness = new double[this.soluciones.Count];
                vectorProbabilidades = new double[this.soluciones.Count];
                media = desvStd = 0;
                for (int i = 0; i < this.soluciones.Count; ++i)
                {
                    fitnessTemp = this.fitness(i);
                    fitness[i] = fitnessTemp;
                    sumatoriaFitness += fitnessTemp;
                    vectorProbabilidades[i] = 0;
                }
                media = sumatoriaFitness / this.soluciones.Count;
                //llenar vector de probabilidades
                //de paso aprovechamos para calcular desvStd
                vectorProbabilidades[0] = fitness[0] / sumatoriaFitness;
                for (int i = 1; i < this.soluciones.Count; ++i)
                {
                    vectorProbabilidades[i] = fitness[i] / sumatoriaFitness + vectorProbabilidades[i - 1];
                    desvStd += Math.Pow(fitness[i] - media, 2);
                }
                desvStd /= this.soluciones.Count;
                desvStd = Math.Sqrt(desvStd);
                sumatoriaFitness = 0;
                //se tiran soluciones.Count/2 dardos. Se verifica a qué tajada del pastel
                //corresponde y se inserta el individuo (padre) asociado en nuevaPoblacion
                for (int i = 0; i < Math.Ceiling(this.soluciones.Count / 2.0); ++i)
                {
                    dardo = this.generadorDeAleatorios.NextDouble();
                    //ubicar el dardo
                    for (int elegido = 0; elegido < vectorProbabilidades.Length; ++elegido)
                    {
                        if (vectorProbabilidades[elegido] >= dardo)//si encontramos la tajada
                        {
                            nuevaPoblacion.Add(this.soluciones[elegido]);//metemos al padre, felicidades!
                            break;
                        }
                    }
                }
                //ahora cruzamos a cada individuo de nuevaPoblacion con su siguiente, produciendo
                //dos hijos (uno con la primera parte del padre y la segunda de la madre; el otro
                //al revés). Los metemos ahí mismo, con cuidado de no cruzar hijos recién nacidos
                //Antes de insertarlo, lo mutamos y lo corregimos (quitamos choques). Listos para el incesto!!
                corte = this.generadorDeAleatorios.Next(this.personas.Count);
                int posicionDelUltimoPadre = nuevaPoblacion.Count;
                for (int i = 0; i < posicionDelUltimoPadre; i += 2)
                {
                    nuevaPoblacion.Add(this.cruzar (nuevaPoblacion[i], nuevaPoblacion[i + 1], corte));
                    nuevaPoblacion.Add(this.cruzar(nuevaPoblacion[i + 1], nuevaPoblacion[i], corte));
                }
                //ahora tenemos una nueva poblacion
                this.soluciones = nuevaPoblacion.Clone(); // :)
                nuevaPoblacion.Clear();
                //calcular distribución de cursos para la nueva población
                this.distribucion.Clear();
                for (int e = 0; e < this.soluciones.Count; ++e)
                {
                    this.setDistribucion(this.soluciones[e]);
                }
            }
            //ahora eliminamos soluciones repetidas y las ordenamos de mejor a peor
            /*this.eliminarRepetidos(this.soluciones);
            //para ordenar, hay que calcular el fitness
            fitness = new double[this.soluciones.Count];
            for (int i = 0; i < this.soluciones.Count; ++i)
            {
                fitness[i] = this.fitness(this.soluciones[i]);
            }
            this.ordenar(this.soluciones, fitness);*/
            //this.soluciones.Sort(delegate(int[] sol1, int[] sol2) { return fitness[this.soluciones.IndexOf(sol1)].CompareTo(fitness[this.soluciones.IndexOf(sol2)]);});//p1.name.CompareTo(p2.name); });
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
        /// <param name="?">índice en this.soluciones del individuo a evaluar su fitness</param>
        /// <returns>
        /// un valor real en [0, 100] que representa la aptitud de 
        /// <paramref name="individuo"/>individuo
        /// </returns>
        private double fitness(int individuo)
        {
            double resultado = 0;
            //primero calificamos si rebasa el cupo de los cursos. Este rubro vale 50%
            //¿Cuál es el peor caso de personas asignadas a un curso a? Pues que rebase el cupo máximo de a
            //en this.personas.Count - a.cupo (o sea, que rebase en lo máximo que se puede rebasar!)
            //Entonces el peor de los casos de este rubro es que ocurra esa violación para todos los cursos!
            //De modo que vale 50/numCursosUsados el no violar este rubro para cada curso.
            int numCursosUsados = this.distribucion[individuo].Count; //num mapeos Curso -> num_personas para individuo
            foreach(Curso c in this.distribucion[individuo].Keys)
            {
                if(c.cupo >= this.distribucion[individuo][c])
                {
                    resultado += 50 / numCursosUsados;
                }
            }
            //ahora calificamos si satisface la necesidad de todas las personas. Este rubro vale 40%
            //en el peor caso, no le asigna ningún curso a nadie. Entonces, la satisfacción de cada persona
            //vale 40/this.personas.Count. Para cada curso j de una persona, su satisfacción vale
            //40/(this.personas.Count*numOpcionesCurso(j))
            Curso cursoAlQueSeRefiere;
            for (int p = 0; p < this.personas.Count; ++p)
            {
                for (int c = 0; c < this.solucionesIndependientes[p][soluciones[individuo][p]].Length; ++c)
                {
                    if (this.solucionesIndependientes[p][soluciones[individuo][p]][c] != -1) //si se asignó el curso respectivo
                    {
                        cursoAlQueSeRefiere = this.cursosTipo[this.personas[p].cursosQueNecesita[c]][solucionesIndependientes[p][soluciones[individuo][p]][c]];
                        resultado += 40.0 / (this.personas.Count * this.personas[p].cursosQueNecesita.Count); //this.cursosTipo[cursoAlQueSeRefiere.nombre].Count);
                    }
                }
            }
            //ahora calificamos que no dejen cursos vacíos. Este rubro vale 10%
            //En el peor caso, todos los cursos quedan vacíos. Entonces, para cada curso, el no estar vacío
            //aporta 10/numCursosUsados puntos
            resultado += numCursosUsados * 10.0 / this.numCursos;
            return resultado;
        }
        /// <summary>
        /// Obtiene un nuevo individuo cuyos genes son parte del padre, parte de la madre
        /// </summary>
        /// <param name="padre">padre del nuevo individuo</param>
        /// <param name="madre">madre del nuevo individuo</param>
        /// <param name="corte">punto de corte. Los genes anteriores a este punto son del padre.
        /// Los demás, son de la madre</param>
        /// <returns>Un nuevo individuo con genes parte del padre, parte de la madre</returns>
        private int[] cruzar(int[] padre, int[] madre, int corte)
        {
            int[] resultado = new int[padre.Length];
            for (int i = 0; i < corte; ++i)
            {
                resultado[i] = padre[i];
            }
            for (int i = corte; i < madre.Length; ++i)
            {
                resultado[i] = madre[i];
            }
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
                    if (solucionesIndependientes[p][individuo[p]][c] != -1) //si se asignó el curso respectivo
                    {
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

        public int[] listaSoluciones() {
            return this.soluciones.ElementAt(0);
        
        }

        public int[] listaSolucionesPersona(int posSol, int persona)
        {
            return this.solucionesIndependientes.ElementAt(persona).ElementAt(posSol);

        }
        
        
        
        }
}
