using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evolucionae
{

    class Curso : IComparable<Curso>
    {
        private int _id;
        private string _nombre;
        private int _cupo;
        private int _dia;
        private int _hora;

        public Curso()
        {
        }
        public Curso(int id, string nombre, int cupo, int dia, int hora)
        {
            this._id = id;
            this._nombre = nombre;
            this._cupo = cupo;
            this._dia = dia;
            this._hora = hora;
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int cupo
        {
            get { return _cupo; }
            set { _cupo = value; }
        }

        public int dia
        {
            get { return _dia; }
            set { _dia = value; }
        }

        public int hora
        {
            get { return _hora; }
            set { _hora = value; }
        }
        #region IComparable<Curso> Members
        public int CompareTo(Curso otro)
        {
            /* LEGEND
            * < 0 means that this object is less than other
            * 0 means that both objects are equal
            * > 0 means that this object is greater than other
            * */

            int resultado = 1;
            if (otro._dia > this._dia)
            {
                resultado = -1;
            }
            else if (otro._dia == this._dia)
            {
                resultado = this._hora.CompareTo(otro._hora);
            }
            return resultado;
        }
        #endregion

    }
}