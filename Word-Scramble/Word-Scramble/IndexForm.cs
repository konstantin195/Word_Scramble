namespace WordScramble;

public partial class IndexForm : Form
{
    // ===================== Lists And Random =====================
    private readonly Random random = new();
    private readonly List<string> wordList = new();
    private readonly List<string> failedAttempts = new();

    // ===================== Game Settings =====================
    private const int TimePerWord = 45; // Seconds for each word

    // ===================== Game Stats =====================
    private int attempts = 0;
    private int guessedWords = 0;
    private int score = 0;
    private int hintsUsed = 0;
    private int timeLeft = TimePerWord;

    // ===================== Current Word Info =====================
    private string currentWord = string.Empty;
    private string currentScrambledWord = string.Empty;

    public IndexForm()
    {
        InitializeComponent();

        // Timer ticks every 1 second
        wordTimer.Interval = 1000;
        wordTimer.Tick += wordTimer_Tick;

        // Start with the modern blue light theme
        ApplyTheme(false);
    }

    // ===================== Form Load =====================
    private void IndexForm_Load(object sender, EventArgs e)
    {
        GetAllWords();
        GenerateNewWord();
        UpdateLabels();
    }

    // ===================== Load Words =====================
    private void GetAllWords()
    {
        string wordsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "words.txt");

        if (!File.Exists(wordsFilePath))
        {
            MessageBox.Show(
                "The words.txt file was not found. Please make sure it is in the project folder.",
                "Missing file",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            buttonCheck.Enabled = false;
            buttonSkip.Enabled = false;
            buttonHint.Enabled = false;
            wordTimer.Stop();
            return;
        }

        using StreamReader reader = new(wordsFilePath);

        while (!reader.EndOfStream)
        {
            string? word = reader.ReadLine();

            if (!string.IsNullOrWhiteSpace(word))
            {
                wordList.Add(word.Trim().ToLower());
            }
        }
    }

    // ===================== New Word =====================
    private void GenerateNewWord()
    {
        if (wordList.Count == 0)
        {
            wordTimer.Stop();

            labelScrambledWord.Text = "No words left!";
            textBoxInput.Enabled = false;
            buttonCheck.Enabled = false;
            buttonSkip.Enabled = false;
            buttonHint.Enabled = false;
            return;
        }

        int randomIndex = random.Next(wordList.Count);
        currentWord = wordList[randomIndex];

        ResetGameInfo();
    }

    private void ResetGameInfo()
    {
        attempts = 0;
        hintsUsed = 0;
        failedAttempts.Clear();
        textBoxInput.Clear();

        buttonHint.Enabled = true;
        labelMessage.Text = "";

        currentScrambledWord = ScrambleWord(currentWord);
        UpdateScrambledWordLabel();
        ResetTimer();
    }

    // ===================== Timer =====================
    private void ResetTimer()
    {
        timeLeft = TimePerWord;
        labelTimerValue.Text = timeLeft.ToString();

        wordTimer.Stop();
        wordTimer.Start();
    }

