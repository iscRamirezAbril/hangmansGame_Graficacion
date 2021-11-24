using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangmansGameForm
{
    public partial class frmPrincipal : Form
    {
        // Declaración de arreglos para almacenar palabras y caracteres.
        char[] palabrasAdivinadas;
        char[] palabraSeleccionada;
        char[] alfabeto;
        String[] Palabras;

        // Declaración de variables
        int oportunidades; // Contador de oportunidades.

        public frmPrincipal()
        {
            InitializeComponent();
        }

        // |===== DECLARACIÓN DE FUNCIONES Y PROCEDIMIENTOS =====|
        // Procedimiento #1: 
        public void iniciarJuego()
        {
            pnlTeclado.Controls.Clear();
            pnlPalabra.Enabled = true;
            pnlAhorcado.Enabled = true;
            lblMensaje.Visible = false;
            oportunidades = 0;
            Palabras = new string[] { "Flores", "Caballo", "Pelota", "Disco", "Computadora", "Celular", "Florero", "Perro" };
            
            alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();

            // Palabra aleatoria a adivinar.
            Random random = new Random();
            int indicePalabraSelec = random.Next(0, Palabras.Length);
            palabraSeleccionada = Palabras[indicePalabraSelec].ToUpper().ToCharArray();
            palabrasAdivinadas = palabraSeleccionada;

        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
