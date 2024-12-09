
namespace AppEscritorio.Vista.Visitas
{
    partial class AgregarVisita
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
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.DtFecha = new System.Windows.Forms.DateTimePicker();
            this.DtHora = new System.Windows.Forms.DateTimePicker();
            this.CboTecnico = new System.Windows.Forms.ComboBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(252, 289);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(182, 23);
            this.BtnAgregar.TabIndex = 38;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseSelectable = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(90, 133);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(200, 20);
            this.TxtDesc.TabIndex = 35;
            // 
            // DtFecha
            // 
            this.DtFecha.Location = new System.Drawing.Point(90, 47);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(200, 20);
            this.DtFecha.TabIndex = 41;
            // 
            // DtHora
            // 
            this.DtHora.Location = new System.Drawing.Point(90, 92);
            this.DtHora.Name = "DtHora";
            this.DtHora.Size = new System.Drawing.Size(200, 20);
            this.DtHora.TabIndex = 42;
            // 
            // CboTecnico
            // 
            this.CboTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTecnico.FormattingEnabled = true;
            this.CboTecnico.Location = new System.Drawing.Point(90, 184);
            this.CboTecnico.Name = "CboTecnico";
            this.CboTecnico.Size = new System.Drawing.Size(200, 21);
            this.CboTecnico.TabIndex = 43;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(320, 47);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(37, 13);
            this.Fecha.TabIndex = 44;
            this.Fecha.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Tecnico";
            // 
            // AgregarVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.CboTecnico);
            this.Controls.Add(this.DtHora);
            this.Controls.Add(this.DtFecha);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtDesc);
            this.Name = "AgregarVisita";
            this.Text = "AgregarVisita";
            this.Load += new System.EventHandler(this.AgregarVisita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton BtnAgregar;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.DateTimePicker DtFecha;
        private System.Windows.Forms.DateTimePicker DtHora;
        private System.Windows.Forms.ComboBox CboTecnico;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}