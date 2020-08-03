namespace AppAdminPeliculas.FormActores
{
    partial class ModificarActor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataActores = new System.Windows.Forms.DataGridView();
            this.cSexoActor = new System.Windows.Forms.ComboBox();
            this.tNombreActor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargarFotoActor = new System.Windows.Forms.Button();
            this.dateFechaActor = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ComponenteImagen = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificarActor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataActores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComponenteImagen)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataActores);
            this.panel1.Controls.Add(this.cSexoActor);
            this.panel1.Controls.Add(this.tNombreActor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCargarFotoActor);
            this.panel1.Controls.Add(this.dateFechaActor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ComponenteImagen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnModificarActor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 480);
            this.panel1.TabIndex = 6;
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
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 59;
            this.label5.Text = "Lista de Actores";
            // 
            // dataActores
            // 
            this.dataActores.AllowUserToAddRows = false;
            this.dataActores.AllowUserToDeleteRows = false;
            this.dataActores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataActores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataActores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataActores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataActores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataActores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataActores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataActores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataActores.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataActores.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataActores.EnableHeadersVisualStyles = false;
            this.dataActores.GridColor = System.Drawing.Color.SteelBlue;
            this.dataActores.Location = new System.Drawing.Point(9, 303);
            this.dataActores.Name = "dataActores";
            this.dataActores.ReadOnly = true;
            this.dataActores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataActores.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataActores.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataActores.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataActores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataActores.Size = new System.Drawing.Size(623, 170);
            this.dataActores.TabIndex = 58;
            this.dataActores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataActores_CellClick);
            // 
            // cSexoActor
            // 
            this.cSexoActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSexoActor.FormattingEnabled = true;
            this.cSexoActor.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cSexoActor.Location = new System.Drawing.Point(135, 121);
            this.cSexoActor.Name = "cSexoActor";
            this.cSexoActor.Size = new System.Drawing.Size(198, 24);
            this.cSexoActor.TabIndex = 57;
            // 
            // tNombreActor
            // 
            this.tNombreActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombreActor.Location = new System.Drawing.Point(135, 70);
            this.tNombreActor.Name = "tNombreActor";
            this.tNombreActor.Size = new System.Drawing.Size(198, 24);
            this.tNombreActor.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Sexo:";
            // 
            // btnCargarFotoActor
            // 
            this.btnCargarFotoActor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargarFotoActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarFotoActor.Location = new System.Drawing.Point(375, 230);
            this.btnCargarFotoActor.Name = "btnCargarFotoActor";
            this.btnCargarFotoActor.Size = new System.Drawing.Size(231, 26);
            this.btnCargarFotoActor.TabIndex = 53;
            this.btnCargarFotoActor.Text = "Cargar Foto";
            this.btnCargarFotoActor.UseVisualStyleBackColor = true;
            this.btnCargarFotoActor.Click += new System.EventHandler(this.btnCargarFotoActor_Click);
            // 
            // dateFechaActor
            // 
            this.dateFechaActor.Location = new System.Drawing.Point(135, 171);
            this.dateFechaActor.Name = "dateFechaActor";
            this.dateFechaActor.Size = new System.Drawing.Size(198, 20);
            this.dateFechaActor.TabIndex = 52;
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
            // ComponenteImagen
            // 
            this.ComponenteImagen.Location = new System.Drawing.Point(375, 39);
            this.ComponenteImagen.Name = "ComponenteImagen";
            this.ComponenteImagen.Size = new System.Drawing.Size(231, 176);
            this.ComponenteImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ComponenteImagen.TabIndex = 49;
            this.ComponenteImagen.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Fecha Nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre: ";
            // 
            // btnModificarActor
            // 
            this.btnModificarActor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificarActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarActor.Location = new System.Drawing.Point(65, 224);
            this.btnModificarActor.Name = "btnModificarActor";
            this.btnModificarActor.Size = new System.Drawing.Size(112, 39);
            this.btnModificarActor.TabIndex = 42;
            this.btnModificarActor.Text = "Modificar Actor";
            this.btnModificarActor.UseVisualStyleBackColor = true;
            this.btnModificarActor.Click += new System.EventHandler(this.btnModificarActor_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bCerrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 61);
            this.panel2.TabIndex = 5;
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
            this.label1.Size = new System.Drawing.Size(209, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Modificar Actores";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // ModificarActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarActor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarActor";
            this.Load += new System.EventHandler(this.ModificarActor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataActores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComponenteImagen)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cSexoActor;
        private System.Windows.Forms.TextBox tNombreActor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargarFotoActor;
        private System.Windows.Forms.DateTimePicker dateFechaActor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox ComponenteImagen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificarActor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataActores;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}