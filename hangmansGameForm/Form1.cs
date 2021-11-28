using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace hangmansGameForm
{
    public partial class frmPrincipal : Form {
        // |===== DECLARACIÓN DE ARREGLOS. =====|
        /* Este arreglo de tipo "char" almacenará las letras adivinadas por el usuario. */
        char[] palabrasAdivinadas;
        /* Este arreglo de tipo "char" almacenará la palabra seleccionada por el programa que tendrá que adivinar el usuario. */
        char[] palabraSeleccionada;
        /* Este arreglo de tipo "char" almacenará el todas las letras del alfabeto. */
        char[] alfabeto;
        /* Este arreglo de tipo "String" almacenará las palabras que se utilizarán en el juego. */
        String[] Palabras;

        // |=== DECLARACIÓN DE VARIABLES. ===|
        int oportunidades; // Contador de oportunidades.

        public frmPrincipal() {
            InitializeComponent();
        }

        // |===== DECLARACIÓN DE PROCEDIMIENTOS =====|
        // Procedimiento #1: "iniciarJuego".
        /* Procedimiento con todas las instrucciones necesarias para comenzar un nuevo juego */
        public void iniciarJuego() {
            /* 
             * Se reinician los elementos y controles que se encuentren dentro del panel de nombre
             * "pnlTeclado". Este panel es el que contendrá las teclas con las letras del alfabeto.
             */
            pnlTeclado.Controls.Clear();
            /* El panel que mostrará la palabra a adivinar se habilitará. */
            pnlPalabra.Enabled = true;
            /* El panel donde se irá dibujando el personaje del ahorcado se habilitará. */
            pnlAhorcado.Enabled = true;
            /* El label que almacena el mensaje correspondiente a los resultados del juego no será visible. */
            lblMensaje.Visible = false;
            /* El contador del número de oportunidades se inicializará en 0. */
            oportunidades = 0;
            /* En el arreglo de nombre "Palabras" se le insertarán las palabras que deseamos que aparezcan en el juego. */
            Palabras = new string[] { "Flores", "Caballo", "Pelota", "Disco", "Computadora", "Celular", "Florero", "Perro" };

            /* Al arreglo de nombre "alfabeto" se le asignan las letras del alfabeto español.
             * Cada letra se devolverá como un caracter. */
            alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();

            Random random = new Random(); // Se declará una variable de tipo "Random".
            /* Se declara una variable de tipo "int" que tendrá el nombre "indicePalabraSelec". Ésta
             * se encargará de seleccionar de manera aleatoria una palabra del arreglo "Palabras". */
            int indicePalabraSelec = random.Next(0, Palabras.Length);
            /* Al arreglo de nombre "palabraSeleccionada" se le asignarán los caracteres de la palabra
             * que fue seleccionada de manera aleatoria, con todas sus letras en mayúsculas. */
            palabraSeleccionada = Palabras[indicePalabraSelec].ToUpper().ToCharArray();
            /* Al arreglo de nombre "palabrasAdivinadas" se le asigna lo que se encuentra en el 
             * arreglo "palabraSeleccionada". */
            palabrasAdivinadas = palabraSeleccionada;

            /* Ciclo "foreach" que se encargará de crear las teclas con cada letra del alfabeto 
             * que se encuentre en el arreglo de nombre "alfabeto". */
            foreach (char letraAlfabeto in alfabeto) {
                /* Propiedades para los botones que se crearán. */
                // Creación del botón que se le asigna por nombre "btnLetra".
                Button btnLetra = new Button();
                // .Tag: propiedad que permitirá almacenar una letra del alfabeto.
                btnLetra.Tag = "";
                // .Text: propiedad que desplegará las letras del alfabeto en un botón.
                btnLetra.Text = letraAlfabeto.ToString();
                // .Width (Ancho): 60 pixeles, .Height (Largo): 40 pixeles.
                btnLetra.Width = 60; btnLetra.Height = 40;
                /* .Click: Al momento de dar click a los botones, se ejecutará el procedimiento de 
                 * nombre "Compara". */
                btnLetra.Click += Compara;
                /* .ForeColor: Propiedad que asigna un color a la tipogrfía de los botones, en este caso, 
                 * será de color negro. */
                btnLetra.ForeColor = Color.Black;
                /* .Font: propiedad que asigna una tipografía a los botones, en este caso, será de tipo
                 * "Bold". */
                btnLetra.Font = new Font(btnLetra.Font.Name, 15, FontStyle.Bold);
                /* .BackgroundImageLayout: Esta propiedad define la alineación de los elementos que se 
                 * se encuentran dentro de los botones, en este caso, se alinearán al centro. */
                btnLetra.BackgroundImageLayout = ImageLayout.Center;
                /* .BackColor: Propiedad que asigna un color de relleno para los botones. */
                btnLetra.BackColor = Color.Azure;
                /* .Name: Asigna un nombre al objeto, al cual se le asignará una letra del alfabeto,
                 * las cuales se encuentran en el arreglo de nombre "letraAlfabeto". */
                btnLetra.Name = letraAlfabeto.ToString();
                /* .Controls: esta propiedad sirve para agregar elementos. En este caso, al panel de
                 * nombre "pnlTeclado" se le agregarán los botones de nombre "btnLetra" con las propiedades
                 * asignadas anteriormente por cada letra del alfabeto. */
                pnlTeclado.Controls.Add(btnLetra);
            }

            // Limpieza del panel donde se ubicará la palabra a adivinar.
            pnlPalabra.Controls.Clear();

            /* Este ciclo es el encragado de agregar un textbox por cada letra de la palabra que se va
             * a adivinar en el juego. */
            for (int indiceValorLetra = 0; indiceValorLetra < palabraSeleccionada.Length; indiceValorLetra++) {
                /* Propiedades para las cajas de texto que se crearán. */
                // Declaración de textboxes de nombres "txtLetra".
                TextBox txtLetra = new TextBox();
                /* .Enabled: Propiedad que habilita o deshabilita las cajas de texto, para este caso,
                 * se deshabilitarán, esto para que el usuario pueda ver su contenido y no modifi-
                 * carlo. */
                txtLetra.Enabled = false;
                /* .Tag: propiedad que permitirá asignar una letra de la palabra aleatoria del arreglo
                 * de nombre "palabraSeleccionada". */
                txtLetra.Tag = palabraSeleccionada[indiceValorLetra].ToString();
                /* .Text: es la propiedad que le asginará un texto inicial a las cajas de texto. */
                txtLetra.Text = "";
                // .Width (Ancho): 46 pixeles, .Height (Largo): 80 pixeles.
                txtLetra.Width = 46; txtLetra.Height = 80;
                /* .ForeColor: Propiedad que asigna un color a la tipogrfía de los botones, en este caso, 
                 * será de color negro. */
                txtLetra.ForeColor = Color.Black;
                /* .Font: propiedad que asigna una tipografía a los botones, en este caso, será de tipo
                 * "Bold". */
                txtLetra.Font = new Font(txtLetra.Font.Name, 32, FontStyle.Bold);
                /* .BackgroundImageLayout: Esta propiedad define la alineación de los elementos que se 
                 * se encuentran dentro de las cajas de texto, en este caso, se alinearán al centro. */
                txtLetra.BackgroundImageLayout = ImageLayout.Center;
                /* .TextAlign: Propiedad que asigna la alineación del texto dentro de las cajas
                   de texto. En este caso, las letras se alinearán al centro. */
                txtLetra.TextAlign = HorizontalAlignment.Center;
                /* .BackColor: Propiedad que asigna un color de relleno para las cajas de texto. */
                txtLetra.BackColor = Color.LightCyan;
                /* .BorderStyle: Se define el tipo de borde para las cajas de texto. */
                txtLetra.BorderStyle = BorderStyle.FixedSingle;
                /* .Name: Asigna un nombre al objeto, al cual se le asignará una letra del alfabeto,
                 * las cuales se encuentran en el arreglo de nombre "letraAlfabeto". */
                txtLetra.Name = "Adivinado" + indiceValorLetra.ToString();
                /* .Controls: esta propiedad sirve para agregar elementos. En este caso, al panel de
                 * nombre "pnlPalabra" se le agregarán las cajas de texto de nombre "txtLetra" con las propiedades
                 * asignadas anteriormente. */
                pnlPalabra.Controls.Add(txtLetra);
            }
        }

        // Procedimiento #2: "Compara".
        /* Procedimiento que contiene todas las condiciones al momento de adivinar o equivocarte con
         * una letra de la palabra que se debe adivinar. */
        void Compara(object sender, EventArgs e) {
            /* Se crea un objeto de nombre "g" de la clase "Graphics", al cual se le asignará
             * el panel de nombre "pnlAhorcado" que llamará al método "CreateGraphics()", que
             * permite realizar dibujos', gráficos o figuras dentro de dicho panel. */
            Graphics g = pnlAhorcado.CreateGraphics();
            /* Declaración de un objeto de la clase "Pluma" con las siguientes propiedades:
             * - Color: Negro.
             * - Grosor: 10 pixeles. */
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 10);

            /* Estas propiedades se le asignarán a los botones que ya fueron presionados o seleccionados. */
            // Se crea un objeto de nombre "btnEncontrado" de la clase "Button".
            Button btnEncontrado = (Button)sender;
            /* .BackColor: Propiedad que asigna un color de relleno para los botones. */
            btnEncontrado.BackColor = Color.White;
            /* .ForeColor: Propiedad que asigna un color a la tipogrfía de los botones, en este caso, 
             * será de color negro. */
            btnEncontrado.ForeColor = Color.Black;
            /* .Enabled: Propiedad que habilita o deshabilita los botones, para este caso,
             * se deshabilitarán, esto para que el usuario no vuelva a presionar un botón con
             * alguna letra repetida, es decir, que ya haya seleccionado. */
            btnEncontrado.Enabled = false;
            /* Se declara una variable de tipo "booleana" que servirá como bandera, declarada 
             * inicialmente con el valor de "false". */
            bool encontrado = false;

            /* Compara la letra seleccionada con las letras de la palabra almacenada en el arreglo
             * de nombre "palabrasAdivinadas". */
            for (int indiceRevisar = 0; indiceRevisar < palabrasAdivinadas.Length; indiceRevisar++)
                /* Si la letra que se encuentra dentro del arreglo de nombre "palabrasAdivinadas" es
                 * igual a la letra que se presionó en el teclado con el alfabeto, entonces... */
                if (palabrasAdivinadas[indiceRevisar] == Char.Parse(btnEncontrado.Text)) {
                    // Si existe la letra, actualiza la palabra agregando el valor correspondiente.
                    TextBox txtLetraAd = this.Controls.Find("Adivinado" + indiceRevisar, true).FirstOrDefault() as TextBox;
                    // En el textbox se mostrará la letra que se adivinó.
                    txtLetraAd.Text = palabrasAdivinadas[indiceRevisar].ToString();
                    /* La letra adivinada se etiquetará con el caracter "-" dentro del arreglo. 
                     * de nombre "palabrasAdivindas. "*/
                    palabrasAdivinadas[indiceRevisar] = '-';
                    // La bandera "encontrado" se actualiza a true.
                    encontrado = true;
                }

            /* Bandera que verifica si todas las letras de la palabra se han adivinado. Se declara
             * una variable de tipo booleana con un valor inicial "true". */
            bool Ganaste = true;
            /* Compara el indice de la letra correcta con las letras de la palabra almacenada en el 
             * arreglo de nombre "palabrasAdivinadas". */
            for (int indiceAnalizadorG = 0; indiceAnalizadorG < palabrasAdivinadas.Length; indiceAnalizadorG++) {
                /* Si el usuario tiene letras pendientes por adivinar, se cambia el estado de la
                 * bandera por "false". */
                if (palabrasAdivinadas[indiceAnalizadorG] != '-') Ganaste = false;
            }

            // Si la bandera de nombre "Ganaste" es "true", quiere decir que el usuario ganó la partida.
            if (Ganaste) {
                // La etiqueta que se encuentra en el juego podrá ser vista por el usuario.
                lblMensaje.Visible = true;
                // El texto de la etiqueta desplegará el mensaje ganador.
                lblMensaje.Text = "¡Ganaste! :D";
                // El color de la letra para el mensaje ganador será de color verde.
                lblMensaje.ForeColor = Color.Green;
            }

            /* Si la bandera "encontrado" es diferente de "true", quiere decir que el usuario ha fallado
             * y no seleccionó alguna letra correspondiente a la palabra. */
            if (!encontrado) {
                /* El contador de nombre "oportunidades" irá aumentando un valor en cada intento. Es 
                 * importante mencionar que, el usuario solo contará con 6 oportunidades para adivinar
                 * la palabra. */
                oportunidades = oportunidades + 1;
                /*|===== Condiciones para dibujar al personaje =====| */
                /* Para graficar las figuras correspondientes, se tomó en cuenta un panel de 226x318
                 * pixeles. */

                /* Si el usuario falla en el primer intento, entonces se dibujará la cabeza. Con la 
                   función "DrawArc" se dibujará un circulo mediante un arco, proporcionando los
                   siguientes parámetros:
                   - pen: Propiedades de la pluma con la que se dibujará dicho circulo. Este se declaró
                   más arriba. 
                   - Rectangle: Se tuvo que asignar un área de dibujo en la posición (50, 50) con un
                                tamaño de 70x70 pixeles.
                   - Ángulo con el que comienza a dibujarse el círculo. En este caso, será de 50°
                   - Cuantos grados recorrerá el arco, en este caso, para que se genere un círculo,
                   - tendrá que recorrer 360°. */
                if (oportunidades == 1) g.DrawArc(pen, new Rectangle(5, 5, 70, 70), 50, 360);
                /* Si el usuario falla en el segundo intento, entonces se dibujará el cuerpo. Con la
                   función "DrawLine" se dibujará una línea que tendrá los siguientes parámetros:
                   - pen: Propiedades de la pluma con la que se dibujará.
                   - Primer punto (donde comenzará la línea): p1 (40, 75) pixeles. 
                   - Segundo punto (donde terminará la línea): p2 (70, 70) pixeles. */
                if (oportunidades == 2) g.DrawLine(pen, 40, 75, 40, 200);
                /* Si el usuario falla en el tercer intento, entonces se dibujará el primer brazo. Con la
                   función "DrawLine" se dibujará una línea que tendrá los siguientes parámetros:
                   - pen: Propiedades de la pluma con la que se dibujará.
                   - Primer punto (donde comenzará la línea): p1 (40, 100) pixeles. 
                   - Segundo punto (donde terminará la línea): p2 (10, 120) pixeles. */
                if (oportunidades == 3) g.DrawLine(pen, 40, 100, 10, 120);
                /* Si el usuario falla en el cuerto intento, entonces se dibujará el segundo brazo. Con la
                   función "DrawLine" se dibujará una línea que tendrá los siguientes parámetros:
                   - pen: Propiedades de la pluma con la que se dibujará.
                   - Primer punto (donde comenzará la línea): p1 (80, 120) pixeles. 
                   - Segundo punto (donde terminará la línea): p2 (40, 100) pixeles. */
                if (oportunidades == 4) g.DrawLine(pen, 80, 120, 40, 100);
                /* Si el usuario falla en el quinto intento, entonces se dibujará la primera pierna. Con la
                   función "DrawLine" se dibujará una línea que tendrá los siguientes parámetros:
                   - pen: Propiedades de la pluma con la que se dibujará.
                   - Primer punto (donde comenzará la línea): p1 (40, 200) pixeles. 
                   - Segundo punto (donde terminará la línea): p2 (90, 230) pixeles. */
                if (oportunidades == 5) g.DrawLine(pen, 40, 200, 90, 230);
                /* Si el usuario falla en el sexto intento, entonces.... */
                if (oportunidades == 6) {
                    /* Se dibujará la segunda pierna. Con la función "DrawLine" se dibujará una línea que tendrá
                     los siguientes parámetros:
                    - pen: Propiedades de la pluma con la que se dibujará.
                   - Primer punto (donde comenzará la línea): p1 (40, 200) pixeles. 
                   - Segundo punto (donde terminará la línea): p2 (5, 230) pixeles. */
                    g.DrawLine(pen, 40, 200, 5, 230);
                    /* La etiqueta con el mensaje perdedor podrá ser visualizada. */
                    lblMensaje.Visible = true;

                    /* Este ciclo se encarga de revisar todas las letras que corresponden a la palabra que se
                     * tenía que adivinar. */
                    for (int indiceValLetra = 0; indiceValLetra < palabraSeleccionada.Length; indiceValLetra++){
                        /* A las cajas de texto se les asignarán las letras correspondoentes a la palabra a adivinar. */
                        TextBox txtLetra = this.Controls.Find("Adivinado" + indiceValLetra, true).FirstOrDefault() as TextBox;
                        /* Conversión de las letras a tipo string. */
                        txtLetra.Text = txtLetra.Tag.ToString();
                    }

                    pnlPalabra.Enabled = false;
                }
            }
        }
    
                                        // |===== EVENTOS =====|
        // |----- Evento #1: Load -----|
        /* Este evento es el encargado de iniciar el programa o formulario. */
        private void frmPrincipal_Load(object sender, EventArgs e){
            iniciarJuego(); // Llamada al método de nombre "iniciarJuego()".
        }

        // |----- Evento #2: Click -----|
        /* Este evento se activa al momento que se presiona un botón. */
        private void btnNuevoJuego_Click(object sender, EventArgs e){
            pnlAhorcado.Invalidate(); // Reinicio o limpieza del panel de nombre "pnlAhorcado".
            iniciarJuego(); // Llamada al método de nombre "iniciarJuego()".
        }

        private void btnSalir_Click(object sender, EventArgs e){
            Close(); // Procedimiento encargado de cerrar el programa.
        }
    }
}
