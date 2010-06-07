using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evolucionae
{
    class Persona
    {
        int _id;
        String _nombre;
        List<String> _cursosQueNecesita;

        public Persona()
        {
            this._cursosQueNecesita = new List<string>();
        }

        public Persona(int id, string nombre)
        {
            this._id = id;
            this._nombre = nombre;
            this._cursosQueNecesita = new List<string>();
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public List<String> cursosQueNecesita
        {
            get { return _cursosQueNecesita; }
            set { _cursosQueNecesita = value; }
        }

    }
}