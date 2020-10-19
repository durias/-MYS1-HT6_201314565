namespace _MYS1_HT6_201314565
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
            this.crear_modelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crear_modelo
            // 
            this.crear_modelo.Location = new System.Drawing.Point(205, 163);
            this.crear_modelo.Name = "crear_modelo";
            this.crear_modelo.Size = new System.Drawing.Size(75, 23);
            this.crear_modelo.TabIndex = 0;
            this.crear_modelo.Text = "GO!";
            this.crear_modelo.UseVisualStyleBackColor = true;
            this.crear_modelo.Click += new System.EventHandler(this.crear_modelo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.crear_modelo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button crear_modelo;
    }
}

