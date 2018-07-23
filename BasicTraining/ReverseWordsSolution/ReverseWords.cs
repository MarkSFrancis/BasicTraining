using System;

namespace ReverseWordsSolution
{
    public static class ReverseWords
    {
        public static string Reverse(string sentence)
        {
            if (sentence == null)
            {
                throw new ArgumentNullException(nameof(sentence));
            }

            string[] words = sentence.Split(' ');

            for (int wordIndex = 0; wordIndex < words.Length; ++wordIndex)
            {
                var chars = words[wordIndex].ToCharArray();
                Array.Reverse(chars);
                words[wordIndex] = new string(chars);
            }

            return string.Join(" ", words);
        }
    }
}
