namespace Laboratorio_8
{
    public partial class FormEjercicios : Form
    {
        public FormEjercicios()
        {
            InitializeComponent();
        }

        private void botonEjercicio1_Click(object sender, EventArgs e)
        {
            string textoEjercicio1 = "1. Escriba una funci�n que reciba un conjunto de n�meros y devuelva un conjunto con los n�meros primos.";
            FormularioNumeros formularioNumeros = new FormularioNumeros(textoEjercicio1);
            formularioNumeros.ShowDialog();
        }
        private void botonEjercicio2_Click(object sender, EventArgs e)
        {
            string textoEjercicio2 = "2. Escriba una funci�n que reciba un conjunto de palabras y devuelva un conjunto con las palabras que comienzan con una letra determinada.";
            FormularioPalabras formularioPalabras = new FormularioPalabras(textoEjercicio2);
            formularioPalabras.ShowDialog();
        }
        private void botonEjercicio3_Click(object sender, EventArgs e)
        {
            string textoEjercicio3 = "3. Escriba una funci�n que reciba un conjunto de n�meros y devuelva un conjunto con los n�meros que son divisibles por un n�mero determinado.";
            FormularioNumeros formularioNumeros = new FormularioNumeros(textoEjercicio3);
            formularioNumeros.ShowDialog();
        }

        private void botonEjercicio4_Click(object sender, EventArgs e)
        {
            string textoEjercicio4 = "4. Escriba una funci�n que reciba dos conjuntos de n�meros y devuelva un conjunto con los n�meros que est�n en ambos conjuntos.";
            FormularioNumeros formularioNumeros = new FormularioNumeros(textoEjercicio4);
            formularioNumeros.ShowDialog();
        }

        private void botonEjercicio5_Click(object sender, EventArgs e)
        {
            string textoEjercicio5 = "5. Escriba una funci�n que reciba dos conjuntos de n�meros y devuelva un conjunto con los n�meros que est�n en el primer conjunto pero no en el segundo.";
            FormularioNumeros formularioNumeros = new FormularioNumeros(textoEjercicio5);
            formularioNumeros.ShowDialog();
        }

        private void botonEjercicio6_Click(object sender, EventArgs e)
        {
            string textoEjercicio6 = "6. Escriba una funci�n que reciba dos conjuntos de n�meros y devuelva un conjunto con los n�meros que est�n en el segundo conjunto pero no en el primero.";
            FormularioNumeros formularioNumeros = new FormularioNumeros(textoEjercicio6);
            formularioNumeros.ShowDialog();
        }
        private void botonEjercicio7_Click(object sender, EventArgs e)
        {
            string textoEjercicio7 = "7. Escriba una funci�n que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son anagramas.";
            FormularioPalabras formularioPalabras = new FormularioPalabras(textoEjercicio7);
            formularioPalabras.ShowDialog();
        }
        private void botonEjercicio8_Click(object sender, EventArgs e)
        {
            string textoEjercicio8 = "8. Escriba una funci�n que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son pal�ndromos";
            FormularioPalabras formularioPalabras = new FormularioPalabras(textoEjercicio8);
            formularioPalabras.ShowDialog();
        }
        private void botonEjercicio9_Click(object sender, EventArgs e)
        {
            string textoEjercicio9 = "9. Escriba una funci�n que reciba un conjunto de palabras y devuelva un conjunto con las palabras que tienen una longitud determinada. ";
            FormularioPalabras formularioPalabras = new FormularioPalabras(textoEjercicio9);
            formularioPalabras.ShowDialog();
        }
        private void botonEjercicio10_Click(object sender, EventArgs e)
        {
            string textoEjercicio10 = "10. Escriba una funci�n que reciba un conjunto de palabras y devuelva un conjunto con las palabras que contienen una letra determinada.  ";
            FormularioPalabras formularioPalabras = new FormularioPalabras(textoEjercicio10);
            formularioPalabras.ShowDialog();
        }
        private void botonEjercicio11_Click(object sender, EventArgs e)
        {
            string textoEjercicio11 = "11. Escriba una funci�n que reciba un conjunto de n�meros y devuelva un conjunto con los n�meros que est�n ordenados de menor a mayor.";
            FormularioNumeros formularioNumeros = new FormularioNumeros(textoEjercicio11);
            formularioNumeros.ShowDialog();
        }

