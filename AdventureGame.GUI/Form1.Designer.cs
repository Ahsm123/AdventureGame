namespace AdventureGame.GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BtnAttack = new Button();
            BtnRest = new Button();
            BtnQuit = new Button();
            LblPlayerStats = new Label();
            LblMonsterStats = new Label();
            pictureBox1 = new PictureBox();
            TxtBoxCombatLog = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnAttack
            // 
            BtnAttack.Location = new Point(229, 388);
            BtnAttack.Name = "BtnAttack";
            BtnAttack.Size = new Size(94, 29);
            BtnAttack.TabIndex = 0;
            BtnAttack.Text = "Attack";
            BtnAttack.UseVisualStyleBackColor = true;
            BtnAttack.Click += BtnAttack_Click;
            // 
            // BtnRest
            // 
            BtnRest.Location = new Point(329, 388);
            BtnRest.Name = "BtnRest";
            BtnRest.Size = new Size(94, 29);
            BtnRest.TabIndex = 1;
            BtnRest.Text = "Rest";
            BtnRest.UseVisualStyleBackColor = true;
            BtnRest.Click += BtnRest_Click;
            // 
            // BtnQuit
            // 
            BtnQuit.Location = new Point(429, 388);
            BtnQuit.Name = "BtnQuit";
            BtnQuit.Size = new Size(94, 29);
            BtnQuit.TabIndex = 2;
            BtnQuit.Text = "Quit";
            BtnQuit.UseVisualStyleBackColor = true;
            BtnQuit.Click += BtnQuit_Click;
            // 
            // LblPlayerStats
            // 
            LblPlayerStats.AutoSize = true;
            LblPlayerStats.BackColor = SystemColors.ActiveBorder;
            LblPlayerStats.Location = new Point(60, 45);
            LblPlayerStats.Name = "LblPlayerStats";
            LblPlayerStats.Size = new Size(81, 20);
            LblPlayerStats.TabIndex = 4;
            LblPlayerStats.Text = "PlayerStats";
            // 
            // LblMonsterStats
            // 
            LblMonsterStats.AutoSize = true;
            LblMonsterStats.BackColor = SystemColors.ActiveBorder;
            LblMonsterStats.Location = new Point(547, 45);
            LblMonsterStats.Name = "LblMonsterStats";
            LblMonsterStats.Size = new Size(95, 20);
            LblMonsterStats.TabIndex = 5;
            LblMonsterStats.Text = "MonsterStats";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(547, 203);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 154);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // TxtBoxCombatLog
            // 
            TxtBoxCombatLog.Location = new Point(229, 45);
            TxtBoxCombatLog.Name = "TxtBoxCombatLog";
            TxtBoxCombatLog.Size = new Size(281, 312);
            TxtBoxCombatLog.TabIndex = 7;
            TxtBoxCombatLog.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(TxtBoxCombatLog);
            Controls.Add(pictureBox1);
            Controls.Add(LblMonsterStats);
            Controls.Add(LblPlayerStats);
            Controls.Add(BtnQuit);
            Controls.Add(BtnRest);
            Controls.Add(BtnAttack);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAttack;
        private Button BtnRest;
        private Button BtnQuit;
        private Label LblPlayerStats;
        private Label LblMonsterStats;
        private PictureBox pictureBox1;
        private RichTextBox TxtBoxCombatLog;
    }
}
