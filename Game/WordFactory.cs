using System;
using System.Collections.Generic;

namespace cse210_03
{
   class WordFactory
   {
     private List <string> words = new List<string>{"Aa","Kerfuffle", "Mormon", "Catatonic", "Alphabet", "Hamster", "Strawberry"};
      public string RandomWord()
      {
         var newRandom = new Random();
         int index = newRandom.Next(words.Count);
         
         return words[index];
      }
   }
}
