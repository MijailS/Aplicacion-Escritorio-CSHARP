
namespace AppEscritorio.Vista
{
    partial class Login
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
            this.TxtRut = new MetroFramework.Controls.MetroTextBox();
            this.TxtContrasenia = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BtnAgregar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // TxtRut
            // 
            // 
            // 
            // 
            this.TxtRut.CustomButton.Image = null;
            this.TxtRut.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.TxtRut.CustomButton.Name = "";
            this.TxtRut.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtRut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRut.CustomButton.TabIndex = 1;
            this.TxtRut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRut.CustomButton.UseSelectable = true;
            this.TxtRut.CustomButton.Visible = false;
            this.TxtRut.Lines = new string[0];
            this.TxtRut.Location = new System.Drawing.Point(129, 117);
            this.TxtRut.MaxLength = 32767;
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.PasswordChar = '\0';
            this.TxtRut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRut.SelectedText = "";
            this.TxtRut.SelectionLength = 0;
            this.TxtRut.SelectionStart = 0;
            this.TxtRut.ShortcutsEnabled = true;
            this.TxtRut.Size = new System.Drawing.Size(139, 23);
            this.TxtRut.TabIndex = 0;
            this.TxtRut.UseSelectable = true;
            this.TxtRut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtContrasenia
            // 
            // 
            // 
            // 
            this.TxtContrasenia.CustomButton.Image = null;
            this.TxtContrasenia.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.TxtContrasenia.CustomButton.Name = "";
            this.TxtContrasenia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtContrasenia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtContrasenia.CustomButton.TabIndex = 1;
            this.TxtContrasenia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtContrasenia.CustomButton.UseSelectable = true;
            this.TxtContrasenia.CustomButton.Visible = false;
            this.TxtContrasenia.Lines = new string[0];
            this.TxtContrasenia.Location = new System.Drawing.Point(129, 176);
            this.TxtContrasenia.MaxLength = 32767;
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.PasswordChar = '●';
            this.TxtContrasenia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtContrasenia.SelectedText = "";
            this.TxtContrasenia.SelectionLength = 0;
            this.TxtContrasenia.SelectionStart = 0;
            this.TxtContrasenia.ShortcutsEnabled = true;
            this.TxtContrasenia.Size = new System.Drawing.Size(139, 23);
            this.TxtContrasenia.TabIndex = 1;
            this.TxtContrasenia.UseSelectable = true;
            this.TxtContrasenia.UseSystemPasswordChar = true;
            this.TxtContrasenia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtContrasenia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(156, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Ingrese rut";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Red;
            this.metroLabel2.Location = new System.Drawing.Point(141, 154);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Ingrese contraseña";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Red;
            this.BtnAgregar.Location = new System.Drawing.Point(141, 282);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(118, 23);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Acceder";
            this.BtnAgregar.UseSelectable = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 438);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtContrasenia);
            this.Controls.Add(this.TxtRut);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Login";
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.AliceBlue;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TxtRut;
        private MetroFramework.Controls.MetroTextBox TxtContrasenia;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton BtnAgregar;
    }
}