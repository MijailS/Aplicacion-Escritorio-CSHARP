
namespace AppEscritorio.Vista.Inventario
{
    partial class ListarInventario
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
            this.BtnLibros = new MetroFramework.Controls.MetroButton();
            this.BtnInsumos = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // BtnLibros
            // 
            this.BtnLibros.Location = new System.Drawing.Point(106, 144);
            this.BtnLibros.Name = "BtnLibros";
            this.BtnLibros.Size = new System.Drawing.Size(158, 48);
            this.BtnLibros.TabIndex = 0;
            this.BtnLibros.Text = "Libros";
            this.BtnLibros.UseSelectable = true;
            this.BtnLibros.Click += new System.EventHandler(this.BtnLibros_Click);
            // 
            // BtnInsumos
            // 
            this.BtnInsumos.Location = new System.Drawing.Point(477, 144);
            this.BtnInsumos.Name = "BtnInsumos";
            this.BtnInsumos.Size = new System.Drawing.Size(158, 48);
            this.BtnInsumos.TabIndex = 1;
            this.BtnInsumos.Text = "Insumos";
            this.BtnInsumos.UseSelectable = true;
            this.BtnInsumos.Click += new System.EventHandler(this.BtnInsumos_Click);
            // 
            // ListarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnInsumos);
            this.Controls.Add(this.BtnLibros);
            this.Name = "ListarInventario";
            this.Text = "ListarInventario";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnLibros;
        private MetroFramework.Controls.MetroButton BtnInsumos;
    }
}