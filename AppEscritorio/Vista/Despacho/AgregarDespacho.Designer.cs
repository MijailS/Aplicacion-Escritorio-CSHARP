
namespace AppEscritorio.Vista.Despacho
{
    partial class AgregarDespacho
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
            this.CboEnvio = new System.Windows.Forms.ComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.TxtDireccion = new MetroFramework.Controls.MetroTextBox();
            this.LblComuna = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TxtTelefono = new MetroFramework.Controls.MetroTextBox();
            this.CboComuna = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BtnAgregar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // CboEnvio
            // 
            this.CboEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEnvio.FormattingEnabled = true;
            this.CboEnvio.Location = new System.Drawing.Point(428, 152);
            this.CboEnvio.Name = "CboEnvio";
            this.CboEnvio.Size = new System.Drawing.Size(121, 21);
            this.CboEnvio.TabIndex = 27;
            this.CboEnvio.SelectedIndexChanged += new System.EventHandler(this.CboEnvio_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AllowDrop = true;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(149, 130);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 26;
            this.metroLabel6.Text = "Direccion";
            // 
            // TxtDireccion
            // 
            // 
            // 
            // 
            this.TxtDireccion.CustomButton.Image = null;
            this.TxtDireccion.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.TxtDireccion.CustomButton.Name = "";
            this.TxtDireccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDireccion.CustomButton.TabIndex = 1;
            this.TxtDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDireccion.CustomButton.UseSelectable = true;
            this.TxtDireccion.CustomButton.Visible = false;
            this.TxtDireccion.Lines = new string[0];
            this.TxtDireccion.Location = new System.Drawing.Point(149, 151);
            this.TxtDireccion.MaxLength = 32767;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.PasswordChar = '\0';
            this.TxtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDireccion.SelectedText = "";
            this.TxtDireccion.SelectionLength = 0;
            this.TxtDireccion.SelectionStart = 0;
            this.TxtDireccion.ShortcutsEnabled = true;
            this.TxtDireccion.Size = new System.Drawing.Size(123, 23);
            this.TxtDireccion.TabIndex = 25;
            this.TxtDireccion.UseSelectable = true;
            this.TxtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LblComuna
            // 
            this.LblComuna.AllowDrop = true;
            this.LblComuna.AutoSize = true;
            this.LblComuna.Location = new System.Drawing.Point(428, 128);
            this.LblComuna.Name = "LblComuna";
            this.LblComuna.Size = new System.Drawing.Size(40, 19);
            this.LblComuna.TabIndex = 24;
            this.LblComuna.Text = "Envio";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AllowDrop = true;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(149, 72);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Telefono";
            // 
            // TxtTelefono
            // 
            // 
            // 
            // 
            this.TxtTelefono.CustomButton.Image = null;
            this.TxtTelefono.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.TxtTelefono.CustomButton.Name = "";
            this.TxtTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtTelefono.CustomButton.TabIndex = 1;
            this.TxtTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtTelefono.CustomButton.UseSelectable = true;
            this.TxtTelefono.CustomButton.Visible = false;
            this.TxtTelefono.Lines = new string[0];
            this.TxtTelefono.Location = new System.Drawing.Point(149, 94);
            this.TxtTelefono.MaxLength = 32767;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.PasswordChar = '\0';
            this.TxtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTelefono.SelectedText = "";
            this.TxtTelefono.SelectionLength = 0;
            this.TxtTelefono.SelectionStart = 0;
            this.TxtTelefono.ShortcutsEnabled = true;
            this.TxtTelefono.Size = new System.Drawing.Size(123, 23);
            this.TxtTelefono.TabIndex = 19;
            this.TxtTelefono.UseSelectable = true;
            this.TxtTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // CboComuna
            // 
            this.CboComuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboComuna.FormattingEnabled = true;
            this.CboComuna.Location = new System.Drawing.Point(428, 94);
            this.CboComuna.Name = "CboComuna";
            this.CboComuna.Size = new System.Drawing.Size(121, 21);
            this.CboComuna.TabIndex = 29;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AllowDrop = true;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(428, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Comuna";
            // 
            // CboEstado
            // 
            this.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEstado.FormattingEnabled = true;
            this.CboEstado.Location = new System.Drawing.Point(428, 216);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(121, 21);
            this.CboEstado.TabIndex = 31;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AllowDrop = true;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(428, 194);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Estado";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(265, 315);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(167, 23);
            this.BtnAgregar.TabIndex = 32;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseSelectable = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // AgregarDespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.CboEstado);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.CboComuna);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CboEnvio);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.LblComuna);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.TxtTelefono);
            this.Name = "AgregarDespacho";
            this.Text = "AgregarDespacho";
            this.Load += new System.EventHandler(this.AgregarDespacho_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboEnvio;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel LblComuna;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox TxtDireccion;
        private MetroFramework.Controls.MetroTextBox TxtTelefono;
        private System.Windows.Forms.ComboBox CboComuna;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox CboEstado;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton BtnAgregar;
    }
}