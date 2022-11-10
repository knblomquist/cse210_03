using System;
using System.Collections.Generic;

namespace cse210_03.Game
{
///class///    
    public class Jumper
    {
        private List<string> player = new List<string>{ 
            "   ___ ", 
            "  /___\\",
            "  \\   /",
            "    o  ",
            "   /|\\",
            "   / \\ ",
            "^^^^^^^^^"};

        private int leftStart;

        public Jumper()
        {
            leftStart = 0;
        }

        public bool removeLine()
        {
            leftStart += 1;
            
            if(leftStart >= 3)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public void toString()
        {
           for(int i = leftStart; i <player.Count; i++)
           {
                Console.WriteLine(player[i]);
           }
        }
    }
}
