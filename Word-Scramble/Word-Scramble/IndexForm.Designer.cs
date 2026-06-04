namespace WordScramble;

partial class IndexForm
{
    private System.ComponentModel.IContainer components = null;

    private Label labelTitle;
    private Label labelAttempts;
    private Label labelAttemptsCount;
    private Label labelGuessedWords;
    private Label labelGuessedWordsValue;
    private Label labelScore;
    private Label labelScoreValue;
    private Label labelScrambledWord;
    private Label labelFailedAttempts;
    private TextBox textBoxInput;
    private TextBox textBoxFailedAttempts;
    private Button buttonCheck;
    private Button buttonSkip;
    private Button buttonHint;

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
        labelTitle = new Label();
        labelAttempts = new Label();
        labelAttemptsCount = new Label();
        labelGuessedWords = new Label();
        labelGuessedWordsValue = new Label();
        labelScore = new Label();
        labelScoreValue = new Label();
        labelScrambledWord = new Label();
        labelFailedAttempts = new Label();
        textBoxInput = new TextBox();
        textBoxFailedAttempts = new TextBox();
        buttonCheck = new Button();
        buttonSkip = new Button();
        buttonHint = new Button();
        SuspendLayout();

        // labelTitle
        labelTitle.Anchor = AnchorStyles.Top;
        labelTitle.AutoSize = true;
        labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
        labelTitle.Location = new Point(151, 24);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(244, 45);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Word Scramble";

        // labelAttempts
        labelAttempts.AutoSize = true;
        labelAttempts.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        labelAttempts.Location = new Point(55, 100);
        labelAttempts.Name = "labelAttempts";
        labelAttempts.Size = new Size(76, 20);
        labelAttempts.TabIndex = 1;
        labelAttempts.Text = "Attempts:";

        // labelAttemptsCount
        labelAttemptsCount.AutoSize = true;
        labelAttemptsCount.BackColor = Color.Teal;
        labelAttemptsCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        labelAttemptsCount.ForeColor = Color.White;
        labelAttemptsCount.Location = new Point(137, 100);
        labelAttemptsCount.MinimumSize = new Size(28, 24);
        labelAttemptsCount.Name = "labelAttemptsCount";
        labelAttemptsCount.Size = new Size(28, 24);
        labelAttemptsCount.TabIndex = 2;
        labelAttemptsCount.Text = "0";
        labelAttemptsCount.TextAlign = ContentAlignment.MiddleCenter;

        // labelGuessedWords
        labelGuessedWords.AutoSize = true;
        labelGuessedWords.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        labelGuessedWords.Location = new Point(220, 100);
        labelGuessedWords.Name = "labelGuessedWords";
        labelGuessedWords.Size = new Size(119, 20);
        labelGuessedWords.TabIndex = 3;
        labelGuessedWords.Text = "Guessed words:";

        // labelGuessedWordsValue
        labelGuessedWordsValue.AutoSize = true;
        labelGuessedWordsValue.BackColor = Color.Teal;
        labelGuessedWordsValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        labelGuessedWordsValue.ForeColor = Color.White;
        labelGuessedWordsValue.Location = new Point(345, 100);
        labelGuessedWordsValue.MinimumSize = new Size(28, 24);
        labelGuessedWordsValue.Name = "labelGuessedWordsValue";
        labelGuessedWordsValue.Size = new Size(28, 24);
        labelGuessedWordsValue.TabIndex = 4;
        labelGuessedWordsValue.Text = "0";
        labelGuessedWordsValue.TextAlign = ContentAlignment.MiddleCenter;

        // labelScore
        labelScore.AutoSize = true;
        labelScore.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        labelScore.Location = new Point(410, 100);
        labelScore.Name = "labelScore";
        labelScore.Size = new Size(51, 20);
        labelScore.TabIndex = 5;
        labelScore.Text = "Score:";

