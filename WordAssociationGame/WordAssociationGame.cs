using System.ComponentModel.Design;
using System.Text;

namespace WordAssociationGame
{
    public partial class WordAssociationGame : Form
    {
        private const int SEED = 1;
        private Random _rng = new Random(SEED);
        private Trie _root = new();
        private string _wordString;
        private Trie _wordTrie;
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
        }

        private void RevealWordClick(object? sender, EventArgs e)
        {
            uxGuessResult.Text = $"The word is: {_wordString}";
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
            }
            else
            {
                uxGuessResult.Text = $"Similarity Rank: {result}";
            }

        }
    }
}
