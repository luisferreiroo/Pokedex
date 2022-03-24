
namespace Pokedex2022_CSharp
{
    partial class Ventana2
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
            this.caja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // caja
            // 
            this.caja.Location = new System.Drawing.Point(245, 143);
            this.caja.Name = "caja";
            this.caja.Size = new System.Drawing.Size(100, 23);
            this.caja.TabIndex = 0;
            // 
            // Ventana2
            // 
            this.ClientSize = new System.Drawing.Size(612, 395);
            this.Controls.Add(this.caja);
            this.Name = "Ventana2";
            this.Load += new System.EventHandler(this.Ventana2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cajaDescripcion;
        private System.Windows.Forms.Label caja;
    }
}   