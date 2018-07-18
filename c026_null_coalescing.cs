// The null coalescing operator is used with the nullable value types and
// reference types. It is used for converting an operand to the type of
// another nullable (or not) value type operand, where an implicit conversion
// is possible.

// If the value of the first operand is null, then the operator returns the
// value of the second operand, otherwise it returns the value of the
// first operand.

using System;

namespace CalculatorApplication {
   class NullablesAtShow {
      static void Main(string[] args) {
         double? num1 = null;
         double? num2 = 3.14157;
         double num3;
         
         num3 = num1 ?? 5.34;      
         Console.WriteLine(" Value of num3: {0}", num3);
         
         num3 = num2 ?? 5.34;
         Console.WriteLine(" Value of num3: {0}", num3);
         Console.ReadLine();
      }
   }
}

// --- Output ---
//  Value of num3: 5.34
//  Value of num3: 3.14157
