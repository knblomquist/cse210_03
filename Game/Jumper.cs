using System;
using System.Collections.Generic;

namespace Word.Game
{
    public class Word
    {
        private string secretWord;
        private string encodedWord;
        public void AssignWord(string randomWord)
        {
            secretWord = randomWord;
            // converts randomWord to underscores
            encodedWord = new string("_", randomWord.Length);

        }

        public void DisplayWord()
        {
            Console.WriteLine(EncodedWord);
        }

        private bool CompareGuess(string letter, string secretWord, string EncodedWord)
        {
            // Compare letter to secretWord
            // If letter is in secretWord, replace the dash with the lette
            bool letterGuessed = false;
            for (int i = 0; i < secretWord.Length; i++)
            {   
                if (secretWord[i] == letter[0])
                {
                    EncodedWord = EncodedWord.Remove(i, 1);
                    EncodedWord = EncodedWord.Insert(i, letter);
                    letterGuessed = true;
                }
            }
            return letterGuessed;
        }
    }
}