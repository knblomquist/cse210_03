using System;
using System.Collections.Generic;

namespace cse210_03.Game
{
///class///    
    public class Jumper
    {
        private List<string> player = new List<string>[ "   ___ ", 
                                            "  /___\\",
                                            "  \\   /",                                            \ /
                                            "    o  ",
                                            "   /|\\",
                                            "   / \\ ",
                                            "^^^^^^^^^"];

        private int leftStart;

        public Jumper()
        {
            leftStart = 0;
        }

        public void removeLine()
        {
            leftStart += 1;
        }
        public void toString()
        {
           for(int i = leftStart; leftStart <player.Count; i++)
           {

           }
        }
    }
}
