using System;
using System.Collections.Generic;

namespace Word.Game
{
    public class Word
    {   
        private string secretWord;
        private List<char> letterList = new List<char>();
        private string encodedWord;
        
        public void EncodeWord(string randomWord)
        {
            secretWord = randomWord;
            // convert the secret word to underscores
            for (int i = 0; i < secretWord.Length; i++)
            {
                letterList.Add('_');
            }

        }

        public void DisplayWord()
        {   
            for (int i = 0; i < letterList.Count; i++)
            {
                Console.Write(letterList[i] + " ");
            }
        }

        public bool CompareGuess(string letter)
        {
            // Compare letter to secretWord
            // If letter is in secretWord, replace the dash with the letter
            bool letterGuessed = false;
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (letter == secretWord[i].ToString())
                {
                    letterList[i] = letter[0];
                    letterGuessed = true;
                }
            }
            return letterGuessed;
        }
    }
}