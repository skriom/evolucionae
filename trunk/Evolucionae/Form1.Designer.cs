namespace Evolucionae
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbCursos = new System.Windows.Forms.TabControl();
            this.tbInsertar = new System.Windows.Forms.TabPage();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.obtenerListaCursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCursos = new Evolucionae.Dataset.DataSetCursos();
            this.grpBxCursos = new System.Windows.Forms.GroupBox();
            this.btnInsertarC = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSoluciones = new System.Windows.Forms.TabPage();
            this.ListaP = new System.Windows.Forms.ListBox();
            this.grpBxPersona = new System.Windows.Forms.GroupBox();
            this.gbCursosP = new System.Windows.Forms.GroupBox();
            this.btnListo = new System.Windows.Forms.Button();
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsertarP = new System.Windows.Forms.Button();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.obtenerListaPersonasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPersona = new Evolucionae.Dataset.DataSetPersona();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPersonas = new System.Windows.Forms.ComboBox();
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obtenerListaCursos = new Evolucionae.Dataset.DataSetCursosTableAdapters.obtenerListaCursos();
            this.btnSalir = new System.Windows.Forms.Button();
            this.obtenerListaPersonas = new Evolucionae.Dataset.DataSetPersonaTableAdapters.obtenerListaPersonas();
            this.tbCursos.SuspendLayout();
            this.tbInsertar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerListaCursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCursos)).BeginInit();
            this.grpBxCursos.SuspendLayout();
            this.tbSoluciones.SuspendLayout();
            this.grpBxPersona.SuspendLayout();
            this.gbCursosP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerListaPersonasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPersona)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCursos
            // 
            this.tbCursos.Controls.Add(this.tbInsertar);
            this.tbCursos.Controls.Add(this.tbSoluciones);
            this.tbCursos.Controls.Add(this.tabPage1);
            this.tbCursos.Location = new System.Drawing.Point(3, 2);
            this.tbCursos.Name = "tbCursos";
            this.tbCursos.SelectedIndex = 0;
            this.tbCursos.Size = new System.Drawing.Size(671, 449);
            this.tbCursos.TabIndex = 0;
            // 
            // tbInsertar
            // 
            this.tbInsertar.Controls.Add(this.dgvCursos);
            this.tbInsertar.Controls.Add(this.grpBxCursos);
            this.tbInsertar.Location = new System.Drawing.Point(4, 22);
            this.tbInsertar.Name = "tbInsertar";
            this.tbInsertar.Padding = new System.Windows.Forms.Padding(3);
            this.tbInsertar.Size = new System.Drawing.Size(663, 423);
            this.tbInsertar.TabIndex = 0;
            this.tbInsertar.Text = "Cursos";
            this.tbInsertar.UseVisualStyleBackColor = true;
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AutoGenerateColumns = false;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn1,
            this.diaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.cupoDataGridViewTextBoxColumn,
            this.Eliminar});
            this.dgvCursos.DataSource = this.obtenerListaCursosBindingSource;
            this.dgvCursos.Location = new System.Drawing.Point(48, 24);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.Size = new System.Drawing.Size(559, 219);
            this.dgvCursos.TabIndex = 25;
            this.dgvCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellContentClick);
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // diaDataGridViewTextBoxColumn
            // 
            this.diaDataGridViewTextBoxColumn.DataPropertyName = "Dia";
            this.diaDataGridViewTextBoxColumn.HeaderText = "Dia";
            this.diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            this.diaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cupoDataGridViewTextBoxColumn
            // 
            this.cupoDataGridViewTextBoxColumn.DataPropertyName = "Cupo";
            this.cupoDataGridViewTextBoxColumn.HeaderText = "Cupo";
            this.cupoDataGridViewTextBoxColumn.Name = "cupoDataGridViewTextBoxColumn";
            this.cupoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.DataPropertyName = "Eliminar";
            this.Eliminar.HeaderText = "  ";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.ToolTipText = "Eliminar curso";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // obtenerListaCursosBindingSource
            // 
            this.obtenerListaCursosBindingSource.DataMember = "obtenerListaCursos";
            this.obtenerListaCursosBindingSource.DataSource = this.dataSetCursos;
            // 
            // dataSetCursos
            // 
            this.dataSetCursos.DataSetName = "DataSetCursos";
            this.dataSetCursos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpBxCursos
            // 
            this.grpBxCursos.Controls.Add(this.btnInsertarC);
            this.grpBxCursos.Controls.Add(this.txtNombre);
            this.grpBxCursos.Controls.Add(this.txtCupo);
            this.grpBxCursos.Controls.Add(this.label1);
            this.grpBxCursos.Controls.Add(this.cmbHora);
            this.grpBxCursos.Controls.Add(this.label2);
            this.grpBxCursos.Controls.Add(this.cmbDia);
            this.grpBxCursos.Controls.Add(this.label3);
            this.grpBxCursos.Controls.Add(this.label4);
            this.grpBxCursos.Location = new System.Drawing.Point(48, 254);
            this.grpBxCursos.Name = "grpBxCursos";
            this.grpBxCursos.Size = new System.Drawing.Size(559, 142);
            this.grpBxCursos.TabIndex = 8;
            this.grpBxCursos.TabStop = false;
            this.grpBxCursos.Text = "Cursos";
            this.grpBxCursos.Enter += new System.EventHandler(this.grpBxCursos_Enter);
            // 
            // btnInsertarC
            // 
            this.btnInsertarC.Location = new System.Drawing.Point(249, 97);
            this.btnInsertarC.Name = "btnInsertarC";
            this.btnInsertarC.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarC.TabIndex = 10;
            this.btnInsertarC.Text = "Insertar";
            this.btnInsertarC.UseVisualStyleBackColor = true;
            this.btnInsertarC.Click += new System.EventHandler(this.btnInsertarC_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCupo
            // 
            this.txtCupo.Location = new System.Drawing.Point(105, 54);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(64, 20);
            this.txtCupo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del curso:";
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbHora.Location = new System.Drawing.Point(402, 50);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(121, 21);
            this.cmbHora.TabIndex = 6;
            this.cmbHora.SelectedIndexChanged += new System.EventHandler(this.cmbHora_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cupo:";
            // 
            // cmbDia
            // 
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.cmbDia.Location = new System.Drawing.Point(402, 19);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(121, 21);
            this.cmbDia.TabIndex = 5;
            this.cmbDia.SelectedIndexChanged += new System.EventHandler(this.cmbDia_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Día:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora:";
            // 
            // tbSoluciones
            // 
            this.tbSoluciones.Controls.Add(this.ListaP);
            this.tbSoluciones.Controls.Add(this.grpBxPersona);
            this.tbSoluciones.Controls.Add(this.dgvPersonas);
            this.tbSoluciones.Location = new System.Drawing.Point(4, 22);
            this.tbSoluciones.Name = "tbSoluciones";
            this.tbSoluciones.Padding = new System.Windows.Forms.Padding(3);
            this.tbSoluciones.Size = new System.Drawing.Size(663, 423);
            this.tbSoluciones.TabIndex = 1;
            this.tbSoluciones.Text = "Personas";
            this.tbSoluciones.UseVisualStyleBackColor = true;
            // 
            // ListaP
            // 
            this.ListaP.FormattingEnabled = true;
            this.ListaP.Location = new System.Drawing.Point(412, 24);
            this.ListaP.Name = "ListaP";
            this.ListaP.Size = new System.Drawing.Size(158, 212);
            this.ListaP.TabIndex = 28;
            // 
            // grpBxPersona
            // 
            this.grpBxPersona.Controls.Add(this.gbCursosP);
            this.grpBxPersona.Controls.Add(this.btnAgregarPersona);
            this.grpBxPersona.Controls.Add(this.txtNombreP);
            this.grpBxPersona.Controls.Add(this.label5);
            this.grpBxPersona.Location = new System.Drawing.Point(70, 253);
            this.grpBxPersona.Name = "grpBxPersona";
            this.grpBxPersona.Size = new System.Drawing.Size(521, 132);
            this.grpBxPersona.TabIndex = 27;
            this.grpBxPersona.TabStop = false;
            this.grpBxPersona.Text = "Persona";
            // 
            // gbCursosP
            // 
            this.gbCursosP.Controls.Add(this.btnListo);
            this.gbCursosP.Controls.Add(this.cmbCursos);
            this.gbCursosP.Controls.Add(this.label6);
            this.gbCursosP.Controls.Add(this.btnInsertarP);
            this.gbCursosP.Enabled = false;
            this.gbCursosP.Location = new System.Drawing.Point(221, 19);
            this.gbCursosP.Name = "gbCursosP";
            this.gbCursosP.Size = new System.Drawing.Size(279, 99);
            this.gbCursosP.TabIndex = 28;
            this.gbCursosP.TabStop = false;
            this.gbCursosP.Text = "Agregar cursos";
            // 
            // btnListo
            // 
            this.btnListo.Location = new System.Drawing.Point(163, 60);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(75, 23);
            this.btnListo.TabIndex = 27;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // cmbCursos
            // 
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Location = new System.Drawing.Point(49, 24);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(205, 21);
            this.cmbCursos.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Curso:";
            // 
            // btnInsertarP
            // 
            this.btnInsertarP.Location = new System.Drawing.Point(46, 60);
            this.btnInsertarP.Name = "btnInsertarP";
            this.btnInsertarP.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarP.TabIndex = 26;
            this.btnInsertarP.Text = "Agregar";
            this.btnInsertarP.UseVisualStyleBackColor = true;
            this.btnInsertarP.Click += new System.EventHandler(this.btnInsertarP_Click_1);
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Location = new System.Drawing.Point(73, 79);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPersona.TabIndex = 17;
            this.btnAgregarPersona.Text = "Insertar";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click);
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(73, 23);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(117, 20);
            this.txtNombreP.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre:";
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.AutoGenerateColumns = false;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.Eliminar2});
            this.dgvPersonas.DataSource = this.obtenerListaPersonasBindingSource;
            this.dgvPersonas.Location = new System.Drawing.Point(100, 17);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(248, 219);
            this.dgvPersonas.TabIndex = 0;
            this.dgvPersonas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPersonas_RowHeaderMouseClick);
            this.dgvPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonas_CellContentClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Eliminar2
            // 
            this.Eliminar2.HeaderText = "";
            this.Eliminar2.Name = "Eliminar2";
            this.Eliminar2.ReadOnly = true;
            this.Eliminar2.Text = "Eliminar";
            this.Eliminar2.UseColumnTextForButtonValue = true;
            // 
            // obtenerListaPersonasBindingSource
            // 
            this.obtenerListaPersonasBindingSource.DataMember = "obtenerListaPersonas";
            this.obtenerListaPersonasBindingSource.DataSource = this.dataSetPersona;
            // 
            // dataSetPersona
            // 
            this.dataSetPersona.DataSetName = "DataSetPersona";
            this.dataSetPersona.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnMostrar);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cmbPersonas);
            this.tabPage1.Controls.Add(this.dgvHorario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(663, 423);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Horarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(382, 370);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(86, 35);
            this.btnMostrar.TabIndex = 15;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre:";
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.FormattingEnabled = true;
            this.cmbPersonas.Location = new System.Drawing.Point(194, 370);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(148, 21);
            this.cmbPersonas.TabIndex = 1;
            // 
            // dgvHorario
            // 
            this.dgvHorario.AllowUserToAddRows = false;
            this.dgvHorario.AllowUserToDeleteRows = false;
            this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hora,
            this.Dia0,
            this.Dia1,
            this.Dia2,
            this.Dia3,
            this.Dia4});
            this.dgvHorario.Location = new System.Drawing.Point(7, 6);
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.ReadOnly = true;
            this.dgvHorario.Size = new System.Drawing.Size(644, 332);
            this.dgvHorario.TabIndex = 0;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Dia0
            // 
            this.Dia0.HeaderText = "Lunes";
            this.Dia0.Name = "Dia0";
            this.Dia0.ReadOnly = true;
            // 
            // Dia1
            // 
            this.Dia1.HeaderText = "Martes";
            this.Dia1.Name = "Dia1";
            this.Dia1.ReadOnly = true;
            // 
            // Dia2
            // 
            this.Dia2.HeaderText = "Miercoles";
            this.Dia2.Name = "Dia2";
            this.Dia2.ReadOnly = true;
            // 
            // Dia3
            // 
            this.Dia3.HeaderText = "Jueves";
            this.Dia3.Name = "Dia3";
            this.Dia3.ReadOnly = true;
            // 
            // Dia4
            // 
            this.Dia4.HeaderText = "Viernes";
            this.Dia4.Name = "Dia4";
            this.Dia4.ReadOnly = true;
            // 
            // obtenerListaCursos
            // 
            this.obtenerListaCursos.ClearBeforeFill = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(280, 467);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 36);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // obtenerListaPersonas
            // 
            this.obtenerListaPersonas.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 524);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tbCursos);
            this.Name = "Form1";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbCursos.ResumeLayout(false);
            this.tbInsertar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerListaCursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCursos)).EndInit();
            this.grpBxCursos.ResumeLayout(false);
            this.grpBxCursos.PerformLayout();
            this.tbSoluciones.ResumeLayout(false);
            this.grpBxPersona.ResumeLayout(false);
            this.grpBxPersona.PerformLayout();
            this.gbCursosP.ResumeLayout(false);
            this.gbCursosP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerListaPersonasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPersona)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCursos;
        private System.Windows.Forms.TabPage tbInsertar;
        private System.Windows.Forms.TabPage tbSoluciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grpBxCursos;
        private System.Windows.Forms.Button btnInsertarC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private Evolucionae.Dataset.DataSetPersona dataSetPersona;
        private System.Windows.Forms.BindingSource obtenerListaPersonasBindingSource;
        private Evolucionae.Dataset.DataSetPersonaTableAdapters.obtenerListaPersonas obtenerListaPersonas;
        private System.Windows.Forms.DataGridView dgvHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia4;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPersonas;
        private System.Windows.Forms.GroupBox grpBxPersona;
        private System.Windows.Forms.GroupBox gbCursosP;
        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsertarP;
        private System.Windows.Forms.Button btnAgregarPersona;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ListaP;
        private System.Windows.Forms.DataGridView dgvCursos;
        private Evolucionae.Dataset.DataSetCursos dataSetCursos;
        private System.Windows.Forms.BindingSource obtenerListaCursosBindingSource;
        private Evolucionae.Dataset.DataSetCursosTableAdapters.obtenerListaCursos obtenerListaCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar2;
        private System.Windows.Forms.Button btnListo;
    }
}

