namespace WordScramble;

partial class IndexForm
{
    private System.ComponentModel.IContainer components = null;

    // ===================== Form Controls =====================
    private Label labelTitle;
    private CheckBox checkBoxDarkMode;

    // ===================== Stats Controls =====================
    private Label labelAttempts;
    private Label labelAttemptsCount;
    private Label labelGuessedWords;
    private Label labelGuessedWordsValue;
    private Label labelScore;
    private Label labelScoreValue;
    private Label labelTimer;
    private Label labelTimerValue;

    // ===================== Game Area Controls =====================
    private Label labelScrambledWord;
    private Label labelMessage;
    private TextBox textBoxInput;
    private Button buttonCheck;
    private Button buttonSkip;
    private Button buttonHint;

    // ===================== Failed Attempts Controls =====================
    private Label labelFailedAttempts;
    private TextBox textBoxFailedAttempts;

    // ===================== Timer =====================
    private System.Windows.Forms.Timer wordTimer;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();

        // ===================== Create Controls =====================
        labelTitle = new Label();
        checkBoxDarkMode = new CheckBox();

        labelAttempts = new Label();
        labelAttemptsCount = new Label();
        labelGuessedWords = new Label();
        labelGuessedWordsValue = new Label();
        labelScore = new Label();
        labelScoreValue = new Label();
        labelTimer = new Label();
        labelTimerValue = new Label();

        labelScrambledWord = new Label();
        labelMessage = new Label();
        textBoxInput = new TextBox();
        buttonCheck = new Button();
        buttonSkip = new Button();
        buttonHint = new Button();

        labelFailedAttempts = new Label();
        textBoxFailedAttempts = new TextBox();

        wordTimer = new System.Windows.Forms.Timer(components);

        SuspendLayout();

        // ===================== Header Section =====================

        // Title
        labelTitle.Anchor = AnchorStyles.Top;
        labelTitle.AutoSize = true;
        labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
        labelTitle.ForeColor = Color.FromArgb(17, 24, 39);
        labelTitle.Location = new Point(135, 20);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(244, 45);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Word Scramble";

        // Dark mode button
        checkBoxDarkMode.Appearance = Appearance.Button;
        checkBoxDarkMode.BackColor = Color.FromArgb(37, 99, 235);
        checkBoxDarkMode.FlatStyle = FlatStyle.Flat;
        checkBoxDarkMode.FlatAppearance.BorderColor = Color.FromArgb(29, 78, 216);
        checkBoxDarkMode.FlatAppearance.BorderSize = 1;
        checkBoxDarkMode.FlatAppearance.CheckedBackColor = Color.FromArgb(37, 99, 235);
        checkBoxDarkMode.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
        checkBoxDarkMode.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
        checkBoxDarkMode.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        checkBoxDarkMode.ForeColor = Color.White;
        checkBoxDarkMode.Location = new Point(405, 25);
        checkBoxDarkMode.Name = "checkBoxDarkMode";
        checkBoxDarkMode.Size = new Size(115, 35);
        checkBoxDarkMode.TabIndex = 1;
        checkBoxDarkMode.Text = "Dark Mode";
        checkBoxDarkMode.TextAlign = ContentAlignment.MiddleCenter;
        checkBoxDarkMode.UseVisualStyleBackColor = false;
        checkBoxDarkMode.CheckedChanged += checkBoxDarkMode_CheckedChanged;

        // ===================== Timer Section =====================

        // Timer label
        labelTimer.AutoSize = true;
        labelTimer.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        labelTimer.ForeColor = Color.FromArgb(17, 24, 39);
        labelTimer.Location = new Point(215, 80);
        labelTimer.Name = "labelTimer";
        labelTimer.Size = new Size(48, 20);
        labelTimer.TabIndex = 2;
        labelTimer.Text = "Time:";

        // Timer value
        labelTimerValue.AutoSize = true;
        labelTimerValue.BackColor = Color.FromArgb(30, 64, 175);
        labelTimerValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        labelTimerValue.ForeColor = Color.White;
        labelTimerValue.Location = new Point(270, 78);
        labelTimerValue.MinimumSize = new Size(40, 26);
        labelTimerValue.Name = "labelTimerValue";
        labelTimerValue.Size = new Size(40, 26);
        labelTimerValue.TabIndex = 3;
        labelTimerValue.Text = "45";
        labelTimerValue.TextAlign = ContentAlignment.MiddleCenter;

        // ===================== Stats Section =====================

