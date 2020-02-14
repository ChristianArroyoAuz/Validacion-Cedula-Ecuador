namespace Validacion_Cedula
{
    partial class Validacion_Cedula
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonNuevo = new System.Windows.Forms.Button();
            this.botonValidar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.etiquetaId = new System.Windows.Forms.Label();
            this.etiquetaNombre = new System.Windows.Forms.Label();
            this.etiquetaCedula = new System.Windows.Forms.Label();
            this.Idtxt = new System.Windows.Forms.Label();
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.Cedulatxt = new System.Windows.Forms.TextBox();
            this.lista_de_Cedulas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(15, 94);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(75, 23);
            this.botonNuevo.TabIndex = 0;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonValidar
            // 
            this.botonValidar.Location = new System.Drawing.Point(96, 94);
            this.botonValidar.Name = "botonValidar";
            this.botonValidar.Size = new System.Drawing.Size(75, 23);
            this.botonValidar.TabIndex = 1;
            this.botonValidar.Text = "Validar";
            this.botonValidar.UseVisualStyleBackColor = true;
            this.botonValidar.Click += new System.EventHandler(this.botonValidar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(177, 94);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 2;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // etiquetaId
            // 
            this.etiquetaId.AutoSize = true;
            this.etiquetaId.Location = new System.Drawing.Point(12, 9);
            this.etiquetaId.Name = "etiquetaId";
            this.etiquetaId.Size = new System.Drawing.Size(19, 13);
            this.etiquetaId.TabIndex = 3;
            this.etiquetaId.Text = "Id:";
            // 
            // etiquetaNombre
            // 
            this.etiquetaNombre.AutoSize = true;
            this.etiquetaNombre.Location = new System.Drawing.Point(12, 36);
            this.etiquetaNombre.Name = "etiquetaNombre";
            this.etiquetaNombre.Size = new System.Drawing.Size(47, 13);
            this.etiquetaNombre.TabIndex = 4;
            this.etiquetaNombre.Text = "Nombre:";
            // 
            // etiquetaCedula
            // 
            this.etiquetaCedula.AutoSize = true;
            this.etiquetaCedula.Location = new System.Drawing.Point(12, 68);
            this.etiquetaCedula.Name = "etiquetaCedula";
            this.etiquetaCedula.Size = new System.Drawing.Size(43, 13);
            this.etiquetaCedula.TabIndex = 5;
            this.etiquetaCedula.Text = "Cedula:";
            // 
            // Idtxt
            // 
            this.Idtxt.AutoSize = true;
            this.Idtxt.Location = new System.Drawing.Point(70, 9);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(13, 13);
            this.Idtxt.TabIndex = 6;
            this.Idtxt.Text = "1";
            // 
            // Nombretxt
            // 
            this.Nombretxt.Location = new System.Drawing.Point(73, 33);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(100, 20);
            this.Nombretxt.TabIndex = 7;
            this.Nombretxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombretxt_KeyPress);
            this.Nombretxt.LostFocus += new System.EventHandler(Nombretxt_LostFocus);
            // 
            // Cedulatxt
            // 
            this.Cedulatxt.Location = new System.Drawing.Point(73, 68);
            this.Cedulatxt.Name = "Cedulatxt";
            this.Cedulatxt.Size = new System.Drawing.Size(100, 20);
            this.Cedulatxt.TabIndex = 8;
            this.Cedulatxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cedulatxt_KeyPress);
            this.Cedulatxt.LostFocus += new System.EventHandler(Cedulatxt_LostFocus);
            // 
            // lista_de_Cedulas
            // 
            this.lista_de_Cedulas.FormattingEnabled = true;
            this.lista_de_Cedulas.Location = new System.Drawing.Point(189, 9);
            this.lista_de_Cedulas.Name = "lista_de_Cedulas";
            this.lista_de_Cedulas.Size = new System.Drawing.Size(426, 82);
            this.lista_de_Cedulas.TabIndex = 9;
            this.lista_de_Cedulas.SelectedIndexChanged += new System.EventHandler(this.lista_de_Cedulas_SelectedIndexChanged);
            // 
            // Validacion_Cedula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 123);
            this.Controls.Add(this.lista_de_Cedulas);
            this.Controls.Add(this.Cedulatxt);
            this.Controls.Add(this.Nombretxt);
            this.Controls.Add(this.Idtxt);
            this.Controls.Add(this.etiquetaCedula);
            this.Controls.Add(this.etiquetaNombre);
            this.Controls.Add(this.etiquetaId);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonValidar);
            this.Controls.Add(this.botonNuevo);
            this.Name = "Validacion_Cedula";
            this.Text = "Validacion Cedula";
            this.Load += new System.EventHandler(this.Validacion_Cedula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.Button botonValidar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Label etiquetaId;
        private System.Windows.Forms.Label etiquetaNombre;
        private System.Windows.Forms.Label etiquetaCedula;
        private System.Windows.Forms.Label Idtxt;
        private System.Windows.Forms.TextBox Nombretxt;
        private System.Windows.Forms.TextBox Cedulatxt;
        private System.Windows.Forms.ListBox lista_de_Cedulas;
    }
}

