
namespace AppEscritorio.Vista.Inventario
{
    partial class ModificarInsumos
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregarInsumos = new MetroFramework.Controls.MetroButton();
            this.BtnAgregarLibro = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "¿Que desea agregar ?";
            // 
            // BtnAgregarInsumos
            // 
            this.BtnAgregarInsumos.Location = new System.Drawing.Point(436, 149);
            this.BtnAgregarInsumos.Name = "BtnAgregarInsumos";
            this.BtnAgregarInsumos.Size = new System.Drawing.Size(197, 36);
            this.BtnAgregarInsumos.TabIndex = 4;
            this.BtnAgregarInsumos.Text = "Insumos";
            this.BtnAgregarInsumos.UseSelectable = true;
            // 
            // BtnAgregarLibro
            // 
            this.BtnAgregarLibro.Location = new System.Drawing.Point(133, 149);
            this.BtnAgregarLibro.Name = "BtnAgregarLibro";
            this.BtnAgregarLibro.Size = new System.Drawing.Size(197, 36);
            this.BtnAgregarLibro.TabIndex = 3;
            this.BtnAgregarLibro.Text = "Libros";
            this.BtnAgregarLibro.UseSelectable = true;
            // 
            // ModificarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAgregarInsumos);
            this.Controls.Add(this.BtnAgregarLibro);
            this.Name = "ModificarInsumos";
            this.Text = "ModificarInsumos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton BtnAgregarInsumos;
        private MetroFramework.Controls.MetroButton BtnAgregarLibro;
    }
}