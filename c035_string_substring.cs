using System;

namespace StringApplication {

   class StringProg {
   
      static void Main(string[] args) {
         string str = "Last night I dreamt of San Pedro";
         Console.WriteLine(str);
         string substr = str.Substring(23);
         Console.WriteLine(substr);
      }
   }
}

// --- Output ---
// Last night I dreamt of San Pedro
// San Pedro

