using System;
using Xunit;





// public class UnitTest1
// {
//     [Fact]
//     public void Test1()
//     {
//         // Assert is how we tell the framework that a test has failed or passed.
//         // expected value and actual value

// // arrange the object or values you want to use, 
//         var x = 5;
//         var y = 2; 

//         // Act invoke a method that returns something
//         var actual = x + y;  // here you'll add some method you want to test from in this case the GradeBook
//         var expectedValue = 7;

// // Assert that it produces theh expected values
//         Assert.Equal(expectedValue, actual);
        
//     }
// }

// your filename must always match the class name as per convention of c#

namespace  GradeBook.Tests{
    

public class BookTests
{
    [Fact]
    public void BookCalculatesStatistics(){
        // arrange
        var book = new Book(""); // this class is in the GradeBook Folder so we need to create a project reference in the dotnet cli type dotnet add reference ..\..\src\GradeBook\GradeBook.csproj
//  you can have as many project references as you need for a given application or library, 
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.3);
        //act 
        var result = book.GetStatistics();

        // assert
        Assert.Equal(85.6,result.Average,1);
        Assert.Equal('B', result.Letter);
        Assert.Equal(90.5,result.High,1);
        Assert.Equal(77.3,result.Low,1);
        
    }

//     [Fact]
//     public void BookAddGradesMethodDoesNotAddNegativeNumbers(){
//         // arrange
//         var book = new Book(""); // this class is in the GradeBook Folder so we need to create a project reference in the dotnet cli type dotnet add reference ..\..\src\GradeBook\GradeBook.csproj
// //  you can have as many project references as you need for a given application or library, 
//         book.AddGrade(-23);
       
//         //act 
//         var result = book.GetStatistics();

//         // assert
//         // Assert.Equal(85.6,result.Average,1);
//         // Assert.Equal(90.5,result.High,1);
//         Assert.Equal(70,result.Low,1);
        
//     }

//      [Fact]
//     public void BookAddGradesMethodDoesNotNumbersOverOneHundred(){
//         // arrange
//         var book = new Book(""); // this class is in the GradeBook Folder so we need to create a project reference in the dotnet cli type dotnet add reference ..\..\src\GradeBook\GradeBook.csproj
// //  you can have as many project references as you need for a given application or library, 
//         book.AddGrade(105);
       
//         //act 
//         var result = book.GetStatistics();

//         // assert
//         // Assert.Equal(85.6,result.Average,1);
//         // Assert.Equal(90.5,result.High,1);
//         Assert.Equal(0,result.Low);
        
//     }
} 

}