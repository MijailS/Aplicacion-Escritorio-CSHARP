
namespace AppEscritorio.Vista.Visitas
{
    partial class EliminarVisita
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
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(212, 108);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(334, 20);
            this.TxtID.TabIndex = 42;
            this.TxtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtID_KeyPress);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(287, 243);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(182, 23);
            this.BtnEliminar.TabIndex = 41;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseSelectable = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ingrese ID visita";
            // 
            // EliminarVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.BtnEliminar);
            this.Name = "EliminarVisita";
            this.Text = "EliminarVisita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtID;
        private MetroFramework.Controls.MetroButton BtnEliminar;
        private System.Windows.Forms.Label label1;
    }
}