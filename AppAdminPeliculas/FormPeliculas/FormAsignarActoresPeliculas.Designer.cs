namespace AppAdminPeliculas.FormPeliculas
{
    partial class FormAsignarActoresPeliculas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tNombreActor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNuevaPelicula = new System.Windows.Forms.Button();
            this.dataActoresPeliculas = new System.Windows.Forms.DataGridView();
            this.tFechaActor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tTituloPelicula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tEstrenoPelicula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bBuscarPelicula = new System.Windows.Forms.Button();
            this.bBuscarActor = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataActoresPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bCerrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 61);
            this.panel2.TabIndex = 6;
            // 
            // bCerrar
            // 
            this.bCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCerrar.FlatAppearance.BorderSize = 0;
            this.bCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCerrar.Image = global::AppAdminPeliculas.Properties.Resources.salir;
            this.bCerrar.Location = new System.Drawing.Point(767, 3);
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
            this.label1.Location = new System.Drawing.Point(280, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Agregar Peliculas";
            // 
            // tNombreActor
            // 
            this.tNombreActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombreActor.Location = new System.Drawing.Point(107, 94);
            this.tNombreActor.Name = "tNombreActor";
            this.tNombreActor.ReadOnly = true;
            this.tNombreActor.Size = new System.Drawing.Size(151, 24);
            this.tNombreActor.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nombre Actor";
            // 
            // btnNuevaPelicula
            // 
            this.btnNuevaPelicula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevaPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaPelicula.Location = new System.Drawing.Point(91, 292);
            this.btnNuevaPelicula.Name = "btnNuevaPelicula";
            this.btnNuevaPelicula.Size = new System.Drawing.Size(98, 39);
            this.btnNuevaPelicula.TabIndex = 59;
            this.btnNuevaPelicula.Text = "Guardar";
            this.btnNuevaPelicula.UseVisualStyleBackColor = true;
            this.btnNuevaPelicula.Click += new System.EventHandler(this.btnNuevaPelicula_Click);
            // 
            // dataActoresPeliculas
            // 
            this.dataActoresPeliculas.AllowUserToAddRows = false;
            this.dataActoresPeliculas.AllowUserToDeleteRows = false;
            this.dataActoresPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataActoresPeliculas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataActoresPeliculas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataActoresPeliculas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataActoresPeliculas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataActoresPeliculas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataActoresPeliculas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataActoresPeliculas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataActoresPeliculas.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataActoresPeliculas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataActoresPeliculas.EnableHeadersVisualStyles = false;
            this.dataActoresPeliculas.GridColor = System.Drawing.Color.SteelBlue;
            this.dataActoresPeliculas.Location = new System.Drawing.Point(342, 78);
            this.dataActoresPeliculas.Name = "dataActoresPeliculas";
            this.dataActoresPeliculas.ReadOnly = true;
            this.dataActoresPeliculas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataActoresPeliculas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataActoresPeliculas.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataActoresPeliculas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataActoresPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataActoresPeliculas.Size = new System.Drawing.Size(446, 253);
            this.dataActoresPeliculas.TabIndex = 63;
            // 
            // tFechaActor
            // 
            this.tFechaActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tFechaActor.Location = new System.Drawing.Point(107, 126);
            this.tFechaActor.Name = "tFechaActor";
            this.tFechaActor.ReadOnly = true;
            this.tFechaActor.Size = new System.Drawing.Size(151, 24);
            this.tFechaActor.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Nacimiento";
            // 
            // tTituloPelicula
            // 
            this.tTituloPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTituloPelicula.Location = new System.Drawing.Point(107, 195);
            this.tTituloPelicula.Name = "tTituloPelicula";
            this.tTituloPelicula.ReadOnly = true;
            this.tTituloPelicula.Size = new System.Drawing.Size(151, 24);
            this.tTituloPelicula.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Titulo Pelicula:";
            // 
            // tEstrenoPelicula
            // 
            this.tEstrenoPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEstrenoPelicula.Location = new System.Drawing.Point(107, 228);
            this.tEstrenoPelicula.Name = "tEstrenoPelicula";
            this.tEstrenoPelicula.ReadOnly = true;
            this.tEstrenoPelicula.Size = new System.Drawing.Size(151, 24);
            this.tEstrenoPelicula.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Estreno:";
            // 
            // bBuscarPelicula
            // 
            this.bBuscarPelicula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bBuscarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBuscarPelicula.Location = new System.Drawing.Point(268, 204);
            this.bBuscarPelicula.Name = "bBuscarPelicula";
            this.bBuscarPelicula.Size = new System.Drawing.Size(56, 39);
            this.bBuscarPelicula.TabIndex = 70;
            this.bBuscarPelicula.Text = "Buscar Pelicula";
            this.bBuscarPelicula.UseVisualStyleBackColor = true;
            this.bBuscarPelicula.Click += new System.EventHandler(this.bBuscarPelicula_Click);
            // 
            // bBuscarActor
            // 
            this.bBuscarActor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bBuscarActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBuscarActor.Location = new System.Drawing.Point(268, 106);
            this.bBuscarActor.Name = "bBuscarActor";
            this.bBuscarActor.Size = new System.Drawing.Size(56, 39);
            this.bBuscarActor.TabIndex = 71;
            this.bBuscarActor.Text = "Buscar Actor";
            this.bBuscarActor.UseVisualStyleBackColor = true;
            this.bBuscarActor.Click += new System.EventHandler(this.bBuscarActor_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAsignarActoresPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 343);
            this.Controls.Add(this.bBuscarActor);
            this.Controls.Add(this.bBuscarPelicula);
            this.Controls.Add(this.tEstrenoPelicula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tTituloPelicula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tFechaActor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataActoresPeliculas);
            this.Controls.Add(this.btnNuevaPelicula);
            this.Controls.Add(this.tNombreActor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAsignarActoresPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAsignarActoresPeliculas";
            this.Load += new System.EventHandler(this.FormAsignarActoresPeliculas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataActoresPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNombreActor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevaPelicula;
        private System.Windows.Forms.DataGridView dataActoresPeliculas;
        private System.Windows.Forms.TextBox tFechaActor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tTituloPelicula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tEstrenoPelicula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bBuscarPelicula;
        private System.Windows.Forms.Button bBuscarActor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}