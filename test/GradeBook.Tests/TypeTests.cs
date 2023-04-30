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
    

public class TypeTests
{

 // remember that value types are immutable


    

     [Fact]
    public void ValueTypesAlsoPassByValue(){
      var x = GetInt();
       SetInt(ref x);   

        
        Assert.Equal(42, x);
    }

        private void SetInt(ref int x)
        {
           x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
    public void CSharpCanPassByRef(){
      var book1 = GetBook("Book 1");
       GetBookSetName(ref book1, "New Name");   

    //   Assert.Equal("Book 1", book1.Name);
    //   Assert.Equal("Book 2", book2.Name);     
        Assert.Equal("New Name", book1.Name);
    }

       void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }



     [Fact]
    public void CanSetNameFromReference(){
      var book1 = GetBook("Book 1");
       SetName(book1, "New Name");   

    //   Assert.Equal("Book 1", book1.Name);
    //   Assert.Equal("Book 2", book2.Name);     
        Assert.Equal("New Name", book1.Name);
    }

       void SetName(Book book1, string name)
        {
            book1.Name = name;
        }

        [Fact]
    public void GetBookReturnsDifferentObjects(){
      var book1 = GetBook("Book 1");
      var book2 = GetBook("Book 2");   

      Assert.Equal("Book 1", book1.Name);
      Assert.Equal("Book 2", book2.Name);     
    }



[Fact]
    public void TwoVarsCanReferenceSameObject(){
      var book1 = GetBook("Book 1");
      var book2 = book1;


    Assert.Same(book1,book2);
    }
         Book GetBook(string name)
        {
            return new Book(name);
        }
    } 

}