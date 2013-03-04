namespace Tekken5DarkRessurectionScoreKeeper
{
    partial class Window
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.lblLeftCharacter = new System.Windows.Forms.Label();
            this.pbxCharacterSelect = new System.Windows.Forms.PictureBox();
            this.lblRightCharacter = new System.Windows.Forms.Label();
            this.lblRightPlayerName = new System.Windows.Forms.Label();
            this.lblLeftPlayerName = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dBDataSetAll = new Tekken5DarkRessurectionScoreKeeper.DBDataSetAll();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.playerTableAdapter = new Tekken5DarkRessurectionScoreKeeper.DBDataSetAllTableAdapters.PlayerTableAdapter();
            this.dBDataSetAll1 = new Tekken5DarkRessurectionScoreKeeper.DBDataSetAll();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionTableAdapter = new Tekken5DarkRessurectionScoreKeeper.DBDataSetAllTableAdapters.SessionTableAdapter();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tsmNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpgFront = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PlayerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Victories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Defeats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Draw = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacterSelect)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetAll1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            this.panelMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpgFront.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLeftCharacter
            // 
            this.lblLeftCharacter.AutoSize = true;
            this.lblLeftCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftCharacter.Location = new System.Drawing.Point(20, 0);
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
            this.lblRightCharacter.Location = new System.Drawing.Point(20, 0);
            this.lblRightCharacter.Name = "lblRightCharacter";
            this.lblRightCharacter.Size = new System.Drawing.Size(326, 44);
            this.lblRightCharacter.TabIndex = 4;
            this.lblRightCharacter.Text = "Select a character";
            // 
            // lblRightPlayerName
            // 
            this.lblRightPlayerName.AutoSize = true;
            this.lblRightPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightPlayerName.Location = new System.Drawing.Point(40, 40);
            this.lblRightPlayerName.Name = "lblRightPlayerName";
            this.lblRightPlayerName.Size = new System.Drawing.Size(192, 53);
            this.lblRightPlayerName.TabIndex = 6;
            this.lblRightPlayerName.Text = "Player 2";
            // 
            // lblLeftPlayerName
            // 
            this.lblLeftPlayerName.AutoSize = true;
            this.lblLeftPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftPlayerName.Location = new System.Drawing.Point(40, 40);
            this.lblLeftPlayerName.Name = "lblLeftPlayerName";
            this.lblLeftPlayerName.Size = new System.Drawing.Size(192, 53);
            this.lblLeftPlayerName.TabIndex = 5;
            this.lblLeftPlayerName.Text = "Player 1";
            // 
            // panelLeft
            // 
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.lblLeftCharacter);
            this.panelLeft.Controls.Add(this.lblLeftPlayerName);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(544, 129);
            this.panelLeft.TabIndex = 8;
            // 
            // panelRight
            // 
            this.panelRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.lblRightCharacter);
            this.panelRight.Controls.Add(this.lblRightPlayerName);
            this.panelRight.Location = new System.Drawing.Point(543, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(542, 129);
            this.panelRight.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu,
            this.tsmNewGame});
            this.menuStrip1.Location = new System.Drawing.Point(0, 658);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmMenu
            // 
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(50, 20);
            this.tsmMenu.Text = "Menu";
            this.tsmMenu.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // dBDataSetAll
            // 
            this.dBDataSetAll.DataSetName = "DBDataSetAll";
            this.dBDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Player";
            this.bindingSource1.DataSource = this.dBDataSetAll;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // dBDataSetAll1
            // 
            this.dBDataSetAll1.DataSetName = "DBDataSetAll";
            this.dBDataSetAll1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataMember = "Session";
            this.sessionBindingSource.DataSource = this.dBDataSetAll1;
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tcMain);
            this.panelMain.Controls.Add(this.panelRight);
            this.panelMain.Controls.Add(this.panelLeft);
            this.panelMain.Location = new System.Drawing.Point(0, 267);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1085, 388);
            this.panelMain.TabIndex = 11;
            // 
            // tsmNewGame
            // 
            this.tsmNewGame.Name = "tsmNewGame";
            this.tsmNewGame.Size = new System.Drawing.Size(86, 20);
            this.tsmNewGame.Text = "New Game...";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpgFront);
            this.tcMain.Location = new System.Drawing.Point(0, 135);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1085, 253);
            this.tcMain.TabIndex = 10;
            // 
            // tpgFront
            // 
            this.tpgFront.Controls.Add(this.listView1);
            this.tpgFront.Location = new System.Drawing.Point(4, 22);
            this.tpgFront.Name = "tpgFront";
            this.tpgFront.Padding = new System.Windows.Forms.Padding(3);
            this.tpgFront.Size = new System.Drawing.Size(1077, 227);
            this.tpgFront.TabIndex = 0;
            this.tpgFront.Text = "tabPage1";
            this.tpgFront.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PlayerName,
            this.Victories,
            this.Defeats,
            this.Draw});
            this.listView1.Location = new System.Drawing.Point(95, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1085, 682);
            this.Controls.Add(this.pbxCharacterSelect);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.Text = "Tekken 5 Dark Resurrection Score Keeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacterSelect)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetAll1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpgFront.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLeftCharacter;
        private System.Windows.Forms.PictureBox pbxCharacterSelect;
        private System.Windows.Forms.Label lblRightCharacter;
        private System.Windows.Forms.Label lblRightPlayerName;
        private System.Windows.Forms.Label lblLeftPlayerName;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private DBDataSetAll dBDataSetAll;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DBDataSetAllTableAdapters.PlayerTableAdapter playerTableAdapter;
        private DBDataSetAll dBDataSetAll1;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private DBDataSetAllTableAdapters.SessionTableAdapter sessionTableAdapter;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem tsmNewGame;
        public System.Windows.Forms.TabPage tpgFront;
        public System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.ColumnHeader PlayerName;
        private System.Windows.Forms.ColumnHeader Victories;
        private System.Windows.Forms.ColumnHeader Defeats;
        private System.Windows.Forms.ColumnHeader Draw;
        public System.Windows.Forms.ListView listView1;
    }
}

