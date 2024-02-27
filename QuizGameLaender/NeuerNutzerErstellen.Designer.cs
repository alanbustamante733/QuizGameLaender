namespace QuizGameLaender
{
    partial class NeuerNutzerErstellen
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
            this.labelNeuerNutzer = new System.Windows.Forms.Label();
            this.labelNutzerName = new System.Windows.Forms.Label();
            this.textBoxNutzerName = new System.Windows.Forms.TextBox();
            this.labelPasswort = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.buttonNeuerNutzerErstellen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNeuerNutzer
            // 
            this.labelNeuerNutzer.AutoSize = true;
            this.labelNeuerNutzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNeuerNutzer.Location = new System.Drawing.Point(26, 57);
            this.labelNeuerNutzer.Name = "labelNeuerNutzer";
            this.labelNeuerNutzer.Size = new System.Drawing.Size(587, 32);
            this.labelNeuerNutzer.TabIndex = 0;
            this.labelNeuerNutzer.Text = "Daten von dem neuen Nutzer geben, bitte.";
            // 
            // labelNutzerName
            // 
            this.labelNutzerName.AutoSize = true;
            this.labelNutzerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNutzerName.Location = new System.Drawing.Point(43, 146);
            this.labelNutzerName.Name = "labelNutzerName";
            this.labelNutzerName.Size = new System.Drawing.Size(113, 20);
            this.labelNutzerName.TabIndex = 3;
            this.labelNutzerName.Text = "Nutzer Name:";
            // 
            // textBoxNutzerName
            // 
            this.textBoxNutzerName.Location = new System.Drawing.Point(196, 144);
            this.textBoxNutzerName.Name = "textBoxNutzerName";
            this.textBoxNutzerName.Size = new System.Drawing.Size(190, 22);
            this.textBoxNutzerName.TabIndex = 4;
            // 
            // labelPasswort
            // 
            this.labelPasswort.AutoSize = true;
            this.labelPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswort.Location = new System.Drawing.Point(43, 195);
            this.labelPasswort.Name = "labelPasswort";
            this.labelPasswort.Size = new System.Drawing.Size(88, 20);
            this.labelPasswort.TabIndex = 5;
            this.labelPasswort.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(196, 193);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(190, 22);
            this.textBoxPassword.TabIndex = 6;
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(68, 251);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(147, 49);
            this.buttonAbbrechen.TabIndex = 7;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // buttonNeuerNutzerErstellen
            // 
            this.buttonNeuerNutzerErstellen.Location = new System.Drawing.Point(246, 251);
            this.buttonNeuerNutzerErstellen.Name = "buttonNeuerNutzerErstellen";
            this.buttonNeuerNutzerErstellen.Size = new System.Drawing.Size(149, 49);
            this.buttonNeuerNutzerErstellen.TabIndex = 8;
            this.buttonNeuerNutzerErstellen.Text = "Neuer Nutzer Erstellen";
            this.buttonNeuerNutzerErstellen.UseVisualStyleBackColor = true;
            this.buttonNeuerNutzerErstellen.Click += new System.EventHandler(this.buttonNeuerNutzerErstellen_Click);
            // 
            // NeuerNutzerErstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.buttonNeuerNutzerErstellen);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPasswort);
            this.Controls.Add(this.textBoxNutzerName);
            this.Controls.Add(this.labelNutzerName);
            this.Controls.Add(this.labelNeuerNutzer);
            this.Name = "NeuerNutzerErstellen";
            this.Text = "NeuerNutzerErstellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNeuerNutzer;
        private System.Windows.Forms.Label labelNutzerName;
        private System.Windows.Forms.TextBox textBoxNutzerName;
        private System.Windows.Forms.Label labelPasswort;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Button buttonNeuerNutzerErstellen;
    }
}