        // Attempts label
        labelAttempts.AutoSize = true;
        labelAttempts.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        labelAttempts.ForeColor = Color.FromArgb(17, 24, 39);
        labelAttempts.Location = new Point(70, 120);
        labelAttempts.Name = "labelAttempts";
        labelAttempts.Size = new Size(72, 19);
        labelAttempts.TabIndex = 4;
        labelAttempts.Text = "Attempts:";

        // Attempts value
        labelAttemptsCount.AutoSize = true;
        labelAttemptsCount.BackColor = Color.FromArgb(30, 64, 175);
        labelAttemptsCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        labelAttemptsCount.ForeColor = Color.White;
        labelAttemptsCount.Location = new Point(145, 118);
        labelAttemptsCount.MinimumSize = new Size(30, 26);
        labelAttemptsCount.Name = "labelAttemptsCount";
        labelAttemptsCount.Size = new Size(30, 26);
        labelAttemptsCount.TabIndex = 5;
        labelAttemptsCount.Text = "0";
        labelAttemptsCount.TextAlign = ContentAlignment.MiddleCenter;

        // Guessed words label
        labelGuessedWords.AutoSize = true;
        labelGuessedWords.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        labelGuessedWords.ForeColor = Color.FromArgb(17, 24, 39);
        labelGuessedWords.Location = new Point(205, 120);
        labelGuessedWords.Name = "labelGuessedWords";
        labelGuessedWords.Size = new Size(111, 19);
        labelGuessedWords.TabIndex = 6;
        labelGuessedWords.Text = "Guessed words:";

        // Guessed words value
        labelGuessedWordsValue.AutoSize = true;
        labelGuessedWordsValue.BackColor = Color.FromArgb(30, 64, 175);
        labelGuessedWordsValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        labelGuessedWordsValue.ForeColor = Color.White;
        labelGuessedWordsValue.Location = new Point(320, 118);
        labelGuessedWordsValue.MinimumSize = new Size(30, 26);
        labelGuessedWordsValue.Name = "labelGuessedWordsValue";
        labelGuessedWordsValue.Size = new Size(30, 26);
        labelGuessedWordsValue.TabIndex = 7;
        labelGuessedWordsValue.Text = "0";
        labelGuessedWordsValue.TextAlign = ContentAlignment.MiddleCenter;

        // Score label
        labelScore.AutoSize = true;
        labelScore.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        labelScore.ForeColor = Color.FromArgb(17, 24, 39);
        labelScore.Location = new Point(385, 120);
        labelScore.Name = "labelScore";
        labelScore.Size = new Size(49, 19);
        labelScore.TabIndex = 8;
        labelScore.Text = "Score:";

        // Score value
        labelScoreValue.AutoSize = true;
        labelScoreValue.BackColor = Color.FromArgb(30, 64, 175);
        labelScoreValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        labelScoreValue.ForeColor = Color.White;
        labelScoreValue.Location = new Point(438, 118);
        labelScoreValue.MinimumSize = new Size(45, 26);
        labelScoreValue.Name = "labelScoreValue";
        labelScoreValue.Size = new Size(45, 26);
        labelScoreValue.TabIndex = 9;
        labelScoreValue.Text = "0";
        labelScoreValue.TextAlign = ContentAlignment.MiddleCenter;

        // ===================== Word Display Section =====================

        // Scrambled word and hint
        labelScrambledWord.Anchor = AnchorStyles.Top;
        labelScrambledWord.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        labelScrambledWord.ForeColor = Color.FromArgb(17, 24, 39);
        labelScrambledWord.Location = new Point(70, 165);
        labelScrambledWord.Name = "labelScrambledWord";
        labelScrambledWord.Size = new Size(420, 80);
        labelScrambledWord.TabIndex = 10;
        labelScrambledWord.Text = "scrambled word";
        labelScrambledWord.TextAlign = ContentAlignment.MiddleCenter;

        // ===================== Input And Buttons Section =====================

        // Player input
        textBoxInput.BorderStyle = BorderStyle.FixedSingle;
        textBoxInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxInput.Location = new Point(66, 260);
        textBoxInput.Name = "textBoxInput";
        textBoxInput.Size = new Size(155, 29);
        textBoxInput.TabIndex = 11;

