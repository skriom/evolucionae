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
            this.grpBxPersona = new System.Windows.Forms.GroupBox();
            this.gbCursosP = new System.Windows.Forms.GroupBox();
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.btnListo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsertarP = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ListaP = new System.Windows.Forms.ListBox();
            this.ListaC = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpBxCursos = new System.Windows.Forms.GroupBox();
            this.cmbListo = new System.Windows.Forms.Button();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSetPersona = new Evolucionae.Dataset.DataSetPersona();
            this.obtenerListaPersonasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obtenerListaPersonas = new Evolucionae.Dataset.DataSetPersonaTableAdapters.obtenerListaPersonas();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCursos.SuspendLayout();
            this.tbInsertar.SuspendLayout();
            this.grpBxPersona.SuspendLayout();
            this.gbCursosP.SuspendLayout();
            this.grpBxCursos.SuspendLayout();
            this.tbSoluciones.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerListaPersonasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCursos
            // 
            this.tbCursos.Controls.Add(this.tbInsertar);
            this.tbCursos.Controls.Add(this.tbSoluciones);
            this.tbCursos.Controls.Add(this.tabPage1);
            this.tbCursos.Location = new System.Drawing.Point(1, 2);
            this.tbCursos.Name = "tbCursos";
            this.tbCursos.SelectedIndex = 0;
            this.tbCursos.Size = new System.Drawing.Size(709, 589);
            this.tbCursos.TabIndex = 0;
            // 
            // tbInsertar
            // 
            this.tbInsertar.Controls.Add(this.grpBxPersona);
            this.tbInsertar.Controls.Add(this.ListaP);
            this.tbInsertar.Controls.Add(this.ListaC);
            this.tbInsertar.Controls.Add(this.btnSalir);
            this.tbInsertar.Controls.Add(this.grpBxCursos);
            this.tbInsertar.Location = new System.Drawing.Point(4, 22);
            this.tbInsertar.Name = "tbInsertar";
            this.tbInsertar.Padding = new System.Windows.Forms.Padding(3);
            this.tbInsertar.Size = new System.Drawing.Size(715, 499);
            this.tbInsertar.TabIndex = 0;
            this.tbInsertar.Text = "Cursos";
            this.tbInsertar.UseVisualStyleBackColor = true;
            // 
            // grpBxPersona
            // 
            this.grpBxPersona.Controls.Add(this.gbCursosP);
            this.grpBxPersona.Controls.Add(this.btnAtras);
            this.grpBxPersona.Controls.Add(this.btnAgregarPersona);
            this.grpBxPersona.Controls.Add(this.txtNombreP);
            this.grpBxPersona.Controls.Add(this.label5);
            this.grpBxPersona.Location = new System.Drawing.Point(6, 172);
            this.grpBxPersona.Name = "grpBxPersona";
            this.grpBxPersona.Size = new System.Drawing.Size(499, 212);
            this.grpBxPersona.TabIndex = 26;
            this.grpBxPersona.TabStop = false;
            this.grpBxPersona.Text = "Persona";
            this.grpBxPersona.Visible = false;
            // 
            // gbCursosP
            // 
            this.gbCursosP.Controls.Add(this.cmbCursos);
            this.gbCursosP.Controls.Add(this.btnListo);
            this.gbCursosP.Controls.Add(this.label6);
            this.gbCursosP.Controls.Add(this.btnInsertarP);
            this.gbCursosP.Enabled = false;
            this.gbCursosP.Location = new System.Drawing.Point(142, 54);
            this.gbCursosP.Name = "gbCursosP";
            this.gbCursosP.Size = new System.Drawing.Size(279, 99);
            this.gbCursosP.TabIndex = 28;
            this.gbCursosP.TabStop = false;
            this.gbCursosP.Text = "Agregar cursos";
            // 
            // cmbCursos
            // 
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Location = new System.Drawing.Point(49, 24);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(205, 21);
            this.cmbCursos.TabIndex = 25;
            // 
            // btnListo
            // 
            this.btnListo.Location = new System.Drawing.Point(179, 60);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(75, 23);
            this.btnListo.TabIndex = 27;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click_1);
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
            this.btnInsertarP.Location = new System.Drawing.Point(49, 60);
            this.btnInsertarP.Name = "btnInsertarP";
            this.btnInsertarP.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarP.TabIndex = 26;
            this.btnInsertarP.Text = "Agregar";
            this.btnInsertarP.UseVisualStyleBackColor = true;
            this.btnInsertarP.Click += new System.EventHandler(this.btnInsertarP_Click_1);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(304, 173);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 18;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Location = new System.Drawing.Point(208, 173);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPersona.TabIndex = 17;
            this.btnAgregarPersona.Text = "Insertar";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click_1);
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(227, 19);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(163, 20);
            this.txtNombreP.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre:";
            // 
            // ListaP
            // 
            this.ListaP.FormattingEnabled = true;
            this.ListaP.Location = new System.Drawing.Point(542, 172);
            this.ListaP.Name = "ListaP";
            this.ListaP.Size = new System.Drawing.Size(158, 199);
            this.ListaP.TabIndex = 25;
            // 
            // ListaC
            // 
            this.ListaC.FormattingEnabled = true;
            this.ListaC.Location = new System.Drawing.Point(542, 6);
            this.ListaC.Name = "ListaC";
            this.ListaC.Size = new System.Drawing.Size(158, 160);
            this.ListaC.TabIndex = 24;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(310, 402);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 62);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpBxCursos
            // 
            this.grpBxCursos.Controls.Add(this.cmbListo);
            this.grpBxCursos.Controls.Add(this.btnInsertarC);
            this.grpBxCursos.Controls.Add(this.txtNombre);
            this.grpBxCursos.Controls.Add(this.txtCupo);
            this.grpBxCursos.Controls.Add(this.label1);
            this.grpBxCursos.Controls.Add(this.cmbHora);
            this.grpBxCursos.Controls.Add(this.label2);
            this.grpBxCursos.Controls.Add(this.cmbDia);
            this.grpBxCursos.Controls.Add(this.label3);
            this.grpBxCursos.Controls.Add(this.label4);
            this.grpBxCursos.Location = new System.Drawing.Point(6, 6);
            this.grpBxCursos.Name = "grpBxCursos";
            this.grpBxCursos.Size = new System.Drawing.Size(499, 159);
            this.grpBxCursos.TabIndex = 8;
            this.grpBxCursos.TabStop = false;
            this.grpBxCursos.Text = "Cursos";
            this.grpBxCursos.Enter += new System.EventHandler(this.grpBxCursos_Enter);
            // 
            // cmbListo
            // 
            this.cmbListo.Location = new System.Drawing.Point(331, 111);
            this.cmbListo.Name = "cmbListo";
            this.cmbListo.Size = new System.Drawing.Size(75, 23);
            this.cmbListo.TabIndex = 11;
            this.cmbListo.Text = "Listo";
            this.cmbListo.UseVisualStyleBackColor = true;
            this.cmbListo.Click += new System.EventHandler(this.cmbListo_Click);
            // 
            // btnInsertarC
            // 
            this.btnInsertarC.Location = new System.Drawing.Point(142, 111);
            this.btnInsertarC.Name = "btnInsertarC";
            this.btnInsertarC.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarC.TabIndex = 10;
            this.btnInsertarC.Text = "Insertar";
            this.btnInsertarC.UseVisualStyleBackColor = true;
            this.btnInsertarC.Click += new System.EventHandler(this.btnInsertarC_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCupo
            // 
            this.txtCupo.Location = new System.Drawing.Point(105, 59);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(163, 20);
            this.txtCupo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
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
            this.cmbHora.Location = new System.Drawing.Point(355, 55);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(121, 21);
            this.cmbHora.TabIndex = 6;
            this.cmbHora.SelectedIndexChanged += new System.EventHandler(this.cmbHora_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
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
            this.cmbDia.Location = new System.Drawing.Point(355, 24);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(121, 21);
            this.cmbDia.TabIndex = 5;
            this.cmbDia.SelectedIndexChanged += new System.EventHandler(this.cmbDia_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Día:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora:";
            // 
            // tbSoluciones
            // 
            this.tbSoluciones.Controls.Add(this.dataGridView1);
            this.tbSoluciones.Location = new System.Drawing.Point(4, 22);
            this.tbSoluciones.Name = "tbSoluciones";
            this.tbSoluciones.Padding = new System.Windows.Forms.Padding(3);
            this.tbSoluciones.Size = new System.Drawing.Size(715, 499);
            this.tbSoluciones.TabIndex = 1;
            this.tbSoluciones.Text = "Personas";
            this.tbSoluciones.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvHorario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(701, 563);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Horarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.obtenerListaPersonasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(249, 135);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSetPersona
            // 
            this.dataSetPersona.DataSetName = "DataSetPersona";
            this.dataSetPersona.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obtenerListaPersonasBindingSource
            // 
            this.obtenerListaPersonasBindingSource.DataMember = "obtenerListaPersonas";
            this.obtenerListaPersonasBindingSource.DataSource = this.dataSetPersona;
            // 
            // obtenerListaPersonas
            // 
            this.obtenerListaPersonas.ClearBeforeFill = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // dgvHorario
            // 
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
            this.dgvHorario.Size = new System.Drawing.Size(646, 439);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 590);
            this.Controls.Add(this.tbCursos);
            this.Name = "Form1";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbCursos.ResumeLayout(false);
            this.tbInsertar.ResumeLayout(false);
            this.grpBxPersona.ResumeLayout(false);
            this.grpBxPersona.PerformLayout();
            this.gbCursosP.ResumeLayout(false);
            this.gbCursosP.PerformLayout();
            this.grpBxCursos.ResumeLayout(false);
            this.grpBxCursos.PerformLayout();
            this.tbSoluciones.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerListaPersonasBindingSource)).EndInit();
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
        private System.Windows.Forms.Button cmbListo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox ListaP;
        private System.Windows.Forms.ListBox ListaC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpBxPersona;
        private System.Windows.Forms.GroupBox gbCursosP;
        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsertarP;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAgregarPersona;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Evolucionae.Dataset.DataSetPersona dataSetPersona;
        private System.Windows.Forms.BindingSource obtenerListaPersonasBindingSource;
        private Evolucionae.Dataset.DataSetPersonaTableAdapters.obtenerListaPersonas obtenerListaPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia4;
    }
}

