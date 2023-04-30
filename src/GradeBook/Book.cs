using System.Collections.Generic;


namespace GradeBook
{
    // a class can be thought of as doing 2 things, there's the state or information that it holds and then theres the behavior it does
    // our book class will hold the grades and have behavior that will act on the grades
  public  class Book
    {

          public Book(string name) // a constructor method must have the same name as your class name
          {
            grades = new List<double>(); // this code will be guaranteed to run when i invoke the new keyword
            Name = name;
          }
        
        public void AddGrade(double grade)
        {
            if(grade >= 0 && grade <= 100)
             {
              
              grades.Add(grade);
              
              }
              else
              {

                throw new ArgumentException($"Invalid {nameof(grade)}");
              }

        }

        public Statistics GetStatistics() {

          // 
            var result = new Statistics(); // the dotnet runtime will ensure that our instance of statistics is initialized with what is known as all bits ofF MEANINING ALL THE BITS ARE 0
            
               result.High = double.MinValue;
               result.Low = double.MaxValue;
              foreach( var grade in grades){
          
                result.High = Math.Max( result.High, grade);
                result.Low = Math.Min(result.Low, grade);
              
                result.Average += grade;
            

            }
            
            result.Average = result.Average/ grades.Count;

            switch(result.Average)
            {
              case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
              case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
              case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
              case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;
              default:
                   result.Letter = 'F';
                   break;
                
            }

            return result;
            
         
        }

       

       private List<double> grades ; // this is not a variable it is a field, you cannot use implicit typing with var 
    //   one way of initilizing the grades array is with the new keyword
    // List<double> grades = new List<double>();
        public string Name; // By convention any public member of a class must be uppercase
    }
}