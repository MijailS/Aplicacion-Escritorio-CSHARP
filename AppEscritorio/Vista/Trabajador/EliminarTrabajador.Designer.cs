﻿
namespace AppEscritorio.Vista.Trabajador
{
    partial class EliminarTrabajador
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
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(301, 206);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(180, 23);
            this.BtnEliminar.TabIndex = 14;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ingrese Run de Trabajador";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(217, 108);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(358, 20);
            this.txtID.TabIndex = 12;
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(579, 12);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(209, 20);
            this.TxtTipo.TabIndex = 32;
            this.TxtTipo.Text = "sasas";
            this.TxtTipo.Visible = false;
            // 
            // EliminarTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtTipo);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Name = "EliminarTrabajador";
            this.Text = "EliminarTrabajador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox TxtTipo;
    }
}