namespace Laboratorio7_2
{
    public partial class FormOficina : Form
    {
        Jefe jefe;
        public FormOficina()
        {
            InitializeComponent();
        }

        // evento a inicializar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            comboCargo.SelectedIndex = 0;
            comboArea.SelectedIndex = 0;
        }

        private TextBox GetTextAntiguedad()
        {
            return textAntiguedad;
        }

        //evento al click en Crear objeto
        private void botonCrearObjeto_Click(object sender, EventArgs e)
        {
            string nombres = textNombres.Text;
            string dni = textDni.Text;
            string cargo = comboCargo.Text;
            string area = comboArea.Text;
            string antiguedadtexto = textAntiguedad.Text;
            int antiguedad;
            int.TryParse(antiguedadtexto, out antiguedad);


            jefe = new Jefe(nombres, dni, cargo, area, antiguedad);
            MessageBox.Show("Objeto Creado");
        }

        private void botonMostrar_Click(object sender, EventArgs e)
        {
            textResultado.AppendText("Objeto Nro: " + Jefe.GetContador().ToString() + Environment.NewLine);
            textResultado.AppendText("Nombres: " + jefe.Nombres + Environment.NewLine);
            textResultado.AppendText("DNI: " + jefe.Dni + Environment.NewLine);
            textResultado.AppendText("Cargo: " + jefe.Cargo + Environment.NewLine);
            textResultado.AppendText("Area: " + jefe.Area + Environment.NewLine);
            textResultado.AppendText("Antiguedad : " + jefe.Antiguedad + Environment.NewLine);
          
            textResultado.AppendText("Bonificación: " + jefe.CalcularBonificacion() + Environment.NewLine);
            textResultado.AppendText("Movilidad: " + jefe.Movilidad() + Environment.NewLine);
            textResultado.AppendText("Sueldo Final: " + jefe.SueldoFinal() + Environment.NewLine);

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textNombres.Text = string.Empty;
            textDni.Clear();
            textResultado.Clear();
            textAntiguedad.Clear();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
