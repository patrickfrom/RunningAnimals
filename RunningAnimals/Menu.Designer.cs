namespace RunningAnimals
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.GameTitle = new System.Windows.Forms.Label();
            this.AnimalListText = new System.Windows.Forms.RichTextBox();
            this.CreatePlayerButton = new System.Windows.Forms.Button();
            this.PlayerCreationPanel = new System.Windows.Forms.Panel();
            this.PlayerNameInput = new System.Windows.Forms.TextBox();
            this.AnimalComboChoice = new System.Windows.Forms.ComboBox();
            this.CapeComboChoice = new System.Windows.Forms.ComboBox();
            this.TrackComboChoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TrackNameLabel = new System.Windows.Forms.Label();
            this.PlayerInfoPanel = new System.Windows.Forms.Panel();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.AnimalPictureBox = new System.Windows.Forms.PictureBox();
            this.BetAmountInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AnimalBetLabel = new System.Windows.Forms.RichTextBox();
            this.StartRaceButton = new System.Windows.Forms.Button();
            this.WinningPlayerLabel = new System.Windows.Forms.RichTextBox();
            this.PlayerCreationPanel.SuspendLayout();
            this.PlayerInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTitle
            // 
            this.GameTitle.AutoSize = true;
            this.GameTitle.BackColor = System.Drawing.Color.Transparent;
            this.GameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.GameTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GameTitle.Location = new System.Drawing.Point(230, 3);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(375, 54);
            this.GameTitle.TabIndex = 1;
            this.GameTitle.Text = "Running Animals";
            // 
            // AnimalListText
            // 
            this.AnimalListText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.AnimalListText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnimalListText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.AnimalListText.ForeColor = System.Drawing.SystemColors.Window;
            this.AnimalListText.Location = new System.Drawing.Point(12, 12);
            this.AnimalListText.Name = "AnimalListText";
            this.AnimalListText.ReadOnly = true;
            this.AnimalListText.Size = new System.Drawing.Size(212, 453);
            this.AnimalListText.TabIndex = 2;
            this.AnimalListText.Text = "";
            // 
            // CreatePlayerButton
            // 
            this.CreatePlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.CreatePlayerButton.Location = new System.Drawing.Point(39, 256);
            this.CreatePlayerButton.Name = "CreatePlayerButton";
            this.CreatePlayerButton.Size = new System.Drawing.Size(184, 62);
            this.CreatePlayerButton.TabIndex = 3;
            this.CreatePlayerButton.Text = "Start";
            this.CreatePlayerButton.UseVisualStyleBackColor = true;
            this.CreatePlayerButton.Click += new System.EventHandler(this.CreatePlayerButton_Click);
            // 
            // PlayerCreationPanel
            // 
            this.PlayerCreationPanel.Controls.Add(this.label2);
            this.PlayerCreationPanel.Controls.Add(this.BetAmountInput);
            this.PlayerCreationPanel.Controls.Add(this.label1);
            this.PlayerCreationPanel.Controls.Add(this.TrackComboChoice);
            this.PlayerCreationPanel.Controls.Add(this.CapeComboChoice);
            this.PlayerCreationPanel.Controls.Add(this.AnimalComboChoice);
            this.PlayerCreationPanel.Controls.Add(this.PlayerNameInput);
            this.PlayerCreationPanel.Controls.Add(this.CreatePlayerButton);
            this.PlayerCreationPanel.Location = new System.Drawing.Point(527, 129);
            this.PlayerCreationPanel.Name = "PlayerCreationPanel";
            this.PlayerCreationPanel.Size = new System.Drawing.Size(261, 336);
            this.PlayerCreationPanel.TabIndex = 4;
            // 
            // PlayerNameInput
            // 
            this.PlayerNameInput.Location = new System.Drawing.Point(21, 39);
            this.PlayerNameInput.Name = "PlayerNameInput";
            this.PlayerNameInput.Size = new System.Drawing.Size(220, 20);
            this.PlayerNameInput.TabIndex = 5;
            this.PlayerNameInput.Text = "Jesus";
            // 
            // AnimalComboChoice
            // 
            this.AnimalComboChoice.AutoCompleteCustomSource.AddRange(new string[] {
            "Bear",
            "Dog",
            "Duck"});
            this.AnimalComboChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnimalComboChoice.FormattingEnabled = true;
            this.AnimalComboChoice.Items.AddRange(new object[] {
            "Bear",
            "Dog",
            "Duck"});
            this.AnimalComboChoice.Location = new System.Drawing.Point(21, 121);
            this.AnimalComboChoice.Name = "AnimalComboChoice";
            this.AnimalComboChoice.Size = new System.Drawing.Size(220, 21);
            this.AnimalComboChoice.TabIndex = 6;
            // 
            // CapeComboChoice
            // 
            this.CapeComboChoice.AutoCompleteCustomSource.AddRange(new string[] {
            "Beginner Cape - $0",
            "Baby Cape - $25",
            "Super Cape - $50",
            "God Cape - $100"});
            this.CapeComboChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CapeComboChoice.FormattingEnabled = true;
            this.CapeComboChoice.Items.AddRange(new object[] {
            "Beginner Cape - $0",
            "Baby Cape - $25",
            "Super Cape - $50",
            "God Cape - $100"});
            this.CapeComboChoice.Location = new System.Drawing.Point(21, 160);
            this.CapeComboChoice.Name = "CapeComboChoice";
            this.CapeComboChoice.Size = new System.Drawing.Size(220, 21);
            this.CapeComboChoice.TabIndex = 7;
            // 
            // TrackComboChoice
            // 
            this.TrackComboChoice.AutoCompleteCustomSource.AddRange(new string[] {
            "Beginner Cape - $0",
            "Baby Cape - $25",
            "Super Cape - $50",
            "God Cape - $100"});
            this.TrackComboChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrackComboChoice.FormattingEnabled = true;
            this.TrackComboChoice.Location = new System.Drawing.Point(21, 196);
            this.TrackComboChoice.Name = "TrackComboChoice";
            this.TrackComboChoice.Size = new System.Drawing.Size(220, 21);
            this.TrackComboChoice.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Player Name";
            // 
            // TrackNameLabel
            // 
            this.TrackNameLabel.AutoSize = true;
            this.TrackNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.TrackNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TrackNameLabel.Location = new System.Drawing.Point(235, 54);
            this.TrackNameLabel.Name = "TrackNameLabel";
            this.TrackNameLabel.Size = new System.Drawing.Size(96, 22);
            this.TrackNameLabel.TabIndex = 10;
            this.TrackNameLabel.Text = "Track: N/A";
            this.TrackNameLabel.Visible = false;
            // 
            // PlayerInfoPanel
            // 
            this.PlayerInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.PlayerInfoPanel.Controls.Add(this.AnimalBetLabel);
            this.PlayerInfoPanel.Controls.Add(this.AnimalPictureBox);
            this.PlayerInfoPanel.Controls.Add(this.MoneyLabel);
            this.PlayerInfoPanel.Controls.Add(this.PlayerNameLabel);
            this.PlayerInfoPanel.Location = new System.Drawing.Point(665, 12);
            this.PlayerInfoPanel.Name = "PlayerInfoPanel";
            this.PlayerInfoPanel.Size = new System.Drawing.Size(123, 212);
            this.PlayerInfoPanel.TabIndex = 11;
            this.PlayerInfoPanel.Visible = false;
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PlayerNameLabel.Location = new System.Drawing.Point(3, 14);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(67, 13);
            this.PlayerNameLabel.TabIndex = 10;
            this.PlayerNameLabel.Text = "Player Name";
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.MoneyLabel.Location = new System.Drawing.Point(3, 40);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(51, 13);
            this.MoneyLabel.TabIndex = 11;
            this.MoneyLabel.Text = "Money: 0";
            // 
            // AnimalPictureBox
            // 
            this.AnimalPictureBox.Image = global::RunningAnimals.Properties.Resources.duck;
            this.AnimalPictureBox.Location = new System.Drawing.Point(12, 118);
            this.AnimalPictureBox.Name = "AnimalPictureBox";
            this.AnimalPictureBox.Size = new System.Drawing.Size(100, 72);
            this.AnimalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AnimalPictureBox.TabIndex = 13;
            this.AnimalPictureBox.TabStop = false;
            // 
            // BetAmountInput
            // 
            this.BetAmountInput.Location = new System.Drawing.Point(20, 88);
            this.BetAmountInput.Name = "BetAmountInput";
            this.BetAmountInput.Size = new System.Drawing.Size(220, 20);
            this.BetAmountInput.TabIndex = 10;
            this.BetAmountInput.Text = "25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Place Bet Amount";
            // 
            // AnimalBetLabel
            // 
            this.AnimalBetLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.AnimalBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnimalBetLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.AnimalBetLabel.Location = new System.Drawing.Point(6, 69);
            this.AnimalBetLabel.Name = "AnimalBetLabel";
            this.AnimalBetLabel.ReadOnly = true;
            this.AnimalBetLabel.Size = new System.Drawing.Size(106, 43);
            this.AnimalBetLabel.TabIndex = 14;
            this.AnimalBetLabel.Text = "";
            // 
            // StartRaceButton
            // 
            this.StartRaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.StartRaceButton.Location = new System.Drawing.Point(469, 416);
            this.StartRaceButton.Name = "StartRaceButton";
            this.StartRaceButton.Size = new System.Drawing.Size(319, 49);
            this.StartRaceButton.TabIndex = 12;
            this.StartRaceButton.Text = "Start Race";
            this.StartRaceButton.UseVisualStyleBackColor = true;
            this.StartRaceButton.Visible = false;
            this.StartRaceButton.Click += new System.EventHandler(this.StartRace_click);
            // 
            // WinningPlayerLabel
            // 
            this.WinningPlayerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.WinningPlayerLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WinningPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.WinningPlayerLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.WinningPlayerLabel.Location = new System.Drawing.Point(239, 79);
            this.WinningPlayerLabel.Name = "WinningPlayerLabel";
            this.WinningPlayerLabel.ReadOnly = true;
            this.WinningPlayerLabel.Size = new System.Drawing.Size(212, 386);
            this.WinningPlayerLabel.TabIndex = 13;
            this.WinningPlayerLabel.Text = "";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.WinningPlayerLabel);
            this.Controls.Add(this.StartRaceButton);
            this.Controls.Add(this.PlayerInfoPanel);
            this.Controls.Add(this.TrackNameLabel);
            this.Controls.Add(this.PlayerCreationPanel);
            this.Controls.Add(this.AnimalListText);
            this.Controls.Add(this.GameTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Running Animals";
            this.PlayerCreationPanel.ResumeLayout(false);
            this.PlayerCreationPanel.PerformLayout();
            this.PlayerInfoPanel.ResumeLayout(false);
            this.PlayerInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GameTitle;
        public System.Windows.Forms.RichTextBox AnimalListText;
        private System.Windows.Forms.Button CreatePlayerButton;
        public System.Windows.Forms.TextBox PlayerNameInput;
        public System.Windows.Forms.Panel PlayerCreationPanel;
        private System.Windows.Forms.ComboBox AnimalComboChoice;
        private System.Windows.Forms.ComboBox CapeComboChoice;
        private System.Windows.Forms.ComboBox TrackComboChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TrackNameLabel;
        private System.Windows.Forms.Panel PlayerInfoPanel;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.PictureBox AnimalPictureBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox BetAmountInput;
        private System.Windows.Forms.RichTextBox AnimalBetLabel;
        private System.Windows.Forms.Button StartRaceButton;
        public System.Windows.Forms.RichTextBox WinningPlayerLabel;
    }
}

