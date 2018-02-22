namespace SpamHammer
{
    partial class Form1
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
            this.btnDoTraining = new System.Windows.Forms.Button();
            this.btnAnalyseTestData = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSpamNGramCount = new System.Windows.Forms.Label();
            this.labelHamNGramsFound = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.textBoxNGramLength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelWrong = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMissingNGramPoints = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDoTraining
            // 
            this.btnDoTraining.Location = new System.Drawing.Point(30, 154);
            this.btnDoTraining.Name = "btnDoTraining";
            this.btnDoTraining.Size = new System.Drawing.Size(140, 23);
            this.btnDoTraining.TabIndex = 0;
            this.btnDoTraining.Text = "Analyse Training Data";
            this.btnDoTraining.UseVisualStyleBackColor = true;
            this.btnDoTraining.Click += new System.EventHandler(this.btnDoTraining_Click);
            // 
            // btnAnalyseTestData
            // 
            this.btnAnalyseTestData.Enabled = false;
            this.btnAnalyseTestData.Location = new System.Drawing.Point(242, 154);
            this.btnAnalyseTestData.Name = "btnAnalyseTestData";
            this.btnAnalyseTestData.Size = new System.Drawing.Size(140, 23);
            this.btnAnalyseTestData.TabIndex = 1;
            this.btnAnalyseTestData.Text = "Analyse Test Data";
            this.btnAnalyseTestData.UseVisualStyleBackColor = true;
            this.btnAnalyseTestData.Click += new System.EventHandler(this.btnAnalyseTestData_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(27, 197);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(91, 13);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Nothing done yet.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spam nGrams found:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ham nGrams found:";
            // 
            // labelSpamNGramCount
            // 
            this.labelSpamNGramCount.AutoSize = true;
            this.labelSpamNGramCount.Location = new System.Drawing.Point(466, 41);
            this.labelSpamNGramCount.Name = "labelSpamNGramCount";
            this.labelSpamNGramCount.Size = new System.Drawing.Size(13, 13);
            this.labelSpamNGramCount.TabIndex = 5;
            this.labelSpamNGramCount.Text = "0";
            // 
            // labelHamNGramsFound
            // 
            this.labelHamNGramsFound.AutoSize = true;
            this.labelHamNGramsFound.Location = new System.Drawing.Point(466, 54);
            this.labelHamNGramsFound.Name = "labelHamNGramsFound";
            this.labelHamNGramsFound.Size = new System.Drawing.Size(13, 13);
            this.labelHamNGramsFound.TabIndex = 6;
            this.labelHamNGramsFound.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Test data results:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Correct:";
            // 
            // labelCorrect
            // 
            this.labelCorrect.AutoSize = true;
            this.labelCorrect.Location = new System.Drawing.Point(604, 41);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(30, 13);
            this.labelCorrect.TabIndex = 9;
            this.labelCorrect.Text = "0 / 0";
            // 
            // textBoxNGramLength
            // 
            this.textBoxNGramLength.Location = new System.Drawing.Point(126, 34);
            this.textBoxNGramLength.Name = "textBoxNGramLength";
            this.textBoxNGramLength.Size = new System.Drawing.Size(53, 20);
            this.textBoxNGramLength.TabIndex = 10;
            this.textBoxNGramLength.Text = "2";
            this.textBoxNGramLength.TextChanged += new System.EventHandler(this.textBoxNGramLength_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Max length of nGrams:";
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.Location = new System.Drawing.Point(604, 63);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(30, 13);
            this.labelWrong.TabIndex = 13;
            this.labelWrong.Text = "0 / 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(554, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Wrong:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "(Changing this resets learned values)";
            // 
            // textBoxMissingNGramPoints
            // 
            this.textBoxMissingNGramPoints.Location = new System.Drawing.Point(126, 85);
            this.textBoxMissingNGramPoints.Name = "textBoxMissingNGramPoints";
            this.textBoxMissingNGramPoints.Size = new System.Drawing.Size(53, 20);
            this.textBoxMissingNGramPoints.TabIndex = 15;
            this.textBoxMissingNGramPoints.Text = "300";
            this.textBoxMissingNGramPoints.TextChanged += new System.EventHandler(this.textBoxMissingNGramPoints_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Max length of nGrams:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(303, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "(Can be changed without reset. How much difference score\r\nit\'s worth if the nGram" +
    " is completely missing from the reference.)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 334);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxMissingNGramPoints);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelWrong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNGramLength);
            this.Controls.Add(this.labelCorrect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelHamNGramsFound);
            this.Controls.Add(this.labelSpamNGramCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnAnalyseTestData);
            this.Controls.Add(this.btnDoTraining);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoTraining;
        private System.Windows.Forms.Button btnAnalyseTestData;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSpamNGramCount;
        private System.Windows.Forms.Label labelHamNGramsFound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCorrect;
        private System.Windows.Forms.TextBox textBoxNGramLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelWrong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMissingNGramPoints;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

