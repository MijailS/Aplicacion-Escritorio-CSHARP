
namespace AppEscritorio.Vista
{
    partial class AgregarLibro
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
            this.ISBN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Valor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtIMG = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtResenia = new System.Windows.Forms.TextBox();
            this.TxtIsbn = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtPaginas = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.Txtauid = new System.Windows.Forms.TextBox();
            this.txtanio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN.Location = new System.Drawing.Point(367, 67);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(60, 25);
            this.ISBN.TabIndex = 4;
            this.ISBN.Text = "ISBN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titulo";
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor.Location = new System.Drawing.Point(367, 148);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(62, 25);
            this.Valor.TabIndex = 7;
            this.Valor.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Paginas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(676, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(676, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Img";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(676, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Autor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(676, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Año de edición";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(450, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Reseña";
            // 
            // TxtIMG
            // 
            this.TxtIMG.Location = new System.Drawing.Point(539, 188);
            this.TxtIMG.Name = "TxtIMG";
            this.TxtIMG.Size = new System.Drawing.Size(131, 20);
            this.TxtIMG.TabIndex = 20;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Moccasin;
            this.BtnAgregar.Location = new System.Drawing.Point(407, 360);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(191, 35);
            this.BtnAgregar.TabIndex = 23;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(230, 110);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(131, 20);
            this.TxtTitulo.TabIndex = 24;
            // 
            // TxtResenia
            // 
            this.TxtResenia.Location = new System.Drawing.Point(313, 305);
            this.TxtResenia.Name = "TxtResenia";
            this.TxtResenia.Size = new System.Drawing.Size(370, 20);
            this.TxtResenia.TabIndex = 25;
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.Location = new System.Drawing.Point(230, 73);
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(131, 20);
            this.TxtIsbn.TabIndex = 28;
            this.TxtIsbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIsbn_KeyPress);
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(230, 153);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(131, 20);
            this.TxtValor.TabIndex = 29;
            this.TxtValor.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // TxtPaginas
            // 
            this.TxtPaginas.Location = new System.Drawing.Point(230, 190);
            this.TxtPaginas.Name = "TxtPaginas";
            this.TxtPaginas.Size = new System.Drawing.Size(131, 20);
            this.TxtPaginas.TabIndex = 30;
            this.TxtPaginas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPaginas_KeyPress);
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(539, 153);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(131, 20);
            this.TxtStock.TabIndex = 31;
            this.TxtStock.TextChanged += new System.EventHandler(this.TxtStock_TextChanged);
            this.TxtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStock_KeyPress);
            // 
            // Txtauid
            // 
            this.Txtauid.Location = new System.Drawing.Point(539, 71);
            this.Txtauid.Name = "Txtauid";
            this.Txtauid.Size = new System.Drawing.Size(131, 20);
            this.Txtauid.TabIndex = 32;
            // 
            // txtanio
            // 
            this.txtanio.Location = new System.Drawing.Point(539, 110);
            this.txtanio.Name = "txtanio";
            this.txtanio.Size = new System.Drawing.Size(131, 20);
            this.txtanio.TabIndex = 34;
            this.txtanio.TextChanged += new System.EventHandler(this.txtanio_TextChanged);
            this.txtanio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtanio_KeyPress);
            // 
            // AgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 474);
            this.Controls.Add(this.txtanio);
            this.Controls.Add(this.Txtauid);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.TxtPaginas);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.TxtIsbn);
            this.Controls.Add(this.TxtResenia);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtIMG);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ISBN);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AgregarLibro";
            this.Text = "AgregarLibro";
            this.Load += new System.EventHandler(this.AgregarLibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtIMG;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtResenia;
        private System.Windows.Forms.TextBox TxtIsbn;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtPaginas;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.TextBox Txtauid;
        private System.Windows.Forms.TextBox txtanio;
    }
}