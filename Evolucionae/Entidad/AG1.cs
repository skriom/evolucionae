﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evolucionae
{
    /// <summary>
    /// La clase AG1 se comporta como un algoritmo genético que genera y optimiza
    /// horarios para una persona. Un objeto <c>AG1</c> está asociado a una persona
    /// (que tiene una necesidad de cursos) y una lista de cursos suficiente para satisfacer
    /// la necesidad de la persona.
    /// </summary>
    class AG1
    {
        private int cursosPorDia;
        //private List<Curso> cursos;
        private Persona persona;
        private List<int[]> soluciones;
        private Random generadorDeAleatorios;
        /// <summary>
        /// Porcentaje (de MAX_SOLUCIONES) de soluciones que se generarán para la persona
        /// </summary>
        public const int PORCENTAJE_SOLUCIONES = 70;
        /// <summary>
        /// Cota superior (suficientemente pequeña) al número máximo de soluciones
        /// posibles para la persona.
        /// </summary>
        /// <remarks>El número de soluciones que se generarán para la persona
        /// es menor o igual que MAX_SOLUCIONES*PORCENTAJE_SOLUCIONES/100</remarks>
        private int MAX_SOLUCIONES;
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
        private Dictionary<string, List<Curso>> cursosTipo;
        /// <summary>
        /// número de cursos en la necesidad de la persona
        /// </summary>
        private int numCursosNecesita;
        /// <summary>
        /// Crea un nuevo objeto <c>AG1</c> que busca soluciones para
        /// <paramref name="persona"/> dada la piscina de cursos
        /// <paramref name="cursos"/>
        /// </summary>
        /// <param name="persona">persona para la que se buscarán soluciones</param>
        /// <param name="cursos">lista de cursos disponibles para satisfacer
        /// la necesidad de información de <paramref name="persona"/></param>
        public AG1(Persona persona, Dictionary<string, List<Curso>> cursosT)
        {
            this.generadorDeAleatorios = new Random(DateTime.Now.Millisecond);
            this.persona = persona;
            //this.cursos = cursos;
            this.numCursosNecesita = this.persona.cursosQueNecesita.Count;
            this.cursosTipo = cursosT;
            this.soluciones = new List<int[]>();
            this.setMaxNumeroSoluciones();
        }
        /// <summary>
        /// Calcula una cota superior (tan pequeña como sea posible) del número máximo
        /// de soluciones posibles para la persona y la asigna a this.MAX_SOLUCIONES
        /// </summary>
        private void setMaxNumeroSoluciones()
        {
            int resultado = 1;
            foreach (string curso in this.persona.cursosQueNecesita)
            {
                resultado *= this.cursosTipo[curso].Count;
            }
            this.MAX_SOLUCIONES = resultado;
        }
       
       
        /// <summary>
        /// <para>Genera una solución cualquiera para la persona, o, si no es posible
        /// con la piscina actual de cursos, se genera lo más cercano a una
        /// solución, es decir, una asignación que satisfaga la mayor cantidad
        /// de tipos de curso en la necesidad.
        /// Para una persona con una necesidad {cursoTipo0, cursoTipo1,..., cursoTipoN-1},
        /// una solución es un arreglo <code>solucion</code> de N enteros, donde
        /// <code>solucion[i] = a</code> significa que en la solución generada,
        /// el curso asignado para satisfacer el elemento de la necesidad cursoTipoi es el curso
        /// <code>
        /// </para>
        /// <para>
        /// Un caso especial es si solucion[i] = -1. Significa que no se satisface
        /// al elemento i de la necesidad.
        /// </para>
        /// this.cursosTipo[cursoTipoi][a]
        /// </code>
        /// </summary>
        /// <returns>un arreglo de dimensión N, (N número de tipos de curso en la
        /// necesidad de la persona) donde cada entrada i indica el curso asignado
        /// como un índice de la lista asociada al valor cursoTipoi en 
        /// <code>
        /// this.cursosTipo
        /// </code>
        /// Además, el valor para toda entrada del arreglo devuelto
        /// debe haber sido escogido aleatoriamente con distribución uniforme.
        /// </returns>
        /// <remarks>Nótese que si la piscina de cursos sólo contiene k
        /// cursos de tipo i, entonces la i-ésima entrada del arreglo devuelto
        /// no puede tener un valor mayor que k-1</remarks>
        public int[] generarSolucionAleatoria()
        {
            int random = 0;
            int[] solucion = new int[this.numCursosNecesita];
            Curso cursoAMeter;
            for (int i = 0; i < this.numCursosNecesita; ++i)
            {
                solucion[i]=-1;
            }
            for (int i = 0; i < this.numCursosNecesita; ++i)
            {
                random = generadorDeAleatorios.Next(this.cursosTipo[this.persona.cursosQueNecesita.ElementAt(i)].Count);
                cursoAMeter = this.cursosTipo[this.persona.cursosQueNecesita.ElementAt(i)][random];

                if (!this.chocaCurso(cursoAMeter, solucion, i))
                {
                    solucion[i] = random;
                }
            }
            return solucion;
        }

        private Boolean chocaCurso(Curso cursoAMeter, int[] solucion, int posicion)
        {
            Boolean resultado=false;
            if(posicion !=0){
            int diferenciaHoras = 0;
            Curso cursoConQuePodriaChocar;
                for(int i = 0; i < posicion; i++){
                    if (solucion[i] != -1) //solucion[i] podría ser -1 si no se asignó el curso respectivo
                    {
                        cursoConQuePodriaChocar = this.cursosTipo[this.persona.cursosQueNecesita.ElementAt(i)][solucion[i]];
                        if (cursoAMeter.dia == cursoConQuePodriaChocar.dia)
                        {
                            //La diferencia de horas(valor absoluto) entre cursos debe ser mayor o igual a 2,
                            diferenciaHoras = Math.Abs(cursoAMeter.hora - cursoConQuePodriaChocar.hora);
                            if ((diferenciaHoras < 2))
                            {
                                resultado = true;
                                break;
                            }
                        }
                    }
                 }
            }
			return resultado;
        }
        /// <summary>
        /// Corrige un individuo eliminando los choques en él
        /// </summary>
        /// <param name="individuo">Individuo a ser corregido. Luego del llamado a este
        /// método, no pueden haber choques en los cursos que lo componen
        /// </param>
        /// <returns>individuo corregido</returns>
        private int[] corregirSolucion(int[] individuo)
        {
            Curso cursoActual;
            for(int i = 0; i < individuo.Length; ++i)
            {
                if (individuo[i] != -1)
                {
                    cursoActual = this.cursosTipo[this.persona.cursosQueNecesita.ElementAt(i)][individuo[i]];
                    if (this.chocaCurso(cursoActual, individuo, i))
                    {
                        individuo[i] = -1;
                    }
                }
            }
            return individuo;
        }

        /// <summary>
        /// Indica si una solución presenta choques de horarios
        /// </summary>
        /// <param name="individuo">solución en la que se buscarán choques de horarios</param>
        /// <returns>true si la solución presenta choques de horarios</returns>
        private bool hayChoque(int individuo)
        {
            bool resultado = false;

            return resultado;
        }
        /// <summary>
        /// Genera la población, es decir, llena la estructura this.soluciones
        /// con elementos producidos por this.generarSolucionAleatoria().
        /// Produce 21 soluciones o tantas como pueda, si el número de soluciones
        /// posibles es menor que 21
        /// </summary>
        /// <remarks>no hace falta verificar que no hayan repetidos</remarks>
        public void generarPoblacionInicial()
        {
            int numIndividuos = Math.Min(this.MAX_SOLUCIONES, 21);
            for (int i = 0; i < numIndividuos; i++)
            {
                this.soluciones.Add(this.generarSolucionAleatoria());
            }
        }
        /// <summary>
        /// Modifica la lista de soluciones, insertando en ella elementos cada vez mejores
        /// según la función de fitness, todo esto siguiendo un modelo de algoritmo genético.
        /// Se efectúan 30 iteraciones, en cada una de las cuales se hace lo siguiente:
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
        /// es la idea) this.soluciones.Count elementos, según la probabilidad asociada de cada
        /// uno (de modo que se repitan más aquellos con mayor fitness)
        /// </item>
        /// <item>
        /// Los elementos escogidos se agrupan en
        /// </item>
        /// </list>
        /// </summary>
        public void evolucionar()
        {
            double[] fitness;
            double sumatoriaFitness = 0;
            double fitnessTemp;
            double[] vectorProbabilidades;
            List<int[]> nuevaPoblacion = new List<int[]>();
            double dardo;
            for (int generaciones = 0; generaciones < 25; ++generaciones)
            {
                fitness = new double[this.soluciones.Count];
                vectorProbabilidades = new double[this.soluciones.Count];
                for (int i = 0; i < this.soluciones.Count; ++i)
                {
                    fitnessTemp = this.fitness(this.soluciones[i]);
                    fitness[i] = fitnessTemp;
                    sumatoriaFitness += fitnessTemp;
                    vectorProbabilidades[i] = 0;
                }
                //llenar vector de probabilidades
                for (int i = 0; i < this.soluciones.Count; ++i)
                {
                    vectorProbabilidades[i] = fitness[i] / sumatoriaFitness;
                    for (int jSumatoria = 0; jSumatoria < i; ++jSumatoria)
                    {
                        vectorProbabilidades[i] += vectorProbabilidades[jSumatoria];
                    }
                }
                //se tiran soluciones.Count/2 dardos. Se verifica a qué tajada del pastel
                //corresponde y se inserta el individuo (padre) asociado en nuevaPoblacion
                for (int elegido = 0; elegido < this.soluciones.Count / 2; ++elegido)
                {
                    dardo = this.generadorDeAleatorios.NextDouble();
                    //ubicar el dardo
                    for (int i = 1; i < vectorProbabilidades.Length; ++i)
                    {
                        if (vectorProbabilidades[i] > dardo)
                        {
                            nuevaPoblacion.Add(this.soluciones[i - 1]);
                            break;
                        }
                    }
                }
                //ahora cruzamos a cada individuo de nuevaPoblacion con su siguiente, produciendo
                //dos hijos (uno con la primera parte del padre y la segunda de la madre; el otro
                //al revés). Los metemos ahí mismo, con cuidado de no cruzar hijos recién nacidos
                //Antes de insertarlo, lo corregimos (quitamos choques). Listos para el incesto!!
                int posicionDelUltimoPadre = nuevaPoblacion.Count;
                for (int i = 0; i < posicionDelUltimoPadre; ++i)
                {
                    nuevaPoblacion.Add(this.corregirSolucion(this.cruzar(nuevaPoblacion[i], nuevaPoblacion[i + 1], true)));
                    nuevaPoblacion.Add(this.corregirSolucion(this.cruzar(nuevaPoblacion[i], nuevaPoblacion[i + 1], false)));
                }
                //ahora tenemos una nueva poblacion
                this.soluciones = nuevaPoblacion; // :)
            }
                /*for (int i = 0; i < this.soluciones.Count; ++i)
                {
                    this.fitness(this.soluciones[i]);
                }*/
        }
        /// <summary>
        /// Obtiene un nuevo individuo cuyos genes son parte del padre, parte de la madre
        /// Se establece un punto i de corte. Si pImD es true, el nuevo individuo tiene todos
        /// sus genes desde el 0 hasta el i-1 del padre y los demás de la madre. Al revés si
        /// pImD es false
        /// </summary>
        /// <param name="padre">padre del nuevo individuo</param>
        /// <param name="madre">madre del nuevo individuo</param>
        /// <param name="pImD">si es true, los genes antes del corte los aporta el padre
        /// y los demás la madre. Al revés si es false</param>
        /// <returns></returns>
        private int[] cruzar(int[] padre, int[] madre, bool pImD)
        {
            int[] resultado = new int[padre.Length];
            int corte = this.generadorDeAleatorios.Next(padre.Length);
            if (pImD)
            {
                for (int i = 0; i < corte; ++i)
                {
                    resultado[i] = padre[i];
                }
                for (int i = corte; i < madre.Length; ++i)
                {
                    resultado[i] = madre[i];
                }
            }
            else
            {
                for (int i = 0; i < corte; ++i)
                {
                    resultado[i] = madre[i];
                }
                for (int i = corte; i < padre.Length; ++i)
                {
                    resultado[i] = padre[i];
                }
            }
            return resultado;
        }
        /// <summary>
        /// Califica a un individuo de acuerdo a qué tan apto es.
        /// La medida de calificación debe cumplir las siguientes propiedades:
        /// <list type="bullet">
        /// <item>
        /// Un elemento que satisfaga toda la necesidad de la persona, debe ser
        /// mejor calificado que uno que no la satisfaga toda.
        /// </item>
        /// <item>
        /// Si dos elementos satisfacen la misma cantidad de elementos de la
        /// necesidad de la persona, debe ser mejor calificado el que use menos
        /// días de la semana para satisfacer esa necesidad
        /// </item>
        /// <item>
        /// Si dos elementos empatan según el punto anterior, debe ser mejor
        /// calificado aquel con la menor suma de cajones vacíos.
        /// </item>
        /// <item>
        /// Ningún individuo puede tener una medida de aptitud negativa.
        /// </item>
        /// <item>
        /// Ningún individuo puede tener una medida de aptitud mayor que 100
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="individuo">
        /// Individuo a ser calificado según su aptitud</param>
        /// <returns>
        /// Una medida de aptitud del individuo
        /// </returns>
        private double fitness(int[] individuo)
        {
            double resultado = 0;
            //calcular cuánto de la necesidad está satisfecha: 70% para este rubro
            //n = individuo.Length. s = num elementos de necesidad que fueron satisfechos
            //nótese s <= n
            //x = calificación de este rubro que vale 70%
            //Tenemos: n/70 = s/x => x = 70s/n. Nótese s = n => x = 70
            int s = 0;
            bool[] dia = {false, false, false, false, false};
            Dictionary<int, List<Curso>> cursosDia = new Dictionary<int, List<Curso>>();
            Curso cursoAsignadoActual;
            for (int i = 0; i < individuo.Length; ++i)
            {
                if (individuo[i] != -1)
                {
                    s += 1;
                    cursoAsignadoActual = this.cursosTipo[this.persona.cursosQueNecesita.ElementAt(i)][individuo[i]];
                    dia[cursoAsignadoActual.dia] = true;
                    //si cursosDia no lo contiene, insértelo
                    if (!cursosDia.ContainsKey(cursoAsignadoActual.dia))
                    {
                        cursosDia.Add(cursoAsignadoActual.dia, new List<Curso>());
                    }
                    cursosDia[cursoAsignadoActual.dia].Add(cursoAsignadoActual);
                }
            }
            resultado += 70.0 * s / individuo.Length;
            //calcular número de días que abarca la satisfacción de la necesidad:
            //20% para este rubro.
            //Si satisface todo en un día, debe tener la calificación máxima: 20
            //si satisface todo en 5 días, debe tener la calificación mínima: 0
            //si satisface todo en x días, debe tener la calificación -5x + 25:
            // 20-|\
            // 15-|  \
            // 10-|    \
            //  5-|      \
            //  0-|        \
            //    -----------
            //      1 2 3 4 5
            resultado += -5 * cursosDia.Count + 25;
            //calcular cajones de cada día: este rubro vale 10%
            //lo más grande que puede ser el cajón de un día es 11 horas
            //(entrar de 7 a 9, cajón, y luego de 20 a 22). Como son 5 días
            //en la semana, cada uno puede hacer perder hasta 2 puntos.
            //Entonces, si x es la medida del cajón de un día (en horas), los
            //puntos de este 10% que hace perder son 2x/11
            resultado += 10;
            foreach (int llave in cursosDia.Keys)
            {
                resultado -= 2.0 * this.sumaCajon(cursosDia[llave]) / 11;
            }
            return resultado;
        }
        /// <summary>
        /// Recibe una lista de cursos, todos llevados el mismo día y devuelve
        /// la suma (en horas) de los cajones.
        /// Un cajón es el espacio entre el final de un curso y el principio de
        /// otro, tal que no hay ningún curso en medio de esas cotas.
        /// </summary>
        /// <param name="dia">Lista de cursos, llevados todos en un mismo día</param>
        /// <returns>La suma en horas de los cajones en el día de los cursos en la lista</returns>
        private int sumaCajon(List<Curso> dia)
        {
            int resultado = 0;
            if(dia.Count != 0 && dia.Count != 1)
            {
                dia.Sort(); //ordenar, para comparar a cada quien con el cronológicamente anterior
                for (int i = 1; i < dia.Count; ++i)
                {
                    resultado += dia[i].hora - (dia[i - 1].hora + 2);
                }
            }
            return resultado;
        }
        private void cursosDeseadoPorDia(HashSet<int> personas)
        {
            if (personas.Count() < 4)
            {
                this.cursosPorDia = personas.Count();
            }
            else
            {
                //this.cursosPorDia = Math.Ceiling(personas.Count() / 2);
            }
        }

    }
}