        private void botonEjercicio12_Click(object sender, EventArgs e)
        {
            string textoEjercicio12 = "12. Escriba una funci�n que reciba un conjunto de n�meros y devuelva un conjunto con los n�meros que est�n ordenados de mayor a menor.";
            FormularioNumeros formularioNumeros = new FormularioNumeros(textoEjercicio12);
            formularioNumeros.ShowDialog();
        }

        private void botonEjercicio13_Click(object sender, EventArgs e)
        {
            string textoEjercicio13 = "13. Escriba una funci�n que reciba un conjunto de n�meros y devuelva un conjunto con los n�meros que est�n duplicados.";
            FormularioNumeros formularioNumeros = new FormularioNumeros(textoEjercicio13);
            formularioNumeros.ShowDialog();
        }

        private void botonEjercicio14_Click(object sender, EventArgs e)
        {
            string textoEjercicio14 = "14. Escriba una funci�n que reciba un conjunto de n�meros y devuelva un conjunto con los n�meros que no est�n duplicados.";
            FormularioNumeros formularioNumeros = new FormularioNumeros(textoEjercicio14);
            formularioNumeros.ShowDialog();
        }

        private void botonEjercicio15_Click(object sender, EventArgs e)
        {
            string textoEjercicio15 = "15. Escriba una funci�n que reciba un conjunto de n�meros y devuelva un conjunto con los n�meros que son primos y est�n ordenados de menor a mayor.";
            FormularioNumeros formularioNumeros = new FormularioNumeros(textoEjercicio15);
            formularioNumeros.ShowDialog();
        }
        private void botonEjercicio16_Click(object sender, EventArgs e)
        {
            string textoEjercicio16 = "16. Escriba una funci�n que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son pal�ndromos y est�n ordenadas de menor a mayor. ";
            FormularioPalabras formularioPalabras = new FormularioPalabras(textoEjercicio16);
            formularioPalabras.ShowDialog();
        }
        private void botonEjercicio17_Click(object sender, EventArgs e)
        {
            string textoEjercicio17 = "17. Escriba una funci�n que reciba un conjunto de palabras y devuelva un conjunto con las palabras que tienen una longitud determinada y est�n ordenadas de menor a mayor. ";
            FormularioPalabras formularioPalabras = new FormularioPalabras(textoEjercicio17);
            formularioPalabras.ShowDialog();
        }
        private void botonEjercicio18_Click(object sender, EventArgs e)
        {
            string textoEjercicio18 = "18.  Escriba una funci�n que reciba un conjunto de palabras y devuelva un conjunto con las palabras que contienen una letra determinada y est�n ordenadas de mayor a menor. ";
            FormularioPalabras formularioPalabras = new FormularioPalabras(textoEjercicio18);
            formularioPalabras.ShowDialog();
        }
        private void botonEjercicio19_Click(object sender, EventArgs e)
        {
            string textoEjercicio19 = "19. Escriba una funci�n que reciba un conjunto de n�meros y devuelva un conjunto con los n�meros que est�n ordenados de menor a mayor y que no est�n duplicados.";
            FormularioNumeros formularioNumeros = new FormularioNumeros(textoEjercicio19);
            formularioNumeros.ShowDialog();
        }
        private void botonEjercicio20_Click(object sender, EventArgs e)
        {
            string textoEjercicio20 = "20. Escriba una funci�n que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son pal�ndromos, tienen una longitud determinada y est�n ordenadas de menor a mayor. ";
            FormularioPalabras formularioPalabras = new FormularioPalabras(textoEjercicio20);
            formularioPalabras.ShowDialog();
        }
        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
