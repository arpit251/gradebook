using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var newbook = new Book("Arpit's Book");
            Console.WriteLine("Welcome to Arpit's Book.");
            Console.WriteLine("Please enter the grades. To stop entering the grades please press q");
            string input;
            while(true)
            {
                input = Console.ReadLine();
                if(input == "q")
                {
                    break;
                }
                try 
	            {	        
		            var grade = double.Parse(input);
                    newbook.Addgrade(grade);
	            }
	            catch (ArgumentException ex)
	            {
                    Console.WriteLine(ex.Message);
	            }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine(".....");
                }
                
            }
            Console.WriteLine("Grades entered successfully.If you want to see statistics press y ");
            input = Console.ReadLine();
            if(input == "y")
            {
                newbook.show_statistics();
            }
            else
            {
                Console.WriteLine("Thank you for using the app.");
            }
        }
    }
}
