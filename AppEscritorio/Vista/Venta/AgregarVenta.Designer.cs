
namespace AppEscritorio.Vista.Venta
{
    partial class AgregarVenta
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
            this.TxtTotalVenta = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new MetroFramework.Controls.MetroButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CboRutCliente = new System.Windows.Forms.ComboBox();
            this.CboTipoVenta = new System.Windows.Forms.ComboBox();
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.CboTrabajador = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtTotalVenta
            // 
            this.TxtTotalVenta.Location = new System.Drawing.Point(140, 78);
            this.TxtTotalVenta.Name = "TxtTotalVenta";
            this.TxtTotalVenta.Size = new System.Drawing.Size(121, 20);
            this.TxtTotalVenta.TabIndex = 31;
            this.TxtTotalVenta.TextChanged += new System.EventHandler(this.TxtTotalVenta_TextChanged);
            this.TxtTotalVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTotalVenta_KeyPress);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(377, 449);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(182, 23);
            this.BtnAgregar.TabIndex = 30;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseSelectable = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // CboRutCliente
            // 
            this.CboRutCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboRutCliente.FormattingEnabled = true;
            this.CboRutCliente.Location = new System.Drawing.Point(140, 115);
            this.CboRutCliente.Name = "CboRutCliente";
            this.CboRutCliente.Size = new System.Drawing.Size(121, 21);
            this.CboRutCliente.TabIndex = 39;
            // 
            // CboTipoVenta
            // 
            this.CboTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoVenta.FormattingEnabled = true;
            this.CboTipoVenta.Location = new System.Drawing.Point(140, 151);
            this.CboTipoVenta.Name = "CboTipoVenta";
            this.CboTipoVenta.Size = new System.Drawing.Size(121, 21);
            this.CboTipoVenta.TabIndex = 40;
            // 
            // CboEstado
            // 
            this.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEstado.FormattingEnabled = true;
            this.CboEstado.Location = new System.Drawing.Point(140, 197);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(121, 21);
            this.CboEstado.TabIndex = 42;
            // 
            // CboTrabajador
            // 
            this.CboTrabajador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTrabajador.FormattingEnabled = true;
            this.CboTrabajador.Location = new System.Drawing.Point(140, 247);
            this.CboTrabajador.Name = "CboTrabajador";
            this.CboTrabajador.Size = new System.Drawing.Size(121, 21);
            this.CboTrabajador.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Total venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Rut Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Tipo Venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Trabajador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Estado";
            // 
            // AgregarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(786, 521);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboTrabajador);
            this.Controls.Add(this.CboEstado);
            this.Controls.Add(this.CboTipoVenta);
            this.Controls.Add(this.CboRutCliente);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TxtTotalVenta);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "AgregarVenta";
            this.Text = "AgregarVenta";
            this.Load += new System.EventHandler(this.AgregarVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtTotalVenta;
        private MetroFramework.Controls.MetroButton BtnAgregar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CboRutCliente;
        private System.Windows.Forms.ComboBox CboTipoVenta;
        private System.Windows.Forms.ComboBox CboEstado;
        private System.Windows.Forms.ComboBox CboTrabajador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}