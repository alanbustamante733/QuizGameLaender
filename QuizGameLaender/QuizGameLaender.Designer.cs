namespace QuizGameLaender
{
    partial class QuizGameLaender
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAntwort1 = new System.Windows.Forms.Button();
            this.buttonAntwort2 = new System.Windows.Forms.Button();
            this.buttonAntwort3 = new System.Windows.Forms.Button();
            this.buttonAntwort4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAntwort1
            // 
            this.buttonAntwort1.Location = new System.Drawing.Point(12, 305);
            this.buttonAntwort1.Name = "buttonAntwort1";
            this.buttonAntwort1.Size = new System.Drawing.Size(355, 102);
            this.buttonAntwort1.TabIndex = 1;
            this.buttonAntwort1.Text = "button1";
            this.buttonAntwort1.UseVisualStyleBackColor = true;
            this.buttonAntwort1.Click += new System.EventHandler(this.checkAntwortEvent);
            // 
            // buttonAntwort2
            // 
            this.buttonAntwort2.Location = new System.Drawing.Point(433, 305);
            this.buttonAntwort2.Name = "buttonAntwort2";
            this.buttonAntwort2.Size = new System.Drawing.Size(355, 102);
            this.buttonAntwort2.TabIndex = 2;
            this.buttonAntwort2.Text = "button2";
            this.buttonAntwort2.UseVisualStyleBackColor = true;
            this.buttonAntwort2.Click += new System.EventHandler(this.checkAntwortEvent);
            // 
            // buttonAntwort3
            // 
            this.buttonAntwort3.Location = new System.Drawing.Point(12, 425);
            this.buttonAntwort3.Name = "buttonAntwort3";
            this.buttonAntwort3.Size = new System.Drawing.Size(355, 102);
            this.buttonAntwort3.TabIndex = 3;
            this.buttonAntwort3.Text = "button3";
            this.buttonAntwort3.UseVisualStyleBackColor = true;
            this.buttonAntwort3.Click += new System.EventHandler(this.checkAntwortEvent);
            // 
            // buttonAntwort4
            // 
            this.buttonAntwort4.Location = new System.Drawing.Point(433, 425);
            this.buttonAntwort4.Name = "buttonAntwort4";
            this.buttonAntwort4.Size = new System.Drawing.Size(355, 102);
            this.buttonAntwort4.TabIndex = 4;
            this.buttonAntwort4.Text = "button4";
            this.buttonAntwort4.UseVisualStyleBackColor = true;
            this.buttonAntwort4.Click += new System.EventHandler(this.checkAntwortEvent);
            // 
            // QuizGameLaender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.buttonAntwort4);
            this.Controls.Add(this.buttonAntwort3);
            this.Controls.Add(this.buttonAntwort2);
            this.Controls.Add(this.buttonAntwort1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QuizGameLaender";
            this.Text = "QuizGameLaender";
            this.Load += new System.EventHandler(this.QuizGameLaender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAntwort1;
        private System.Windows.Forms.Button buttonAntwort2;
        private System.Windows.Forms.Button buttonAntwort3;
        private System.Windows.Forms.Button buttonAntwort4;
    }
}