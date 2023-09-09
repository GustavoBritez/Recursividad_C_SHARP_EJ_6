namespace Ejercicio6
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
            this.BTN_INGRESAR = new System.Windows.Forms.Button();
            this.LT_1 = new System.Windows.Forms.ListBox();
            this.TX_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_INGRESAR
            // 
            this.BTN_INGRESAR.Location = new System.Drawing.Point(224, 89);
            this.BTN_INGRESAR.Name = "BTN_INGRESAR";
            this.BTN_INGRESAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_INGRESAR.TabIndex = 0;
            this.BTN_INGRESAR.Text = "Ingresar";
            this.BTN_INGRESAR.UseVisualStyleBackColor = true;
            this.BTN_INGRESAR.Click += new System.EventHandler(this.BTN_INGRESAR_Click);
            // 
            // LT_1
            // 
            this.LT_1.FormattingEnabled = true;
            this.LT_1.Location = new System.Drawing.Point(201, 131);
            this.LT_1.Name = "LT_1";
            this.LT_1.Size = new System.Drawing.Size(120, 95);
            this.LT_1.TabIndex = 1;
            // 
            // TX_1
            // 
            this.TX_1.Location = new System.Drawing.Point(164, 63);
            this.TX_1.Name = "TX_1";
            this.TX_1.Size = new System.Drawing.Size(200, 20);
            this.TX_1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escribir un programa que encuentre la suma de los enteros positivos pares desde N" +
    " hasta 2. Chequear que si N es impar se imprima un mensaje de error";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TX_1);
            this.Controls.Add(this.LT_1);
            this.Controls.Add(this.BTN_INGRESAR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_INGRESAR;
        private System.Windows.Forms.ListBox LT_1;
        private System.Windows.Forms.TextBox TX_1;
        private System.Windows.Forms.Label label1;
    }
}

