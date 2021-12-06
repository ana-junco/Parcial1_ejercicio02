
namespace Parcial1_ejercicio02
{
    partial class FrmEjercicio02
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFrase = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LstPalabras = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESA LA FRASE";
            // 
            // TxtFrase
            // 
            this.TxtFrase.Location = new System.Drawing.Point(246, 39);
            this.TxtFrase.Multiline = true;
            this.TxtFrase.Name = "TxtFrase";
            this.TxtFrase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtFrase.Size = new System.Drawing.Size(187, 68);
            this.TxtFrase.TabIndex = 1;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(467, 67);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 2;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RESULTADO";
            // 
            // LstPalabras
            // 
            this.LstPalabras.FormattingEnabled = true;
            this.LstPalabras.Location = new System.Drawing.Point(96, 197);
            this.LstPalabras.Name = "LstPalabras";
            this.LstPalabras.Size = new System.Drawing.Size(120, 95);
            this.LstPalabras.TabIndex = 4;
            // 
            // FrmEjercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstPalabras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtFrase);
            this.Controls.Add(this.label1);
            this.Name = "FrmEjercicio02";
            this.Text = "Cuentas palabras con su respectiva longitud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFrase;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LstPalabras;
    }
}

