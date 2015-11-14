namespace estructuras
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLista = new System.Windows.Forms.Button();
            this.btnPila = new System.Windows.Forms.Button();
            this.btnCola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLista
            // 
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.Location = new System.Drawing.Point(95, 85);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(146, 41);
            this.btnLista.TabIndex = 0;
            this.btnLista.Text = "Linked list";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnPila
            // 
            this.btnPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPila.Location = new System.Drawing.Point(95, 177);
            this.btnPila.Name = "btnPila";
            this.btnPila.Size = new System.Drawing.Size(146, 41);
            this.btnPila.TabIndex = 2;
            this.btnPila.Text = "Stack";
            this.btnPila.UseVisualStyleBackColor = true;
            this.btnPila.Click += new System.EventHandler(this.btnPila_Click);
            // 
            // btnCola
            // 
            this.btnCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCola.Location = new System.Drawing.Point(95, 261);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(146, 41);
            this.btnCola.TabIndex = 1;
            this.btnCola.Text = "Queue";
            this.btnCola.UseVisualStyleBackColor = true;
            this.btnCola.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 346);
            this.Controls.Add(this.btnCola);
            this.Controls.Add(this.btnPila);
            this.Controls.Add(this.btnLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnPila;
        private System.Windows.Forms.Button btnCola;
    }
}

