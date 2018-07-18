// Private access specifier allows a class to hide its member variables
// and member functions from other functions and objects. Only functions
// of the same class can access its private members. Even an instance of
// a class cannot access its private members.

using System;

namespace RectangleApplication {
   class Rectangle {
      //member variables
      private double length;
      private double width;
      
      public void Acceptdetails() {
         Console.WriteLine("Enter Length: ");
         length = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Enter Width: ");
         width = Convert.ToDouble(Console.ReadLine());
      }
      
      public double GetArea() {
         return length * width;
      }

      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//end class Rectangle
   
   class ExecuteRectangle {
      static void Main(string[] args) {
         Rectangle r = new Rectangle();
         r.Acceptdetails();
         r.Display();
         Console.ReadLine();
      }
   }
}

// --- Output ---
// Enter Length: 
// 15
// Enter Width: 
// 10
// Length: 15
// Width: 10
// Area: 150