using System;

namespace HelloWorld 
{   
    class String 
    {
        static void Main(string[] args)
        {
                string phrase = "Anant Mishra" + " "+"is cool";
            // //Console.WriteLine("Anant \nMishra");
            // Console.WriteLine(phrase.Length);
            // Console.WriteLine(phrase.ToLower());
            // Console.WriteLine(phrase.Contains("Mishra"));
              Console.WriteLine(phrase.Substring(6,8));
            // Console.WriteLine(phrase[2]);
            // Console.WriteLine(phrase.IndexOf('z'));
        
        }
    }
    
}