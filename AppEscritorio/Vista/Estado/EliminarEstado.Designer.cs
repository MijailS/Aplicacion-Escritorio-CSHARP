
namespace AppEscritorio.Vista.Estado
{
    partial class EliminarEstado
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
            this.BtnEliminar = new MetroFramework.Controls.MetroButton();
            this.TxtNumero = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(271, 299);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(223, 23);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseSelectable = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
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
            this.TxtNumero.Location = new System.Drawing.Point(240, 162);
            this.TxtNumero.MaxLength = 32767;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.PasswordChar = '\0';
            this.TxtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNumero.SelectedText = "";
            this.TxtNumero.SelectionLength = 0;
            this.TxtNumero.SelectionStart = 0;
            this.TxtNumero.ShortcutsEnabled = true;
            this.TxtNumero.Size = new System.Drawing.Size(272, 23);
            this.TxtNumero.TabIndex = 4;
            this.TxtNumero.UseSelectable = true;
            this.TxtNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNumero.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID ";
            // 
            // EliminarEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TxtNumero);
            this.Name = "EliminarEstado";
            this.Text = "EliminarEstado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnEliminar;
        private MetroFramework.Controls.MetroTextBox TxtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}