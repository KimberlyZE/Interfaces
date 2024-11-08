namespace Interfaz1
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.grbDescuento = new System.Windows.Forms.GroupBox();
            this.rbquince = new System.Windows.Forms.RadioButton();
            this.rbdiez = new System.Windows.Forms.RadioButton();
            this.rbcinco = new System.Windows.Forms.RadioButton();
            this.rbuno = new System.Windows.Forms.RadioButton();
            this.rbcero = new System.Windows.Forms.RadioButton();
            this.btnguardar = new System.Windows.Forms.Button();
            this.lblSubto = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbDescuento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(128, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(209, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "COMERCIAL \"EL TRIUNFO\"";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(32, 80);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(105, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código del producto:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 119);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(109, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre del producto:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(32, 159);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(32, 201);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(172, 80);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(172, 119);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(172, 159);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 7;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(172, 201);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // grbDescuento
            // 
            this.grbDescuento.Controls.Add(this.rbquince);
            this.grbDescuento.Controls.Add(this.rbdiez);
            this.grbDescuento.Controls.Add(this.rbcinco);
            this.grbDescuento.Controls.Add(this.rbuno);
            this.grbDescuento.Controls.Add(this.rbcero);
            this.grbDescuento.Location = new System.Drawing.Point(312, 72);
            this.grbDescuento.Name = "grbDescuento";
            this.grbDescuento.Size = new System.Drawing.Size(140, 149);
            this.grbDescuento.TabIndex = 9;
            this.grbDescuento.TabStop = false;
            this.grbDescuento.Text = "Descuento";
            this.grbDescuento.Enter += new System.EventHandler(this.grbDescuento_Enter);
            // 
            // rbquince
            // 
            this.rbquince.AutoSize = true;
            this.rbquince.Location = new System.Drawing.Point(16, 121);
            this.rbquince.Name = "rbquince";
            this.rbquince.Size = new System.Drawing.Size(45, 17);
            this.rbquince.TabIndex = 4;
            this.rbquince.TabStop = true;
            this.rbquince.Text = "15%";
            this.rbquince.UseVisualStyleBackColor = true;
            this.rbquince.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rbdiez
            // 
            this.rbdiez.AutoSize = true;
            this.rbdiez.Location = new System.Drawing.Point(16, 98);
            this.rbdiez.Name = "rbdiez";
            this.rbdiez.Size = new System.Drawing.Size(45, 17);
            this.rbdiez.TabIndex = 3;
            this.rbdiez.TabStop = true;
            this.rbdiez.Text = "10%";
            this.rbdiez.UseVisualStyleBackColor = true;
            // 
            // rbcinco
            // 
            this.rbcinco.AutoSize = true;
            this.rbcinco.Location = new System.Drawing.Point(16, 75);
            this.rbcinco.Name = "rbcinco";
            this.rbcinco.Size = new System.Drawing.Size(39, 17);
            this.rbcinco.TabIndex = 2;
            this.rbcinco.TabStop = true;
            this.rbcinco.Text = "5%";
            this.rbcinco.UseVisualStyleBackColor = true;
            // 
            // rbuno
            // 
            this.rbuno.AutoSize = true;
            this.rbuno.Location = new System.Drawing.Point(16, 52);
            this.rbuno.Name = "rbuno";
            this.rbuno.Size = new System.Drawing.Size(39, 17);
            this.rbuno.TabIndex = 1;
            this.rbuno.TabStop = true;
            this.rbuno.Text = "1%";
            this.rbuno.UseVisualStyleBackColor = true;
            // 
            // rbcero
            // 
            this.rbcero.AutoSize = true;
            this.rbcero.Location = new System.Drawing.Point(16, 29);
            this.rbcero.Name = "rbcero";
            this.rbcero.Size = new System.Drawing.Size(39, 17);
            this.rbcero.TabIndex = 0;
            this.rbcero.TabStop = true;
            this.rbcero.Text = "0%";
            this.rbcero.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(35, 249);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 26);
            this.btnguardar.TabIndex = 10;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // lblSubto
            // 
            this.lblSubto.AutoSize = true;
            this.lblSubto.Location = new System.Drawing.Point(35, 314);
            this.lblSubto.Name = "lblSubto";
            this.lblSubto.Size = new System.Drawing.Size(55, 13);
            this.lblSubto.TabIndex = 11;
            this.lblSubto.Text = "Subtotal->";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(35, 352);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(68, 13);
            this.lblDescuento.TabIndex = 12;
            this.lblDescuento.Text = "Descuento->";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(35, 389);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(33, 13);
            this.lblIVA.TabIndex = 13;
            this.lblIVA.Text = "IVA->";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(35, 426);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total->";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(172, 306);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 15;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(172, 352);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 16;
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(172, 389);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(100, 20);
            this.txtIva.TabIndex = 17;
            this.txtIva.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(172, 426);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 18;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(149, 249);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 26);
            this.btncalcular.TabIndex = 19;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(262, 251);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 20;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(363, 251);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 21;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(464, 466);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblSubto);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.grbDescuento);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Factura";
            this.Text = "Factura";
            this.grbDescuento.ResumeLayout(false);
            this.grbDescuento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox grbDescuento;
        private System.Windows.Forms.RadioButton rbquince;
        private System.Windows.Forms.RadioButton rbdiez;
        private System.Windows.Forms.RadioButton rbcinco;
        private System.Windows.Forms.RadioButton rbuno;
        private System.Windows.Forms.RadioButton rbcero;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label lblSubto;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

