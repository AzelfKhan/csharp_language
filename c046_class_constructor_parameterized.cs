// A default constructor does not have any parameter but if you need,
// a constructor can have parameters. Such constructors are called
// parameterized constructors.

using System;

namespace LineApplication {
   class Line {
      private double length;   // Length of a line
      
      public Line(double len) {  //Parameterized constructor
         Console.WriteLine("Object is being created, length = {0}", len);
         length = len;
      }
      public void setLength( double len ) {
         length = len;
      }
      public double getLength() {
         return length;
      }
      static void Main(string[] args) {
         Line line = new Line(10.0);
         Console.WriteLine("Length of line : {0}", line.getLength()); 
         
         // set line length
         line.setLength(6.0);
         Console.WriteLine("Length of line : {0}", line.getLength()); 
         Console.ReadKey();
      }
   }
}

// --- Output ---
// Object is being created, length = 10
// Length of line : 10
// Length of line : 6

