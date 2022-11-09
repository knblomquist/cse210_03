using System;
using System.Collections.Generic;

namespace cse210_03
{
   class WordFactory
   {
     public List <string> words = new List<string>{"Aa","Kerfuffle", "Mormon", "Catatonic", "Alphabet", "Hamster", "Strawberry"};
      static void RandomWord()
      {
         var newRandom = new Random();
         int index = Random.Next(words.Count);
         
         return words[index];
      }
   }
}
