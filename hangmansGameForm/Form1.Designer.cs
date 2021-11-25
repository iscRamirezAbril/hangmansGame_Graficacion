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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "El juego del ahorcado";
            // 
            // btnNuevoJuego
            // 
            this.btnNuevoJuego.BackColor = System.Drawing.Color.LightBlue;
            this.btnNuevoJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoJuego.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoJuego.Location = new System.Drawing.Point(225, 560);
            this.btnNuevoJuego.Name = "btnNuevoJuego";
            this.btnNuevoJuego.Size = new System.Drawing.Size(242, 37);
            this.btnNuevoJuego.TabIndex = 2;
            this.btnNuevoJuego.Text = "Nuevo juego";
            this.btnNuevoJuego.UseVisualStyleBackColor = false;
            this.btnNuevoJuego.Click += new System.EventHandler(this.btnNuevoJuego_Click);
            // 
            // pnlTeclado
            // 
            this.pnlTeclado.Location = new System.Drawing.Point(57, 132);
            this.pnlTeclado.Name = "pnlTeclado";
            this.pnlTeclado.Size = new System.Drawing.Size(393, 273);
            this.pnlTeclado.TabIndex = 3;
            // 
            // pnlAhorcado
            // 
            this.pnlAhorcado.Location = new System.Drawing.Point(489, 108);
            this.pnlAhorcado.Name = "pnlAhorcado";
            this.pnlAhorcado.Size = new System.Drawing.Size(226, 318);
            this.pnlAhorcado.TabIndex = 4;
            this.pnlAhorcado.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAhorcado_Paint);
            // 
            // pnlPalabra
            // 
            this.pnlPalabra.Location = new System.Drawing.Point(55, 478);
            this.pnlPalabra.Name = "pnlPalabra";
            this.pnlPalabra.Size = new System.Drawing.Size(599, 64);
            this.pnlPalabra.TabIndex = 5;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(271, 63);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(179, 38);
            this.lblMensaje.TabIndex = 6;
            this.lblMensaje.Text = "¡Perdiste! D:";
            // 
            // lblAdivina
            // 
            this.lblAdivina.AutoSize = true;
            this.lblAdivina.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdivina.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblAdivina.Location = new System.Drawing.Point(218, 440);
            this.lblAdivina.Name = "lblAdivina";
            this.lblAdivina.Size = new System.Drawing.Size(273, 35);
            this.lblAdivina.TabIndex = 7;
            this.lblAdivina.Text = "¡Adivina la palabra! :D";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(727, 609);
            this.ControlBox = false;
            this.Controls.Add(this.lblAdivina);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.pnlPalabra);
            this.Controls.Add(this.pnlAhorcado);
            this.Controls.Add(this.pnlTeclado);
            this.Controls.Add(this.btnNuevoJuego);
            this.Controls.Add(this.label1);
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
    }
}

