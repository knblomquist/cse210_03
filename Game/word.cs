using System;
using System.Collections.Generic;

namespace cse210_03.Game
{
    public class Word
    {   
        private string secretWord;
        private List<char> letterList = new List<char>();

        private WordFactory factory = new WordFactory();

        public Word(){
            string randomWord = factory.RandomWord();
            secretWord = randomWord;
            // convert the secret word to underscores
            for (int i = 0; i < secretWord.Length; i++)
            {
                letterList.Add('_');
            }
        }
        
        public string GetSecretWord()
        {
            return secretWord;
        }

        public void DisplayWord()
        {   
            for (int i = 0; i < letterList.Count; i++)
            {
                Console.Write(letterList[i] + " ");
            }
        }


        public bool UpdateWord(char letter)

        {
            // Compare letter to secretWord
            // If letter is in secretWord, replace the underscore with the letter
            bool letterGuessed = false;
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (letter.ToString().ToLower() == secretWord[i].ToString().ToLower())
                {
                    letterList[i] = secretWord[i];
                    letterGuessed = true;
                }

            }
            return letterGuessed;
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