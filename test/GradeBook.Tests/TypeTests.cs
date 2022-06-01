using System;
using Xunit;

namespace GradeBook.Tests
{
    // Checking the type of the object created
    public class TypeTests
    {
        [Fact]
        public void can_valueType_Passas_Ref()
        {
            int x = 3;
            setint(ref x);
            Assert.Equal(4, x);
        }
        [Fact]
        public void can_set_name_from_reference_passing()
        {
            var book1 = GetBook("Book 1");
            getbooksetnameref(ref book1, "New Name");
            Assert.Equal("New Name", book1.Name);
        }
        [Fact]
        public void can_set_name_from_value()
        {
            var book1 = GetBook("Book 1");
            // getbooksetname is generating a new copy of book and assigning the name to the local book instance generated in the getbooksetname
            getbooksetname(book1, "New name");
            Assert.Equal("Book 1", book1.Name);
        }

        [Fact]
        public void can_set_name_from_reference()
        {
            // Book1 stores the address to the new instance of the book class
            var book1 = GetBook("Book 1");
            setname(book1, "New name");
            Assert.Equal("New name", book1.Name);
        }

        [Fact]
        public void Type_Check_Test()
        {
            // Tests to check if book1 and book2 are referncing to same object or they are referncing to different object
            //Arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            //Act
         
            // Assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book2, book1);
        }

        [Fact]
        public void Two_var_Reference_sameobject()
        {
            // Test to check if two variables can reference to same object
            //Arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;

            //Act
        
            // Assert
            Assert.Same(book2, book1);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        // By default the member is private
        Book GetBook(string name)
        {
            // Returning an instance of book class
            return new Book(name);
        }
        void setname(Book book, string name)
        {
            book.Name = name;
        }
        void getbooksetname(Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }
        void getbooksetnameref(ref Book book, string name)
        {
            book = new Book(name);
        }
        void setint(ref int x)
        {
            x = 4;
        }
    }
}
