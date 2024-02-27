namespace QuizGameLaender
{
    partial class ScoreAnsehen
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
            this.dataGridViewScore = new System.Windows.Forms.DataGridView();
            this.ColumnSpielArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPunkte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSpieler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewScore
            // 
            this.dataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSpielArt,
            this.ColumnPunkte,
            this.ColumnSpieler});
            this.dataGridViewScore.Location = new System.Drawing.Point(12, 22);
            this.dataGridViewScore.Name = "dataGridViewScore";
            this.dataGridViewScore.RowHeadersWidth = 51;
            this.dataGridViewScore.RowTemplate.Height = 24;
            this.dataGridViewScore.Size = new System.Drawing.Size(579, 628);
            this.dataGridViewScore.TabIndex = 0;
            // 
            // ColumnSpielArt
            // 
            this.ColumnSpielArt.HeaderText = "Spielart";
            this.ColumnSpielArt.MinimumWidth = 6;
            this.ColumnSpielArt.Name = "ColumnSpielArt";
            this.ColumnSpielArt.Width = 125;
            // 
            // ColumnPunkte
            // 
            this.ColumnPunkte.HeaderText = "Punkte";
            this.ColumnPunkte.MinimumWidth = 6;
            this.ColumnPunkte.Name = "ColumnPunkte";
            this.ColumnPunkte.Width = 125;
            // 
            // ColumnSpieler
            // 
            this.ColumnSpieler.HeaderText = "Spieler";
            this.ColumnSpieler.MinimumWidth = 6;
            this.ColumnSpieler.Name = "ColumnSpieler";
            this.ColumnSpieler.Width = 125;
            // 
            // ScoreAnsehen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 673);
            this.Controls.Add(this.dataGridViewScore);
            this.Name = "ScoreAnsehen";
            this.Text = "ScoreAnsehen";
            this.Load += new System.EventHandler(this.ScoreAnsehen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpielArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPunkte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpieler;
    }
}