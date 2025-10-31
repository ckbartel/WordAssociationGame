using System.ComponentModel.Design;
using System.Text;
using System.Windows.Forms;

namespace WordAssociationGame
{
    public partial class WordAssociationGame : Form
    {
        private const int SEED = 1;
        private Random _rng = new Random(); // new Random(SEED);
        private Trie _root = new();
        private string _wordString;
        private Trie _wordTrie;
        private HashSet<Guess> _guesses = new();
        int _lettersRevealed = 0;
        public WordAssociationGame()
        {
            InitializeComponent();
        }

        private void LoadDataClick(object? sender, EventArgs e)
        {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(uxOpenFileDialog.FileName))
                {
                    _root = new();
                    int numWords = Convert.ToInt32(sr.ReadLine());
                    Trie[] words = new Trie[numWords];
                    for (int i = 0; i < numWords; i++)
                    {
                        words[i] = _root.Add(sr.ReadLine()!);
                        words[i].Similarities = new Trie[numWords];
                    }
                    for (int i = 0; i < numWords; i++)
                    {
                        string[] indices = sr.ReadLine()!.Split(',');
                        for (int j = 0; j < indices.Length; j++)
                        {
                            int index = Convert.ToInt32(indices[j]);
                            words[i].Similarities![j] = words[index];
                        }
                    }
                    sr.Close();
                }
                MessageBox.Show("File Successfully Read");
                GenerateWord();
            } 
            else
            {
                MessageBox.Show("Error Reading File");
            }
            
        }

        private void GenerateWord()
        {
            uxGuessResult.Text = "Guess The Word!";
            StringBuilder sb = new StringBuilder();
            _wordTrie = _root.GetRandomWord(sb, _rng);
            _wordString = sb.ToString();
            uxHint.Text = "";
            for (int i = 0; i < _wordString.Length; i++)
            {
                uxHint.Text += "_ ";
            }
        }

        private void RevealLetterClick(object? sender, EventArgs e)
        {
            _lettersRevealed = (_lettersRevealed == _wordString.Length) ? _lettersRevealed : _lettersRevealed + 1;
            uxHint.Text = "";
            int i;
            for (i = 0; i < _lettersRevealed; i++)
            {
                uxHint.Text += _wordString[i] + " ";
            }
            for (;i < _wordString.Length; i++)
            {
                uxHint.Text += "_ ";
            }

        }

        private void GuessClick(object? sender, EventArgs e)
        {
            string guess = uxGuessBox.Text.Trim().ToLower();
            Trie? guessTrie = _root.Find(guess);
            int? result = _wordTrie.SimilarityRank(guessTrie);
            if (result == null)
            {
                uxGuessResult.Text = "Guess Doesn't Exist";
            } 
            else if (result == 0)
            {
                GenerateWord();
                MessageBox.Show("Correct!");
                _guesses.Clear();
                uxGuesses.DataSource = null;
                _lettersRevealed = 0;
            }
            else
            {
                uxGuessResult.Text = $"Similarity Rank: {result}";
                AddGuess(guess, (int)result);
            }

        }

        private void AddGuess(string word, int similarity)
        {
            _guesses.Add(new Guess(word, similarity));

            var sorted = _guesses.OrderByDescending(g => -1 * g.Similarity).ToList();

            uxGuesses.DataSource = null;
            uxGuesses.DataSource = sorted;
        }

        private void OnEnter(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GuessClick(null, new());
            }
        }
    }
}
