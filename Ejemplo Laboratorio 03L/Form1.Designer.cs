namespace Ejemplo_Laboratorio_03L
{
    partial class ejemploFormulario
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
            this.lblSaludo = new System.Windows.Forms.Label();
            this.btnSaludo = new System.Windows.Forms.Button();
            this.lblActualizar = new System.Windows.Forms.Label();
            this.cbMaterias = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSaludo.Location = new System.Drawing.Point(13, 56);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(0, 13);
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.TextChanged += new System.EventHandler(this.lblSaludo_TextChanged);
            // 
            // btnSaludo
            // 
            this.btnSaludo.Location = new System.Drawing.Point(336, 46);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(75, 23);
            this.btnSaludo.TabIndex = 1;
            this.btnSaludo.Text = "Saludo";
            this.btnSaludo.UseVisualStyleBackColor = true;
            this.btnSaludo.Click += new System.EventHandler(this.btnSaludo_Click);
            // 
            // lblActualizar
            // 
            this.lblActualizar.AutoSize = true;
            this.lblActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblActualizar.Location = new System.Drawing.Point(12, 126);
            this.lblActualizar.Name = "lblActualizar";
            this.lblActualizar.Size = new System.Drawing.Size(0, 20);
            this.lblActualizar.TabIndex = 2;
            // 
            // cbMaterias
            // 
            this.cbMaterias.FormattingEnabled = true;
            this.cbMaterias.Items.AddRange(new object[] {
            "DSP404",
            "DAW404",
            "SES404",
            "SDR404"});
            this.cbMaterias.Location = new System.Drawing.Point(336, 128);
            this.cbMaterias.Name = "cbMaterias";
            this.cbMaterias.Size = new System.Drawing.Size(121, 21);
            this.cbMaterias.TabIndex = 3;
            this.cbMaterias.SelectedIndexChanged += new System.EventHandler(this.cbMaterias_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(51, 175);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(360, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(51, 223);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 5;
            // 
            // ejemploFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(512, 381);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cbMaterias);
            this.Controls.Add(this.lblActualizar);
            this.Controls.Add(this.btnSaludo);
            this.Controls.Add(this.lblSaludo);
            this.Name = "ejemploFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Button btnSaludo;
        private System.Windows.Forms.Label lblActualizar;
        private System.Windows.Forms.ComboBox cbMaterias;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}

