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
            this.SuspendLayout();
            // 
            // btnDoTraining
            // 
            this.btnDoTraining.Location = new System.Drawing.Point(30, 125);
            this.btnDoTraining.Name = "btnDoTraining";
            this.btnDoTraining.Size = new System.Drawing.Size(140, 23);
            this.btnDoTraining.TabIndex = 0;
            this.btnDoTraining.Text = "Analyse Training Data";
            this.btnDoTraining.UseVisualStyleBackColor = true;
            this.btnDoTraining.Click += new System.EventHandler(this.btnDoTraining_Click);
            // 
            // btnAnalyseTestData
            // 
            this.btnAnalyseTestData.Location = new System.Drawing.Point(242, 125);
            this.btnAnalyseTestData.Name = "btnAnalyseTestData";
            this.btnAnalyseTestData.Size = new System.Drawing.Size(140, 23);
            this.btnAnalyseTestData.TabIndex = 1;
            this.btnAnalyseTestData.Text = "Analyse Test Data";
            this.btnAnalyseTestData.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 328);
            this.Controls.Add(this.btnAnalyseTestData);
            this.Controls.Add(this.btnDoTraining);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoTraining;
        private System.Windows.Forms.Button btnAnalyseTestData;
    }
}

