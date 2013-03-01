namespace Tekken5DarkRessurectionScoreKeeper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblLeftCharacter = new System.Windows.Forms.Label();
            this.pbxCharacterSelect = new System.Windows.Forms.PictureBox();
            this.lblRightCharacter = new System.Windows.Forms.Label();
            this.lblRightPlayerName = new System.Windows.Forms.Label();
            this.lblLeftPlayerName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacterSelect)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLeftCharacter
            // 
            this.lblLeftCharacter.AutoSize = true;
            this.lblLeftCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftCharacter.Location = new System.Drawing.Point(27, 267);
            this.lblLeftCharacter.Name = "lblLeftCharacter";
            this.lblLeftCharacter.Size = new System.Drawing.Size(326, 44);
            this.lblLeftCharacter.TabIndex = 2;
            this.lblLeftCharacter.Text = "Select a character";
            // 
            // pbxCharacterSelect
            // 
            this.pbxCharacterSelect.Image = ((System.Drawing.Image)(resources.GetObject("pbxCharacterSelect.Image")));
            this.pbxCharacterSelect.Location = new System.Drawing.Point(0, 0);
            this.pbxCharacterSelect.Name = "pbxCharacterSelect";
            this.pbxCharacterSelect.Size = new System.Drawing.Size(1085, 262);
            this.pbxCharacterSelect.TabIndex = 3;
            this.pbxCharacterSelect.TabStop = false;
            this.pbxCharacterSelect.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pbxCharacterSelect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // lblRightCharacter
            // 
            this.lblRightCharacter.AutoSize = true;
            this.lblRightCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightCharacter.Location = new System.Drawing.Point(556, 267);
            this.lblRightCharacter.Name = "lblRightCharacter";
            this.lblRightCharacter.Size = new System.Drawing.Size(326, 44);
            this.lblRightCharacter.TabIndex = 4;
            this.lblRightCharacter.Text = "Select a character";
            // 
            // lblRightPlayerName
            // 
            this.lblRightPlayerName.AutoSize = true;
            this.lblRightPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightPlayerName.Location = new System.Drawing.Point(565, 325);
            this.lblRightPlayerName.Name = "lblRightPlayerName";
            this.lblRightPlayerName.Size = new System.Drawing.Size(192, 53);
            this.lblRightPlayerName.TabIndex = 6;
            this.lblRightPlayerName.Text = "Player 2";
            // 
            // lblLeftPlayerName
            // 
            this.lblLeftPlayerName.AutoSize = true;
            this.lblLeftPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftPlayerName.Location = new System.Drawing.Point(36, 325);
            this.lblLeftPlayerName.Name = "lblLeftPlayerName";
            this.lblLeftPlayerName.Size = new System.Drawing.Size(192, 53);
            this.lblLeftPlayerName.TabIndex = 5;
            this.lblLeftPlayerName.Text = "Player 1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripTextBox1,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 649);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 27);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 23);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(13, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 129);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(542, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 129);
            this.panel2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1085, 676);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblRightPlayerName);
            this.Controls.Add(this.lblLeftPlayerName);
            this.Controls.Add(this.lblRightCharacter);
            this.Controls.Add(this.pbxCharacterSelect);
            this.Controls.Add(this.lblLeftCharacter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tekken 5 Dark Resurrection Score";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacterSelect)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLeftCharacter;
        private System.Windows.Forms.PictureBox pbxCharacterSelect;
        private System.Windows.Forms.Label lblRightCharacter;
        private System.Windows.Forms.Label lblRightPlayerName;
        private System.Windows.Forms.Label lblLeftPlayerName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

