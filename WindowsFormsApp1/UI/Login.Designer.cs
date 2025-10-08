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
            // Login (form)
            // 
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 255); // Fondo suave
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // saioaHasiBotoia
            // 
            this.saioaHasiBotoia.BackColor = System.Drawing.Color.FromArgb(70, 130, 180); // Azul
            this.saioaHasiBotoia.ForeColor = System.Drawing.Color.White;
            this.saioaHasiBotoia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saioaHasiBotoia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
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
            this.erabiltzaileLabel.Size = new System.Drawing.Size(81, 19);
            this.erabiltzaileLabel.TabIndex = 1;
            this.erabiltzaileLabel.Text = "Erabiltzailea";
            this.erabiltzaileLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            // 
            // pasahitzaLabel
            // 
            this.pasahitzaLabel.AutoSize = true;
            this.pasahitzaLabel.Location = new System.Drawing.Point(294, 217);
            this.pasahitzaLabel.Name = "pasahitzaLabel";
            this.pasahitzaLabel.Size = new System.Drawing.Size(140, 19);
            this.pasahitzaLabel.TabIndex = 2;
            this.pasahitzaLabel.Text = "Pasahitza";
            this.pasahitzaLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            // 
            // erabiltzaileTextbox
            // 
            this.erabiltzaileTextbox.Location = new System.Drawing.Point(409, 134);
            this.erabiltzaileTextbox.Name = "erabiltzaileTextbox";
            this.erabiltzaileTextbox.Size = new System.Drawing.Size(180, 25);
            this.erabiltzaileTextbox.TabIndex = 3;
            this.erabiltzaileTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // pasahitzaTextbox
            // 
            this.pasahitzaTextbox.Location = new System.Drawing.Point(409, 217);
            this.pasahitzaTextbox.Name = "pasahitzaTextbox";
            this.pasahitzaTextbox.Size = new System.Drawing.Size(180, 25);
            this.pasahitzaTextbox.TabIndex = 4;
            this.pasahitzaTextbox.PasswordChar = '*';
            this.pasahitzaTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.Text = "Inicio de sesión";
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

