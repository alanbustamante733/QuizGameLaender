namespace QuizGameLaender
{
    partial class LoginWindowsForm
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
            this.labelWillkommen = new System.Windows.Forms.Label();
            this.labelNutzerName = new System.Windows.Forms.Label();
            this.labelPasswort = new System.Windows.Forms.Label();
            this.textBoxNutzerName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonNeuerNutzerErstellen = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWillkommen
            // 
            this.labelWillkommen.AutoSize = true;
            this.labelWillkommen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWillkommen.Location = new System.Drawing.Point(167, 59);
            this.labelWillkommen.Name = "labelWillkommen";
            this.labelWillkommen.Size = new System.Drawing.Size(179, 32);
            this.labelWillkommen.TabIndex = 0;
            this.labelWillkommen.Text = "Willkommen";
            // 
            // labelNutzerName
            // 
            this.labelNutzerName.AutoSize = true;
            this.labelNutzerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNutzerName.Location = new System.Drawing.Point(54, 148);
            this.labelNutzerName.Name = "labelNutzerName";
            this.labelNutzerName.Size = new System.Drawing.Size(113, 20);
            this.labelNutzerName.TabIndex = 1;
            this.labelNutzerName.Text = "Nutzer Name:";
            // 
            // labelPasswort
            // 
            this.labelPasswort.AutoSize = true;
            this.labelPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswort.Location = new System.Drawing.Point(54, 197);
            this.labelPasswort.Name = "labelPasswort";
            this.labelPasswort.Size = new System.Drawing.Size(88, 20);
            this.labelPasswort.TabIndex = 2;
            this.labelPasswort.Text = "Password:";
            // 
            // textBoxNutzerName
            // 
            this.textBoxNutzerName.Location = new System.Drawing.Point(201, 148);
            this.textBoxNutzerName.Name = "textBoxNutzerName";
            this.textBoxNutzerName.Size = new System.Drawing.Size(190, 22);
            this.textBoxNutzerName.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(201, 200);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(190, 22);
            this.textBoxPassword.TabIndex = 4;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(173, 245);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(103, 45);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(303, 245);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(107, 45);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonNeuerNutzerErstellen
            // 
            this.buttonNeuerNutzerErstellen.Location = new System.Drawing.Point(431, 138);
            this.buttonNeuerNutzerErstellen.Name = "buttonNeuerNutzerErstellen";
            this.buttonNeuerNutzerErstellen.Size = new System.Drawing.Size(107, 98);
            this.buttonNeuerNutzerErstellen.TabIndex = 7;
            this.buttonNeuerNutzerErstellen.Text = "Neuer Nutzer erstellen";
            this.buttonNeuerNutzerErstellen.UseVisualStyleBackColor = true;
            this.buttonNeuerNutzerErstellen.Click += new System.EventHandler(this.buttonNeuerNutzerErstellen_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(58, 340);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(117, 39);
            this.buttonAbbrechen.TabIndex = 8;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // LoginWindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonNeuerNutzerErstellen);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxNutzerName);
            this.Controls.Add(this.labelPasswort);
            this.Controls.Add(this.labelNutzerName);
            this.Controls.Add(this.labelWillkommen);
            this.Name = "LoginWindowsForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWillkommen;
        private System.Windows.Forms.Label labelNutzerName;
        private System.Windows.Forms.Label labelPasswort;
        private System.Windows.Forms.TextBox textBoxNutzerName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonNeuerNutzerErstellen;
        private System.Windows.Forms.Button buttonAbbrechen;
    }
}