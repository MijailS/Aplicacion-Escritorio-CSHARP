
namespace AppEscritorio.Vista.Boleta
{
    partial class AgregarBoleta
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
            this.CboVenta_Id = new System.Windows.Forms.ComboBox();
            this.CbOInsumo = new System.Windows.Forms.ComboBox();
            this.CboServicio_Id = new System.Windows.Forms.ComboBox();
            this.CbolibroID = new System.Windows.Forms.ComboBox();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CboVenta_Id
            // 
            this.CboVenta_Id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboVenta_Id.FormattingEnabled = true;
            this.CboVenta_Id.Location = new System.Drawing.Point(225, 62);
            this.CboVenta_Id.Name = "CboVenta_Id";
            this.CboVenta_Id.Size = new System.Drawing.Size(121, 21);
            this.CboVenta_Id.TabIndex = 0;
            this.CboVenta_Id.SelectedIndexChanged += new System.EventHandler(this.CboVenta_Id_SelectedIndexChanged);
            // 
            // CbOInsumo
            // 
            this.CbOInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbOInsumo.FormattingEnabled = true;
            this.CbOInsumo.Location = new System.Drawing.Point(225, 145);
            this.CbOInsumo.Name = "CbOInsumo";
            this.CbOInsumo.Size = new System.Drawing.Size(121, 21);
            this.CbOInsumo.TabIndex = 1;
            // 
            // CboServicio_Id
            // 
            this.CboServicio_Id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboServicio_Id.FormattingEnabled = true;
            this.CboServicio_Id.Location = new System.Drawing.Point(225, 102);
            this.CboServicio_Id.Name = "CboServicio_Id";
            this.CboServicio_Id.Size = new System.Drawing.Size(121, 21);
            this.CboServicio_Id.TabIndex = 2;
            // 
            // CbolibroID
            // 
            this.CbolibroID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbolibroID.FormattingEnabled = true;
            this.CbolibroID.Location = new System.Drawing.Point(382, 62);
            this.CbolibroID.Name = "CbolibroID";
            this.CbolibroID.Size = new System.Drawing.Size(121, 21);
            this.CbolibroID.TabIndex = 3;
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Location = new System.Drawing.Point(382, 100);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(121, 20);
            this.TxtSubtotal.TabIndex = 4;
            this.TxtSubtotal.TextChanged += new System.EventHandler(this.TxtSubtotal_TextChanged);
            this.TxtSubtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSubtotal_KeyPress_1);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(382, 145);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(121, 20);
            this.TxtCantidad.TabIndex = 5;
            this.TxtCantidad.TextChanged += new System.EventHandler(this.TxtCantidad_TextChanged);
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(283, 332);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(182, 23);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.Text = "AgregarBoleta";
            this.BtnAgregar.UseSelectable = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Venta ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Insumo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Libro ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "SubTotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ServicioID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Por cada Producto se debe hacer una boleta";
            // 
            // AgregarBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.CbolibroID);
            this.Controls.Add(this.CboServicio_Id);
            this.Controls.Add(this.CbOInsumo);
            this.Controls.Add(this.CboVenta_Id);
            this.Name = "AgregarBoleta";
            this.Text = "AgregarBoleta";
            this.Load += new System.EventHandler(this.AgregarBoleta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboVenta_Id;
        private System.Windows.Forms.ComboBox CbOInsumo;
        private System.Windows.Forms.ComboBox CboServicio_Id;
        private System.Windows.Forms.ComboBox CbolibroID;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.TextBox TxtCantidad;
        private MetroFramework.Controls.MetroButton BtnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}