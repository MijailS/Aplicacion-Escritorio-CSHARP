
namespace AppEscritorio.Vista
{
    partial class Alphilia
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvlibros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DgvInsumosAlphilia = new System.Windows.Forms.DataGridView();
            this.TxtInsumos = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibros)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInsumosAlphilia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.dgvlibros);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(114, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 678);
            this.panel2.TabIndex = 13;
            // 
            // dgvlibros
            // 
            this.dgvlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlibros.Location = new System.Drawing.Point(3, 70);
            this.dgvlibros.Name = "dgvlibros";
            this.dgvlibros.Size = new System.Drawing.Size(569, 277);
            this.dgvlibros.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "📚 Libros Disponibles 📚";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.DgvInsumosAlphilia);
            this.panel3.Controls.Add(this.TxtInsumos);
            this.panel3.Location = new System.Drawing.Point(828, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 678);
            this.panel3.TabIndex = 14;
            // 
            // DgvInsumosAlphilia
            // 
            this.DgvInsumosAlphilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInsumosAlphilia.Location = new System.Drawing.Point(0, 70);
            this.DgvInsumosAlphilia.Name = "DgvInsumosAlphilia";
            this.DgvInsumosAlphilia.Size = new System.Drawing.Size(560, 277);
            this.DgvInsumosAlphilia.TabIndex = 2;
            // 
            // TxtInsumos
            // 
            this.TxtInsumos.AutoSize = true;
            this.TxtInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInsumos.Location = new System.Drawing.Point(167, 15);
            this.TxtInsumos.Name = "TxtInsumos";
            this.TxtInsumos.Size = new System.Drawing.Size(262, 25);
            this.TxtInsumos.TabIndex = 1;
            this.TxtInsumos.Text = "📚 Insumos Disponibles 📚";
            this.TxtInsumos.Click += new System.EventHandler(this.label2_Click);
            // 
            // Alphilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 721);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Alphilia";
            this.Text = "Alphilia";
            this.Load += new System.EventHandler(this.Alphilia_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibros)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInsumosAlphilia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TxtInsumos;
        private System.Windows.Forms.DataGridView dgvlibros;
        private System.Windows.Forms.DataGridView DgvInsumosAlphilia;
    }
}