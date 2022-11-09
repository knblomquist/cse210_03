using System;
using System.Collections.Generic;

namespace Word.Game
{
    public class Word
    {   
        private string secretWord;
        private List<char> letterList = new List<char>();
        
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

        private bool IsLetterGuessed(string letter)
        {
            // Compare letter to secretWord
            // If letter is in secretWord, replace the underscore with the letter
            bool letterGuessed = false;
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (letter == secretWord[i].ToString())
                {
                    letterGuessed = true;
                }
            }
            return letterGuessed;
        }

        public void UpdateWord(string letter)
        {
            // Compare letter to secretWord
            // If letter is in secretWord, replace the underscore with the letter
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (letter == secretWord[i].ToString())
                {
                    letterList[i] = letter[0];
                }
            }
        }
        public bool IsWordGuessed()
        {
            // Check if the word has been guessed
            bool wordGuessed = true;
            for (int i = 0; i < letterList.Count; i++)
            {
                if (letterList[i] == '_')
                {
                    wordGuessed = false;
                }
            }
            return wordGuessed;
        }
        
    }
}