namespace WordScramble;

partial class IndexForm
{
    private System.ComponentModel.IContainer components = null;

    private Label labelTitle;
    private CheckBox checkBoxDarkMode;
    private Label labelAttempts;
    private Label labelAttemptsCount;
    private Label labelGuessedWords;
    private Label labelGuessedWordsValue;
    private Label labelStreak;
    private Label labelStreakValue;
    private Label labelScore;
    private Label labelScoreValue;
    private Label labelTimer;
    private Label labelTimerValue;
    private Label labelScrambledWord;
    private Label labelFailedAttempts;
    private TextBox textBoxInput;
    private TextBox textBoxFailedAttempts;
    private Button buttonCheck;
    private Button buttonSkip;
    private Button buttonHint;
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
        labelTitle = new Label();
        checkBoxDarkMode = new CheckBox();
        labelAttempts = new Label();
        labelAttemptsCount = new Label();
        labelGuessedWords = new Label();
        labelGuessedWordsValue = new Label();
        labelStreak = new Label();
        labelStreakValue = new Label();
        labelScore = new Label();
        labelScoreValue = new Label();
        labelTimer = new Label();
        labelTimerValue = new Label();
        labelScrambledWord = new Label();
        labelFailedAttempts = new Label();
        textBoxInput = new TextBox();
        textBoxFailedAttempts = new TextBox();
        buttonCheck = new Button();
        buttonSkip = new Button();
        buttonHint = new Button();
        wordTimer = new System.Windows.Forms.Timer(components);
        SuspendLayout();

        // labelTitle
        labelTitle.Anchor = AnchorStyles.Top;
        labelTitle.AutoSize = true;
        labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
        labelTitle.Location = new Point(135, 20);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(244, 45);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Word Scramble";

