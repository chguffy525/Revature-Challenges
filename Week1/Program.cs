using System;
using Week1Library;

namespace Week1
{
   public class Program
    {
       public static void Main()
        {
         Palindrome();    
        }
        
     public static Boolean Palindrome()
      {
        Boolean x = false;
        Console.WriteLine("Please enter a Palindrome");

			  string text = Console.ReadLine();
			  string output = text;
        text = text.ToLower();
        Console.WriteLine("Your input is " + text);	
        if (ReverseString(text) == text)
        {
          Console.WriteLine(text + " is a palindrome!");
          return x = true;
        }	
        else 
        {
          Console.WriteLine(text + "is not a palindrome!");
          return x; 
      }
      }
      public static string ReverseString(string s)
      {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
    }
}
