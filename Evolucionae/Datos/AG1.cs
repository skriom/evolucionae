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
        private HashSet<Curso> cursos;
        private Persona persona;
        private List<int[]> soluciones;
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
        public AG1(Persona persona, HashSet<Curso> cursos)
        {
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
            Random r = new Random(DateTime.Now.Millisecond);
            int[] solucion = new int[this.numCursosNecesita];

            for (int i = 0; i < this.numCursosNecesita; ++i)
            {
                solucion[i]=-1;
            }

            for (int i = 0; i < this.numCursosNecesita; ++i)
            {

                random = r.Next(this.cursosTipo[this.persona.cursosQueNecesita.ElementAt(i)].Count);
                Curso c = this.cursosTipo[this.persona.cursosQueNecesita.ElementAt(i)][random];
                
                if(!this.chocaCurso(c, solucion, i)){
                    solucion[i]=random;
         
                 }


            }
            return solucion;
        }

        private Boolean chocaCurso(Curso c, int[] solucion, int posicion)
        {
            Boolean resultado=false;
            int diferenciaHoras = 0;
            
             if(posicion !=0){           
                  for(int i=0; i< posicion; i++){

                      if (c.dia == this.cursosTipo[this.persona.cursosQueNecesita.ElementAt(i)][solucion[i]].dia)
                      {
                          //La diferencia de horas(valor absoluto) entre cursos debe ser mayor o igual a 2,
                          diferenciaHoras = Math.Abs(c.hora - this.cursosTipo[this.persona.cursosQueNecesita.ElementAt(i)][solucion[i]].hora);
                          if (c.hora == this.cursosTipo[this.persona.cursosQueNecesita.ElementAt(i)][solucion[i]].hora || (diferenciaHoras<2))
                          {
                              resultado = true;
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