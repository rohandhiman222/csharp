using System;

namespace FirstFile
{
    // Class => Combines related variables (fields) and function (methods)
    public class FirstClass
    {
        // Fields
        public string fullname;
        private string name;
        private byte age = 33;
        private float height = 5.9f;
        private byte weight = 70;
        
        // methods

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + name);
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public static int multiply(int a, int b)
        {
            return a * b;
        }
    }
    
    /*
     * This class is type or a blueprint from which we created objects
       so an object is an instance of a class. in this example we can create 
       three instance of this person class like objRohan, objSonali, objNoname
     * 
     * 
     */
}