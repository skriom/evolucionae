using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Evolucionae.Dataset;
using System.Data;

namespace Evolucionae
{
    class BDPersona
    {
        DataSetPersona datasetPersonas;
        Evolucionae.Dataset.DataSetPersonaTableAdapters.PersonaTableAdapter personaAdapter;
        Evolucionae.Dataset.DataSetPersonaTableAdapters.obtenerListaPersonas listaPersonas;
        Evolucionae.Dataset.DataSetPersona.PersonaDataTable datatablePersona;

        public BDPersona(){

        datasetPersonas = new DataSetPersona();
        personaAdapter = new Evolucionae.Dataset.DataSetPersonaTableAdapters.PersonaTableAdapter();
        listaPersonas = new Evolucionae.Dataset.DataSetPersonaTableAdapters.obtenerListaPersonas();

            
    
        }

        public bool insertarPersona(Persona p)
        {
            int afectados = 0;
            try
            {
                for(int i=0; i<p.cursosQueNecesita.Count(); i++){
                
                afectados = this.personaAdapter.InsertarPersona(p.nombre,p.cursosQueNecesita.ElementAt(i).ToString() );
                }
                
            }
            catch (Exception e)
            {
                return false;
            }
            return afectados == 1;
        }

        public bool eliminarPersona(String nombre)
        {
            int afectados = 0;
            try
            {
                afectados= this.personaAdapter.EliminarPersona(nombre);
             

            }
            catch (Exception e)
            {
                return false;
            }
            return afectados == 1;
        }
        
        //Devuelve un hashset con todas las personas ingresada en la BD
        public List<Persona> listaPersonasCompletas()
        {
            List<Persona> listaP = new List<Persona>();
            Persona p;
            String nombreP; 
            DataTable dt = solicitaListaNombreP();
            Array lista;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                p= new Persona();
                lista = dt.Rows[i].ItemArray;
                nombreP = (string)lista.GetValue(0);
                p.cursosQueNecesita =listaCursosPersona(nombreP);
                p.nombre = nombreP;
                listaP.Add(p);
            }
            return listaP;
        }
        
        //Solicita los nombres de las personas ingresadas en la BD
        public DataTable solicitaListaNombreP()
        {
            DataTable listaPersonas = this.listaPersonas.solicitarListaPersonas();
            return listaPersonas;
        }
        
        //Solicita la lista de cursos para lapesona que se le envia como parametro
        public List<String> listaCursosPersona(string nombre)
        {

            //string nombreC;
            datatablePersona = consultarCursosPersona(nombre);

            List<String> listacursosPersona = new List<String>();

           Array lista;

            for (int i = 0; i < datatablePersona.Rows.Count; i++)
            {
                string nombreC;
                lista = datatablePersona.Rows[i].ItemArray;
                nombreC = lista.GetValue(0).ToString();
                listacursosPersona.Add(nombreC);
            }

            return listacursosPersona;
        
        }

        //Devuelve un tabla con los cursos de una persona
        public Evolucionae.Dataset.DataSetPersona.PersonaDataTable consultarCursosPersona(string nombre)
        {
            try
            {
                return this.personaAdapter.consultarCursosPersona(nombre);
            }
            catch (Exception e)
            {
                return new Evolucionae.Dataset.DataSetPersona.PersonaDataTable();
            }

        }
        
        

    }
}
