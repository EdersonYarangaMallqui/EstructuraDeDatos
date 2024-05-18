namespace Laboratorio7_1
{
    public partial class FormConstructora : Form
    {
        Arquitecto arquitecto;
        public FormConstructora()
        {
            InitializeComponent();
        }
        // evento a inicializar el formulario
        private void FormConstructora_Load(object sender, EventArgs e)
        {
            comboCondicion.SelectedIndex = 0;
            comboEspecialidad.SelectedIndex = 0;
            comboTipoActividad.SelectedIndex = 0;
            comboTipoAfiliacion.SelectedIndex = 0;
        }

        //evento al click en Crear objeto
        private void botonCrearObjeto_Click(object sender, EventArgs e)
        {
            string codigo = textCodigo.Text;
            string nombre = textNombre.Text;
            string condicion = comboCondicion.Text;
            string especialidad = comboEspecialidad.Text;
            string tipoActividad = comboTipoActividad.Text;
            string tipoAfiliacion = comboTipoAfiliacion.Text;
            arquitecto = new Arquitecto(codigo, nombre, condicion, especialidad,
                tipoActividad, tipoAfiliacion);
            MessageBox.Show("Objeto Creado");
        }
        private void botonMostrar_Click(object sender, EventArgs e)
        {
            textResultado.AppendText("Objeto Nro: " + Arquitecto.GetContador().ToString() + Environment.NewLine);
            textResultado.AppendText("Codigo: " + arquitecto.Codigo + Environment.NewLine);
            textResultado.AppendText("Nombre: " + arquitecto.Nombre + Environment.NewLine);
            textResultado.AppendText("Condición: " + arquitecto.Condicion + Environment.NewLine);
            textResultado.AppendText("Especialidad: " + arquitecto.Especialidad + Environment.NewLine);
            textResultado.AppendText("Tipo de Actividad : " + arquitecto.TipoActividad + Environment.NewLine);
            textResultado.AppendText("Tipo de Afiliación: " + arquitecto.TipoAfiliacion + Environment.NewLine);
            textResultado.AppendText("Bonificación: " + arquitecto.CalcularBonificacion() + Environment.NewLine);
            textResultado.AppendText("Monto Afiliación: " + arquitecto.CalcularMontoSeguro() +
            Environment.NewLine);
            textResultado.AppendText("Monto Essalud: " + arquitecto.CalcularMontoEssalud() +
            Environment.NewLine);
            textResultado.AppendText("Monto Descuento: " + arquitecto.CalcularDescuento() +
            Environment.NewLine);
            textResultado.AppendText("Sueldo Bruto: " + arquitecto.SueldoBruto() + Environment.NewLine);
            textResultado.AppendText("Sueldo Neto: " + arquitecto.SueldoNeto() + Environment.NewLine);

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textCodigo.Text = string.Empty;
            textNombre.Clear();
            textResultado.Clear();
            textCodigo.Focus();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }


}
