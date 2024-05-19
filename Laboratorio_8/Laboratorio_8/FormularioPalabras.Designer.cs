namespace Laboratorio_8
{
    partial class FormularioPalabras
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
            botonAgregarPalabra = new Button();
            labelPalabras = new Label();
            textAgregarPalabras = new TextBox();
            textResultadoPalabras = new TextBox();
            botonMostrarResultadoPalabras = new Button();
            SuspendLayout();
            // 
            // botonAgregarPalabra
            // 
            botonAgregarPalabra.Location = new Point(98, 93);
            botonAgregarPalabra.Name = "botonAgregarPalabra";
            botonAgregarPalabra.Size = new Size(132, 23);
            botonAgregarPalabra.TabIndex = 0;
            botonAgregarPalabra.Text = "Agregar Palabra";
            botonAgregarPalabra.UseVisualStyleBackColor = true;
            botonAgregarPalabra.Click += botonAgregarPalabra_Click;
            // 
            // labelPalabras
            // 
            labelPalabras.Location = new Point(14, 9);
            labelPalabras.Name = "labelPalabras";
            labelPalabras.Size = new Size(316, 45);
            labelPalabras.TabIndex = 1;
            labelPalabras.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textAgregarPalabras
            // 
            textAgregarPalabras.Location = new Point(52, 64);
            textAgregarPalabras.Name = "textAgregarPalabras";
            textAgregarPalabras.Size = new Size(231, 23);
            textAgregarPalabras.TabIndex = 2;
            // 
            // textResultadoPalabras
            // 
            textResultadoPalabras.Location = new Point(14, 128);
            textResultadoPalabras.Multiline = true;
            textResultadoPalabras.Name = "textResultadoPalabras";
            textResultadoPalabras.Size = new Size(314, 277);
            textResultadoPalabras.TabIndex = 3;
            // 
            // botonMostrarResultadoPalabras
            // 
            botonMostrarResultadoPalabras.Location = new Point(98, 417);
            botonMostrarResultadoPalabras.Name = "botonMostrarResultadoPalabras";
            botonMostrarResultadoPalabras.Size = new Size(132, 23);
            botonMostrarResultadoPalabras.TabIndex = 4;
            botonMostrarResultadoPalabras.Text = "Mostrar Resultado";
            botonMostrarResultadoPalabras.UseVisualStyleBackColor = true;
            botonMostrarResultadoPalabras.Click += this.botonMostrarResultadoPalabras_Click;
            // 
            // FormularioPalabras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 452);
            Controls.Add(botonMostrarResultadoPalabras);
            Controls.Add(textResultadoPalabras);
            Controls.Add(textAgregarPalabras);
            Controls.Add(labelPalabras);
            Controls.Add(botonAgregarPalabra);
            Name = "FormularioPalabras";
            Text = "FORMULARIO PALABRAS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonAgregarPalabra;
        private Label labelPalabras;
        private TextBox textAgregarPalabras;
        private TextBox textResultadoPalabras;
        private Button botonMostrarResultadoPalabras;
    }
}