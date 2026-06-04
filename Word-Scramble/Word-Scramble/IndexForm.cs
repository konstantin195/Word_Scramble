namespace WordScramble;

public partial class IndexForm : Form
{
    private readonly Random random = new();
    private readonly List<string> wordList = new();
    private readonly List<string> failedAttempts = new();

    private const int TimePerWord = 30; // Seconds for each word

    private int attempts = 0;
    private int guessedWords = 0;
    private int score = 0;
    private int hintsUsed = 0;
    private int currentStreak = 0; // Correct answers in a row
    private int timeLeft = TimePerWord;

    private string currentWord = string.Empty;
    private string currentScrambledWord = string.Empty;

    public IndexForm()
    {
        InitializeComponent();

        wordTimer.Interval = 1000; // 1 second
        wordTimer.Tick += wordTimer_Tick;
    }

    private void IndexForm_Load(object sender, EventArgs e)
    {
        GetAllWords();
        GenerateNewWord();
        UpdateLabels();
    }

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

        currentScrambledWord = ScrambleWord(currentWord);
        UpdateScrambledWordLabel();
        ResetTimer();
    }

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
            currentStreak = 0; // Time out breaks the streak

            MessageBox.Show($"Time is up! The correct word was: {currentWord}", "Time up");

            GenerateNewWord();
            UpdateLabels();
            textBoxInput.Focus();
        }
    }

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
            MessageBox.Show("Please enter a word first.", "Empty input");
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

    private void SuccessfulAttempt()
    {
        guessedWords++;
        currentStreak++; // Increase streak after correct answer
        score += 10;

        wordList.Remove(currentWord);

        MessageBox.Show("Correct answer! Good job!", "Success");

        GenerateNewWord();
    }

    private void UnsuccessfulAttempt(string input)
    {
        attempts++;
        currentStreak = 0; // Wrong answer breaks the streak
        score -= 2;

        failedAttempts.Add(input);

        if (attempts > 9)
        {
            MessageBox.Show($"Too many failed attempts. The correct word was: {currentWord}", "New word");
            GenerateNewWord();
        }
    }

    private void UpdateLabels()
    {
        labelAttemptsCount.Text = attempts.ToString();
        labelGuessedWordsValue.Text = guessedWords.ToString();
        labelScoreValue.Text = score.ToString();
        labelStreakValue.Text = currentStreak.ToString();
        labelTimerValue.Text = timeLeft.ToString();

        textBoxFailedAttempts.Text = string.Join(Environment.NewLine, failedAttempts);
        textBoxInput.Clear();
    }

    private void buttonSkip_Click(object sender, EventArgs e)
    {
        currentStreak = 0; // Skipping breaks the streak

        GenerateNewWord();
        UpdateLabels();
        textBoxInput.Focus();
    }

    private void buttonHint_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentWord))
        {
            return;
        }

        int maxHints = Math.Min(2, currentWord.Length);

        if (hintsUsed >= maxHints)
        {
            MessageBox.Show("You already used all hints for this word.", "No hints left");
            textBoxInput.Focus();
            return;
        }

        hintsUsed++;
        score -= 5; // Each hint costs 5 points

        UpdateScrambledWordLabel();
        labelScoreValue.Text = score.ToString();

        if (hintsUsed >= maxHints)
        {
            buttonHint.Enabled = false;
        }

        textBoxInput.Focus();
    }

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
}