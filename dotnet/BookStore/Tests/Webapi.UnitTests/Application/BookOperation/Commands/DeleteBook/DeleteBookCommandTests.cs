using System;
using System.Linq;
using AutoMapper;
using FluentAssertions;
using TestSetup;
using Webapi.Application.BookOperations.Commands.DeleteBook;
using Webapi.DBOperations;
using Webapi.Entities;
using Xunit;

namespace Application.BookOperations.Commands.DeleteBook
{
    public class DeleteBookCommandTest : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;

        public DeleteBookCommandTest(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
        }

        [Fact]
        public void WhenNotExistBookIdIsGiven_InvalidOperationException_ShouldBeReturn()
        {
            int id = 30;

            DeleteBookCommand command = new DeleteBookCommand(_context);
            command.BookId = id;

            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Silinecek kitap bulunumadı!");

        }
        [Fact]
        public void WhenValidInputsAreGiven_Book_ShouldBeDeleted()
        {
            int id = 3;

            DeleteBookCommand command = new DeleteBookCommand(_context);
            command.BookId = id;

            FluentActions.Invoking(() => command.Handle()).Invoke();

            var book = _context.Books.SingleOrDefault(book => book.Id == id);
            book.Should().BeNull();
        }
    }
}