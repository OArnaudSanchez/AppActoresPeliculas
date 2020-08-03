namespace AppAdminPeliculas.FormPeliculas
{
    partial class ModificarPelicula
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cGeneroPelicula = new System.Windows.Forms.ComboBox();
            this.tID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataPeliculas = new System.Windows.Forms.DataGridView();
            this.tTituloPelicula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargarFotoPelicula = new System.Windows.Forms.Button();
            this.dateFechaPelicula = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ComponenteImagenPeliculas = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNuevaPelicula = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComponenteImagenPeliculas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cGeneroPelicula);
            this.panel1.Controls.Add(this.tID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataPeliculas);
            this.panel1.Controls.Add(this.tTituloPelicula);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCargarFotoPelicula);
            this.panel1.Controls.Add(this.dateFechaPelicula);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ComponenteImagenPeliculas);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnNuevaPelicula);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 480);
            this.panel1.TabIndex = 8;
            // 
            // cGeneroPelicula
            // 
            this.cGeneroPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cGeneroPelicula.FormattingEnabled = true;
            this.cGeneroPelicula.Items.AddRange(new object[] {
            "Accion",
            "Aventuras",
            "Comedias",
            "Drama",
            "Terror",
            "Musical",
            "Ciencia Ficcion",
            "Guerra o Belicas",
            "Western",
            "Crimen",
            "Suspenso",
            "Infantil",
            "Anime"});
            this.cGeneroPelicula.Location = new System.Drawing.Point(135, 116);
            this.cGeneroPelicula.Name = "cGeneroPelicula";
            this.cGeneroPelicula.Size = new System.Drawing.Size(198, 24);
            this.cGeneroPelicula.TabIndex = 62;
            // 
            // tID
            // 
            this.tID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tID.Location = new System.Drawing.Point(135, 27);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(61, 24);
            this.tID.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 21);
            this.label5.TabIndex = 59;
            this.label5.Text = "Lista de Peliculas";
            // 
            // dataPeliculas
            // 
            this.dataPeliculas.AllowUserToAddRows = false;
            this.dataPeliculas.AllowUserToDeleteRows = false;
            this.dataPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPeliculas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataPeliculas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataPeliculas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPeliculas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataPeliculas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataPeliculas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPeliculas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPeliculas.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPeliculas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataPeliculas.EnableHeadersVisualStyles = false;
            this.dataPeliculas.GridColor = System.Drawing.Color.SteelBlue;
            this.dataPeliculas.Location = new System.Drawing.Point(9, 303);
            this.dataPeliculas.Name = "dataPeliculas";
            this.dataPeliculas.ReadOnly = true;
            this.dataPeliculas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPeliculas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataPeliculas.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataPeliculas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPeliculas.Size = new System.Drawing.Size(623, 170);
            this.dataPeliculas.TabIndex = 58;
            this.dataPeliculas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataActores_CellClick);
            // 
            // tTituloPelicula
            // 
            this.tTituloPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTituloPelicula.Location = new System.Drawing.Point(135, 70);
            this.tTituloPelicula.Name = "tTituloPelicula";
            this.tTituloPelicula.Size = new System.Drawing.Size(198, 24);
            this.tTituloPelicula.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Genero:";
            // 
            // btnCargarFotoPelicula
            // 
            this.btnCargarFotoPelicula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargarFotoPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarFotoPelicula.Location = new System.Drawing.Point(375, 230);
            this.btnCargarFotoPelicula.Name = "btnCargarFotoPelicula";
            this.btnCargarFotoPelicula.Size = new System.Drawing.Size(231, 26);
            this.btnCargarFotoPelicula.TabIndex = 53;
            this.btnCargarFotoPelicula.Text = "Cargar Foto";
            this.btnCargarFotoPelicula.UseVisualStyleBackColor = true;
            this.btnCargarFotoPelicula.Click += new System.EventHandler(this.btnCargarFotoPelicula_Click);
            // 
            // dateFechaPelicula
            // 
            this.dateFechaPelicula.Location = new System.Drawing.Point(135, 171);
            this.dateFechaPelicula.Name = "dateFechaPelicula";
            this.dateFechaPelicula.Size = new System.Drawing.Size(198, 20);
            this.dateFechaPelicula.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(468, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 50;
            this.label6.Text = "Foto:";
            // 
            // ComponenteImagenPeliculas
            // 
            this.ComponenteImagenPeliculas.Location = new System.Drawing.Point(375, 39);
            this.ComponenteImagenPeliculas.Name = "ComponenteImagenPeliculas";
            this.ComponenteImagenPeliculas.Size = new System.Drawing.Size(231, 176);
            this.ComponenteImagenPeliculas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ComponenteImagenPeliculas.TabIndex = 49;
            this.ComponenteImagenPeliculas.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Fecha de Estreno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Titulo:";
            // 
            // btnNuevaPelicula
            // 
            this.btnNuevaPelicula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevaPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaPelicula.Location = new System.Drawing.Point(65, 224);
            this.btnNuevaPelicula.Name = "btnNuevaPelicula";
            this.btnNuevaPelicula.Size = new System.Drawing.Size(110, 39);
            this.btnNuevaPelicula.TabIndex = 42;
            this.btnNuevaPelicula.Text = "Modificar Pelicula";
            this.btnNuevaPelicula.UseVisualStyleBackColor = true;
            this.btnNuevaPelicula.Click += new System.EventHandler(this.btnNuevaPelicula_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bCerrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 61);
            this.panel2.TabIndex = 7;
            // 
            // bCerrar
            // 
            this.bCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCerrar.FlatAppearance.BorderSize = 0;
            this.bCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCerrar.Image = global::AppAdminPeliculas.Properties.Resources.salir;
            this.bCerrar.Location = new System.Drawing.Point(614, 3);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(30, 28);
            this.bCerrar.TabIndex = 12;
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Modificar Peliculas";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ModificarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarPelicula";
            this.Load += new System.EventHandler(this.ModificarPelicula_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComponenteImagenPeliculas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataPeliculas;
        private System.Windows.Forms.TextBox tTituloPelicula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargarFotoPelicula;
        private System.Windows.Forms.DateTimePicker dateFechaPelicula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox ComponenteImagenPeliculas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevaPelicula;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cGeneroPelicula;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}