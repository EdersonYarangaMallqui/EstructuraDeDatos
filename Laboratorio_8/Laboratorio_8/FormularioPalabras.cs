using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Laboratorio_8
{
    public partial class FormularioPalabras : Form
    {
        private List<string> palabras;
        private string ejercicio;

        public FormularioPalabras(string textoEjercicio)
        {
            InitializeComponent();
            palabras = new List<string>();
            labelPalabras.Text = textoEjercicio;
            ejercicio = textoEjercicio;
        }

        private void botonAgregarPalabra_Click(object sender, EventArgs e)
        {
            string palabra = textAgregarPalabras.Text.Trim();
            if (!string.IsNullOrEmpty(palabra))
            {
                palabras.Add(palabra);
                textAgregarPalabras.Clear();
                MessageBox.Show("Palabra agregada correctamente.");
                MostrarPalabras();
            }
            else
            {
                MessageBox.Show("Ingrese una palabra válida.");
            }
        }

        private void botonMostrarResultadoPalabras_Click(object sender, EventArgs e)
        {
            List<string> resultado = new List<string>();

            switch (ejercicio.Substring(0, 2))
            {
                case "2.":
                    char letra = Interaction.InputBox("Ingrese la letra inicial:", "Letra Inicial", "A").ToUpper().First();
                    resultado = EncontrarPalabrasConLetra(palabras, letra);
                    break;
                case "7.":
                    resultado = EncontrarAnagramas(palabras);
                    break;
                case "8.":
                    resultado = EncontrarPalindromos(palabras);
                    break;
                case "9.":
                    int longitud = int.Parse(Interaction.InputBox("Ingrese la longitud deseada:", "Longitud", "1"));
                    resultado = EncontrarPalabrasConLongitud(palabras, longitud);
                    break;
                case "10":
                    char letraContiene = Interaction.InputBox("Ingrese la letra que debe contener:", "Letra a Contener", "A").ToUpper().First();
                    resultado = EncontrarPalabrasContienenLetra(palabras, letraContiene);
                    break;
                case "16":
                    resultado = EncontrarPalindromosOrdenados(palabras);
                    break;
                case "17":
                    int longitudOrdenada = int.Parse(Interaction.InputBox("Ingrese la longitud deseada:", "Longitud", "1"));
                    resultado = EncontrarPalabrasConLongitudOrdenadas(palabras, longitudOrdenada);
                    break;
                case "18":
                    char letraOrdenada = Interaction.InputBox("Ingrese la letra que debe contener:", "Letra a Contener", "A").ToUpper().First();
                    resultado = EncontrarPalabrasContienenLetraOrdenadas(palabras, letraOrdenada);
                    break;
                case "20":
                    int longitudPalindromo = int.Parse(Interaction.InputBox("Ingrese la longitud deseada:", "Longitud", "1"));
                    resultado = EncontrarPalindromosLongitudOrdenados(palabras, longitudPalindromo);
                    break;
                default:
                    MessageBox.Show("Ejercicio no reconocido.");
                    return;
            }

            MostrarResultado(resultado);
        }

        private void MostrarPalabras()
        {
            textResultadoPalabras.Text = string.Join(", ", palabras);
        }

        private void MostrarResultado(List<string> resultado)
        {
            textResultadoPalabras.Text += Environment.NewLine;
            textResultadoPalabras.Text += ("Se muestra el conjunto de los resultados:");
            textResultadoPalabras.Text += Environment.NewLine;
            textResultadoPalabras.Text += Environment.NewLine;
            textResultadoPalabras.Text += string.Join(", ", resultado);
        }

        private List<string> EncontrarPalabrasConLetra(List<string> palabras, char letra)
        {
            return palabras.Where(p => p.StartsWith(letra.ToString(), StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        private List<string> EncontrarAnagramas(List<string> palabras)
        {
            var anagramas = new List<string>();
            var grupos = palabras.GroupBy(p => string.Concat(p.OrderBy(c => c)));
            foreach (var grupo in grupos)
            {
                if (grupo.Count() > 1)
                    anagramas.AddRange(grupo);
            }
            return anagramas;
        }

        private List<string> EncontrarPalindromos(List<string> palabras)
        {
            return palabras.Where(p => p.SequenceEqual(p.Reverse())).ToList();
        }

        private List<string> EncontrarPalabrasConLongitud(List<string> palabras, int longitud)
        {
            return palabras.Where(p => p.Length == longitud).ToList();
        }

        private List<string> EncontrarPalabrasContienenLetra(List<string> palabras, char letra)
        {
            return palabras.Where(p => p.IndexOf(letra) != -1).ToList();
        }

        private List<string> EncontrarPalindromosOrdenados(List<string> palabras)
        {
            return palabras.Where(p => p.SequenceEqual(p.Reverse())).OrderBy(p => p).ToList();
        }

        private List<string> EncontrarPalabrasConLongitudOrdenadas(List<string> palabras, int longitud)
        {
            return palabras.Where(p => p.Length == longitud).OrderBy(p => p).ToList();
        }

        private List<string> EncontrarPalabrasContienenLetraOrdenadas(List<string> palabras, char letra)
        {
            return palabras.Where(p => p.IndexOf(letra) != -1).OrderByDescending(p => p).ToList();
        }

        private List<string> EncontrarPalindromosLongitudOrdenados(List<string> palabras, int longitud)
        {
            return palabras.Where(p => p.SequenceEqual(p.Reverse()) && p.Length == longitud).OrderBy(p => p).ToList();
        }
    }
}
