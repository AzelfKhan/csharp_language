// Declaring a member function as static mean the function can
// access only static variables. The static functions exist even
// before the object is created.

using System;

namespace StaticVarApplication {
   class StaticVar {
      public static int num;
      
      public void count() {
         num++;
      }
      public static int getNum() {
         return num;
      }
   }
   class StaticTester {
      static void Main(string[] args) {
         StaticVar s = new StaticVar();
         
         s.count();
         s.count();
         s.count();
         
         Console.WriteLine("Variable num: {0}", StaticVar.getNum());
         Console.ReadKey();
      }
   }
}

// --- Output ---
// Variable num: 3
