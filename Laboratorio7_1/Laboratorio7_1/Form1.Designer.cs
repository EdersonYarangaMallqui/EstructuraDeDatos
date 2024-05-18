namespace Laboratorio7_1
{
    partial class FormConstructora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelCodigo = new Label();
            textCodigo = new TextBox();
            textNombre = new TextBox();
            labelNombre = new Label();
            labelEspecialidad = new Label();
            comboCondicion = new ComboBox();
            comboEspecialidad = new ComboBox();
            labelEspecialidad_ = new Label();
            labelTipoActividad = new Label();
            comboTipoActividad = new ComboBox();
            labelTipoAfiliacion = new Label();
            comboTipoAfiliacion = new ComboBox();
            textResultado = new TextBox();
            botonCrearObjeto = new Button();
            botonMostrar = new Button();
            botonLimpiar = new Button();
            botonSalir = new Button();
            SuspendLayout();
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Location = new Point(14, 13);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(46, 15);
            labelCodigo.TabIndex = 0;
            labelCodigo.Text = "Código";
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(14, 31);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(84, 23);
            textCodigo.TabIndex = 1;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(124, 31);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(337, 23);
            textNombre.TabIndex = 2;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(124, 13);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre";
            // 
            // labelEspecialidad
            // 
            labelEspecialidad.AutoSize = true;
            labelEspecialidad.Location = new Point(14, 64);
            labelEspecialidad.Name = "labelEspecialidad";
            labelEspecialidad.Size = new Size(126, 15);
            labelEspecialidad.TabIndex = 4;
            labelEspecialidad.Text = "Condición de contrato";
            // 
            // comboCondicion
            // 
            comboCondicion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCondicion.FormattingEnabled = true;
            comboCondicion.Items.AddRange(new object[] { "Estable", "Contratado" });
            comboCondicion.Location = new Point(14, 84);
            comboCondicion.Name = "comboCondicion";
            comboCondicion.Size = new Size(126, 23);
            comboCondicion.TabIndex = 5;
            // 
            // comboEspecialidad
            // 
            comboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEspecialidad.FormattingEnabled = true;
            comboEspecialidad.Items.AddRange(new object[] { "Estructuras", "Recursos Hídricos" });
            comboEspecialidad.Location = new Point(160, 84);
            comboEspecialidad.Name = "comboEspecialidad";
            comboEspecialidad.Size = new Size(130, 23);
            comboEspecialidad.TabIndex = 6;
            // 
            // labelEspecialidad_
            // 
            labelEspecialidad_.AutoSize = true;
            labelEspecialidad_.Location = new Point(160, 64);
            labelEspecialidad_.Name = "labelEspecialidad_";
            labelEspecialidad_.Size = new Size(72, 15);
            labelEspecialidad_.TabIndex = 7;
            labelEspecialidad_.Text = "Especialidad";
            // 
            // labelTipoActividad
            // 
            labelTipoActividad.AutoSize = true;
            labelTipoActividad.Location = new Point(310, 64);
            labelTipoActividad.Name = "labelTipoActividad";
            labelTipoActividad.Size = new Size(99, 15);
            labelTipoActividad.TabIndex = 8;
            labelTipoActividad.Text = "Tipo de Actividad";
            // 
            // comboTipoActividad
            // 
            comboTipoActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoActividad.FormattingEnabled = true;
            comboTipoActividad.Items.AddRange(new object[] { "Supervisión de Obras", "Supervisión de Vías" });
            comboTipoActividad.Location = new Point(310, 84);
            comboTipoActividad.Name = "comboTipoActividad";
            comboTipoActividad.Size = new Size(161, 23);
            comboTipoActividad.TabIndex = 9;
            // 
            // labelTipoAfiliacion
            // 
            labelTipoAfiliacion.AutoSize = true;
            labelTipoAfiliacion.Location = new Point(491, 64);
            labelTipoAfiliacion.Name = "labelTipoAfiliacion";
            labelTipoAfiliacion.Size = new Size(99, 15);
            labelTipoAfiliacion.TabIndex = 10;
            labelTipoAfiliacion.Text = "Tipo de Afiliación";
            // 
            // comboTipoAfiliacion
            // 
            comboTipoAfiliacion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoAfiliacion.FormattingEnabled = true;
            comboTipoAfiliacion.Items.AddRange(new object[] { "AFP", "SNP" });
            comboTipoAfiliacion.Location = new Point(491, 84);
            comboTipoAfiliacion.Name = "comboTipoAfiliacion";
            comboTipoAfiliacion.Size = new Size(138, 23);
            comboTipoAfiliacion.TabIndex = 11;
            // 
            // textResultado
            // 
            textResultado.Location = new Point(14, 128);
            textResultado.Multiline = true;
            textResultado.Name = "textResultado";
            textResultado.Size = new Size(615, 194);
            textResultado.TabIndex = 12;
            // 
            // botonCrearObjeto
            // 
            botonCrearObjeto.Location = new Point(14, 342);
            botonCrearObjeto.Name = "botonCrearObjeto";
            botonCrearObjeto.Size = new Size(99, 23);
            botonCrearObjeto.TabIndex = 13;
            botonCrearObjeto.Text = "Crear Objeto";
            botonCrearObjeto.UseVisualStyleBackColor = true;
            botonCrearObjeto.Click += botonCrearObjeto_Click;
            // 
            // botonMostrar
            // 
            botonMostrar.Location = new Point(135, 342);
            botonMostrar.Name = "botonMostrar";
            botonMostrar.Size = new Size(212, 23);
            botonMostrar.TabIndex = 14;
            botonMostrar.Text = "Mostrar Información del Objeto";
            botonMostrar.UseVisualStyleBackColor = true;
            botonMostrar.Click += botonMostrar_Click;
            // 
            // botonLimpiar
            // 
            botonLimpiar.Location = new Point(442, 342);
            botonLimpiar.Name = "botonLimpiar";
            botonLimpiar.Size = new Size(86, 23);
            botonLimpiar.TabIndex = 15;
            botonLimpiar.Text = "Limpiar";
            botonLimpiar.UseVisualStyleBackColor = true;
            botonLimpiar.Click += botonLimpiar_Click;
            // 
            // botonSalir
            // 
            botonSalir.Location = new Point(543, 342);
            botonSalir.Name = "botonSalir";
            botonSalir.Size = new Size(86, 23);
            botonSalir.TabIndex = 16;
            botonSalir.Text = "Salir";
            botonSalir.UseVisualStyleBackColor = true;
            botonSalir.Click += botonSalir_Click;
            // 
            // FormConstructora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 385);
            Controls.Add(botonSalir);
            Controls.Add(botonLimpiar);
            Controls.Add(botonMostrar);
            Controls.Add(botonCrearObjeto);
            Controls.Add(textResultado);
            Controls.Add(comboTipoAfiliacion);
            Controls.Add(labelTipoAfiliacion);
            Controls.Add(comboTipoActividad);
            Controls.Add(labelTipoActividad);
            Controls.Add(labelEspecialidad_);
            Controls.Add(comboEspecialidad);
            Controls.Add(comboCondicion);
            Controls.Add(labelEspecialidad);
            Controls.Add(labelNombre);
            Controls.Add(textNombre);
            Controls.Add(textCodigo);
            Controls.Add(labelCodigo);
            Name = "FormConstructora";
            Text = "CONSTRUCTORA";
            Load += FormConstructora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCodigo;
        private TextBox textCodigo;
        private TextBox textNombre;
        private Label labelNombre;
        private Label labelEspecialidad;
        private ComboBox comboCondicion;
        private ComboBox comboEspecialidad;
        private Label labelEspecialidad_;
        private Label labelTipoActividad;
        private ComboBox comboTipoActividad;
        private Label labelTipoAfiliacion;
        private ComboBox comboTipoAfiliacion;
        private TextBox textResultado;
        private Button botonCrearObjeto;
        private Button botonMostrar;
        private Button botonLimpiar;
        private Button botonSalir;
    }
}
