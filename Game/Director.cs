using System;

namespace cse210_03.Game
{
    public class Director
    {
        private Jumper player = new Jumper;
        private word secretWord = new word;
        private bool _isPlaying = true;
        private bool _correctGuess = false;

        

        public Director()
        {
            Console.WriteLine("Welcome to a game of Jumper!");
            Console.WriteLine("Guess the hidden word one letter at a time!");
            Console.WriteLine("Be careful, the more letters you get wrong the closer you get to a untimely de...");
            Console.WriteLine("Good luck!");
            Console.WriteLine(player.toString());
            Console.WriteLine(secretWord.DisplayWord());


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
            string guess = Console.ReadLine();

            _correctGuess = secretWord.UpdateWord(guess);
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
            Console.WriteLine(player.toString());
            Console.WriteLine(secretWord.DisplayString());
        }
    }
}
