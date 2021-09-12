
namespace View.Forms
{
    partial class Win
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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblTittleScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(208, 27);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(76, 13);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "name of player";
            // 
            // lblTittleScore
            // 
            this.lblTittleScore.AutoSize = true;
            this.lblTittleScore.Location = new System.Drawing.Point(226, 93);
            this.lblTittleScore.Name = "lblTittleScore";
            this.lblTittleScore.Size = new System.Drawing.Size(44, 13);
            this.lblTittleScore.TabIndex = 1;
            this.lblTittleScore.Text = "SCORE";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(196, 147);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(97, 13);
            this.lblPlayerScore.TabIndex = 2;
            this.lblPlayerScore.Text = "Player Total Score ";
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 268);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblTittleScore);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "Win";
            this.Text = "Win";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Win_FormClosing);
            this.Load += new System.EventHandler(this.Win_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblTittleScore;
        private System.Windows.Forms.Label lblPlayerScore;
    }
}