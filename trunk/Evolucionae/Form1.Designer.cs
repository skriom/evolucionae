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
            this.tbCursos = new System.Windows.Forms.TabControl();
            this.tbInsertar = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
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
            this.ListaC = new System.Windows.Forms.ListBox();
            this.ListaP = new System.Windows.Forms.ListBox();
            this.tbCursos.SuspendLayout();
            this.tbInsertar.SuspendLayout();
            this.grpBxPersona.SuspendLayout();
            this.gbCursosP.SuspendLayout();
            this.grpBxCursos.SuspendLayout();
            this.tbSoluciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCursos
            // 
            this.tbCursos.Controls.Add(this.tbInsertar);
            this.tbCursos.Controls.Add(this.tbSoluciones);
            this.tbCursos.Location = new System.Drawing.Point(1, 2);
            this.tbCursos.Name = "tbCursos";
            this.tbCursos.SelectedIndex = 0;
            this.tbCursos.Size = new System.Drawing.Size(723, 525);
            this.tbCursos.TabIndex = 0;
            // 
            // tbInsertar
            // 
            this.tbInsertar.Controls.Add(this.btnSalir);
            this.tbInsertar.Controls.Add(this.grpBxPersona);
            this.tbInsertar.Controls.Add(this.grpBxCursos);
            this.tbInsertar.Location = new System.Drawing.Point(4, 22);
            this.tbInsertar.Name = "tbInsertar";
            this.tbInsertar.Padding = new System.Windows.Forms.Padding(3);
            this.tbInsertar.Size = new System.Drawing.Size(715, 499);
            this.tbInsertar.TabIndex = 0;
            this.tbInsertar.Text = "Insertar";
            this.tbInsertar.UseVisualStyleBackColor = true;
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
            // grpBxPersona
            // 
            this.grpBxPersona.Controls.Add(this.gbCursosP);
            this.grpBxPersona.Controls.Add(this.btnAtras);
            this.grpBxPersona.Controls.Add(this.btnAgregarPersona);
            this.grpBxPersona.Controls.Add(this.txtNombreP);
            this.grpBxPersona.Controls.Add(this.label5);
            this.grpBxPersona.Location = new System.Drawing.Point(6, 171);
            this.grpBxPersona.Name = "grpBxPersona";
            this.grpBxPersona.Size = new System.Drawing.Size(554, 212);
            this.grpBxPersona.TabIndex = 9;
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
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
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
            this.btnInsertarP.Text = "Insertar";
            this.btnInsertarP.UseVisualStyleBackColor = true;
            this.btnInsertarP.Click += new System.EventHandler(this.btnInsertarP_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(304, 173);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 18;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Location = new System.Drawing.Point(208, 173);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPersona.TabIndex = 17;
            this.btnAgregarPersona.Text = "Agregar";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click);
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
            this.grpBxCursos.Size = new System.Drawing.Size(554, 159);
            this.grpBxCursos.TabIndex = 8;
            this.grpBxCursos.TabStop = false;
            this.grpBxCursos.Text = "Cursos";
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
            this.tbSoluciones.Controls.Add(this.ListaC);
            this.tbSoluciones.Controls.Add(this.ListaP);
            this.tbSoluciones.Location = new System.Drawing.Point(4, 22);
            this.tbSoluciones.Name = "tbSoluciones";
            this.tbSoluciones.Padding = new System.Windows.Forms.Padding(3);
            this.tbSoluciones.Size = new System.Drawing.Size(715, 499);
            this.tbSoluciones.TabIndex = 1;
            this.tbSoluciones.Text = "Generar horario";
            this.tbSoluciones.UseVisualStyleBackColor = true;
            // 
            // ListaC
            // 
            this.ListaC.FormattingEnabled = true;
            this.ListaC.Location = new System.Drawing.Point(275, 15);
            this.ListaC.Name = "ListaC";
            this.ListaC.Size = new System.Drawing.Size(189, 225);
            this.ListaC.TabIndex = 23;
            // 
            // ListaP
            // 
            this.ListaP.FormattingEnabled = true;
            this.ListaP.Location = new System.Drawing.Point(7, 15);
            this.ListaP.Name = "ListaP";
            this.ListaP.Size = new System.Drawing.Size(189, 225);
            this.ListaP.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 578);
            this.Controls.Add(this.tbCursos);
            this.Name = "Form1";
            this.Text = "Principal";
            this.tbCursos.ResumeLayout(false);
            this.tbInsertar.ResumeLayout(false);
            this.grpBxPersona.ResumeLayout(false);
            this.grpBxPersona.PerformLayout();
            this.gbCursosP.ResumeLayout(false);
            this.gbCursosP.PerformLayout();
            this.grpBxCursos.ResumeLayout(false);
            this.grpBxCursos.PerformLayout();
            this.tbSoluciones.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpBxPersona;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAgregarPersona;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Button btnInsertarP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.GroupBox gbCursosP;
        private System.Windows.Forms.ListBox ListaP;
        private System.Windows.Forms.ListBox ListaC;
    }
}

