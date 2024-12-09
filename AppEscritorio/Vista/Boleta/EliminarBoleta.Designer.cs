
namespace AppEscritorio.Vista.Boleta
{
    partial class EliminarBoleta
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
            this.TxtNumero = new MetroFramework.Controls.MetroTextBox();
            this.BtnEliminar = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNumero
            // 
            // 
            // 
            // 
            this.TxtNumero.CustomButton.Image = null;
            this.TxtNumero.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.TxtNumero.CustomButton.Name = "";
            this.TxtNumero.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNumero.CustomButton.TabIndex = 1;
            this.TxtNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNumero.CustomButton.UseSelectable = true;
            this.TxtNumero.CustomButton.Visible = false;
            this.TxtNumero.Lines = new string[0];
            this.TxtNumero.Location = new System.Drawing.Point(257, 101);
            this.TxtNumero.MaxLength = 32767;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.PasswordChar = '\0';
            this.TxtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNumero.SelectedText = "";
            this.TxtNumero.SelectionLength = 0;
            this.TxtNumero.SelectionStart = 0;
            this.TxtNumero.ShortcutsEnabled = true;
            this.TxtNumero.Size = new System.Drawing.Size(272, 23);
            this.TxtNumero.TabIndex = 0;
            this.TxtNumero.UseSelectable = true;
            this.TxtNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNumero.Click += new System.EventHandler(this.TxtNumero_Click);
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(296, 267);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(223, 23);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseSelectable = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "INGRESE ID";
            // 
            // EliminarBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TxtNumero);
            this.Name = "EliminarBoleta";
            this.Text = "Eliminar Boleta";
            this.Load += new System.EventHandler(this.EliminarBoleta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TxtNumero;
        private MetroFramework.Controls.MetroButton BtnEliminar;
        private System.Windows.Forms.Label label1;
    }
}