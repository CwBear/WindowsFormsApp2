namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresoPedido = new System.Windows.Forms.Button();
            this.lbltipopizza = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.cmbTipoPizza = new System.Windows.Forms.ComboBox();
            this.nombrecliente = new System.Windows.Forms.Label();
            this.lblPrueba = new System.Windows.Forms.Label();
            this._tipopizza = new System.Windows.Forms.Label();
            this.tamanopizza = new System.Windows.Forms.Label();
            this.tipobebida = new System.Windows.Forms.Label();
            this.cmbTamanoPizza = new System.Windows.Forms.ComboBox();
            this.cmbTipoBebida = new System.Windows.Forms.ComboBox();
            this._tamanopizza = new System.Windows.Forms.Label();
            this._tipobebida = new System.Windows.Forms.Label();
            this.lblTamanoPizza = new System.Windows.Forms.Label();
            this.lblTipoBebida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresoPedido
            // 
            this.btnIngresoPedido.Location = new System.Drawing.Point(533, 121);
            this.btnIngresoPedido.Name = "btnIngresoPedido";
            this.btnIngresoPedido.Size = new System.Drawing.Size(118, 56);
            this.btnIngresoPedido.TabIndex = 0;
            this.btnIngresoPedido.Text = "Ingresar Pedido";
            this.btnIngresoPedido.UseVisualStyleBackColor = true;
            this.btnIngresoPedido.Click += new System.EventHandler(this.btnIngresoPedido_Click);
            // 
            // lbltipopizza
            // 
            this.lbltipopizza.AutoSize = true;
            this.lbltipopizza.Location = new System.Drawing.Point(91, 63);
            this.lbltipopizza.Name = "lbltipopizza";
            this.lbltipopizza.Size = new System.Drawing.Size(56, 13);
            this.lbltipopizza.TabIndex = 1;
            this.lbltipopizza.Text = "Tipo Pizza";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(198, 24);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(173, 20);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // cmbTipoPizza
            // 
            this.cmbTipoPizza.FormattingEnabled = true;
            this.cmbTipoPizza.Items.AddRange(new object[] {
            "NAPOLITANA",
            "ESPANOLA",
            "HAWAIANA"});
            this.cmbTipoPizza.Location = new System.Drawing.Point(177, 63);
            this.cmbTipoPizza.Name = "cmbTipoPizza";
            this.cmbTipoPizza.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPizza.TabIndex = 3;
            this.cmbTipoPizza.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPizza_SelectedIndexChanged);
            // 
            // nombrecliente
            // 
            this.nombrecliente.AutoSize = true;
            this.nombrecliente.Location = new System.Drawing.Point(94, 27);
            this.nombrecliente.Name = "nombrecliente";
            this.nombrecliente.Size = new System.Drawing.Size(79, 13);
            this.nombrecliente.TabIndex = 4;
            this.nombrecliente.Text = "Nombre Cliente";
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.Location = new System.Drawing.Point(290, 212);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(35, 13);
            this.lblPrueba.TabIndex = 5;
            this.lblPrueba.Text = "label1";
            this.lblPrueba.Click += new System.EventHandler(this.lblPrueba_Click);
            // 
            // _tipopizza
            // 
            this._tipopizza.AutoSize = true;
            this._tipopizza.Location = new System.Drawing.Point(113, 212);
            this._tipopizza.Name = "_tipopizza";
            this._tipopizza.Size = new System.Drawing.Size(132, 13);
            this._tipopizza.TabIndex = 6;
            this._tipopizza.Text = "El tipo de pizza elegida es:";
            // 
            // tamanopizza
            // 
            this.tamanopizza.AutoSize = true;
            this.tamanopizza.Location = new System.Drawing.Point(94, 106);
            this.tamanopizza.Name = "tamanopizza";
            this.tamanopizza.Size = new System.Drawing.Size(73, 13);
            this.tamanopizza.TabIndex = 7;
            this.tamanopizza.Text = "Tamano pizza";
            // 
            // tipobebida
            // 
            this.tipobebida.AutoSize = true;
            this.tipobebida.Location = new System.Drawing.Point(94, 141);
            this.tipobebida.Name = "tipobebida";
            this.tipobebida.Size = new System.Drawing.Size(64, 13);
            this.tipobebida.TabIndex = 8;
            this.tipobebida.Text = "Tipo Bebida";
            // 
            // cmbTamanoPizza
            // 
            this.cmbTamanoPizza.FormattingEnabled = true;
            this.cmbTamanoPizza.Items.AddRange(new object[] {
            "PERSONAL",
            "MEDIANA",
            "FAMILIAR",
            "XXL"});
            this.cmbTamanoPizza.Location = new System.Drawing.Point(177, 97);
            this.cmbTamanoPizza.Name = "cmbTamanoPizza";
            this.cmbTamanoPizza.Size = new System.Drawing.Size(121, 21);
            this.cmbTamanoPizza.TabIndex = 10;
            this.cmbTamanoPizza.SelectedIndexChanged += new System.EventHandler(this.cmbTamanoPizza_SelectedIndexChanged);
            // 
            // cmbTipoBebida
            // 
            this.cmbTipoBebida.FormattingEnabled = true;
            this.cmbTipoBebida.Items.AddRange(new object[] {
            "COCA COLA",
            "FANTA",
            "SPRITE"});
            this.cmbTipoBebida.Location = new System.Drawing.Point(177, 132);
            this.cmbTipoBebida.Name = "cmbTipoBebida";
            this.cmbTipoBebida.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoBebida.TabIndex = 11;
            this.cmbTipoBebida.SelectedIndexChanged += new System.EventHandler(this.cmbTipoBebida_SelectedIndexChanged);
            // 
            // _tamanopizza
            // 
            this._tamanopizza.AutoSize = true;
            this._tamanopizza.Location = new System.Drawing.Point(116, 246);
            this._tamanopizza.Name = "_tamanopizza";
            this._tamanopizza.Size = new System.Drawing.Size(74, 13);
            this._tamanopizza.TabIndex = 12;
            this._tamanopizza.Text = "Tamano Pizza";
            // 
            // _tipobebida
            // 
            this._tipobebida.AutoSize = true;
            this._tipobebida.Location = new System.Drawing.Point(116, 275);
            this._tipobebida.Name = "_tipobebida";
            this._tipobebida.Size = new System.Drawing.Size(64, 13);
            this._tipobebida.TabIndex = 13;
            this._tipobebida.Text = "Tipo Bebida";
            // 
            // lblTamanoPizza
            // 
            this.lblTamanoPizza.AutoSize = true;
            this.lblTamanoPizza.Location = new System.Drawing.Point(290, 243);
            this.lblTamanoPizza.Name = "lblTamanoPizza";
            this.lblTamanoPizza.Size = new System.Drawing.Size(35, 13);
            this.lblTamanoPizza.TabIndex = 14;
            this.lblTamanoPizza.Text = "label3";
            this.lblTamanoPizza.Click += new System.EventHandler(this.lblTamanoPizza_Click);
            // 
            // lblTipoBebida
            // 
            this.lblTipoBebida.AutoSize = true;
            this.lblTipoBebida.Location = new System.Drawing.Point(290, 275);
            this.lblTipoBebida.Name = "lblTipoBebida";
            this.lblTipoBebida.Size = new System.Drawing.Size(35, 13);
            this.lblTipoBebida.TabIndex = 15;
            this.lblTipoBebida.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTipoBebida);
            this.Controls.Add(this.lblTamanoPizza);
            this.Controls.Add(this._tipobebida);
            this.Controls.Add(this._tamanopizza);
            this.Controls.Add(this.cmbTipoBebida);
            this.Controls.Add(this.cmbTamanoPizza);
            this.Controls.Add(this.tipobebida);
            this.Controls.Add(this.tamanopizza);
            this.Controls.Add(this._tipopizza);
            this.Controls.Add(this.lblPrueba);
            this.Controls.Add(this.nombrecliente);
            this.Controls.Add(this.cmbTipoPizza);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lbltipopizza);
            this.Controls.Add(this.btnIngresoPedido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresoPedido;
        private System.Windows.Forms.Label lbltipopizza;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.ComboBox cmbTipoPizza;
        private System.Windows.Forms.Label nombrecliente;
        private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.Label _tipopizza;
        private System.Windows.Forms.Label tamanopizza;
        private System.Windows.Forms.Label tipobebida;
        private System.Windows.Forms.ComboBox cmbTamanoPizza;
        private System.Windows.Forms.ComboBox cmbTipoBebida;
        private System.Windows.Forms.Label _tamanopizza;
        private System.Windows.Forms.Label _tipobebida;
        private System.Windows.Forms.Label lblTamanoPizza;
        private System.Windows.Forms.Label lblTipoBebida;
    }
}