        // checkBoxDarkMode
        checkBoxDarkMode.Appearance = Appearance.Button;
        checkBoxDarkMode.BackColor = Color.FromArgb(0, 105, 105);
        checkBoxDarkMode.FlatStyle = FlatStyle.Flat;
        checkBoxDarkMode.FlatAppearance.BorderColor = Color.FromArgb(0, 80, 80);
        checkBoxDarkMode.FlatAppearance.BorderSize = 2;
        checkBoxDarkMode.FlatAppearance.CheckedBackColor = Color.FromArgb(55, 65, 65);
        checkBoxDarkMode.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 75, 75);
        checkBoxDarkMode.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 55, 55);
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

        // labelTimer
        labelTimer.AutoSize = true;
        labelTimer.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        labelTimer.Location = new Point(215, 80);
        labelTimer.Name = "labelTimer";
        labelTimer.Size = new Size(48, 20);
        labelTimer.TabIndex = 2;
        labelTimer.Text = "Time:";

        // labelTimerValue
        labelTimerValue.AutoSize = true;
        labelTimerValue.BackColor = Color.Teal;
        labelTimerValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        labelTimerValue.ForeColor = Color.White;
        labelTimerValue.Location = new Point(270, 78);
        labelTimerValue.MinimumSize = new Size(40, 26);
        labelTimerValue.Name = "labelTimerValue";
        labelTimerValue.Size = new Size(40, 26);
        labelTimerValue.TabIndex = 3;
        labelTimerValue.Text = "30";
        labelTimerValue.TextAlign = ContentAlignment.MiddleCenter;

        // labelAttempts
        labelAttempts.AutoSize = true;
        labelAttempts.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        labelAttempts.Location = new Point(20, 120);
        labelAttempts.Name = "labelAttempts";
        labelAttempts.Size = new Size(72, 19);
        labelAttempts.TabIndex = 4;
        labelAttempts.Text = "Attempts:";

        // labelAttemptsCount
        labelAttemptsCount.AutoSize = true;
        labelAttemptsCount.BackColor = Color.Teal;
        labelAttemptsCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        labelAttemptsCount.ForeColor = Color.White;
        labelAttemptsCount.Location = new Point(95, 118);
        labelAttemptsCount.MinimumSize = new Size(30, 26);
        labelAttemptsCount.Name = "labelAttemptsCount";
        labelAttemptsCount.Size = new Size(30, 26);
        labelAttemptsCount.TabIndex = 5;
        labelAttemptsCount.Text = "0";
        labelAttemptsCount.TextAlign = ContentAlignment.MiddleCenter;

        // labelGuessedWords
        labelGuessedWords.AutoSize = true;
        labelGuessedWords.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        labelGuessedWords.Location = new Point(140, 120);
        labelGuessedWords.Name = "labelGuessedWords";
        labelGuessedWords.Size = new Size(111, 19);
        labelGuessedWords.TabIndex = 6;
        labelGuessedWords.Text = "Guessed words:";

        // labelGuessedWordsValue
        labelGuessedWordsValue.AutoSize = true;
        labelGuessedWordsValue.BackColor = Color.Teal;
        labelGuessedWordsValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        labelGuessedWordsValue.ForeColor = Color.White;
        labelGuessedWordsValue.Location = new Point(255, 118);
        labelGuessedWordsValue.MinimumSize = new Size(30, 26);
        labelGuessedWordsValue.Name = "labelGuessedWordsValue";
        labelGuessedWordsValue.Size = new Size(30, 26);
        labelGuessedWordsValue.TabIndex = 7;
        labelGuessedWordsValue.Text = "0";
        labelGuessedWordsValue.TextAlign = ContentAlignment.MiddleCenter;

        // labelStreak
        labelStreak.AutoSize = true;
        labelStreak.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        labelStreak.Location = new Point(310, 120);
        labelStreak.Name = "labelStreak";
        labelStreak.Size = new Size(55, 19);
        labelStreak.TabIndex = 8;
        labelStreak.Text = "Streak:";

        // labelStreakValue
        labelStreakValue.AutoSize = true;
        labelStreakValue.BackColor = Color.Teal;
        labelStreakValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        labelStreakValue.ForeColor = Color.White;
        labelStreakValue.Location = new Point(368, 118);
        labelStreakValue.MinimumSize = new Size(30, 26);
        labelStreakValue.Name = "labelStreakValue";
        labelStreakValue.Size = new Size(30, 26);
        labelStreakValue.TabIndex = 9;
        labelStreakValue.Text = "0";
        labelStreakValue.TextAlign = ContentAlignment.MiddleCenter;

        // labelScore
        labelScore.AutoSize = true;
        labelScore.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        labelScore.Location = new Point(415, 120);
        labelScore.Name = "labelScore";
        labelScore.Size = new Size(49, 19);
        labelScore.TabIndex = 10;
        labelScore.Text = "Score:";

        // labelScoreValue
        labelScoreValue.AutoSize = true;
        labelScoreValue.BackColor = Color.Teal;
        labelScoreValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        labelScoreValue.ForeColor = Color.White;
        labelScoreValue.Location = new Point(467, 118);
        labelScoreValue.MinimumSize = new Size(45, 26);
        labelScoreValue.Name = "labelScoreValue";
        labelScoreValue.Size = new Size(45, 26);
        labelScoreValue.TabIndex = 11;
        labelScoreValue.Text = "0";
        labelScoreValue.TextAlign = ContentAlignment.MiddleCenter;

        // labelScrambledWord
        labelScrambledWord.Anchor = AnchorStyles.Top;
        labelScrambledWord.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        labelScrambledWord.Location = new Point(70, 165);
        labelScrambledWord.Name = "labelScrambledWord";
        labelScrambledWord.Size = new Size(420, 80);
        labelScrambledWord.TabIndex = 12;
        labelScrambledWord.Text = "scrambled word";
        labelScrambledWord.TextAlign = ContentAlignment.MiddleCenter;

        // textBoxInput
        textBoxInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxInput.Location = new Point(66, 260);
        textBoxInput.Name = "textBoxInput";
        textBoxInput.Size = new Size(155, 29);
        textBoxInput.TabIndex = 13;

        // buttonCheck
        buttonCheck.BackColor = Color.Teal;
        buttonCheck.FlatStyle = FlatStyle.Flat;
        buttonCheck.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        buttonCheck.ForeColor = Color.White;
        buttonCheck.Location = new Point(232, 259);
        buttonCheck.Name = "buttonCheck";
        buttonCheck.Size = new Size(85, 31);
        buttonCheck.TabIndex = 14;
        buttonCheck.Text = "Check";
        buttonCheck.UseVisualStyleBackColor = false;
        buttonCheck.Click += buttonCheck_Click;

        // buttonSkip
        buttonSkip.BackColor = Color.Teal;
        buttonSkip.FlatStyle = FlatStyle.Flat;
        buttonSkip.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        buttonSkip.ForeColor = Color.White;
        buttonSkip.Location = new Point(326, 259);
        buttonSkip.Name = "buttonSkip";
        buttonSkip.Size = new Size(75, 31);
        buttonSkip.TabIndex = 15;
        buttonSkip.Text = "Skip";
        buttonSkip.UseVisualStyleBackColor = false;
        buttonSkip.Click += buttonSkip_Click;

        // buttonHint
        buttonHint.BackColor = Color.Teal;
        buttonHint.FlatStyle = FlatStyle.Flat;
        buttonHint.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        buttonHint.ForeColor = Color.White;
        buttonHint.Location = new Point(410, 259);
        buttonHint.Name = "buttonHint";
        buttonHint.Size = new Size(75, 31);
        buttonHint.TabIndex = 16;
        buttonHint.Text = "Hint";
        buttonHint.UseVisualStyleBackColor = false;
        buttonHint.Click += buttonHint_Click;

        // labelFailedAttempts
        labelFailedAttempts.Anchor = AnchorStyles.Top;
        labelFailedAttempts.AutoSize = true;
        labelFailedAttempts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        labelFailedAttempts.Location = new Point(205, 325);
        labelFailedAttempts.Name = "labelFailedAttempts";
        labelFailedAttempts.Size = new Size(133, 21);
        labelFailedAttempts.TabIndex = 17;
        labelFailedAttempts.Text = "Failed attempts:";

        // textBoxFailedAttempts
        textBoxFailedAttempts.BackColor = Color.FromArgb(235, 235, 235);
        textBoxFailedAttempts.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxFailedAttempts.Location = new Point(66, 357);
        textBoxFailedAttempts.Multiline = true;
        textBoxFailedAttempts.Name = "textBoxFailedAttempts";
        textBoxFailedAttempts.ReadOnly = true;
        textBoxFailedAttempts.ScrollBars = ScrollBars.Vertical;
        textBoxFailedAttempts.Size = new Size(419, 105);
        textBoxFailedAttempts.TabIndex = 18;

        // IndexForm
        AcceptButton = buttonCheck;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(248, 248, 255);
        ClientSize = new Size(554, 500);
        Controls.Add(textBoxFailedAttempts);
        Controls.Add(labelFailedAttempts);
        Controls.Add(buttonHint);
        Controls.Add(buttonSkip);
        Controls.Add(buttonCheck);
        Controls.Add(textBoxInput);
        Controls.Add(labelScrambledWord);
        Controls.Add(labelScoreValue);
        Controls.Add(labelScore);
        Controls.Add(labelStreakValue);
        Controls.Add(labelStreak);
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