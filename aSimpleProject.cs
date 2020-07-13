using System;
using System.Collections.Generic;

namespace aSimpleProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            //use of a string variable to save the name entered by user
            string userName;
            Console.Write("Hi, welcome to my program!.What's your name? ");
            userName = Console.ReadLine();
            //conditional statement depending on user's action
            if (userName == "")
            {        
                Console.Write("Hmph, you don't want to tell me your name? Well, the show must go on\nI joined the start.ng 2020 workspace and I'd like to tell you a bit about it.");    
                Profile();        
            }  
            else
            {
                Console.Write("Oh hello " + userName + ", how's your isolation going? I hope you're making the best of it like I am.\nI joined the start.ng 2020 workspace and I'd like to tell you a bit about it.");
                Profile();               
            }        
            //end of program
            Console.WriteLine("\n\nThat's all for now " + userName + ", you can reach out to me on Slack (@MorganJay) for more information. Thanks for your time.");         
        }
       
        private static void Profile()
        {
            //use of a "var" type container(variable) to hold name value
            var myName = "Morgan James";
            
            //Use of array to hold values of tracks.
            string[] tracks = new string[]
            {"FrontEnd,"," BackEnd"," and Coding."};
            
            //Declaration of a list to hold courses taken by me
            List<string> courses = new List<string>();
            courses.Add("HTML-CSS,");
            courses.Add(" JavaScript,");
            courses.Add(" Python");
            courses.Add(" and C#.");
            
            //Displaying my information to the user from the array and lists defined.
            Console.WriteLine("\nFYI, my name's " + myName + " and I will be brief.");
            Console.WriteLine("I registered for " + tracks.Length + " tracks and they include " + String.Join("", tracks));
            Console.WriteLine("My courses are " + String.Join("", courses));
        }
    }
}
