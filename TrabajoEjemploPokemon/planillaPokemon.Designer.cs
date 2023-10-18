
namespace TrabajoEjemploPokemon
{
    partial class planillaPokemon
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
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lblNombrePoke = new System.Windows.Forms.Label();
            this.lblNumeroPoke = new System.Windows.Forms.Label();
            this.lblDescripcionPoke = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbDebilidad = new System.Windows.Forms.Label();
            this.cboDebilidad = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.tbUrlImagen = new System.Windows.Forms.TextBox();
            this.pbxPokemon = new System.Windows.Forms.PictureBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(101, 51);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(164, 20);
            this.tbNumero.TabIndex = 0;
            this.tbNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(101, 79);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(164, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(101, 140);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(164, 33);
            this.tbDescripcion.TabIndex = 3;
            // 
            // lblNombrePoke
            // 
            this.lblNombrePoke.AutoSize = true;
            this.lblNombrePoke.Location = new System.Drawing.Point(48, 86);
            this.lblNombrePoke.Name = "lblNombrePoke";
            this.lblNombrePoke.Size = new System.Drawing.Size(47, 13);
            this.lblNombrePoke.TabIndex = 4;
            this.lblNombrePoke.Text = "Nombre:";
            // 
            // lblNumeroPoke
            // 
            this.lblNumeroPoke.AutoSize = true;
            this.lblNumeroPoke.Location = new System.Drawing.Point(48, 51);
            this.lblNumeroPoke.Name = "lblNumeroPoke";
            this.lblNumeroPoke.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroPoke.TabIndex = 5;
            this.lblNumeroPoke.Text = "Numero:";
            // 
            // lblDescripcionPoke
            // 
            this.lblDescripcionPoke.AutoSize = true;
            this.lblDescripcionPoke.Location = new System.Drawing.Point(29, 143);
            this.lblDescripcionPoke.Name = "lblDescripcionPoke";
            this.lblDescripcionPoke.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionPoke.TabIndex = 6;
            this.lblDescripcionPoke.Text = "Descripcion:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(163, 259);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 38);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(283, 259);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 38);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(61, 190);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(31, 13);
            this.lbTipo.TabIndex = 9;
            this.lbTipo.Text = "Tipo:";
            // 
            // lbDebilidad
            // 
            this.lbDebilidad.AutoSize = true;
            this.lbDebilidad.Location = new System.Drawing.Point(38, 223);
            this.lbDebilidad.Name = "lbDebilidad";
            this.lbDebilidad.Size = new System.Drawing.Size(54, 13);
            this.lbDebilidad.TabIndex = 10;
            this.lbDebilidad.Text = "Debilidad:";
            // 
            // cboDebilidad
            // 
            this.cboDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDebilidad.FormattingEnabled = true;
            this.cboDebilidad.Location = new System.Drawing.Point(101, 223);
            this.cboDebilidad.Name = "cboDebilidad";
            this.cboDebilidad.Size = new System.Drawing.Size(163, 21);
            this.cboDebilidad.TabIndex = 12;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(101, 190);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(164, 21);
            this.cboTipo.TabIndex = 13;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(48, 117);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(45, 13);
            this.lblUrlImagen.TabIndex = 15;
            this.lblUrlImagen.Text = "Imagen ";
            // 
            // tbUrlImagen
            // 
            this.tbUrlImagen.Location = new System.Drawing.Point(101, 110);
            this.tbUrlImagen.Name = "tbUrlImagen";
            this.tbUrlImagen.Size = new System.Drawing.Size(164, 20);
            this.tbUrlImagen.TabIndex = 14;
            this.tbUrlImagen.Leave += new System.EventHandler(this.tbUrlImagen_Leave);
            // 
            // pbxPokemon
            // 
            this.pbxPokemon.Location = new System.Drawing.Point(303, 51);
            this.pbxPokemon.Name = "pbxPokemon";
            this.pbxPokemon.Size = new System.Drawing.Size(222, 193);
            this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPokemon.TabIndex = 16;
            this.pbxPokemon.TabStop = false;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(271, 108);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(26, 23);
            this.btnCargarImagen.TabIndex = 17;
            this.btnCargarImagen.Text = "+";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // planillaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 321);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.pbxPokemon);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.tbUrlImagen);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.cboDebilidad);
            this.Controls.Add(this.lbDebilidad);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblDescripcionPoke);
            this.Controls.Add(this.lblNumeroPoke);
            this.Controls.Add(this.lblNombrePoke);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbNumero);
            this.Name = "planillaPokemon";
            this.Text = "                                              ";
            this.Load += new System.EventHandler(this.planillaPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lblNombrePoke;
        private System.Windows.Forms.Label lblNumeroPoke;
        private System.Windows.Forms.Label lblDescripcionPoke;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbDebilidad;
        private System.Windows.Forms.ComboBox cboDebilidad;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox tbUrlImagen;
        private System.Windows.Forms.PictureBox pbxPokemon;
        private System.Windows.Forms.Button btnCargarImagen;
    }
}