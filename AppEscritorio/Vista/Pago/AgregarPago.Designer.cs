
namespace AppEscritorio.Vista.Pago
{
    partial class AgregarPago
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.BtnAgregar = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtMonto = new MetroFramework.Controls.MetroTextBox();
            this.CboIDVenta = new System.Windows.Forms.ComboBox();
            this.CboTipoPago = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(317, 217);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(115, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Ingrese Tipo Pago";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(294, 328);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(174, 23);
            this.BtnAgregar.TabIndex = 16;
            this.BtnAgregar.Text = "Agregar Pago";
            this.BtnAgregar.UseSelectable = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(317, 177);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Ingrese ID venta";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(317, 135);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Ingrese monto";
            // 
            // TxtMonto
            // 
            // 
            // 
            // 
            this.TxtMonto.CustomButton.Image = null;
            this.TxtMonto.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.TxtMonto.CustomButton.Name = "";
            this.TxtMonto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMonto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMonto.CustomButton.TabIndex = 1;
            this.TxtMonto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMonto.CustomButton.UseSelectable = true;
            this.TxtMonto.CustomButton.Visible = false;
            this.TxtMonto.Lines = new string[0];
            this.TxtMonto.Location = new System.Drawing.Point(162, 135);
            this.TxtMonto.MaxLength = 32767;
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.PasswordChar = '\0';
            this.TxtMonto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMonto.SelectedText = "";
            this.TxtMonto.SelectionLength = 0;
            this.TxtMonto.SelectionStart = 0;
            this.TxtMonto.ShortcutsEnabled = true;
            this.TxtMonto.Size = new System.Drawing.Size(130, 23);
            this.TxtMonto.TabIndex = 11;
            this.TxtMonto.UseSelectable = true;
            this.TxtMonto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMonto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMonto_KeyPress);
            // 
            // CboIDVenta
            // 
            this.CboIDVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboIDVenta.FormattingEnabled = true;
            this.CboIDVenta.Location = new System.Drawing.Point(162, 175);
            this.CboIDVenta.Name = "CboIDVenta";
            this.CboIDVenta.Size = new System.Drawing.Size(130, 21);
            this.CboIDVenta.TabIndex = 19;
            this.CboIDVenta.SelectedIndexChanged += new System.EventHandler(this.CboIDVenta_SelectedIndexChanged);
            // 
            // CboTipoPago
            // 
            this.CboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoPago.FormattingEnabled = true;
            this.CboTipoPago.Location = new System.Drawing.Point(162, 215);
            this.CboTipoPago.Name = "CboTipoPago";
            this.CboTipoPago.Size = new System.Drawing.Size(130, 21);
            this.CboTipoPago.TabIndex = 20;
            this.CboTipoPago.SelectedIndexChanged += new System.EventHandler(this.CboTipoPago_SelectedIndexChanged);
            // 
            // AgregarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CboTipoPago);
            this.Controls.Add(this.CboIDVenta);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TxtMonto);
            this.Name = "AgregarPago";
            this.Text = "AgregarPago";
            this.Load += new System.EventHandler(this.AgregarPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton BtnAgregar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtMonto;
        private System.Windows.Forms.ComboBox CboIDVenta;
        private System.Windows.Forms.ComboBox CboTipoPago;
    }
}