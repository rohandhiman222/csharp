using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFile
{
    public class TextClass
    {
        static void TextMsg()
        {
            // Strings => String is mutlable if created you can't change it
            // methods -> ToLower(), ToUpper(), Trim(),  
            
            // Search character
            // IndexOf('a')
            // LastIndexOf("Hello")
            
            // Substring
            // Substring(startIndex)
            // Substring(startIndex, Length)
            
            // Replacing
            // Replace('a', '!');
            // Replace('rohan', "rohan dhiman")
            
            // Null checking
            // String.IsNullOrEmpty(str)
            // String.IsNullOrWhiteSpace(str)
            
            // spltting
            // str.Split(' ');
            
            // converting string to number
            //string s = "12345";
            //int i = int.Parse(s); // empty return expression
            //int j = Convert.ToInt32(s); // this is good if empty no problem return 0
            
            // int i = 1234;
            // string s = i.ToString();
            // string t = i.ToString("C");
            // t = i.ToString("C0")
            
            /* c or C (current) 123456(C) -> $123,456
             * d or D (Decimal) 1234(D6) -> 001234
             * e Or E (Exponential) -> 1052.03345345345(E) 1.3434343+003
             * f Or F (Fixed Point) -> 1234.567 (F1) -> 1234.5
             * x or X Hexadecimal 255(X) -> FF
             *
             */
            
            /* var fullname = "Rohan dhiman   ";
             * Console.WriteLine("Trim: {0}", fullname.Trim())
             * Console.WriteLine("Trim: {0}", fullname.Trim().ToUpper()) // two methods called one time
             * var index = fullname.Index(' ');
             * var firstName = fullname.Substring(0, index)// tow overload 
             * var lastName = fullname.Substring(index+1);
             * var names = fullname.Split(' ');
             * names[0] names[1]
             * fullname.Replace("rohan", "nisha")
             *
             * if(String.IsNullOrEmpty("")){do it}
             * if(Stirng.IsNullOrEmpty(" ".Trim())) 
             * if(String.IsNullOrWhiteSpace(" ")) // no need use trim method because this inbuilt
             *
             * convert
             * var str = "25";
             * var age = Convert.ToByte(str)
             *
             * float price = 25.33f;
             * price.ToString("C");
             */


            // problem show 20 character after show dot dot dot ... like this how to make this
            var sentense = "hello man how are you so tell me what's going do you know me i don't care about your self";
            if (sentense.Length < 20)
            {
                Console.WriteLine(sentense);
            }
            else
            {
                // one solution but not perfect
                // sentense.Substring(0, 20);
                
                // another solutioin
                var words = sentense.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();
                
                foreach (var word in words)
                {
                    summaryWords.Add(word);
                   totalCharacters += word.Length + 1; // one mean add one space
                   if (totalCharacters > 20){
                       break;
                   }
                }

             var summry =   String.Join(" ", summaryWords) + "...";
             Console.WriteLine(summry);
            }



            
            // StringBuilder
            /* Defined in System.Text
             * A mutable string
             *  Easy and fast to create and manipulate strings
             *
             *  Not for searching so don't use it
             *  IndexOf()
             *  LastIndexOf()
             *  Contains()
             *  StartsWith()
             *
             *  Use ti for Manipulation methods
             *  Append()
             *  Insert()
             *  Remove()
             *  Replace()
             *  Clear()
             */
            
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);

            builder.Replace('-', '+');
            builder.Remove(0, 10); // zero to 10 character
        }
    }
}