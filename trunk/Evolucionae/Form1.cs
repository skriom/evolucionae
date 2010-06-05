using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Evolucionae
{
    public partial class Form1 : Form
    {
        HashSet<String> cursosP = new HashSet<String>();
        HashSet<Curso> cursos = new HashSet<Curso>();
        HashSet<Persona> personas = new HashSet<Persona>();
        //Persona p = new Persona();
        //Curso c = new Curso();
        //int contador;
        public const int LUNES = 0;
        public const int MARTES = 1;
        public const int MIERCOLES = 2;
        public const int JUEVES = 3;
        public const int VIERNES = 4;
        public const int SABADO = 5;


        BDCurso bdc= new BDCurso();
        BDPersona bdp = new BDPersona(); 
        public Form1()
        {
            InitializeComponent();
            cargarCursos();
            cargarComboCursos();
            cargarPersonas();
            imprimirListaCursos();
            imprimirListaPersonas();
            this.pruebaTonta();
        }

        public void pruebaTonta()
        {
            int idActual = 0;
            Curso cur = new Curso(idActual++, "paradigmas", 2, MARTES, 7);
            this.cursos.Add(cur);
            cur = new Curso(idActual++, "paradigmas", 2, MARTES, 9);
            this.cursos.Add(cur);
            cur = new Curso(idActual++, "bases", 1, LUNES, 11);
            this.cursos.Add(cur);
            cur = new Curso(idActual++, "bases", 2, LUNES, 1);
            this.cursos.Add(cur);
            cur = new Curso(idActual++, "redes", 2, MARTES, 7);
            this.cursos.Add(cur);
            cur = new Curso(idActual++, "io", 1, LUNES, 7);
            this.cursos.Add(cur);
            cur = new Curso(idActual++, "io", 1, MARTES, 7);
            this.cursos.Add(cur);
            cur = new Curso(idActual++, "mineria", 1, LUNES, 11);
            this.cursos.Add(cur);
            idActual = 0;
            Persona person = new Persona(idActual++, "Fabian");
            person.cursosQueNecesita.Add("paradigmas");
            person.cursosQueNecesita.Add("bases");
            person.cursosQueNecesita.Add("io");
            person.cursosQueNecesita.Add("mineria");

            AG1 ag1 = new AG1(person, this.cursos);
            ag1.generarPoblacionInicial();

        }
        private void cargarComboCursos()
        {
           for (int i = 0; i < cursos.Count; i++) {
               cmbCursos.Items.Add(cursos.ElementAt(i).nombre);
            }
        }
        
        private void cargarCursos()
        {
            Curso c ;
            DataTable dt = bdc.solicitaListaCursos();
            Array lista;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                c= new Curso();
                lista = dt.Rows[i].ItemArray;
                c.nombre = (string)lista.GetValue(0);
                c.dia = (int)lista.GetValue(1);
                c.hora = (int)lista.GetValue(2);
                c.cupo = (int)lista.GetValue(3);
                cursos.Add(c);
            }
        }
        private void cargarPersonas()
        {
            personas = bdp.listaPersonasCompletas();
            
        }

        private void imprimirListaCursos()
        {
            this.ListaC.Items.Clear();
            for (int i = 0; i < cursos.Count; i++)
            {
                this.ListaC.Items.Add(cursos.ElementAt(i).nombre + "-D: " + cursos.ElementAt(i).dia + "-H: " + cursos.ElementAt(i).hora);

            }


        }
        private void imprimirListaPersonas()
        {
            this.ListaP.Items.Clear();
            for (int i = 0; i < personas.Count; i++)
            {
                this.ListaP.Items.Add(personas.ElementAt(i).nombre);

            }


        }

        private void limpiar()
        {
            this.txtCupo.Text = "";
            this.txtNombre.Text = "";
            //this.cmbCursos.SelectedIndex = 0;
            this.cmbDia.SelectedIndex = 0;
        }

        #region "Botones"
        private void cmbListo_Click(object sender, EventArgs e)
        {
           
            grpBxPersona.Visible = true;
            grpBxCursos.Visible = false;
           
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            grpBxCursos.Visible = true;
            grpBxPersona.Visible = false;
            
        }

        private void btnInsertarC_Click(object sender, EventArgs e)
        {
           
            Curso c = new Curso();
            c.nombre = txtNombre.Text;
            c.cupo = Convert.ToInt32(txtCupo.Text);
            c.dia = cmbDia.SelectedIndex;
            c.hora = Convert.ToInt32(cmbHora.Text);

            bdc.insertarCurso(c);
            

        }
       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            /**asdasdadasd*/
            int borrar;

            string message = "¿Está seguro que desea salir?";
            string caption = "Salir";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(message, caption, buttons);

            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            
            }
            
            
        }

        private void btnInsertarP_Click(object sender, EventArgs e)
        {

            //if (contador < cant)
            //{
                cursosP.Add(cmbCursos.Text);
                //contador++;

            //}
            /*else {
                MessageBox.Show("ya ingreso la cantidad de cursos asignados.", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //gbCursosP.Enabled = false;
            
            }*/
            this.cmbCursos.Text="";
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            //contador = 0;
            //cant = Convert.ToInt32(cmbCant.SelectedItem);
            gbCursosP.Enabled = true;
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            
            Persona p = new Persona();
            p.nombre = this.txtNombreP.Text;
            p.cursosQueNecesita = this.cursosP;
            bdp.insertarPersona(p);
            this.personas.Add(p);
            //contador = 0;
            this.txtNombreP.Text = "";
            //this.cmbCant.Text = "";
            gbCursosP.Enabled = false;
        }
        #endregion "Botones"

        private void cmbHora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

       

       
        

        
      

      



        

       

        

      
    }
}
