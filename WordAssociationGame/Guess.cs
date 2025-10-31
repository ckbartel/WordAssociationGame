using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordAssociationGame
{
    public class Guess
    {
        public string Word { get; }
        public int Similarity { get; }

        public Guess(string word, int similarity)
        {
            Word = word;
            Similarity = similarity;
        }

        public override string ToString()
        {
            return $"{Word} ({Similarity})";
        }
        public override bool Equals(object obj)
        {
            if (obj is Guess other)
                return Word.Equals(other.Word, StringComparison.OrdinalIgnoreCase);
            return false;
        }

        public override int GetHashCode()
        {
            return Word.ToLower().GetHashCode();
        }
    }
}
