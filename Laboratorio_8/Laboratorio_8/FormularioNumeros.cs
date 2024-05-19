using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;  // Necesario para usar InputBox

namespace Laboratorio_8
{
    public partial class FormularioNumeros : Form
    {
        private List<int> numeros;
        private string ejercicio;

        public FormularioNumeros(string textoEjercicio)
        {
            InitializeComponent();
            numeros = new List<int>();
            labelNumeros.Text = textoEjercicio;
            ejercicio = textoEjercicio;
        }

        private void botonAgregarNumero_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textAgregarNumeros.Text, out int numero))
            {
                numeros.Add(numero);
                textAgregarNumeros.Clear();
                MessageBox.Show("Número agregado correctamente.");
                textResultadoNumeros.Text += numero + Environment.NewLine;
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }

        private void botonMostrarResultado_Click(object sender, EventArgs e)
        {
            List<int> resultado = new List<int>();

            switch (ejercicio.Substring(0, 2))
            {
                case "1.":
                    resultado = Numeros.EncontrarNumerosPrimos(numeros);
                    break;

                case "3.":
                    string input = Interaction.InputBox("Ingrese el divisor:", "Divisor", "1");
                    if (int.TryParse(input, out int divisor))
                    {
                        resultado = EncontrarNumerosDivisibles(numeros, divisor);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un divisor válido.");
                        return;
                    }
                    break;

                case "4.":
                    resultado = EncontrarInterseccion(numeros, ObtenerConjuntoAdicional("Ingrese los números del segundo conjunto (separados por comas):"));
                    break;

                case "5.":
                    resultado = EncontrarDiferencia(numeros, ObtenerConjuntoAdicional("Ingrese los números del segundo conjunto (separados por comas):"));
                    break;

                case "6.":
                    resultado = EncontrarDiferencia(ObtenerConjuntoAdicional("Ingrese los números del segundo conjunto (separados por comas):"), numeros);
                    break;

                case "11":
                    resultado = OrdenarNumeros(numeros, ascending: true);
                    break;

                case "12":
                    resultado = OrdenarNumeros(numeros, ascending: false);
                    break;

                case "13":
                    resultado = EncontrarDuplicados(numeros);
                    break;

                case "14":
                    resultado = EncontrarNoDuplicados(numeros);
                    break;

                case "15":
                    resultado = Numeros.EncontrarNumerosPrimos(numeros).OrderBy(n => n).ToList();
                    break;

                case "19":
                    resultado = OrdenarNumeros(numeros.Distinct().ToList(), ascending: true);
                    break;

                default:
                    MessageBox.Show("Ejercicio no reconocido.");
                    return;
            }

            MostrarResultado(resultado);
        }

        private List<int> ObtenerConjuntoAdicional(string mensaje)
        {
            string input = Interaction.InputBox(mensaje, "Segundo Conjunto", "");
            if (!string.IsNullOrEmpty(input))
            {
                var conjunto2 = input.Split(',').Select(n => int.TryParse(n.Trim(), out int num) ? num : (int?)null).Where(n => n.HasValue).Select(n => n.Value).ToList();
                return conjunto2;
            }
            else
            {
                MessageBox.Show("Entrada no válida.");
                return null;
            }
        }

        private void MostrarResultado(List<int> resultado)
        {
            textResultadoNumeros.Text += Environment.NewLine;
            textResultadoNumeros.Text += ("Se muestra el conjunto de los resultados:");
            textResultadoNumeros.Text += Environment.NewLine;
            textResultadoNumeros.Text += Environment.NewLine;
            textResultadoNumeros.Text += string.Join(", ", resultado);
        }

        private List<int> EncontrarNumerosDivisibles(List<int> numeros, int divisor)
        {
            return numeros.Where(n => n % divisor == 0).ToList();
        }

        private List<int> EncontrarInterseccion(List<int> conjunto1, List<int> conjunto2)
        {
            return conjunto1.Intersect(conjunto2).ToList();
        }

        private List<int> EncontrarDiferencia(List<int> conjunto1, List<int> conjunto2)
        {
            return conjunto1.Except(conjunto2).ToList();
        }

        private List<int> OrdenarNumeros(List<int> numeros, bool ascending)
        {
            return ascending ? numeros.OrderBy(n => n).ToList() : numeros.OrderByDescending(n => n).ToList();
        }

        private List<int> EncontrarDuplicados(List<int> numeros)
        {
            return numeros.GroupBy(n => n).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
        }

        private List<int> EncontrarNoDuplicados(List<int> numeros)
        {
            return numeros.GroupBy(n => n).Where(g => g.Count() == 1).Select(g => g.Key).ToList();
        }
    }
}