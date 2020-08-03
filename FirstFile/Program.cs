using System;

namespace FirstFile
{

 public class Person
 {
  public string FirstName;
  public string LastName;

  public void Introduce()
  {
   Console.WriteLine("My name is " + FirstName + " " + LastName);
  }
 }
 
 
  internal class Program
  {
    public static void Main(string[] args)
    {
     
     var rohan = new Person();
     rohan.FirstName = "rohan";
     rohan.LastName = "dhiman";
     rohan.Introduce();
     
      // string name = "rohan dhiman";
      // Console.WriteLine(name);
      
      /*
       * Variables and Constants
       * Variable: a name given to a storage location in memory
       * Constant: an immutable value that we know at compile time and that value
         can't change throughout the life of the application.
         why do we use constant.
          The reason for that is to create safety in our application.
          imagine you're creating an application that involves same mathematical 
          computation around circles we have this number called Pi which is 
          point 3.14 and we use thtat to calculate the area of a circle
          That number should always be the same. we don't want to accidentally
          change that in our program. if we accidentally  change that everything
          is going to blow up in terms of the results the program produces.
          so we declare that number as a constant.
          and this way we create safety in our application in c-sharp to declare a
          variable.
           
          
       * 
       */
      
      /*
       * Declaring Variables / Constants
       * first type or identifier
       * second name
       * third value
       *
       * and C-sharp is case sensitive language number, NUMBER both are different
       * one has lowercase one has uppercase
       */
      int number; // error if you don't assign value
      int number2 = 1; // plus 2 billion minus 2 billion
      const float Pi = 3.14f;
      
      /*
       * Naming conventions
       *  Camel Case: firstName
       *  Pascal Case: FirstName
       *  Hungarian Notation: strFirstName // str mean string => don't use it
       */
      
      
      
      /*  ############ Primitive Types #################
       *  C# type         .NET Type    Byte     Range
       *
       *  #Integral Numbers
       *
       *  byte            Byte         1        0 to 255
       *  short           int16        2        -32768 to 32767
       *  int            int32         4        -2.1B TO 2.1B
       *  long            int64        8        .........
       *
       *  #Real Numbers
       * 
       *  float          Single        4        -3.4*10power38 to same plus float num = 1.2f;
       *  double        Double         8        .........        num 1.2 think compiler double
       *  decimal       Decimal        16        -7.9*10power28   decimal num = 1.2m;
       *
       *  #Character
       *  
       *  char         Char            2        Unicode Characters
       *
       *  #Boolean
       * 
       *  bool        Boolean          1        True, False
       *
       *
       * ########## Non-Primitive Types  ##############
       *
       * String, Array, Enum, Class
       * 
       */
      
      
    // Console.WriteLine(number);

    /*
     *  ######### Overflowing ############
     *  byte number = 255;
     *  number = number + 1; // 0 because we overflow the boundary of byte
     *
     *  ####### scope #############
     *  as you know a block is indicated by curly braces
     *  {}
     */

    // Blue color mean keywords
    var myNum = 14; // var automatic check in c-sharp
    
    byte numberOne;
    numberOne = 15;
    int count = 10;
    float totalPrice = 20.95f;
    double totalShirt = 33.30;
    char character = 'A'; // SINGLE QUOTES

    string firstName = "rohan Dhiman";
    bool isWorking = true;
    
    
    Console.WriteLine(numberOne);
    Console.WriteLine(count);
    Console.WriteLine(totalPrice);
    Console.WriteLine(totalShirt);
    Console.WriteLine(character);
    Console.WriteLine(firstName);
    Console.WriteLine(isWorking);
    Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
    Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

    const float PI = 3.14f;
    Console.WriteLine(PI);

    
    /* Implicit type conversion
     * Explicit type conversion (casting)
     * Conversion between non-compatible types
     */
    
    // Implicit Type Conversion
    byte b = 1;  // 00000001  one byte
    int i = b;   // 00000000 00000000 00000000 00000001  four byte.
    int numInt = 1;
    float f = i;
    // there is no data loss
    Console.WriteLine(i);
    
    // Explicit Type Conversion also that's we called casting
    int NumInt = 1;
    // byte NumByte = i; // error won't compile
    byte NumByte = (byte) i; // you know data will be loss that case we will use it
    
    
    // Not Use Explicit  with Non-Compatible types
    string s = "1";
    // int iNum = (int) s; // won't compile
    // work in this case with two methods
    int iNum = Convert.ToInt32(s);
    int j = int.Parse(s);
    Console.WriteLine(iNum);
    Console.WriteLine(j);
    
    /* Convert Class some methods
     *  ToByte()
     *  ToInt16()
     *  ToInt32()
     *  ToInt64()
     */

    
    /*
     * Operators
     *  Arithmetic Operators (add +) (substract -) (multiple *) (divide /) (remainder %)
        increment ++ exm (a++ ==== a = a + 1),  decrement - exm  (a-- ==== a = a -1)
        PostFix Increment int a = 1; int b = a++; (a = 2, b = 1)
        Prefix Increment int a = 1; int b = ++a; (a = 2, b = 2)
        
     *  Comparison Operators (Equal ==) (Not Equal !=) (Greater Than > ) (Greater than or equal to >=)
        (Less than < )  (Less than or equal to <=)
         
     *  Assignment Operators (Assignment = ) (Addition Assignment += ) (Subtraction Assignment -=)
       (Multiplication Assignment *= ) (Division Assignment /=)
     
     *  Logical Operators (And &&) ( Or || ) ( Not ! )
     *  Bitwise Operators (And &) (Or |)
     */
    
    /* 
     *
     * 
     */
    

     // both case work with var and ClassName with
     // FirstClass firstClass = new FirstClass();
     var firstClass = new FirstClass();
     Console.WriteLine(firstClass.Add(34, 34));
     firstClass.Introduce();

     Console.WriteLine(FirstClass.multiply(44,10));
     
     /* static main use
      *  so without the static modifier or method when you create three objects
         of this FirstClass each object in memory will have the add method
         
         But when you apply the static modifier the add method will be only in 
         one place in memory add that is FirstClass class itself. so it's not
         going to be repeated three times in memory
         
         We use the static modifier when we want to present a concept that only a single
         instance of that should exist in memory.
         Example
         class Program{
             static void main(){} mean one instance of the main method in memory
             there is only one entry point in each c-sharp application.
         }
      *
      * 
      */


     // we have to caste
     var method = Languages.Express;
     // enum convert into int
     Console.WriteLine(" Enum class  "+ (int) method);

     // get enum Varialble name
     var methodId = 3;
     Console.WriteLine((Languages)methodId); // result Express

     // got Express field name
     Console.WriteLine(method.ToString());
     
     // string convert into enum
     // inprogramming we use parse method
     var methodName = "Express";
     var languages = (Languages)Enum.Parse(typeof(Languages), methodName);
     
    }
  }
}