    private void wordTimer_Tick(object sender, EventArgs e)
    {
        timeLeft--;
        labelTimerValue.Text = timeLeft.ToString();

        if (timeLeft <= 0)
        {
            wordTimer.Stop();

            MessageBox.Show(
                $"Time is up! The correct word was: {currentWord}",
                "Time up",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            labelMessage.Text = "";

            GenerateNewWord();
            UpdateLabels();
            textBoxInput.Focus();
        }
    }

    // ===================== Scramble Word =====================
    private string ScrambleWord(string word)
    {
        if (word.Length <= 1)
        {
            return word;
        }

        char[] chars = word.ToCharArray();
        string scrambledWord;

        do
        {
            for (int i = chars.Length - 1; i > 0; i--)
            {
                int randomIndex = random.Next(i + 1);
                (chars[i], chars[randomIndex]) = (chars[randomIndex], chars[i]);
            }

            scrambledWord = new string(chars);
        }
        while (scrambledWord == word);

        return scrambledWord;
    }

    // ===================== Check Button =====================
    private void buttonCheck_Click(object sender, EventArgs e)
    {
        CheckTheWord();
        UpdateLabels();
        textBoxInput.Focus();
    }

    private void CheckTheWord()
    {
        string input = textBoxInput.Text.Trim().ToLower();

        if (string.IsNullOrWhiteSpace(input))
        {
            ShowMessage("Please enter a word first.", Color.FromArgb(220, 38, 38));
            return;
        }

        if (input == currentWord)
        {
            SuccessfulAttempt();
        }
        else
        {
            UnsuccessfulAttempt(input);
        }
    }

    // ===================== Correct Answer =====================
    private void SuccessfulAttempt()
    {
        guessedWords++;

        int pointsEarned = GetPointsForCorrectAnswer();
        score += pointsEarned;

        wordList.Remove(currentWord);

        MessageBox.Show(
            $"Correct! You earned {pointsEarned} points.",
            "Correct answer",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        labelMessage.Text = "";

        GenerateNewWord();
    }

    private int GetPointsForCorrectAnswer()
    {
        int points = 15 - hintsUsed * 5;

        return points;
    }

    // ===================== Wrong Answer =====================
    private void UnsuccessfulAttempt(string input)
    {
        attempts++;

        failedAttempts.Add(input);

        ShowMessage("Wrong answer. Try again.", Color.FromArgb(220, 38, 38));

        if (attempts > 9)
        {
            MessageBox.Show(
                $"Too many failed attempts. The correct word was: {currentWord}",
                "New word",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            labelMessage.Text = "";

            GenerateNewWord();
        }
    }

    // ===================== Update Labels =====================
    private void UpdateLabels()
    {
        labelAttemptsCount.Text = attempts.ToString();
        labelGuessedWordsValue.Text = guessedWords.ToString();
        labelScoreValue.Text = score.ToString();
        labelTimerValue.Text = timeLeft.ToString();

        textBoxFailedAttempts.Text = string.Join(Environment.NewLine, failedAttempts);
        textBoxInput.Clear();
    }

    // ===================== Skip Button =====================
    private void buttonSkip_Click(object sender, EventArgs e)
    {
        MessageBox.Show(
            $"Skipped. The correct word was: {currentWord}",
            "Skipped word",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        labelMessage.Text = "";

        GenerateNewWord();
        UpdateLabels();
        textBoxInput.Focus();
    }

    // ===================== Hint Button =====================
    private void buttonHint_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentWord))
        {
            return;
        }

        int maxHints = Math.Min(2, currentWord.Length);

        if (hintsUsed >= maxHints)
        {
            ShowMessage("You already used all hints for this word.", Color.FromArgb(220, 38, 38));
            textBoxInput.Focus();
            return;
        }

        hintsUsed++; // Each hint lowers the reward by 5 points

        UpdateScrambledWordLabel();

        if (hintsUsed >= maxHints)
        {
            buttonHint.Enabled = false;
        }

        textBoxInput.Focus();
    }

    // ===================== Hint Display =====================
    private void UpdateScrambledWordLabel()
    {
        if (hintsUsed == 0)
        {
            labelScrambledWord.Text = currentScrambledWord;
            return;
        }

        labelScrambledWord.Text = $"{currentScrambledWord}{Environment.NewLine}Hint: {GetHintText()}";
    }

    private string GetHintText()
    {
        List<string> letters = new();

        for (int i = 0; i < currentWord.Length; i++)
        {
            if (i < hintsUsed)
            {
                letters.Add(currentWord[i].ToString());
            }
            else
            {
                letters.Add("_");
            }
        }

        return string.Join(" ", letters);
    }

    // ===================== Message Label =====================
    private void ShowMessage(string message, Color color)
    {
        labelMessage.Text = message;
        labelMessage.ForeColor = color;
    }

    // ===================== Dark Mode Button =====================
    private void checkBoxDarkMode_CheckedChanged(object sender, EventArgs e)
    {
        ApplyTheme(checkBoxDarkMode.Checked);
    }

    // ===================== Theme System =====================
    private void ApplyTheme(bool darkMode)
    {
        Color backgroundColor = darkMode ? Color.FromArgb(17, 24, 39) : Color.FromArgb(244, 247, 251);
        Color mainTextColor = darkMode ? Color.White : Color.FromArgb(17, 24, 39);

        Color buttonColor = Color.FromArgb(37, 99, 235);
        Color buttonHoverColor = Color.FromArgb(29, 78, 216);
        Color buttonDownColor = Color.FromArgb(30, 64, 175);

        Color scoreBoxColor = Color.FromArgb(30, 64, 175);

        Color inputBackColor = darkMode ? Color.FromArgb(31, 41, 55) : Color.White;
        Color failedBoxColor = darkMode ? Color.FromArgb(55, 65, 81) : Color.FromArgb(229, 231, 235);

        BackColor = backgroundColor;

        // Normal labels
        labelTitle.ForeColor = mainTextColor;
        labelAttempts.ForeColor = mainTextColor;
        labelGuessedWords.ForeColor = mainTextColor;
        labelScore.ForeColor = mainTextColor;
        labelTimer.ForeColor = mainTextColor;
        labelScrambledWord.ForeColor = mainTextColor;
        labelFailedAttempts.ForeColor = mainTextColor;

        // Dark mode button
        checkBoxDarkMode.Text = darkMode ? "Light Mode" : "Dark Mode";
        checkBoxDarkMode.ForeColor = Color.White;
        checkBoxDarkMode.BackColor = buttonColor;
        checkBoxDarkMode.FlatAppearance.BorderColor = buttonHoverColor;
        checkBoxDarkMode.FlatAppearance.BorderSize = 1;
        checkBoxDarkMode.FlatAppearance.CheckedBackColor = buttonColor;
        checkBoxDarkMode.FlatAppearance.MouseOverBackColor = buttonHoverColor;
        checkBoxDarkMode.FlatAppearance.MouseDownBackColor = buttonDownColor;

        // Value labels
        StyleValueLabel(labelAttemptsCount, scoreBoxColor);
        StyleValueLabel(labelGuessedWordsValue, scoreBoxColor);
        StyleValueLabel(labelScoreValue, scoreBoxColor);
        StyleValueLabel(labelTimerValue, scoreBoxColor);

        // Text boxes
        textBoxInput.BackColor = inputBackColor;
        textBoxInput.ForeColor = mainTextColor;
        textBoxInput.BorderStyle = BorderStyle.FixedSingle;

        textBoxFailedAttempts.BackColor = failedBoxColor;
        textBoxFailedAttempts.ForeColor = mainTextColor;
        textBoxFailedAttempts.BorderStyle = BorderStyle.FixedSingle;

        // Buttons
        StyleButton(buttonCheck, buttonColor, buttonHoverColor, buttonDownColor);
        StyleButton(buttonSkip, buttonColor, buttonHoverColor, buttonDownColor);
        StyleButton(buttonHint, buttonColor, buttonHoverColor, buttonDownColor);
    }

    // ===================== Style Helpers =====================
    private void StyleValueLabel(Label label, Color backColor)
    {
        label.BackColor = backColor;
        label.ForeColor = Color.White;
    }

    private void StyleButton(Button button, Color backColor, Color hoverColor, Color downColor)
    {
        button.BackColor = backColor;
        button.ForeColor = Color.White;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.FlatAppearance.MouseOverBackColor = hoverColor;
        button.FlatAppearance.MouseDownBackColor = downColor;
    }
}