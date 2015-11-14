namespace estructuras
{
    partial class linkedList
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
            this.btnAgregarInicio = new System.Windows.Forms.Button();
            this.btnAgregarFinal = new System.Windows.Forms.Button();
            this.btnAgregarAntes = new System.Windows.Forms.Button();
            this.btnAgregarDespues = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEliminarPrimero = new System.Windows.Forms.Button();
            this.btnEliminarUltimo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtBoxValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregarInicio
            // 
            this.btnAgregarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInicio.Location = new System.Drawing.Point(12, 98);
            this.btnAgregarInicio.Name = "btnAgregarInicio";
            this.btnAgregarInicio.Size = new System.Drawing.Size(165, 31);
            this.btnAgregarInicio.TabIndex = 0;
            this.btnAgregarInicio.Text = "Agregar al inicio";
            this.btnAgregarInicio.UseVisualStyleBackColor = true;
            this.btnAgregarInicio.Click += new System.EventHandler(this.btnAgregarInicio_Click);
            // 
            // btnAgregarFinal
            // 
            this.btnAgregarFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFinal.Location = new System.Drawing.Point(12, 135);
            this.btnAgregarFinal.Name = "btnAgregarFinal";
            this.btnAgregarFinal.Size = new System.Drawing.Size(165, 31);
            this.btnAgregarFinal.TabIndex = 1;
            this.btnAgregarFinal.Text = "Agregar al final";
            this.btnAgregarFinal.UseVisualStyleBackColor = true;
            this.btnAgregarFinal.Click += new System.EventHandler(this.btnAgregarFinal_Click);
            // 
            // btnAgregarAntes
            // 
            this.btnAgregarAntes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAntes.Location = new System.Drawing.Point(12, 172);
            this.btnAgregarAntes.Name = "btnAgregarAntes";
            this.btnAgregarAntes.Size = new System.Drawing.Size(165, 31);
            this.btnAgregarAntes.TabIndex = 2;
            this.btnAgregarAntes.Text = "Agregar antes de ";
            this.btnAgregarAntes.UseVisualStyleBackColor = true;
            this.btnAgregarAntes.Click += new System.EventHandler(this.btnAgregarAntes_Click);
            // 
            // btnAgregarDespues
            // 
            this.btnAgregarDespues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDespues.Location = new System.Drawing.Point(12, 209);
            this.btnAgregarDespues.Name = "btnAgregarDespues";
            this.btnAgregarDespues.Size = new System.Drawing.Size(165, 31);
            this.btnAgregarDespues.TabIndex = 3;
            this.btnAgregarDespues.Text = "Agregar despues de";
            this.btnAgregarDespues.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(12, 246);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 31);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPrimero
            // 
            this.btnEliminarPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPrimero.Location = new System.Drawing.Point(12, 283);
            this.btnEliminarPrimero.Name = "btnEliminarPrimero";
            this.btnEliminarPrimero.Size = new System.Drawing.Size(165, 31);
            this.btnEliminarPrimero.TabIndex = 5;
            this.btnEliminarPrimero.Text = "Eliminar primero";
            this.btnEliminarPrimero.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUltimo
            // 
            this.btnEliminarUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUltimo.Location = new System.Drawing.Point(12, 320);
            this.btnEliminarUltimo.Name = "btnEliminarUltimo";
            this.btnEliminarUltimo.Size = new System.Drawing.Size(165, 31);
            this.btnEliminarUltimo.TabIndex = 6;
            this.btnEliminarUltimo.Text = "Eliminar ultimo";
            this.btnEliminarUltimo.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(220, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 244);
            this.listBox1.TabIndex = 7;
            // 
            // txtBoxValor
            // 
            this.txtBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxValor.Location = new System.Drawing.Point(12, 39);
            this.txtBoxValor.Name = "txtBoxValor";
            this.txtBoxValor.Size = new System.Drawing.Size(143, 27);
            this.txtBoxValor.TabIndex = 8;
            // 
            // linkedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 385);
            this.Controls.Add(this.txtBoxValor);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEliminarUltimo);
            this.Controls.Add(this.btnEliminarPrimero);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarDespues);
            this.Controls.Add(this.btnAgregarAntes);
            this.Controls.Add(this.btnAgregarFinal);
            this.Controls.Add(this.btnAgregarInicio);
            this.Name = "linkedList";
            this.Text = "linkedList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarInicio;
        private System.Windows.Forms.Button btnAgregarFinal;
        private System.Windows.Forms.Button btnAgregarAntes;
        private System.Windows.Forms.Button btnAgregarDespues;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEliminarPrimero;
        private System.Windows.Forms.Button btnEliminarUltimo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtBoxValor;
    }
}