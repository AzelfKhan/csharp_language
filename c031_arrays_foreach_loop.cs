using System;

namespace ArrayApplication {
   class MyArray {
      static void Main(string[] args) {
         int []  n = new int[10]; /* n is an array of 10 integers */
         
         /* initialize elements of array n */
         for ( int i = 0; i < 10; i++ ) {
            n[i] = i + 100;
         }
         
         /* output each array element's value */
         foreach (int j in n ) {
            int i = j-100;
            Console.WriteLine("Element[{0}] = {1}", i, j);
         }
         Console.ReadKey();
      }
   }
}

// --- Output ---
// Element[0] = 100
// Element[1] = 101
// Element[2] = 102
// Element[3] = 103
// Element[4] = 104
// Element[5] = 105
// Element[6] = 106
// Element[7] = 107
// Element[8] = 108
// Element[9] = 109