        // Check button
        buttonCheck.BackColor = Color.FromArgb(37, 99, 235);
        buttonCheck.FlatStyle = FlatStyle.Flat;
        buttonCheck.FlatAppearance.BorderSize = 0;
        buttonCheck.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
        buttonCheck.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
        buttonCheck.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        buttonCheck.ForeColor = Color.White;
        buttonCheck.Location = new Point(232, 259);
        buttonCheck.Name = "buttonCheck";
        buttonCheck.Size = new Size(85, 31);
        buttonCheck.TabIndex = 12;
        buttonCheck.Text = "Check";
        buttonCheck.UseVisualStyleBackColor = false;
        buttonCheck.Click += buttonCheck_Click;

        // Skip button
        buttonSkip.BackColor = Color.FromArgb(37, 99, 235);
        buttonSkip.FlatStyle = FlatStyle.Flat;
        buttonSkip.FlatAppearance.BorderSize = 0;
        buttonSkip.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
        buttonSkip.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
        buttonSkip.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        buttonSkip.ForeColor = Color.White;
        buttonSkip.Location = new Point(326, 259);
        buttonSkip.Name = "buttonSkip";
        buttonSkip.Size = new Size(75, 31);
        buttonSkip.TabIndex = 13;
        buttonSkip.Text = "Skip";
        buttonSkip.UseVisualStyleBackColor = false;
        buttonSkip.Click += buttonSkip_Click;

        // Hint button
        buttonHint.BackColor = Color.FromArgb(37, 99, 235);
        buttonHint.FlatStyle = FlatStyle.Flat;
        buttonHint.FlatAppearance.BorderSize = 0;
        buttonHint.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
        buttonHint.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
        buttonHint.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        buttonHint.ForeColor = Color.White;
        buttonHint.Location = new Point(410, 259);
        buttonHint.Name = "buttonHint";
        buttonHint.Size = new Size(75, 31);
        buttonHint.TabIndex = 14;
        buttonHint.Text = "Hint";
        buttonHint.UseVisualStyleBackColor = false;
        buttonHint.Click += buttonHint_Click;

        // Message label
        labelMessage.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        labelMessage.Location = new Point(66, 302);
        labelMessage.Name = "labelMessage";
        labelMessage.Size = new Size(419, 24);
        labelMessage.TabIndex = 15;
        labelMessage.Text = "";
        labelMessage.TextAlign = ContentAlignment.MiddleCenter;

        // ===================== Failed Attempts Section =====================

        // Failed attempts label
        labelFailedAttempts.Anchor = AnchorStyles.Top;
        labelFailedAttempts.AutoSize = true;
        labelFailedAttempts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        labelFailedAttempts.ForeColor = Color.FromArgb(17, 24, 39);
        labelFailedAttempts.Location = new Point(205, 335);
        labelFailedAttempts.Name = "labelFailedAttempts";
        labelFailedAttempts.Size = new Size(133, 21);
        labelFailedAttempts.TabIndex = 16;
        labelFailedAttempts.Text = "Failed attempts:";

        // Failed attempts box
        textBoxFailedAttempts.BackColor = Color.FromArgb(229, 231, 235);
        textBoxFailedAttempts.BorderStyle = BorderStyle.FixedSingle;
        textBoxFailedAttempts.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxFailedAttempts.Location = new Point(66, 367);
        textBoxFailedAttempts.Multiline = true;
        textBoxFailedAttempts.Name = "textBoxFailedAttempts";
        textBoxFailedAttempts.ReadOnly = true;
        textBoxFailedAttempts.ScrollBars = ScrollBars.Vertical;
        textBoxFailedAttempts.Size = new Size(419, 105);
        textBoxFailedAttempts.TabIndex = 17;

        // ===================== Form Settings =====================

        AcceptButton = buttonCheck;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(244, 247, 251);
        ClientSize = new Size(554, 520);

        // Add controls to the form
        Controls.Add(textBoxFailedAttempts);
        Controls.Add(labelFailedAttempts);
        Controls.Add(labelMessage);
        Controls.Add(buttonHint);
        Controls.Add(buttonSkip);
        Controls.Add(buttonCheck);
        Controls.Add(textBoxInput);
        Controls.Add(labelScrambledWord);
        Controls.Add(labelScoreValue);
        Controls.Add(labelScore);
        Controls.Add(labelGuessedWordsValue);
        Controls.Add(labelGuessedWords);
        Controls.Add(labelAttemptsCount);
        Controls.Add(labelAttempts);
        Controls.Add(labelTimerValue);
        Controls.Add(labelTimer);
        Controls.Add(checkBoxDarkMode);
        Controls.Add(labelTitle);

        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "IndexForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Word Scramble";
        Load += IndexForm_Load;

        ResumeLayout(false);
        PerformLayout();
    }
}