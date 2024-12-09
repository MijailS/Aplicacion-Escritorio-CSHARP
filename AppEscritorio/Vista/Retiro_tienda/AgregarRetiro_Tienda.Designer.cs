
namespace AppEscritorio.Vista.Retiro_tienda
{
    partial class AgregarRetiro_Tienda
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
            this.BtnAgregar = new MetroFramework.Controls.MetroButton();
            this.CboIdEnvio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(287, 269);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(182, 23);
            this.BtnAgregar.TabIndex = 15;
            this.BtnAgregar.Text = "AgregarRetiro";
            this.BtnAgregar.UseSelectable = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // CboIdEnvio
            // 
            this.CboIdEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboIdEnvio.FormattingEnabled = true;
            this.CboIdEnvio.Location = new System.Drawing.Point(208, 153);
            this.CboIdEnvio.Name = "CboIdEnvio";
            this.CboIdEnvio.Size = new System.Drawing.Size(326, 21);
            this.CboIdEnvio.TabIndex = 18;
            this.CboIdEnvio.SelectedIndexChanged += new System.EventHandler(this.CboIdEnvio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "ENVIO ID";
            // 
            // AgregarRetiro_Tienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboIdEnvio);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "AgregarRetiro_Tienda";
            this.Text = "Retiro_Tienda";
            this.Load += new System.EventHandler(this.AgregarRetiro_Tienda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton BtnAgregar;
        private System.Windows.Forms.ComboBox CboIdEnvio;
        private System.Windows.Forms.Label label2;
    }
}