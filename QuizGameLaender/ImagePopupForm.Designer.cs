namespace QuizGameLaender
{
    partial class ImagePopupForm
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
            this.labelTitel = new System.Windows.Forms.Label();
            this.pictureBoxPopUp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopUp)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitel.Location = new System.Drawing.Point(142, 70);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(351, 32);
            this.labelTitel.TabIndex = 0;
            this.labelTitel.Text = "Diese Flagge war richtig!";
            // 
            // pictureBoxPopUp
            // 
            this.pictureBoxPopUp.Location = new System.Drawing.Point(75, 131);
            this.pictureBoxPopUp.Name = "pictureBoxPopUp";
            this.pictureBoxPopUp.Size = new System.Drawing.Size(515, 242);
            this.pictureBoxPopUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPopUp.TabIndex = 1;
            this.pictureBoxPopUp.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Leider deine Auswahl war falsch.";
            // 
            // ImagePopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxPopUp);
            this.Controls.Add(this.labelTitel);
            this.Name = "ImagePopupForm";
            this.Text = "ImagePopupForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.PictureBox pictureBoxPopUp;
        private System.Windows.Forms.Label label1;
    }
}