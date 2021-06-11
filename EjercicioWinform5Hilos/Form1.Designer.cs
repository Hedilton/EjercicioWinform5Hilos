
namespace EjercicioWinform5Hilos
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
            this.button1 = new System.Windows.Forms.Button();
            this.Tabla11 = new System.Windows.Forms.ListBox();
            this.Tabla12 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tabla11
            // 
            this.Tabla11.FormattingEnabled = true;
            this.Tabla11.Location = new System.Drawing.Point(55, 126);
            this.Tabla11.Name = "Tabla11";
            this.Tabla11.Size = new System.Drawing.Size(176, 277);
            this.Tabla11.TabIndex = 1;
            // 
            // Tabla12
            // 
            this.Tabla12.FormattingEnabled = true;
            this.Tabla12.Location = new System.Drawing.Point(292, 126);
            this.Tabla12.Name = "Tabla12";
            this.Tabla12.Size = new System.Drawing.Size(180, 277);
            this.Tabla12.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 456);
            this.Controls.Add(this.Tabla12);
            this.Controls.Add(this.Tabla11);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Tabla11;
        private System.Windows.Forms.ListBox Tabla12;
    }
}

