
namespace Pokedex
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.izquierda = new System.Windows.Forms.Button();
            this.derecha = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(57, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 142);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // izquierda
            // 
            this.izquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izquierda.ForeColor = System.Drawing.SystemColors.Control;
            this.izquierda.Location = new System.Drawing.Point(214, 364);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(29, 25);
            this.izquierda.TabIndex = 1;
            this.izquierda.Text = "<";
            this.izquierda.UseVisualStyleBackColor = false;
            this.izquierda.Click += new System.EventHandler(this.button1_Click);
            // 
            // derecha
            // 
            this.derecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.derecha.ForeColor = System.Drawing.SystemColors.Control;
            this.derecha.Location = new System.Drawing.Point(259, 363);
            this.derecha.Name = "derecha";
            this.derecha.Size = new System.Drawing.Size(27, 26);
            this.derecha.TabIndex = 2;
            this.derecha.Text = ">";
            this.derecha.UseVisualStyleBackColor = false;
            this.derecha.Click += new System.EventHandler(this.button2_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.Color.Lime;
            this.nombrePokemon.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombrePokemon.Location = new System.Drawing.Point(431, 150);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(100, 23);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(636, 472);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 496);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.derecha);
            this.Controls.Add(this.izquierda);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button izquierda;
        private System.Windows.Forms.Button derecha;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

