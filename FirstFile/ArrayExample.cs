using System;

namespace FirstFile
{
    public class ArrayExample
    {
        /* What is an Array?
         *  A data structure to store a collection of variables of the same type.
         *
         *  int number1;
         *  int number2;
         *  int number3;
         *  one way array use
         *  int[] numbers = new int[3];
         *  numbers[0] = 1;
         *  numbers[1] = 2;
         *  numbers[2] = 3;
         *
         *  c sharp if don't set any value in variable by default value is zero
         *  c sharp if don't set any value in variable by default value is boolean by default false
         *  second way use array use
         *  int[] numbers = new int[3] {1,2,4}
         * 
         *  
         * 
         *  Declaring Arrays?
         *  Initializing Arrays?
         *  Access Array Elements
         */
        
        
        /*
         * What is a string?
           A sequence of characters. e.g "hello world"
           string firstName = "Rohan"; // this is string literal
           string Fullname = firstName + " " + lastName;
           string format
           string name = string.Format({0} {1}, firstName, lastName)
           
           array of object
           var numbers = new int[3] {1, 2, 3}
           string list = string.Join(",", numbers);
           
           String Elements
         * How to create strings
           string name = "rohan";
           car firstChar = name[0];
           
           String are immutable
           Once you create them, you can't change them.
           Example
           string name = "rohan";
           char firstChar = name[0];
           name[0] = 'm';
           immutable mean never change origin value and return always new value thats
           mean immutable....
           got old name same value of rohan if you do it string always return new string
           ordinal string never change
           
          string name = "rohan"; literal
          var name = "rohan"; compiler know you are using literal
          
          String name2 = "rohan"; this is class we have to import this String class namespace
          
        
         
         * Escape characters and verbatim strings
         *  \n = New line
         *  \t = Tab
         *  \\ = Backslash
         *  \' = Single quotation mark
         *  \" = Double quotation mark
           
           string path = "c:\\projects\\project1\\folder1"
           verbatim string no need double slashed
           string path = @"c:\projects\project1\folder1"
         * 
         */

        private String First = "rohan";
        private string Second = "dhiman";
        private Int32 num = 232;
        private int num2 = 3434;
        
        // var fullname = string. // there are many methods got in suggestion
        // private var fullname = string.Format("{0} {1}", First, Second);
        
        /*
         * string name = "Hii Rohan \n Look into the following paths \n  c:\\folder1\\project1 "
         * string name = @"
              Hii Rohan
              Look into the the following paths
              c:\folder1\project1
           "
         * 
         */
    }
}