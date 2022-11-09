using System;
using System.Collections.Generic;

namespace cse210_03.Game
{
    
    public class Jumper
    {
        private List<string> player = new List<string>[ "   ___ ", 
                                            "  /___\\",
                                            "  \\   /",                                            \ /
                                            "    o  ",
                                            "   /|\\",
                                            "   / \\ ",
                                            "^^^^^^^^^"];

        private int leftStart = 0;

        public Jumper()
        {

        }

        public void removeLine()
        {
            leftStart += 1;
        }
        public void toString()
        {
            while(leftStart < player.Count){
                
            }
        }
    }
}
