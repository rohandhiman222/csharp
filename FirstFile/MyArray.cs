using System;
using System.Collections.Generic;

namespace FirstFile
{
    public class MyArray
    {
        /*
         * Array:
         *     Represents a fixed number of variables of a particular type.
         *     two type of array
         *         Single Dimension
                
                var numbers = new int[5];
                var numbers = new int[5]{1, 3, 5, 6, 8};
                 
                
        
         * Mutli Dimension
                
                // 3*5 Rectangular array  
                0 1 2 3 4 
                0 1 2 3 4 
                0 1 2 3 4 
                
                var matrix = new int[3, 5]; 3 row and 5 column
                var matrix = new int[3, 5]
                {
                    {1, 4, 5, 6, 7, 8}, 3 row
                    {1, 4, 5, 6, 7, 8}, 5 column
                    {1, 4, 5, 6, 7, 8}
                }
                // get value of array
                var element = matrix[0,0];
                
                // 3 dimension
                var colors = new int[3, 5, 4];
                
                
                jagged array
                0 1 2 3 4 
                0 1 2 3 4 5
                0 1 2 3 
                
                var array = new int[3][];
                array[0] = new int[4];
                array[1] = new int[5];
                array[3] = new int[3];
                
                array[0][0] = 1;
                
                different both array
                jagged var array = new int[3][];
                rectangular var array = new int[3, 5];
                array type is class it has a bunch of properties Length, Clear(), Copy(), IndexOf(), Reverse(), Sort()
                
                
          
         * 
         */
        
        
        static void MyArrayCode()
        {
            var numbers = new int[] {3, 4, 6, 7, 8, 9, 8};
            // Length this member of numbers via access by object
            
            
            Console.WriteLine(numbers.Length);
            
            // indexOf get position of array Array Static class IndexOf methods in Array class
            
            
            var index = Array.IndexOf(numbers, 9); // overloading method
            Console.WriteLine("index of 9: "+ index);
            
            // Clear method
            Array.Clear(numbers, 0, 2);// start to end clear
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            
            // Copy 
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var num in another)
            {
                Console.WriteLine(num);
            }
            
            // Sort(); // got sort 
            Array.Sort(another);
            
            // Reverse
            Array.Reverse(numbers);
            
       
        
        
        /*
         * Lists
         *      Arrays vs lists
         *     Array: fixed size
         *     List: dynamic size
         *     list we use that time we don't know how many we have variables, objects
         *
         *     Creating Lists
         *         var numbers = new List<int>(); // list is generic type <> this mean generic we always pass type mean type of list
         *         var numbers = new List<int>(){3, 4, 34, 34, 5};
         *         Use full methods Add(), AddRange(), Remove(), RemoveAll(), IndexOOf(), Contains(), Count()   
         *         
         *         
         */
        
         var listNumber = new List<int>(){2, 4, 56, 8, 9};
            listNumber.Add(66);
            
            // ranges
            listNumber.AddRange(new int[3]{3, 45, 6});

            foreach (var num in listNumber)
            {
                Console.WriteLine(num);
            }
            
            // IndexOf
            listNumber.IndexOf(66); // return true, false -1

            // count
            listNumber.Count();
            listNumber.Remove(66);

            
            // tip you can't modify collect in list inside foreach loop
            
            // clear
            listNumber.Clear();
            

        }    
        
    }
    
    
    

}