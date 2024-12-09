
namespace AppEscritorio.Vista
{
    partial class AgregarInventario
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
            this.BtnAgregarLibro = new MetroFramework.Controls.MetroButton();
            this.BtnAgregarInsumos = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAgregarLibro
            // 
            this.BtnAgregarLibro.Location = new System.Drawing.Point(124, 142);
            this.BtnAgregarLibro.Name = "BtnAgregarLibro";
            this.BtnAgregarLibro.Size = new System.Drawing.Size(197, 36);
            this.BtnAgregarLibro.TabIndex = 0;
            this.BtnAgregarLibro.Text = "Libros";
            this.BtnAgregarLibro.UseSelectable = true;
            this.BtnAgregarLibro.Click += new System.EventHandler(this.BtnAgregarLibro_Click);
            // 
            // BtnAgregarInsumos
            // 
            this.BtnAgregarInsumos.Location = new System.Drawing.Point(427, 142);
            this.BtnAgregarInsumos.Name = "BtnAgregarInsumos";
            this.BtnAgregarInsumos.Size = new System.Drawing.Size(197, 36);
            this.BtnAgregarInsumos.TabIndex = 1;
            this.BtnAgregarInsumos.Text = "Insumos";
            this.BtnAgregarInsumos.UseSelectable = true;
            this.BtnAgregarInsumos.Click += new System.EventHandler(this.BtnAgregarInsumos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Que desea agregar ?";
            // 
            // AgregarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAgregarInsumos);
            this.Controls.Add(this.BtnAgregarLibro);
            this.Name = "AgregarInventario";
            this.Text = "AgregarInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnAgregarLibro;
        private MetroFramework.Controls.MetroButton BtnAgregarInsumos;
        private System.Windows.Forms.Label label1;
    }
}