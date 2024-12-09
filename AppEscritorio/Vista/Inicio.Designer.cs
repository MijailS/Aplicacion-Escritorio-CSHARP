
namespace AppEscritorio
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnVenta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Binicio = new System.Windows.Forms.Button();
            this.Bbodega = new System.Windows.Forms.Button();
            this.BcerrarSesion = new System.Windows.Forms.Button();
            this.Balphilia = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BinventarioLibros = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnGestionar = new System.Windows.Forms.Button();
            this.MGVSolicitudes = new MetroFramework.Controls.MetroGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.TxtRun = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MGVSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(309, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "bodega - inicio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnVenta
            // 
            this.BtnVenta.BackColor = System.Drawing.Color.White;
            this.BtnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVenta.Location = new System.Drawing.Point(34, 448);
            this.BtnVenta.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVenta.Name = "BtnVenta";
            this.BtnVenta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnVenta.Size = new System.Drawing.Size(121, 33);
            this.BtnVenta.TabIndex = 6;
            this.BtnVenta.Text = "Solicitudes";
            this.BtnVenta.UseVisualStyleBackColor = false;
            this.BtnVenta.Click += new System.EventHandler(this.Solicitudes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.Binicio);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.Bbodega);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.BcerrarSesion);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Balphilia);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtnVenta);
            this.panel1.Location = new System.Drawing.Point(10, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 622);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Binicio
            // 
            this.Binicio.BackColor = System.Drawing.Color.White;
            this.Binicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Binicio.Location = new System.Drawing.Point(34, 121);
            this.Binicio.Margin = new System.Windows.Forms.Padding(2);
            this.Binicio.Name = "Binicio";
            this.Binicio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Binicio.Size = new System.Drawing.Size(121, 33);
            this.Binicio.TabIndex = 12;
            this.Binicio.Text = "Inicio";
            this.Binicio.UseVisualStyleBackColor = false;
            this.Binicio.Click += new System.EventHandler(this.Binicio_Click);
            // 
            // Bbodega
            // 
            this.Bbodega.BackColor = System.Drawing.Color.White;
            this.Bbodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bbodega.Location = new System.Drawing.Point(35, 239);
            this.Bbodega.Margin = new System.Windows.Forms.Padding(2);
            this.Bbodega.Name = "Bbodega";
            this.Bbodega.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Bbodega.Size = new System.Drawing.Size(121, 33);
            this.Bbodega.TabIndex = 10;
            this.Bbodega.Text = "Bodega";
            this.Bbodega.UseVisualStyleBackColor = false;
            this.Bbodega.Click += new System.EventHandler(this.Bbodega_Click);
            // 
            // BcerrarSesion
            // 
            this.BcerrarSesion.BackColor = System.Drawing.Color.White;
            this.BcerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BcerrarSesion.Location = new System.Drawing.Point(34, 553);
            this.BcerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.BcerrarSesion.Name = "BcerrarSesion";
            this.BcerrarSesion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BcerrarSesion.Size = new System.Drawing.Size(121, 33);
            this.BcerrarSesion.TabIndex = 8;
            this.BcerrarSesion.Text = "Cerrar Sesión";
            this.BcerrarSesion.UseVisualStyleBackColor = false;
            this.BcerrarSesion.Click += new System.EventHandler(this.BcerrarSesion_Click);
            // 
            // Balphilia
            // 
            this.Balphilia.BackColor = System.Drawing.Color.White;
            this.Balphilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balphilia.Location = new System.Drawing.Point(34, 339);
            this.Balphilia.Margin = new System.Windows.Forms.Padding(2);
            this.Balphilia.Name = "Balphilia";
            this.Balphilia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Balphilia.Size = new System.Drawing.Size(121, 33);
            this.Balphilia.TabIndex = 6;
            this.Balphilia.Text = "Administrar";
            this.Balphilia.UseVisualStyleBackColor = false;
            this.Balphilia.Click += new System.EventHandler(this.Balphilia_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(813, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 622);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Solicitudes Alphilia";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.pictureBox7);
            this.panel6.Location = new System.Drawing.Point(24, 44);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(465, 300);
            this.panel6.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pictureBox6);
            this.panel5.Controls.Add(this.BinventarioLibros);
            this.panel5.Location = new System.Drawing.Point(124, 433);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(283, 153);
            this.panel5.TabIndex = 10;
            // 
            // BinventarioLibros
            // 
            this.BinventarioLibros.BackColor = System.Drawing.Color.Transparent;
            this.BinventarioLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinventarioLibros.Location = new System.Drawing.Point(21, 92);
            this.BinventarioLibros.Margin = new System.Windows.Forms.Padding(2);
            this.BinventarioLibros.Name = "BinventarioLibros";
            this.BinventarioLibros.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BinventarioLibros.Size = new System.Drawing.Size(222, 44);
            this.BinventarioLibros.TabIndex = 14;
            this.BinventarioLibros.Text = "Inventario Alphilia";
            this.BinventarioLibros.UseVisualStyleBackColor = false;
            this.BinventarioLibros.Click += new System.EventHandler(this.BinventarioLibros_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.BtnGestionar);
            this.panel3.Controls.Add(this.pictureBox8);
            this.panel3.Controls.Add(this.MGVSolicitudes);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(299, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 622);
            this.panel3.TabIndex = 9;
            // 
            // BtnGestionar
            // 
            this.BtnGestionar.BackColor = System.Drawing.Color.White;
            this.BtnGestionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionar.Location = new System.Drawing.Point(149, 433);
            this.BtnGestionar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGestionar.Name = "BtnGestionar";
            this.BtnGestionar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnGestionar.Size = new System.Drawing.Size(244, 82);
            this.BtnGestionar.TabIndex = 13;
            this.BtnGestionar.Text = "Gestionar Solicitudes";
            this.BtnGestionar.UseVisualStyleBackColor = false;
            this.BtnGestionar.Click += new System.EventHandler(this.BtnGestionar_Click);
            // 
            // MGVSolicitudes
            // 
            this.MGVSolicitudes.AllowUserToAddRows = false;
            this.MGVSolicitudes.AllowUserToDeleteRows = false;
            this.MGVSolicitudes.AllowUserToResizeColumns = false;
            this.MGVSolicitudes.AllowUserToResizeRows = false;
            this.MGVSolicitudes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGVSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MGVSolicitudes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MGVSolicitudes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGVSolicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MGVSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MGVSolicitudes.DefaultCellStyle = dataGridViewCellStyle2;
            this.MGVSolicitudes.Enabled = false;
            this.MGVSolicitudes.EnableHeadersVisualStyles = false;
            this.MGVSolicitudes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MGVSolicitudes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGVSolicitudes.Location = new System.Drawing.Point(16, 60);
            this.MGVSolicitudes.Name = "MGVSolicitudes";
            this.MGVSolicitudes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGVSolicitudes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MGVSolicitudes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MGVSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MGVSolicitudes.Size = new System.Drawing.Size(441, 319);
            this.MGVSolicitudes.TabIndex = 11;
            this.MGVSolicitudes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MGVSolicitudes_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Solicitudes online";
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(656, 18);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(209, 38);
            this.TxtTipo.TabIndex = 10;
            this.TxtTipo.Text = "sasas";
            this.TxtTipo.Visible = false;
            // 
            // TxtRun
            // 
            this.TxtRun.Location = new System.Drawing.Point(937, 18);
            this.TxtRun.Name = "TxtRun";
            this.TxtRun.Size = new System.Drawing.Size(209, 38);
            this.TxtRun.TabIndex = 32;
            this.TxtRun.Text = "sasas";
            this.TxtRun.Visible = false;
            this.TxtRun.TextChanged += new System.EventHandler(this.TxtRun_TextChanged);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::AppEscritorio.Properties.Resources.caracteristicas;
            this.pictureBox8.Location = new System.Drawing.Point(25, 433);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(120, 82);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::AppEscritorio.Properties.Resources.YoMijail;
            this.pictureBox7.Location = new System.Drawing.Point(0, 2);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(463, 298);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AppEscritorio.Properties.Resources.book_icon_158035;
            this.pictureBox6.Location = new System.Drawing.Point(22, 15);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(221, 82);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AppEscritorio.Properties.Resources.home_icon_icons_com_73532;
            this.pictureBox5.Location = new System.Drawing.Point(35, 44);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(120, 82);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AppEscritorio.Properties.Resources._3615744_barcode_delivery_order_package_parcel_shipment_tracking_number_107911;
            this.pictureBox4.Location = new System.Drawing.Point(35, 153);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 82);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AppEscritorio.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.pictureBox3.Location = new System.Drawing.Point(35, 476);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppEscritorio.Properties.Resources.protection_manage_icon_216363;
            this.pictureBox2.Location = new System.Drawing.Point(35, 276);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppEscritorio.Properties.Resources._1492532808_5_shopping_bag_83223;
            this.pictureBox1.Location = new System.Drawing.Point(35, 371);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 725);
            this.Controls.Add(this.TxtRun);
            this.Controls.Add(this.TxtTipo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "Inicio";
            this.ShowInTaskbar = false;
            this.Text = "App Escritorio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MGVSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnVenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button Binicio;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Bbodega;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BcerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Balphilia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button BinventarioLibros;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGestionar;
        private System.Windows.Forms.PictureBox pictureBox8;
        private MetroFramework.Controls.MetroGrid MGVSolicitudes;
        public System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.TextBox TxtRun;
    }
}

