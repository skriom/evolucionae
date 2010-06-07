using System;
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
        private List<Curso> cursos;
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
        public AG1(Persona persona, List<Curso> cursos)
        {
            this.generadorDeAleatorios = new Random(DateTime.Now.Millisecond);
            this.persona = persona;
            this.cursos = cursos;
            this.numCursosNecesita = this.persona.cursosQueNecesita.Count;
            this.cursosTipo = new Dictionary<string, List<Curso>>();
            this.soluciones = new List<int[]>();
            this.initCursosTipo();
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
        /// Construye la estructura cursosTipo.
        /// <example>
        /// La estructura debería tener una forma como la siguiente:
        /// +-----+   +--------+--------+   +-----------+
        /// |tipo1|-->|opcion10|opcion11|...|opcion1N1-1|
        /// +-----+   +--------+--------+   +-----------+
        /// |tipo2|-->|opcion20|opcion21|...|opcion2N2-1|
        /// +-----+   +--------+--------+...+-----------+
        /// .           .                        .
        /// .           .                ...     .
        /// .           .                        .
        /// +-----+   +--------+--------+   +-----------+
        /// |tipon|-->|opcionn0|opcionn1|...|opcionnNn-1|
        /// +-----+   +--------+--------+   +-----------+
        /// Aquí, tipo1 podría ser "paradigmas", y opción11 podría ser (martes, 11 am), claro,
        /// recordando que los objetos en la lista asociada a cada tipo, son objetos
        /// <code>Curso</code>
        /// </example>
        /// </summary>
        /// <exception cref="InvalidOperationException">Si la lista de cursos es
        /// <code>null</code></exception>
        private void initCursosTipo()
        {
            if (this.cursos == null)
            {
                throw new InvalidOperationException("La lista de cursos es nula");
            }
            foreach (Curso c in this.cursos)
            {
                if (!this.cursosTipo.ContainsKey(c.nombre)) //si no hay una entrada para ese
                {//curso, créela
                    this.cursosTipo.Add(c.nombre, new List<Curso>());
                }
                this.cursosTipo[c.nombre].Add(c);//añada el curso
            }
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
                solucion[i] = -1;
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
        /// según 
        /// </summary>
        public void evolucionar()
        {
            for (int i = 0; i < this.soluciones.Count; ++i)
            {
                this.fitness(this.soluciones[i]);
            }
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
            for (int i = 0; i < individuo.Length; ++i)
            {
                if (individuo[i] != -1)
                {
                    s += 1;
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
            bool[] dia = new bool[5];
            for (int i = 0; i < individuo.Length; ++i)
            {
                if(individuo[i] != -1)
                {
                    dia[this.cursosTipo[this.persona.cursosQueNecesita.ElementAt(i)][individuo[i]].dia] = true;
                }
            }
            int numeroDiasUsados = 0;
            for (int i = 0; i < dia.Length; ++i)
            {
                if (dia[i])
                {
                    numeroDiasUsados++;
                }
            }
            resultado += -5 * numeroDiasUsados + 25;
            //calcular cajones de cada día: este rubro vale 10%
            //lo más grande que puede ser el cajón de un día es 11 horas
            //(entrar de 7 a 9, cajón, y luego de 20 a 22). Como son 5 días
            //en la semana, cada uno puede hacer perder hasta 2 puntos.
            //Entonces, si x es la medida del cajón de un día (en horas), los
            //puntos de este 10% que hace perder son 2x/11
            Dictionary<int, List<Curso>> cursosDia = new Dictionary<int, List<Curso>>();
            Curso cursoAsignadoActual;
            for (int i = 0; i < individuo.Length; i++)
            {
                if (individuo[i] != -1)
                {
                    cursoAsignadoActual = this.cursosTipo[this.persona.cursosQueNecesita.ElementAt(i)][individuo[i]];
                    //si no lo contiene, insértelo
                    if (!cursosDia.ContainsKey(cursoAsignadoActual.dia))
                    {
                        cursosDia.Add(cursoAsignadoActual.dia, new List<Curso>());
                    }
                    cursosDia[cursoAsignadoActual.dia].Add(cursoAsignadoActual);
                }
            }
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