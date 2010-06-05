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
    public bool eliminarCurso(string nombre, int dia, int hora) 
    { 
        bool resultado = false;
        try
        {
            resultado = this.cursoAdapter.EliminarCurso(nombre, dia, hora) == 1;
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
