namespace Laboratorio_8
{
    partial class FormularioNumeros
    {
        private void FormularioNumeros_Load(object sender, EventArgs e)
        {
            
        }

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
            botonAgregarNumero = new Button();
            textAgregarNumeros = new TextBox();
            textResultadoNumeros = new TextBox();
            botonMostrarResultadoNumeros = new Button();
            labelNumeros = new Label();
            SuspendLayout();
            // 
            // botonAgregarNumero
            // 
            botonAgregarNumero.Location = new Point(97, 98);
            botonAgregarNumero.Name = "botonAgregarNumero";
            botonAgregarNumero.Size = new Size(126, 23);
            botonAgregarNumero.TabIndex = 0;
            botonAgregarNumero.Text = "Agregar Número";
            botonAgregarNumero.UseVisualStyleBackColor = true;
            botonAgregarNumero.Click += botonAgregarNumero_Click;
            // 
            // textAgregarNumeros
            // 
            textAgregarNumeros.Location = new Point(47, 69);
            textAgregarNumeros.Name = "textAgregarNumeros";
            textAgregarNumeros.Size = new Size(236, 23);
            textAgregarNumeros.TabIndex = 1;
            // 
            // textResultadoNumeros
            // 
            textResultadoNumeros.Location = new Point(12, 136);
            textResultadoNumeros.Multiline = true;
            textResultadoNumeros.Name = "textResultadoNumeros";
            textResultadoNumeros.Size = new Size(309, 268);
            textResultadoNumeros.TabIndex = 2;
            // 
            // botonMostrarResultadoNumeros
            // 
            botonMostrarResultadoNumeros.Location = new Point(97, 413);
            botonMostrarResultadoNumeros.Name = "botonMostrarResultadoNumeros";
            botonMostrarResultadoNumeros.Size = new Size(126, 23);
            botonMostrarResultadoNumeros.TabIndex = 3;
            botonMostrarResultadoNumeros.Text = "Mostrar Resultado";
            botonMostrarResultadoNumeros.UseVisualStyleBackColor = true;
            botonMostrarResultadoNumeros.Click += botonMostrarResultado_Click;
            // 
            // labelNumeros
            // 
            labelNumeros.Location = new Point(12, 9);
            labelNumeros.Name = "labelNumeros";
            labelNumeros.Size = new Size(309, 53);
            labelNumeros.TabIndex = 4;
            labelNumeros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormularioNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 448);
            Controls.Add(labelNumeros);
            Controls.Add(botonMostrarResultadoNumeros);
            Controls.Add(textResultadoNumeros);
            Controls.Add(textAgregarNumeros);
            Controls.Add(botonAgregarNumero);
            Name = "FormularioNumeros";
            Text = "FORMULARIO NUMEROS";
            Load += FormularioNumeros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonAgregarNumero;
        private TextBox textAgregarNumeros;
        private TextBox textResultadoNumeros;
        private Button botonMostrarResultadoNumeros;
        private Label labelNumeros;
    }
}