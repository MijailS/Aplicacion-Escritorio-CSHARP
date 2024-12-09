
namespace AppEscritorio.Vista.Trabajador
{
    partial class AgregarTrabajador
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new MetroFramework.Controls.MetroButton();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.TxtRun = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DtFec_Nac = new System.Windows.Forms.DateTimePicker();
            this.CboComuna = new System.Windows.Forms.ComboBox();
            this.CboTipoTrab = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(162, 70);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(121, 20);
            this.TxtNombre.TabIndex = 23;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(560, 69);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(121, 20);
            this.TxtEmail.TabIndex = 22;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(560, 109);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(121, 20);
            this.TxtTelefono.TabIndex = 21;
            this.TxtTelefono.TextChanged += new System.EventHandler(this.TxtTelefono_TextChanged);
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(162, 109);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(121, 20);
            this.TxtApellido.TabIndex = 20;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(333, 423);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(182, 23);
            this.BtnAgregar.TabIndex = 19;
            this.BtnAgregar.Text = "Agregar Trabajador";
            this.BtnAgregar.UseSelectable = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(162, 183);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(121, 20);
            this.TxtPass.TabIndex = 18;
            // 
            // TxtRun
            // 
            this.TxtRun.Location = new System.Drawing.Point(162, 144);
            this.TxtRun.Name = "TxtRun";
            this.TxtRun.Size = new System.Drawing.Size(121, 20);
            this.TxtRun.TabIndex = 16;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(560, 146);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(121, 20);
            this.TxtDireccion.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Rut";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(289, 186);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(61, 13);
            this.pass.TabIndex = 30;
            this.pass.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(687, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Fecha nacimiento";
            // 
            // DtFec_Nac
            // 
            this.DtFec_Nac.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DtFec_Nac.Location = new System.Drawing.Point(162, 222);
            this.DtFec_Nac.Name = "DtFec_Nac";
            this.DtFec_Nac.Size = new System.Drawing.Size(121, 20);
            this.DtFec_Nac.TabIndex = 33;
            this.DtFec_Nac.Value = new System.DateTime(2022, 9, 15, 0, 0, 0, 0);
            // 
            // CboComuna
            // 
            this.CboComuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboComuna.FormattingEnabled = true;
            this.CboComuna.Location = new System.Drawing.Point(560, 181);
            this.CboComuna.Name = "CboComuna";
            this.CboComuna.Size = new System.Drawing.Size(121, 21);
            this.CboComuna.TabIndex = 34;
            // 
            // CboTipoTrab
            // 
            this.CboTipoTrab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoTrab.FormattingEnabled = true;
            this.CboTipoTrab.Location = new System.Drawing.Point(560, 219);
            this.CboTipoTrab.Name = "CboTipoTrab";
            this.CboTipoTrab.Size = new System.Drawing.Size(121, 21);
            this.CboTipoTrab.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(687, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Tipo Trabajador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(687, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(687, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Telefono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(690, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Comuna";
            // 
            // AgregarTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 568);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CboTipoTrab);
            this.Controls.Add(this.CboComuna);
            this.Controls.Add(this.DtFec_Nac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtRun);
            this.Name = "AgregarTrabajador";
            this.Text = "AgregarTrabajador";
            this.Load += new System.EventHandler(this.AgregarTrabajador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtApellido;
        private MetroFramework.Controls.MetroButton BtnAgregar;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.TextBox TxtRun;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtFec_Nac;
        private System.Windows.Forms.ComboBox CboComuna;
        private System.Windows.Forms.ComboBox CboTipoTrab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}