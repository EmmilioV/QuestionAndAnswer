
namespace View.Forms
{
    partial class Questions
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.gboxOptions = new System.Windows.Forms.GroupBox();
            this.rbOption4 = new System.Windows.Forms.RadioButton();
            this.rbOption3 = new System.Windows.Forms.RadioButton();
            this.rbOption2 = new System.Windows.Forms.RadioButton();
            this.rbOption1 = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.gboxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(35, 45);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(98, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Here\'s the question";
            // 
            // gboxOptions
            // 
            this.gboxOptions.Controls.Add(this.rbOption4);
            this.gboxOptions.Controls.Add(this.rbOption3);
            this.gboxOptions.Controls.Add(this.rbOption2);
            this.gboxOptions.Controls.Add(this.rbOption1);
            this.gboxOptions.Location = new System.Drawing.Point(38, 84);
            this.gboxOptions.Name = "gboxOptions";
            this.gboxOptions.Size = new System.Drawing.Size(226, 133);
            this.gboxOptions.TabIndex = 1;
            this.gboxOptions.TabStop = false;
            this.gboxOptions.Text = "Answer Options";
            // 
            // rbOption4
            // 
            this.rbOption4.AutoSize = true;
            this.rbOption4.Location = new System.Drawing.Point(7, 91);
            this.rbOption4.Name = "rbOption4";
            this.rbOption4.Size = new System.Drawing.Size(85, 17);
            this.rbOption4.TabIndex = 3;
            this.rbOption4.TabStop = true;
            this.rbOption4.Text = "radioButton4";
            this.rbOption4.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            this.rbOption3.AutoSize = true;
            this.rbOption3.Location = new System.Drawing.Point(7, 68);
            this.rbOption3.Name = "rbOption3";
            this.rbOption3.Size = new System.Drawing.Size(85, 17);
            this.rbOption3.TabIndex = 2;
            this.rbOption3.Text = "radioButton3";
            this.rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            this.rbOption2.AutoSize = true;
            this.rbOption2.Location = new System.Drawing.Point(7, 44);
            this.rbOption2.Name = "rbOption2";
            this.rbOption2.Size = new System.Drawing.Size(85, 17);
            this.rbOption2.TabIndex = 1;
            this.rbOption2.TabStop = true;
            this.rbOption2.Text = "radioButton2";
            this.rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption1
            // 
            this.rbOption1.AutoSize = true;
            this.rbOption1.Location = new System.Drawing.Point(7, 20);
            this.rbOption1.Name = "rbOption1";
            this.rbOption1.Size = new System.Drawing.Size(85, 17);
            this.rbOption1.TabIndex = 0;
            this.rbOption1.Text = "radioButton1";
            this.rbOption1.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(38, 240);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(92, 26);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Location = new System.Drawing.Point(188, 13);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(30, 13);
            this.lblTittle.TabIndex = 3;
            this.lblTittle.Text = "Tittle";
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 304);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gboxOptions);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Questions";
            this.Text = "Questions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.END);
            this.gboxOptions.ResumeLayout(false);
            this.gboxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox gboxOptions;
        private System.Windows.Forms.RadioButton rbOption4;
        private System.Windows.Forms.RadioButton rbOption3;
        private System.Windows.Forms.RadioButton rbOption2;
        private System.Windows.Forms.RadioButton rbOption1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTittle;
    }
}