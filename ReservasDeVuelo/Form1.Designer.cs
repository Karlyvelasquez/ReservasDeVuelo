namespace ReservasDeVuelo
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
            this.lblOrigen = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.grpAsiento = new System.Windows.Forms.GroupBox();
            this.rdoCentro = new System.Windows.Forms.RadioButton();
            this.rdoVentana = new System.Windows.Forms.RadioButton();
            this.rdoPasillo = new System.Windows.Forms.RadioButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblDestino = new System.Windows.Forms.Label();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.grpAsiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(94, 48);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 17;
            this.lblOrigen.Text = "Origen";
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(255, 214);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(143, 43);
            this.btnReservar.TabIndex = 16;
            this.btnReservar.Text = "Reservar ";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click_1);
            // 
            // grpAsiento
            // 
            this.grpAsiento.Controls.Add(this.rdoCentro);
            this.grpAsiento.Controls.Add(this.rdoVentana);
            this.grpAsiento.Controls.Add(this.rdoPasillo);
            this.grpAsiento.Location = new System.Drawing.Point(138, 87);
            this.grpAsiento.Name = "grpAsiento";
            this.grpAsiento.Size = new System.Drawing.Size(123, 89);
            this.grpAsiento.TabIndex = 15;
            this.grpAsiento.TabStop = false;
            this.grpAsiento.Text = "Lugar de asiento";
            // 
            // rdoCentro
            // 
            this.rdoCentro.AutoSize = true;
            this.rdoCentro.Location = new System.Drawing.Point(6, 39);
            this.rdoCentro.Name = "rdoCentro";
            this.rdoCentro.Size = new System.Drawing.Size(56, 17);
            this.rdoCentro.TabIndex = 2;
            this.rdoCentro.TabStop = true;
            this.rdoCentro.Text = "Centro";
            this.rdoCentro.UseVisualStyleBackColor = true;
            // 
            // rdoVentana
            // 
            this.rdoVentana.AutoSize = true;
            this.rdoVentana.Location = new System.Drawing.Point(6, 66);
            this.rdoVentana.Name = "rdoVentana";
            this.rdoVentana.Size = new System.Drawing.Size(65, 17);
            this.rdoVentana.TabIndex = 1;
            this.rdoVentana.TabStop = true;
            this.rdoVentana.Text = "Ventana";
            this.rdoVentana.UseVisualStyleBackColor = true;
            // 
            // rdoPasillo
            // 
            this.rdoPasillo.AutoSize = true;
            this.rdoPasillo.Location = new System.Drawing.Point(6, 16);
            this.rdoPasillo.Name = "rdoPasillo";
            this.rdoPasillo.Size = new System.Drawing.Size(55, 17);
            this.rdoPasillo.TabIndex = 0;
            this.rdoPasillo.TabStop = true;
            this.rdoPasillo.Text = "Pasillo";
            this.rdoPasillo.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(359, 105);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(67, 13);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha salida";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(432, 105);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(154, 20);
            this.dtpFecha.TabIndex = 13;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(383, 48);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 12;
            this.lblDestino.Text = "Destino";
            // 
            // cboDestino
            // 
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Location = new System.Drawing.Point(424, 45);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(128, 21);
            this.cboDestino.TabIndex = 11;
            // 
            // cboOrigen
            // 
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Location = new System.Drawing.Point(138, 45);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(127, 21);
            this.cboOrigen.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 293);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.grpAsiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.cboDestino);
            this.Controls.Add(this.cboOrigen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpAsiento.ResumeLayout(false);
            this.grpAsiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.GroupBox grpAsiento;
        private System.Windows.Forms.RadioButton rdoCentro;
        private System.Windows.Forms.RadioButton rdoVentana;
        private System.Windows.Forms.RadioButton rdoPasillo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.ComboBox cboOrigen;
    }
}

