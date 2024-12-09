
namespace AppEscritorio.Vista
{
    partial class EliminarInventario
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
            this.BtnEliminarLibros = new MetroFramework.Controls.MetroButton();
            this.BtnEliminarInsumos = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // BtnEliminarLibros
            // 
            this.BtnEliminarLibros.Location = new System.Drawing.Point(145, 120);
            this.BtnEliminarLibros.Name = "BtnEliminarLibros";
            this.BtnEliminarLibros.Size = new System.Drawing.Size(166, 59);
            this.BtnEliminarLibros.TabIndex = 0;
            this.BtnEliminarLibros.Text = "Libro";
            this.BtnEliminarLibros.UseSelectable = true;
            this.BtnEliminarLibros.Click += new System.EventHandler(this.BtnEliminarLibros_Click);
            // 
            // BtnEliminarInsumos
            // 
            this.BtnEliminarInsumos.Location = new System.Drawing.Point(429, 120);
            this.BtnEliminarInsumos.Name = "BtnEliminarInsumos";
            this.BtnEliminarInsumos.Size = new System.Drawing.Size(166, 59);
            this.BtnEliminarInsumos.TabIndex = 1;
            this.BtnEliminarInsumos.Text = "Insumos";
            this.BtnEliminarInsumos.UseSelectable = true;
            this.BtnEliminarInsumos.Click += new System.EventHandler(this.BtnEliminarInsumos_Click);
            // 
            // EliminarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEliminarInsumos);
            this.Controls.Add(this.BtnEliminarLibros);
            this.Name = "EliminarInventario";
            this.Text = "EliminarInventario";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnEliminarLibros;
        private MetroFramework.Controls.MetroButton BtnEliminarInsumos;
    }
}