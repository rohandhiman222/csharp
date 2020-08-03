namespace FirstFile
{
    public class TypeReferenceValueType
    {
        /*
         * Reference Types and Value Types
           Primitive Types => int, char, float, bool
           Non-Primitive = classes, structures, arrays (System.Array), strings(System.String)
         * 
         */
        
        
        /*
         *  Structures // use small things like rgb colors 8 byte
            All primitive types are structures, all primitive types are very small types. they take no more
            than 8 bytes. that's whey they are internally defined as a structure
            Primitive Types
            Custom structures 
            
         *
         *  Classes -> Arrays or strings are both classes. we can also create custom classes like Person or Calculator
            C-sharp these classes or structures are treated differently at runtime in terms of memory management
            Arrays
            String
            Custom Classes
         * 
         */
        
        
        
        
        /* 
         * Value Types
           Structures are what we called value types..
           when you create variable that is a value type..
           a part of memory called stack is allocated for that variable...
           This memory allocation is done automatically...
           when this variable goes out of scope it will immediately get removed from the stack by runtime or clr...
           
           Structures
           Allocated on stack
           Memory allocation done automatically
           Immediately removed when out of scope
           
         
         * Reference Types
           Reference types however you the programmer need to allocate memory yourself...
           remember the new operator we use the new operator with classes...
           so when we use the new operator we tell the runtime to allocate memory to this object...
           And This happens from a different area of the memory called heap memory on the stack is more sustainable 
           .. so you create an object and that object goes out of scope it will continue to exist in the heap for
           a little while.. it won't be removed immediately .. there is a process called garbage collection which
           is done by runtime or clr that takes care of this..
           so once in a while clr looks at the objects that are no longer used and removes them from the heap
           this is the theory behind value types and reference types.
           
           Classes are reference types..
           Classes
           You need to allocate memory
           Memory allocated on heap
           Grabase collected by CLR
           
          
          
         */
        
        
        /* .................value type in example.............
           var a = 10; 
           var b = a;  // a value will be same 10;
           ...because integers are value types....
           when we copy a value type to another varialbe a copy of that value is taken and store 
           in the target location in memory..
           b++; 
           cw( got b value 11 and a value 10 same before)
           when you copy a value type to a different variable a copy of that value is taken and store
           in target variable. so that's why we called them value types.. their values are copied..
           let me show you what happened in memory..
           so imagine here is tha stack and somewhere in the stack we have a location identified by (a).
           And in that location we have the value 10. when we copy a to b new location in memory and stack
           is created. identified as b and the value we had there in a is copied to b..
           that's why these two variable are now completely independent and making change to one does not 
           impact the other.
         
         */
        
        /*  ------------- reference types in action --------------
          so this time i'm going to create an integer array.
          and as you know in c-sharp an array is a class.. so it's reference type..
          
          var array1 = new int[3]{1,3,5};
          var array2 = array1;
          array2[0] = 0;
          important if you change anything in array2.. array one also change because both are same..
          
          
          stack                                     heap
                                               First Array class reference here
          array1                                0x00416a -> memory address
          0x00416a                            [1 2 3] -> actual array
          array1 points or reference the object on the heap
          array1 copy to array two what happen in this case
          
          array2
          0x00416a
          array2 is not creating heap it copy reference 0x00416a from the heap
          so that's why array1 or array2 pointing the same object 
          if you change array2 automatically change array1;
          that's called reference type
          when we copy them there reference or their memory address is copied..
          not the copy actual value..
          
          
                                                
          
          
         */
        
    }
}