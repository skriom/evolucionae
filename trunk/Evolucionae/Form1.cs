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
        List<String> cursosP = new List<String>();
        List<Curso> cursos = new List<Curso>();
        List<Persona> personas = new List<Persona>();
        Dictionary<string, List<Curso>> cursosTipo = new Dictionary<string, List<Curso>>();
        //Persona p = new Persona();
        //Curso c = new Curso();
        //int contador;
        //Borrado personas
        //Borrado cursos
        Curso cursoBorrar = new Curso();
        public const int LUNES = 0;
        public const int MARTES = 1;
        public const int MIERCOLES = 2;
        public const int JUEVES = 3;
        public const int VIERNES = 4;
        public const int SABADO = 5;

        int[] solucion= new int[70];

        BDCurso bdc= new BDCurso();
        BDPersona bdp = new BDPersona(); 
        public Form1()
        {
            InitializeComponent();

            //this.pruebaTonta();
            cargarCursos();
            cargarComboCursos();
            cargarPersonas();
            cargarComboPersonas();
            this.initCursosTipo();
            this.pruebaTonta();
            this.inicializarGridHorario();
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
            cur = new Curso(idActual++, "bases", 2, LUNES, 13);
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
            bdp.insertarPersona(person);
            AG1 ag1 = new AG1(person, cursosTipo);
            ag1.generarPoblacionInicial();
            ag1.evolucionar();
        }
        #region "Cargar cosas"
        
        private void cargarComboCursos()
        {

            this.cmbCursos.Items.Clear();
            String nombre;
            DataTable dt = bdc.solicitaNombreCursos();
            Array lista;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista = dt.Rows[i].ItemArray;
                nombre = (string)lista.GetValue(0);
                cmbCursos.Items.Add(nombre);

            }

        }

        private void cargarComboPersonas() {
            for (int i = 0; i < personas.Count; i++)
            {
                this.cmbPersonas.Items.Add(personas.ElementAt(i).nombre);

            }
        
        
        }
        
        private void cargarCursos()
        {
            cursos = bdc.listaCursosCompletas();
            
        }

        private void cargarPersonas()
        {
            personas = bdp.listaPersonasCompletas();

        }

        #endregion "Cargar cosas"

        #region "Limpiar/Imprimir cosas"
        
        
        
        private void limpiarListBox(ListBox Lista) {

            for (int i = 0; i < Lista.Items.Count; i++ )
            {
                Lista.Items.RemoveAt(i);

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
            this.cmbDia.SelectedIndex = -1; ;
            this.cmbHora.SelectedIndex = -1; ;
        }
        
        #endregion "Limpiar/Imprimir cosas"
        
        #region "Botones"

        #region "Curso"

        

        private void btnInsertarC_Click(object sender, EventArgs e)
        {
            if (validarEspacios())
            {
            Curso c = new Curso();
            c.nombre = txtNombre.Text;
            c.cupo = Convert.ToInt32(txtCupo.Text);
            c.dia = cmbDia.SelectedIndex;
            c.hora = Convert.ToInt32(cmbHora.Text);

            bdc.insertarCurso(c);

            //Actualiza la lista de cursos, y refresca la lista
            this.cargarCursos();
            this.cargarComboCursos();
            this.obtenerListaCursos.Fill(this.dataSetCursos.obtenerListaCursos);
            this.limpiar();
           
           }else{

               MessageBox.Show("Debe llenar todos los campos", "Insertar curso");
           }

            
            

        }
        
        private Boolean validarEspacios() {
            Boolean completos = true;
            if (txtNombre.Text=="")
            {
             completos=false;
             }
            if (txtCupo.Text== "")
            {
                completos = false;
            }
            if (cmbDia.SelectedIndex == -1)
            {
                completos = false;
            }
            if (cmbHora.SelectedIndex == -1)
            {
                completos = false;
            }
            return completos;

        }

        #endregion "Curso"

        #region "Persona"

        private void btnInsertarP_Click_1(object sender, EventArgs e)
        {
            if(this.cmbCursos.SelectedIndex != -1){
                cursosP.Add(cmbCursos.Text);
                this.cmbCursos.SelectedIndex = -1;

            }else{
                MessageBox.Show("Debe seleccionar un curso", "Agregar curso");
            }
            
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            //contador = 0;
            //cant = Convert.ToInt32(cmbCant.SelectedItem);
            if (txtNombreP.Text != "")
            {

                gbCursosP.Enabled = true;
            }
            else {

                MessageBox.Show("Debe ingresar un nombre", "Insertar persona");
            
            }
            
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            
            Persona p = new Persona();
            p.nombre = this.txtNombreP.Text;
            p.cursosQueNecesita = this.cursosP;
            bdp.insertarPersona(p);
            this.cargarPersonas();
            this.obtenerListaPersonas.Fill(this.dataSetPersona.obtenerListaPersonas);
            this.txtNombreP.Text = "";
            this.cmbCursos.SelectedIndex = -1;
            gbCursosP.Enabled = false;
        }
        
        #endregion "Persona"

        private void btnSalir_Click_1(object sender, EventArgs e)
        {

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

        #endregion "Botones"

        private void cmbHora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpBxCursos_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetCursos.obtenerListaCursos' Puede moverla o quitarla según sea necesario.
            this.obtenerListaCursos.Fill(this.dataSetCursos.obtenerListaCursos);
            // TODO: This line of code loads data into the 'dataSetPersona.obtenerListaPersonas' table. You can move, or remove it, as needed.
            this.obtenerListaPersonas.Fill(this.dataSetPersona.obtenerListaPersonas);

        }

        #region "Datagrid"

        private void inicializarGridHorario() {

            int hora= 7;
            DataGridViewCell dgc = new DataGridViewButtonCell();
            //Recorremos el DataGridView con un bucle for
            //dataGridView1.Rows. = 13;
           
           for (int i = 0; i < 14; i++)
            {
                string[] row = { hora.ToString(), "", "", "", "", "" };

                dgvHorario.Rows.Add(row);
                //dgvHorario.Rows[i].Cells[0].Value= hora;
                //celda = ((String)dgc.Value) + "\r\n";
                //textBox1.Text += celda.Replace(".", ",");
                hora++;
            }


        
        }
        
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.inicializarSolucion();
            int contador = 0;
            for(int i=0; i<14; i++){
                contador = i;
                for(int j=1; j<6; j++){
                    if (contador < 70)
                    {

//                     dgvHorario.Rows[i].Cells[j].Value = solucion[contador].ToString();
                        dgvHorario.Rows[i].Cells[j].Value = cursos.ElementAt(solucion[contador]).nombre;
                     contador += 14;
                    }
                }
            }
            

        }

        private void inicializarSolucion() {

            for (int i = 0; i < 70;i++ )
            {
                     solucion[i] = 0;
            }
            for (int i = 0; i < 70; i += 2)
            {
                solucion[i] = 1;
            }
        
        }
 
        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string message = "¿Está seguro que desea eliminar esta persona?";
            string caption = "Eliminar persona";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(message, caption, buttons);

            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {

                object nombre = dgvPersonas.Rows[e.RowIndex].Cells[0].Value;
                bdp.eliminarPersona(nombre.ToString());
                this.cargarPersonas();
                this.obtenerListaPersonas.Fill(this.dataSetPersona.obtenerListaPersonas);
                this.ListaP.Items.Clear();

            }

        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string message = "¿Está seguro que desea eliminar este curso?";
            string caption = "Eliminar curso";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(message, caption, buttons);

            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                           
            object nombre = dgvCursos.Rows[e.RowIndex].Cells[0].Value;
            cursoBorrar.nombre= nombre.ToString();

            object dia = dgvCursos.Rows[e.RowIndex].Cells[1].Value;
             cursoBorrar.dia= Convert.ToInt32(dia);

            object hora = dgvCursos.Rows[e.RowIndex].Cells[2].Value;
            cursoBorrar.hora = Convert.ToInt32(hora);

            object cupo = dgvCursos.Rows[e.RowIndex].Cells[3].Value;
            cursoBorrar.cupo= Convert.ToInt32(cupo);
            bdc.eliminarCurso(cursoBorrar);
            bdp.eliminarPersonaPorCurso(cursoBorrar.nombre);
            //Se actuliza el combo de cursos hasta que termine de ingresar todos los cursos
            this.cargarCursos();
            this.obtenerListaCursos.Fill(this.dataSetCursos.obtenerListaCursos);
            this.cargarComboCursos();
            this.cargarPersonas();
            this.obtenerListaPersonas.Fill(this.dataSetPersona.obtenerListaPersonas);
            this.ListaP.Items.Clear();
            this.limpiar();

            }
        }
        
        # endregion "Datagrid"

        private void dgvPersonas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            object nombreP = dgvPersonas.Rows[e.RowIndex].Cells[0].Value;
            int posicion=0;
            for (int i = 0; i < personas.Count; i++ )
            {
                if (personas.ElementAt(i).nombre==nombreP.ToString()){
                    posicion = i;
                    break;
                }

            }

           this.ListaP.Items.Clear();
            for (int i = 0; i < personas[posicion].cursosQueNecesita.Count; i++)
            {
            this.ListaP.Items.Add(personas[posicion].cursosQueNecesita.ElementAt(i));
            }
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
        /// Genera una lista de soluciones para cada
        /// </summary>
        private void generarSolucionIndependientes()
        { 
        
        }
        

        

     }
}
