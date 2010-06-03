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
        public readonly int MAX_SOLUCIONES;
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
            this.cursosTipo = new Dictionary<string, List<Curso>>();
            this.soluciones = new List<int[]>();
        }
        /// <summary>
        /// Construye la estructura cursosTipo.
        /// <example>
        /// La estructura debería tener una forma como la siguiente:
        /// +-----+   +--------+--------+   +--------+
        /// |tipo1|-->|opcion11|opcion12|...|opcion1N1|
        /// +-----+   +--------+--------+   +---------+
        /// |tipo2|-->|opcion21|opcion22|...|opcion2N2|
        /// +-----+   +--------+--------+...+---------+
        /// .           .                        .
        /// .           .                ...     .
        /// .           .                        .
        /// +-----+   +--------+--------+   +---------+
        /// |tipon|-->|opcionn1|opcionn2|...|opcionnNn|
        /// +-----+   +--------+--------+   +---------+
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
            foreach(Curso c in this.cursos)
            {
            }
        }

        public void generarSolRandom()
        { 

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
