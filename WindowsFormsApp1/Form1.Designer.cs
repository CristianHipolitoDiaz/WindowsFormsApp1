namespace WindowsFormsApp1
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
            this.Titulo = new System.Windows.Forms.TextBox();
            this.statustarea = new System.Windows.Forms.CheckBox();
            this.vencimiento = new System.Windows.Forms.DateTimePicker();
            this.Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(206, 42);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(100, 20);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Titulo";
            this.Titulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // statustarea
            // 
            this.statustarea.AutoSize = true;
            this.statustarea.Location = new System.Drawing.Point(420, 116);
            this.statustarea.Name = "statustarea";
            this.statustarea.Size = new System.Drawing.Size(78, 17);
            this.statustarea.TabIndex = 1;
            this.statustarea.Text = "statustarea";
            this.statustarea.UseVisualStyleBackColor = true;
            this.statustarea.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // vencimiento
            // 
            this.vencimiento.Location = new System.Drawing.Point(168, 116);
            this.vencimiento.Name = "vencimiento";
            this.vencimiento.Size = new System.Drawing.Size(200, 20);
            this.vencimiento.TabIndex = 2;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(420, 39);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 3;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.vencimiento);
            this.Controls.Add(this.statustarea);
            this.Controls.Add(this.Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.CheckBox statustarea;
        private System.Windows.Forms.DateTimePicker vencimiento;
        private System.Windows.Forms.Button Agregar;
    }
}

