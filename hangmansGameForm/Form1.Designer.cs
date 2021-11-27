namespace hangmansGameForm
{
    partial class frmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoJuego = new System.Windows.Forms.Button();
            this.pnlTeclado = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAhorcado = new System.Windows.Forms.Panel();
            this.pnlPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblAdivina = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(251, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "El juego del ahorcado";
            // 
            // btnNuevoJuego
            // 
            this.btnNuevoJuego.BackColor = System.Drawing.Color.LightBlue;
            this.btnNuevoJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoJuego.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoJuego.Location = new System.Drawing.Point(160, 689);
            this.btnNuevoJuego.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevoJuego.Name = "btnNuevoJuego";
            this.btnNuevoJuego.Size = new System.Drawing.Size(323, 46);
            this.btnNuevoJuego.TabIndex = 2;
            this.btnNuevoJuego.Text = "Nuevo juego";
            this.btnNuevoJuego.UseVisualStyleBackColor = false;
            this.btnNuevoJuego.Click += new System.EventHandler(this.btnNuevoJuego_Click);
            // 
            // pnlTeclado
            // 
            this.pnlTeclado.Location = new System.Drawing.Point(76, 162);
            this.pnlTeclado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTeclado.Name = "pnlTeclado";
            this.pnlTeclado.Size = new System.Drawing.Size(524, 336);
            this.pnlTeclado.TabIndex = 3;
            // 
            // pnlAhorcado
            // 
            this.pnlAhorcado.Location = new System.Drawing.Point(652, 162);
            this.pnlAhorcado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAhorcado.Name = "pnlAhorcado";
            this.pnlAhorcado.Size = new System.Drawing.Size(301, 336);
            this.pnlAhorcado.TabIndex = 4;
            // 
            // pnlPalabra
            // 
            this.pnlPalabra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPalabra.Location = new System.Drawing.Point(73, 588);
            this.pnlPalabra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPalabra.Name = "pnlPalabra";
            this.pnlPalabra.Size = new System.Drawing.Size(799, 79);
            this.pnlPalabra.TabIndex = 5;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(361, 78);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(226, 48);
            this.lblMensaje.TabIndex = 6;
            this.lblMensaje.Text = "¡Perdiste! D:";
            // 
            // lblAdivina
            // 
            this.lblAdivina.AutoSize = true;
            this.lblAdivina.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdivina.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblAdivina.Location = new System.Drawing.Point(68, 529);
            this.lblAdivina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdivina.Name = "lblAdivina";
            this.lblAdivina.Size = new System.Drawing.Size(342, 41);
            this.lblAdivina.TabIndex = 7;
            this.lblAdivina.Text = "¡Adivina la palabra! :D";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(581, 689);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(165, 46);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(969, 750);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblAdivina);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.pnlPalabra);
            this.Controls.Add(this.pnlAhorcado);
            this.Controls.Add(this.pnlTeclado);
            this.Controls.Add(this.btnNuevoJuego);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego del ahorcado";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoJuego;
        private System.Windows.Forms.FlowLayoutPanel pnlTeclado;
        private System.Windows.Forms.Panel pnlAhorcado;
        private System.Windows.Forms.FlowLayoutPanel pnlPalabra;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblAdivina;
        private System.Windows.Forms.Button btnSalir;
    }
}

