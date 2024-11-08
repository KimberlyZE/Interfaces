namespace Interfaz2
{
    partial class Bonificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bonificaciones));
            this.lblCalculo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSueldoBase = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSueldoBase = new System.Windows.Forms.TextBox();
            this.grp = new System.Windows.Forms.GroupBox();
            this.rbtndiez = new System.Windows.Forms.RadioButton();
            this.rbnveinte = new System.Windows.Forms.RadioButton();
            this.rbtntreinta = new System.Windows.Forms.RadioButton();
            this.lblBoni = new System.Windows.Forms.Label();
            this.lblRetencion = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBoni = new System.Windows.Forms.TextBox();
            this.txtReten = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCalculo
            // 
            this.lblCalculo.AutoSize = true;
            this.lblCalculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblCalculo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCalculo.Location = new System.Drawing.Point(12, 21);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(215, 22);
            this.lblCalculo.TabIndex = 0;
            this.lblCalculo.Text = "Calculo de Bonificaciones";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(113, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del empleado:";
            // 
            // lblSueldoBase
            // 
            this.lblSueldoBase.AutoSize = true;
            this.lblSueldoBase.Location = new System.Drawing.Point(16, 125);
            this.lblSueldoBase.Name = "lblSueldoBase";
            this.lblSueldoBase.Size = new System.Drawing.Size(69, 13);
            this.lblSueldoBase.TabIndex = 2;
            this.lblSueldoBase.Text = "Sueldo base:";
            this.lblSueldoBase.Click += new System.EventHandler(this.lblSueldoBase_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(167, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtSueldoBase
            // 
            this.txtSueldoBase.Location = new System.Drawing.Point(167, 122);
            this.txtSueldoBase.Name = "txtSueldoBase";
            this.txtSueldoBase.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoBase.TabIndex = 4;
            this.txtSueldoBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoBase_KeyPress);
            // 
            // grp
            // 
            this.grp.Controls.Add(this.rbtntreinta);
            this.grp.Controls.Add(this.rbnveinte);
            this.grp.Controls.Add(this.rbtndiez);
            this.grp.Location = new System.Drawing.Point(19, 174);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(413, 55);
            this.grp.TabIndex = 5;
            this.grp.TabStop = false;
            this.grp.Text = "Bonificación";
            // 
            // rbtndiez
            // 
            this.rbtndiez.AutoSize = true;
            this.rbtndiez.Location = new System.Drawing.Point(82, 20);
            this.rbtndiez.Name = "rbtndiez";
            this.rbtndiez.Size = new System.Drawing.Size(45, 17);
            this.rbtndiez.TabIndex = 0;
            this.rbtndiez.TabStop = true;
            this.rbtndiez.Text = "10%";
            this.rbtndiez.UseVisualStyleBackColor = true;
            // 
            // rbnveinte
            // 
            this.rbnveinte.AutoSize = true;
            this.rbnveinte.Location = new System.Drawing.Point(174, 20);
            this.rbnveinte.Name = "rbnveinte";
            this.rbnveinte.Size = new System.Drawing.Size(45, 17);
            this.rbnveinte.TabIndex = 1;
            this.rbnveinte.TabStop = true;
            this.rbnveinte.Text = "20%";
            this.rbnveinte.UseVisualStyleBackColor = true;
            // 
            // rbtntreinta
            // 
            this.rbtntreinta.AutoSize = true;
            this.rbtntreinta.Location = new System.Drawing.Point(266, 20);
            this.rbtntreinta.Name = "rbtntreinta";
            this.rbtntreinta.Size = new System.Drawing.Size(45, 17);
            this.rbtntreinta.TabIndex = 2;
            this.rbtntreinta.TabStop = true;
            this.rbtntreinta.Text = "35%";
            this.rbtntreinta.UseVisualStyleBackColor = true;
            // 
            // lblBoni
            // 
            this.lblBoni.AutoSize = true;
            this.lblBoni.Location = new System.Drawing.Point(19, 251);
            this.lblBoni.Name = "lblBoni";
            this.lblBoni.Size = new System.Drawing.Size(68, 13);
            this.lblBoni.TabIndex = 6;
            this.lblBoni.Text = "Bonificación:";
            // 
            // lblRetencion
            // 
            this.lblRetencion.AutoSize = true;
            this.lblRetencion.Location = new System.Drawing.Point(19, 290);
            this.lblRetencion.Name = "lblRetencion";
            this.lblRetencion.Size = new System.Drawing.Size(76, 13);
            this.lblRetencion.TabIndex = 7;
            this.lblRetencion.Text = "Retención 5%:";
            this.lblRetencion.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(19, 359);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(90, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total a recibir:";
            this.lblTotal.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBoni
            // 
            this.txtBoni.Enabled = false;
            this.txtBoni.Location = new System.Drawing.Point(167, 251);
            this.txtBoni.Name = "txtBoni";
            this.txtBoni.Size = new System.Drawing.Size(100, 20);
            this.txtBoni.TabIndex = 9;
            // 
            // txtReten
            // 
            this.txtReten.Enabled = false;
            this.txtReten.Location = new System.Drawing.Point(167, 290);
            this.txtReten.Name = "txtReten";
            this.txtReten.Size = new System.Drawing.Size(100, 20);
            this.txtReten.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(167, 359);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 11;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(330, 251);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(330, 280);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(330, 309);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(303, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Bonificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(444, 397);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtReten);
            this.Controls.Add(this.txtBoni);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRetencion);
            this.Controls.Add(this.lblBoni);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.txtSueldoBase);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSueldoBase);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCalculo);
            this.Name = "Bonificaciones";
            this.Text = "Bonificaciones";
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSueldoBase;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSueldoBase;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.RadioButton rbtntreinta;
        private System.Windows.Forms.RadioButton rbnveinte;
        private System.Windows.Forms.RadioButton rbtndiez;
        private System.Windows.Forms.Label lblBoni;
        private System.Windows.Forms.Label lblRetencion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBoni;
        private System.Windows.Forms.TextBox txtReten;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

