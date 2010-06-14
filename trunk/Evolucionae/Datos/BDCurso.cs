using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Evolucionae.Dataset;
using System.Data;

namespace Evolucionae
{
    
    class BDCurso
    {

        DataSetCursos datasetCursos;
        Evolucionae.Dataset.DataSetCursosTableAdapters.CursoTableAdapter cursoAdapter;
        Evolucionae.Dataset.DataSetCursosTableAdapters.obtenerListaCursos listaCursosAdapter;
        Evolucionae.Dataset.DataSetCursosTableAdapters.obtenerNombreCursos nombreCursosAdapter;


        public BDCurso()
	{
		//
		// TODO: Add constructor logic here
		//
        datasetCursos = new DataSetCursos();
        cursoAdapter = new Evolucionae.Dataset.DataSetCursosTableAdapters.CursoTableAdapter();
        listaCursosAdapter = new Evolucionae.Dataset.DataSetCursosTableAdapters.obtenerListaCursos();
        nombreCursosAdapter = new Evolucionae.Dataset.DataSetCursosTableAdapters.obtenerNombreCursos();
	}

    //<<>> resultado:=eliminarCurso
    public bool eliminarCurso(Curso c) 
    { 
        bool resultado = false;
        try
        {
            resultado = this.cursoAdapter.EliminarCurso(c.nombre, c.dia, c.hora, c.cupo) == 1;
        }
        catch (Exception e)
        {
            resultado = false;
        }
        return resultado;
    }

    public DataTable solicitaListaCursos()
    {
        DataTable listaCursos = this.listaCursosAdapter.solicitarListaCurso();
        return listaCursos;
    }

    //Devuelve un hashset con todas las personas ingresada en la BD
    public List<Curso> listaCursosCompletas()
    {
        List<Curso> listaC = new List<Curso>();
        Curso c;
        DataTable dt = solicitaListaCursos();
        Array lista;
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            c = new Curso();
            lista = dt.Rows[i].ItemArray;
            c.nombre = (string)lista.GetValue(0);
            c.dia = (int)lista.GetValue(1);
            c.hora = (int)lista.GetValue(2);
            c.cupo = (int)lista.GetValue(3);
            c.id = (int)lista.GetValue(4);

            listaC.Add(c);
        }
        return listaC;
    }
    public DataTable solicitaNombreCursos()
    {
        DataTable nombreCursos = this.nombreCursosAdapter.solicitarNombreCursos();
        return nombreCursos;
    }

    
    
    public bool insertarCurso(Curso c)
    {
        int afectados = 0;
        try
        {
            afectados = this.cursoAdapter.InsertarCurso(c.nombre, c.dia, c.hora, c.cupo);
        }
        catch (Exception e)
        {
            return false;
        }
        return afectados == 1;
    }


    public DataSetCursos.CursoDataTable consultarDatosCurso(String nombre)
    {
        try
        {
            return new DataSetCursos.CursoDataTable();
            //return this.cursoAdapter.SeleccionarCurso(nombre);
        }
        catch (Exception e)
        {
            return new DataSetCursos.CursoDataTable();
        }

    }












    }
}
