using System;
using System.Collections.Generic;

namespace cse210_03.Game
{
    public class Director
    {
        private Jumper player = new Jumper();
        private Word secretWord = new Word();
        private bool _isPlaying = true;
        private bool _correctGuess = false;

        

        public Director()
        {
            Console.WriteLine("Welcome to a game of Jumper!");
            Console.WriteLine("Guess the hidden word one letter at a time!");
            Console.WriteLine("Be careful, the more letters you get wrong the closer you get to a untimely de...");
            Console.WriteLine("Good luck!");
            player.toString();
            secretWord.DisplayWord();


        }

        public void StartGame()
        {
            while(_isPlaying)
            {
                if(_isPlaying)
                {
                    GetInputs();
                    DoUpdates();
                    DoOutputs();
                }
            }
        }

        public void GetInputs()
        {
            

            Console.WriteLine("What letter will you guess? ");
            String charGuess = Console.ReadLine();

            _correctGuess = secretWord.UpdateWord(charGuess[0]);
        }

        public void DoUpdates()
        {
            if(!_correctGuess)
            {
                player.removeLine();
            }
        }

        public void DoOutputs()
        {
            player.toString();
            secretWord.DisplayWord();
        }
    }
}
