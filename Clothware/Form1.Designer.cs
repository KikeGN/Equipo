namespace CLOTHWARE
{
    partial class CONEXION
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
            this.btnComprobar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComprobar
            // 
            this.btnComprobar.BackColor = System.Drawing.Color.White;
            this.btnComprobar.Location = new System.Drawing.Point(13, 13);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(259, 23);
            this.btnComprobar.TabIndex = 0;
            this.btnComprobar.Text = "COMPROBAR";
            this.btnComprobar.UseVisualStyleBackColor = false;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // CONEXION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 47);
            this.Controls.Add(this.btnComprobar);
            this.Name = "CONEXION";
            this.Text = "CONEXION";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComprobar;
    }
}

