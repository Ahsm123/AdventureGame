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
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BtnAttack
            // 
            BtnAttack.Location = new Point(286, 485);
            BtnAttack.Margin = new Padding(4);
            BtnAttack.Name = "BtnAttack";
            BtnAttack.Size = new Size(118, 36);
            BtnAttack.TabIndex = 0;
            BtnAttack.Text = "Attack";
            BtnAttack.UseVisualStyleBackColor = true;
            BtnAttack.Click += BtnAttack_Click;
            // 
            // BtnRest
            // 
            BtnRest.Location = new Point(411, 485);
            BtnRest.Margin = new Padding(4);
            BtnRest.Name = "BtnRest";
            BtnRest.Size = new Size(118, 36);
            BtnRest.TabIndex = 1;
            BtnRest.Text = "Rest";
            BtnRest.UseVisualStyleBackColor = true;
            BtnRest.Click += BtnRest_Click;
            // 
            // BtnQuit
            // 
            BtnQuit.Location = new Point(536, 485);
            BtnQuit.Margin = new Padding(4);
            BtnQuit.Name = "BtnQuit";
            BtnQuit.Size = new Size(118, 36);
            BtnQuit.TabIndex = 2;
            BtnQuit.Text = "Quit";
            BtnQuit.UseVisualStyleBackColor = true;
            BtnQuit.Click += BtnQuit_Click;
            // 
            // LblPlayerStats
            // 
            LblPlayerStats.AutoSize = true;
            LblPlayerStats.BackColor = SystemColors.ActiveBorder;
            LblPlayerStats.Location = new Point(75, 56);
            LblPlayerStats.Margin = new Padding(4, 0, 4, 0);
            LblPlayerStats.Name = "LblPlayerStats";
            LblPlayerStats.Size = new Size(97, 25);
            LblPlayerStats.TabIndex = 4;
            LblPlayerStats.Text = "PlayerStats";
            // 
            // LblMonsterStats
            // 
            LblMonsterStats.AutoSize = true;
            LblMonsterStats.BackColor = SystemColors.ActiveBorder;
            LblMonsterStats.Location = new Point(684, 56);
            LblMonsterStats.Margin = new Padding(4, 0, 4, 0);
            LblMonsterStats.Name = "LblMonsterStats";
            LblMonsterStats.Size = new Size(116, 25);
            LblMonsterStats.TabIndex = 5;
            LblMonsterStats.Text = "MonsterStats";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(684, 254);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // TxtBoxCombatLog
            // 
            TxtBoxCombatLog.Location = new Point(286, 56);
            TxtBoxCombatLog.Margin = new Padding(4);
            TxtBoxCombatLog.Name = "TxtBoxCombatLog";
            TxtBoxCombatLog.Size = new Size(350, 389);
            TxtBoxCombatLog.TabIndex = 7;
            TxtBoxCombatLog.Text = "";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(55, 262);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(193, 183);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 562);
            Controls.Add(pictureBox2);
            Controls.Add(TxtBoxCombatLog);
            Controls.Add(pictureBox1);
            Controls.Add(LblMonsterStats);
            Controls.Add(LblPlayerStats);
            Controls.Add(BtnQuit);
            Controls.Add(BtnRest);
            Controls.Add(BtnAttack);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
    }
}
