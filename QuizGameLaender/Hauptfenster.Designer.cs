namespace QuizGameLaender
{
    partial class Hauptfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitel = new System.Windows.Forms.Label();
            this.buttonLaender = new System.Windows.Forms.Button();
            this.labelFrage = new System.Windows.Forms.Label();
            this.buttonHauptstaedten = new System.Windows.Forms.Button();
            this.buttonFlaggen = new System.Windows.Forms.Button();
            this.buttonScoreAnsehen = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitel.Location = new System.Drawing.Point(203, 30);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(382, 38);
            this.labelTitel.TabIndex = 0;
            this.labelTitel.Text = "Quiz Game Geographie";
            // 
            // buttonLaender
            // 
            this.buttonLaender.Location = new System.Drawing.Point(42, 224);
            this.buttonLaender.Name = "buttonLaender";
            this.buttonLaender.Size = new System.Drawing.Size(219, 77);
            this.buttonLaender.TabIndex = 1;
            this.buttonLaender.Text = "Länder";
            this.buttonLaender.UseVisualStyleBackColor = true;
            this.buttonLaender.Click += new System.EventHandler(this.buttonLaender_Click);
            // 
            // labelFrage
            // 
            this.labelFrage.AutoSize = true;
            this.labelFrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrage.Location = new System.Drawing.Point(23, 104);
            this.labelFrage.Name = "labelFrage";
            this.labelFrage.Size = new System.Drawing.Size(286, 29);
            this.labelFrage.TabIndex = 2;
            this.labelFrage.Text = "Was möchten Sie lernen?";
            // 
            // buttonHauptstaedten
            // 
            this.buttonHauptstaedten.Location = new System.Drawing.Point(297, 224);
            this.buttonHauptstaedten.Name = "buttonHauptstaedten";
            this.buttonHauptstaedten.Size = new System.Drawing.Size(219, 77);
            this.buttonHauptstaedten.TabIndex = 3;
            this.buttonHauptstaedten.Text = "Hauptstädten";
            this.buttonHauptstaedten.UseVisualStyleBackColor = true;
            this.buttonHauptstaedten.Click += new System.EventHandler(this.buttonHauptstaedten_Click);
            // 
            // buttonFlaggen
            // 
            this.buttonFlaggen.Location = new System.Drawing.Point(552, 224);
            this.buttonFlaggen.Name = "buttonFlaggen";
            this.buttonFlaggen.Size = new System.Drawing.Size(219, 77);
            this.buttonFlaggen.TabIndex = 4;
            this.buttonFlaggen.Text = "Flaggen";
            this.buttonFlaggen.UseVisualStyleBackColor = true;
            this.buttonFlaggen.Click += new System.EventHandler(this.buttonFlaggen_Click);
            // 
            // buttonScoreAnsehen
            // 
            this.buttonScoreAnsehen.Location = new System.Drawing.Point(297, 335);
            this.buttonScoreAnsehen.Name = "buttonScoreAnsehen";
            this.buttonScoreAnsehen.Size = new System.Drawing.Size(219, 70);
            this.buttonScoreAnsehen.TabIndex = 5;
            this.buttonScoreAnsehen.Text = "Score ansehen";
            this.buttonScoreAnsehen.UseVisualStyleBackColor = true;
            this.buttonScoreAnsehen.Click += new System.EventHandler(this.buttonScoreAnsehen_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(42, 335);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(219, 70);
            this.buttonAbbrechen.TabIndex = 6;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonScoreAnsehen);
            this.Controls.Add(this.buttonFlaggen);
            this.Controls.Add(this.buttonHauptstaedten);
            this.Controls.Add(this.labelFrage);
            this.Controls.Add(this.buttonLaender);
            this.Controls.Add(this.labelTitel);
            this.Name = "Hauptfenster";
            this.Text = "Quiz Game Geographie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Button buttonLaender;
        private System.Windows.Forms.Label labelFrage;
        private System.Windows.Forms.Button buttonHauptstaedten;
        private System.Windows.Forms.Button buttonFlaggen;
        private System.Windows.Forms.Button buttonScoreAnsehen;
        private System.Windows.Forms.Button buttonAbbrechen;
    }
}

