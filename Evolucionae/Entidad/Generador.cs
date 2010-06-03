using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evolucionae
{
    class Generador
    {
        HashSet<int> cursos;
        HashSet<int> personas;
        

        public Generador(HashSet<int> c, HashSet<int> p)
        {
            this.cursos = c;
            this.personas=p;
        }

        public Dictionary<Persona, HashSet<HashSet<Curso>>> generarSoluciones()
        { 
            Dictionary<Persona, HashSet<HashSet<Curso>>> resultado = new Dictionary<Persona,HashSet<HashSet<Curso>>>();



            return resultado;  
                  
        }
        
    }
}
