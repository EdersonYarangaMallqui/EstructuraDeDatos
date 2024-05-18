namespace Laboratorio7_2
{
    partial class FormOficina
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textNombres = new TextBox();
            textDni = new TextBox();
            textAntiguedad = new TextBox();
            comboCargo = new ComboBox();
            comboArea = new ComboBox();
            textResultado = new TextBox();
            botonCrearObjeto = new Button();
            botonMostrar = new Button();
            botonLimpiar = new Button();
            botonSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 14);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 67);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Cargo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 67);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 67);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 4;
            label5.Text = "Años de Antiguedad";
            // 
            // textNombres
            // 
            textNombres.Location = new Point(17, 32);
            textNombres.Name = "textNombres";
            textNombres.Size = new Size(381, 23);
            textNombres.TabIndex = 5;
            // 
            // textDni
            // 
            textDni.Location = new Point(416, 32);
            textDni.Name = "textDni";
            textDni.Size = new Size(141, 23);
            textDni.TabIndex = 6;
            // 
            // textAntiguedad
            // 
            textAntiguedad.Location = new Point(17, 85);
            textAntiguedad.Name = "textAntiguedad";
            textAntiguedad.Size = new Size(144, 23);
            textAntiguedad.TabIndex = 7;
            // 
            // comboCargo
            // 
            comboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCargo.FormattingEnabled = true;
            comboCargo.Items.AddRange(new object[] { "Gerente", "Subgerente" });
            comboCargo.Location = new Point(196, 85);
            comboCargo.Name = "comboCargo";
            comboCargo.Size = new Size(172, 23);
            comboCargo.TabIndex = 8;
            // 
            // comboArea
            // 
            comboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            comboArea.FormattingEnabled = true;
            comboArea.Items.AddRange(new object[] { "Contabilidad", "Planificación" });
            comboArea.Location = new Point(393, 85);
            comboArea.Name = "comboArea";
            comboArea.Size = new Size(164, 23);
            comboArea.TabIndex = 9;
            // 
            // textResultado
            // 
            textResultado.Location = new Point(17, 126);
            textResultado.Multiline = true;
            textResultado.Name = "textResultado";
            textResultado.Size = new Size(540, 226);
            textResultado.TabIndex = 10;
            // 
            // botonCrearObjeto
            // 
            botonCrearObjeto.Location = new Point(18, 368);
            botonCrearObjeto.Name = "botonCrearObjeto";
            botonCrearObjeto.Size = new Size(92, 24);
            botonCrearObjeto.TabIndex = 11;
            botonCrearObjeto.Text = "Crear Objeto";
            botonCrearObjeto.UseVisualStyleBackColor = true;
            botonCrearObjeto.Click += botonCrearObjeto_Click;
            // 
            // botonMostrar
            // 
            botonMostrar.Location = new Point(127, 369);
            botonMostrar.Name = "botonMostrar";
            botonMostrar.Size = new Size(191, 23);
            botonMostrar.TabIndex = 12;
            botonMostrar.Text = "Mostrar Información del Objeto";
            botonMostrar.UseVisualStyleBackColor = true;
            botonMostrar.Click += botonMostrar_Click;
            // 
            // botonLimpiar
            // 
            botonLimpiar.Location = new Point(393, 368);
            botonLimpiar.Name = "botonLimpiar";
            botonLimpiar.Size = new Size(75, 23);
            botonLimpiar.TabIndex = 13;
            botonLimpiar.Text = "Limpiar";
            botonLimpiar.UseVisualStyleBackColor = true;
            botonLimpiar.Click += botonLimpiar_Click;
            // 
            // botonSalir
            // 
            botonSalir.Location = new Point(482, 368);
            botonSalir.Name = "botonSalir";
            botonSalir.Size = new Size(75, 23);
            botonSalir.TabIndex = 14;
            botonSalir.Text = "Salir";
            botonSalir.UseVisualStyleBackColor = true;
            botonSalir.Click += botonSalir_Click;
            // 
            // FormOficina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 408);
            Controls.Add(botonSalir);
            Controls.Add(botonLimpiar);
            Controls.Add(botonMostrar);
            Controls.Add(botonCrearObjeto);
            Controls.Add(textResultado);
            Controls.Add(comboArea);
            Controls.Add(comboCargo);
            Controls.Add(textAntiguedad);
            Controls.Add(textDni);
            Controls.Add(textNombres);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormOficina";
            Text = "OFICINA";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textNombres;
        private TextBox textDni;
        private TextBox textAntiguedad;
        private ComboBox comboCargo;
        private ComboBox comboArea;
        private TextBox textResultado;
        private Button botonCrearObjeto;
        private Button botonMostrar;
        private Button botonLimpiar;
        private Button botonSalir;
    }
}
