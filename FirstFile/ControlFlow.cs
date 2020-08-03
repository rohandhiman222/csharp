using Microsoft.SqlServer.Server;

namespace FirstFile
{
    public class ControlFlow
    {
        /*
         * Condition one line code use otherwise use curly braces
          if(condition)
             someStatement
          else if(anotherCondition)   
              anotherStatement
          else
               yetanotherStatement    
               
           switch / case use Role class is enum and admin , moderator is value
           switch(role)
                case Role.Admin;
                .....
                break;
                case Role.Moderator;
                .....
                break;
                default:
                .....
                break;
                
                float price = (condition) ? "true":"false";
                
          
          
         */
        
        
        /*
         * Iteration statements
          For loops
          Foreach loops
          While loops
          do-while loop
          
          for(var i = 0; i < 10; i++){}
          foreach(var number in numbers) {}
          while(i < 20){i++}
          do{} while();
          Break and continue
          Break : jumps out of the loop
          continue: jumps to the next iteration.
          
        
        var name = "rohan hacker";
        for(var i = 0; i < name.Length; i++){
            Console.WriteLine(name[i])
        }  
        
        foreach(var character in name){
            Console.WriteLine(charater)
        }
        
        var numbers = new int[] {1, 3, 5, 7};
        foreach(var number in numbers){
            Console.WriteLine(number)
        }
           
           
         var i = 0;
         while(i <= 10){
            if(i % 2 == 0){
                Console.WriteLine(i))
            }
            i++;
         }  
           
           
        // taking input form users
        while(true){
            Console.Write("Type your name: ");
            var input = Console.ReadLine();
            
            if(String.IsNullWhiteSpace(input))
            break;
            
            Console.WriteLine("@Echo : " + input)
        }   
           
        // another example with taking input break and continue
        
        while(true){
            Console.Write("Type your namej...");
            var input = Console.ReadLine();
            if(!String.IsNullWhiteSpace(input))[
                Console.WriteLine("@echo " + input);
                continue;
            }
            break;
        }   
           
           var random = new Random();
           for(var i = 0; i < 10; i++){
                Console.WriteLine(random.Next());
                Console.WriteLine(random.Next(1, 15));
           }
           
          
         */
        

    }
}