        // labelScoreValue
        labelScoreValue.AutoSize = true;
        labelScoreValue.BackColor = Color.Teal;
        labelScoreValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        labelScoreValue.ForeColor = Color.White;
        labelScoreValue.Location = new Point(467, 100);
        labelScoreValue.MinimumSize = new Size(35, 24);
        labelScoreValue.Name = "labelScoreValue";
        labelScoreValue.Size = new Size(35, 24);
        labelScoreValue.TabIndex = 6;
        labelScoreValue.Text = "0";
        labelScoreValue.TextAlign = ContentAlignment.MiddleCenter;

        // labelScrambledWord
        labelScrambledWord.Anchor = AnchorStyles.Top;
        labelScrambledWord.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        labelScrambledWord.Location = new Point(70, 150);
        labelScrambledWord.Name = "labelScrambledWord";
        labelScrambledWord.Size = new Size(420, 45);
        labelScrambledWord.TabIndex = 7;
        labelScrambledWord.Text = "scrambled word";
        labelScrambledWord.TextAlign = ContentAlignment.MiddleCenter;

        // textBoxInput
        textBoxInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxInput.Location = new Point(66, 214);
        textBoxInput.Name = "textBoxInput";
        textBoxInput.Size = new Size(155, 29);
        textBoxInput.TabIndex = 1;

        // buttonCheck
        buttonCheck.BackColor = Color.Teal;
        buttonCheck.FlatStyle = FlatStyle.Flat;
        buttonCheck.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        buttonCheck.ForeColor = Color.White;
        buttonCheck.Location = new Point(232, 213);
        buttonCheck.Name = "buttonCheck";
        buttonCheck.Size = new Size(85, 31);
        buttonCheck.TabIndex = 2;
        buttonCheck.Text = "Check";
        buttonCheck.UseVisualStyleBackColor = false;
        buttonCheck.Click += buttonCheck_Click;

        // buttonSkip
        buttonSkip.BackColor = Color.Teal;
        buttonSkip.FlatStyle = FlatStyle.Flat;
        buttonSkip.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        buttonSkip.ForeColor = Color.White;
        buttonSkip.Location = new Point(326, 213);
        buttonSkip.Name = "buttonSkip";
        buttonSkip.Size = new Size(75, 31);
        buttonSkip.TabIndex = 3;
        buttonSkip.Text = "Skip";
        buttonSkip.UseVisualStyleBackColor = false;
        buttonSkip.Click += buttonSkip_Click;

        // buttonHint
        buttonHint.BackColor = Color.Teal;
        buttonHint.FlatStyle = FlatStyle.Flat;
        buttonHint.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        buttonHint.ForeColor = Color.White;
        buttonHint.Location = new Point(410, 213);
        buttonHint.Name = "buttonHint";
        buttonHint.Size = new Size(75, 31);
        buttonHint.TabIndex = 4;
        buttonHint.Text = "Hint";
        buttonHint.UseVisualStyleBackColor = false;
        buttonHint.Click += buttonHint_Click;

        // labelFailedAttempts
        labelFailedAttempts.Anchor = AnchorStyles.Top;
        labelFailedAttempts.AutoSize = true;
        labelFailedAttempts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        labelFailedAttempts.Location = new Point(205, 273);
        labelFailedAttempts.Name = "labelFailedAttempts";
        labelFailedAttempts.Size = new Size(133, 21);
        labelFailedAttempts.TabIndex = 12;
        labelFailedAttempts.Text = "Failed attempts:";

        // textBoxFailedAttempts
        textBoxFailedAttempts.BackColor = Color.FromArgb(235, 235, 235);
        textBoxFailedAttempts.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxFailedAttempts.Location = new Point(66, 305);
        textBoxFailedAttempts.Multiline = true;
        textBoxFailedAttempts.Name = "textBoxFailedAttempts";
        textBoxFailedAttempts.ReadOnly = true;
        textBoxFailedAttempts.ScrollBars = ScrollBars.Vertical;
        textBoxFailedAttempts.Size = new Size(419, 105);
        textBoxFailedAttempts.TabIndex = 5;

        // IndexForm
        AcceptButton = buttonCheck;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(248, 248, 255);
        ClientSize = new Size(554, 451);
        Controls.Add(textBoxFailedAttempts);
        Controls.Add(labelFailedAttempts);
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