using System;
using System.Collections.Generic;

namespace GradeBook {


    class Program 
    {
        static void Main(string[] args){
    
        var book = new Book("Kanombola");
       

        var done = false;
          

      
        
       

      while(!done){
             
             System.Console.WriteLine("Enter a grade or 'q' to quit");

        var input = Console.ReadLine();
             if(input == "q")
             {
                break;
             }


         try
         {
             var grade = double.Parse(input);
             book.AddGrade(grade);

         }
        //  catch(Exception ex) // this will catch any exception , this is not good practice because sometimes our software is trying to do something illegal like wiping our hard drive and if we let it do that it might be bad
        //  { // what we should do here is to forsee a possible error that might happen and catch that, to do that we should explicity state the exception type 
        //     Console.WriteLine(ex.Message);
        //  }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }

// if there is a piece of code that needs to be executed always, then you can use a finally block,
        finally
        {
            // Console.WriteLine(" something has gone wrong");
        }
      }

          
        // }




         



        var stats = book.GetStatistics();

        
            Console.WriteLine($"the average grade is {stats.Average:N2}");
            Console.WriteLine($"the highest grade is {stats.High}");
            Console.WriteLine($" the Lowest grade is {stats.Low}");

        //   book.removeGrade();
        // book.grades.Add(56.2)

        //     var grades = new List<double>() {12.7, 10.3, 6.11, 4.1}; // with initializers

        //     // List<double> grades= new List<double>();  // Every class that c# will use, will be in a namespace, this helps c# developers to avoid collisions in the names of classes
        //     grades.Add(56.1); // a list is implemented as a dynamically sizable collection which you can keep adding and removing things from
        //     grades[0] ; // a list and arrays share a lot of the same/behaviors it's just that lists are dynamic 

           
        //     foreach( var number in grades){
        //     //  result = x + y ;
        //         highestGrade = Math.Max(highestGrade, number);
        //         lowestGrade = Math.Min(lowestGrade, number);
        //         result += number;
        //     // Console.WriteLine(numbers[i]);

        //     }





            
           
        }
    }
}