namespace Tekken5DarkRessurectionScoreKeeper
{
    partial class SessionLoad
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
            this.button1 = new System.Windows.Forms.Button();
            this.gbxSavedSessions = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gbxSavedSessions.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbxSavedSessions
            // 
            this.gbxSavedSessions.Controls.Add(this.radioButton1);
            this.gbxSavedSessions.Location = new System.Drawing.Point(12, 12);
            this.gbxSavedSessions.Name = "gbxSavedSessions";
            this.gbxSavedSessions.Size = new System.Drawing.Size(340, 233);
            this.gbxSavedSessions.TabIndex = 2;
            this.gbxSavedSessions.TabStop = false;
            this.gbxSavedSessions.Text = "Saved Sessions";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // SessionLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 307);
            this.Controls.Add(this.gbxSavedSessions);
            this.Controls.Add(this.button1);
            this.Name = "SessionLoad";
            this.Text = "SessionLoad";
            this.gbxSavedSessions.ResumeLayout(false);
            this.gbxSavedSessions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbxSavedSessions;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}