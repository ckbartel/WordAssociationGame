using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordAssociationGame
{
    public class Trie
    {
        /// <summary>
        /// number of words contained in the trie
        /// </summary>
        public int WordCount { get; private set; } = 0;

        /// <summary>
        /// children of the trie
        /// </summary>
        public Dictionary<char, Trie> Children = new Dictionary<char, Trie>();

        /// <summary>
        /// array of similar trie words ranked in order
        /// </summary>
        public Trie[]? Similarities { get; set; }

        /// <summary>
        /// adds a word to the trie
        /// </summary>
        /// <param name="word">word to add</param>
        /// <returns>trie where word is ended</returns>
        public Trie Add(string word)
        {
            WordCount++;
            if (word == "") return this;
            char c = word[0];
            Trie child;
            if (!Children.TryGetValue(c, out child!))
            {
                child = new Trie();
                Children.Add(c, child);
            }
            return child.Add(word.Substring(1));
        }

        /// <summary>
        /// finds a word in a trie
        /// </summary>
        /// <param name="word">word to find</param>
        /// <returns>trie where word is ended</returns>
        public Trie? Find(string word)
        {
            if (word == "") return this;
            char c = word[0];
            Trie child;
            if (!Children.TryGetValue(c, out child!))
            {
                return null;
            }
            return child.Find(word.Substring(1));
        }

        /// <summary>
        /// gets a random word within the trie
        /// </summary>
        /// <param name="word">current word so far</param>
        /// <param name="rng">random number generator</param>
        /// <returns>trie where word is ended</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public Trie GetRandomWord(StringBuilder word, Random rng)
        {
            int choice = rng.Next(WordCount);

            if (Similarities != null)
            {
                if (choice == 0) return this;
                choice--;
            }

            foreach (var kvp in Children)
            {
                Trie child = kvp.Value;
                if (choice < child.WordCount) return child.GetRandomWord(word.Append(kvp.Key), rng);
                choice -= child.WordCount;
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// finds the similarity ranking between this trie and another
        /// </summary>
        /// <param name="other">other trie</param>
        /// <returns>0 if the same, 1+ if similar, null if no relation</returns>
        public int? SimilarityRank(Trie? other)
        {
            if (other == null) return null;

            if (ReferenceEquals(this, other)) return 0;

            if (Similarities == null) return null;

            for (int i = 0; i < Similarities.Length; i++)
            {
                if (ReferenceEquals(Similarities[i], other)) return i + 1;
            }

            return null;
        }

    }
}
