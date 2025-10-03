namespace WindowsFormsApp1
{
    partial class Login
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
            this.saioaHasiBotoia = new System.Windows.Forms.Button();
            this.erabiltzaileLabel = new System.Windows.Forms.Label();
            this.pasahitzaLabel = new System.Windows.Forms.Label();
            this.erabiltzaileTextbox = new System.Windows.Forms.TextBox();
            this.pasahitzaTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saioaHasiBotoia
            // 
            this.saioaHasiBotoia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saioaHasiBotoia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.saioaHasiBotoia.Location = new System.Drawing.Point(337, 299);
            this.saioaHasiBotoia.Name = "saioaHasiBotoia";
            this.saioaHasiBotoia.Size = new System.Drawing.Size(147, 47);
            this.saioaHasiBotoia.TabIndex = 0;
            this.saioaHasiBotoia.Text = "Saioa Hasi";
            this.saioaHasiBotoia.UseVisualStyleBackColor = false;
            // 
            // erabiltzaileLabel
            // 
            this.erabiltzaileLabel.AutoSize = true;
            this.erabiltzaileLabel.Location = new System.Drawing.Point(294, 142);
            this.erabiltzaileLabel.Name = "erabiltzaileLabel";
            this.erabiltzaileLabel.Size = new System.Drawing.Size(81, 16);
            this.erabiltzaileLabel.TabIndex = 1;
            this.erabiltzaileLabel.Text = "Erabiltzailea";
            // 
            // pasahitzaLabel
            // 
            this.pasahitzaLabel.AutoSize = true;
            this.pasahitzaLabel.Location = new System.Drawing.Point(294, 217);
            this.pasahitzaLabel.Name = "pasahitzaLabel";
            this.pasahitzaLabel.Size = new System.Drawing.Size(66, 16);
            this.pasahitzaLabel.TabIndex = 2;
            this.pasahitzaLabel.Text = "Pasahitza";
            // 
            // erabiltzaileTextbox
            // 
            this.erabiltzaileTextbox.Location = new System.Drawing.Point(409, 134);
            this.erabiltzaileTextbox.Name = "erabiltzaileTextbox";
            this.erabiltzaileTextbox.Size = new System.Drawing.Size(117, 22);
            this.erabiltzaileTextbox.TabIndex = 3;
            // 
            // pasahitzaTextbox
            // 
            this.pasahitzaTextbox.Location = new System.Drawing.Point(409, 217);
            this.pasahitzaTextbox.Name = "pasahitzaTextbox";
            this.pasahitzaTextbox.Size = new System.Drawing.Size(117, 22);
            this.pasahitzaTextbox.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pasahitzaTextbox);
            this.Controls.Add(this.erabiltzaileTextbox);
            this.Controls.Add(this.pasahitzaLabel);
            this.Controls.Add(this.erabiltzaileLabel);
            this.Controls.Add(this.saioaHasiBotoia);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saioaHasiBotoia;
        private System.Windows.Forms.Label erabiltzaileLabel;
        private System.Windows.Forms.Label pasahitzaLabel;
        private System.Windows.Forms.TextBox erabiltzaileTextbox;
        private System.Windows.Forms.TextBox pasahitzaTextbox;
    }
}

