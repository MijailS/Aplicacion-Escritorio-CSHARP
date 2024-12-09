
namespace AppEscritorio.Vista.Servicio
{
    partial class AgregarServicio
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
            this.TxtObservacion = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtNombreServ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DtFechaProgramada = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.DtFechaRealizadaa = new System.Windows.Forms.DateTimePicker();
            this.CboTecnicoID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(291, 363);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(182, 23);
            this.BtnAgregar.TabIndex = 11;
            this.BtnAgregar.Text = "Agregar Servicio";
            this.BtnAgregar.UseSelectable = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtObservacion
            // 
            this.TxtObservacion.Location = new System.Drawing.Point(33, 113);
            this.TxtObservacion.Name = "TxtObservacion";
            this.TxtObservacion.Size = new System.Drawing.Size(121, 20);
            this.TxtObservacion.TabIndex = 10;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(33, 74);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(121, 20);
            this.TxtValor.TabIndex = 8;
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // TxtNombreServ
            // 
            this.TxtNombreServ.Location = new System.Drawing.Point(33, 39);
            this.TxtNombreServ.Name = "TxtNombreServ";
            this.TxtNombreServ.Size = new System.Drawing.Size(121, 20);
            this.TxtNombreServ.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Observacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fecha Programada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tecnico ID";
            // 
            // DtFechaProgramada
            // 
            this.DtFechaProgramada.Location = new System.Drawing.Point(33, 149);
            this.DtFechaProgramada.Name = "DtFechaProgramada";
            this.DtFechaProgramada.Size = new System.Drawing.Size(121, 20);
            this.DtFechaProgramada.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Fecha Realizada";
            // 
            // DtFechaRealizadaa
            // 
            this.DtFechaRealizadaa.Location = new System.Drawing.Point(33, 194);
            this.DtFechaRealizadaa.Name = "DtFechaRealizadaa";
            this.DtFechaRealizadaa.Size = new System.Drawing.Size(121, 20);
            this.DtFechaRealizadaa.TabIndex = 23;
            // 
            // CboTecnicoID
            // 
            this.CboTecnicoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTecnicoID.Location = new System.Drawing.Point(33, 226);
            this.CboTecnicoID.Name = "CboTecnicoID";
            this.CboTecnicoID.Size = new System.Drawing.Size(121, 21);
            this.CboTecnicoID.TabIndex = 0;
            this.CboTecnicoID.SelectedIndexChanged += new System.EventHandler(this.CboTecnicoID_SelectedIndexChanged);
            // 
            // AgregarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CboTecnicoID);
            this.Controls.Add(this.DtFechaRealizadaa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DtFechaProgramada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombreServ);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtObservacion);
            this.Controls.Add(this.TxtValor);
            this.Name = "AgregarServicio";
            this.Text = "AgregarServicio";
            this.Load += new System.EventHandler(this.AgregarServicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnAgregar;
        private System.Windows.Forms.TextBox TxtObservacion;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtNombreServ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtFechaProgramada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtFechaRealizadaa;
        private System.Windows.Forms.ComboBox CboTecnicoID;
    }
}