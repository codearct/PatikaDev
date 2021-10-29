using System;
using System.Linq;
using AutoMapper;
using FluentAssertions;
using TestSetup;
using Webapi.Application.BookOperations.Commands.UpdateBook;
using Webapi.DBOperations;
using Webapi.Entities;
using Xunit;

namespace Application.BookOperations.Commands.UpdateBook
{
    public class UpdateBookCommandValidatorTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;
        public UpdateBookCommandValidatorTests(CommonTestFixture textFixture)
        {
            _context = textFixture.Context;
        }

        [Theory]
        [InlineData("Lord of The Rings", 0, 0, 0)]
        [InlineData("Lord of The Rings", 0, 1, 1)]
        [InlineData("Lord of The Rings", 100, 0, 0)]
        [InlineData("", 0, 0, 0)]
        [InlineData("", 100, 1, 1)]
        [InlineData("", 0, 1, 1)]
        [InlineData("Lor", 100, 1, 1)]
        [InlineData("Lord", 100, 0, 0)]
        [InlineData("Lord", 0, 1, 1)]
        [InlineData(" ", 100, 1, 1)]
        public void WhenInValidInputIsGiven_Validator_ShouldBeReturnErrors(string title, int pageCount, int genreId, int authorId)
        {
            //arrange(Hazırlık)
            Random rnd = new Random();
            int id = rnd.Next(1, 3);

            UpdateBookCommand command = new UpdateBookCommand(null);
            command.BookId = id;
            command.updatedModel = new UpdateBookModel()
            {
                Title = title,
                PageCount = pageCount,
                PublishDate = DateTime.Now.Date.AddYears(-1),
                GenreId = genreId,
                AuthorId = authorId
            };

            //act(Çalıştırma)

            UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
            var result = validator.Validate(command);

            //assert(Doğrulama)

            result.Errors.Count.Should().BeGreaterThan(0);
        }

        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnError()
        {
            Random rnd = new Random();
            int id = rnd.Next(1, 3);

            UpdateBookCommand command = new UpdateBookCommand(null);
            command.BookId = id;

            command.updatedModel = new UpdateBookModel()
            {
                Title = "Lord of The Rings",
                PageCount = 100,
                PublishDate = DateTime.Now.Date,
                GenreId = 1,
                AuthorId = 1
            };

            UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
            var result = validator.Validate(command);

            result.Errors.Count.Should().BeGreaterThan(0);

        }

        [Theory]
        [InlineData("Lord of The Rings")]
        [InlineData("Lord of The Rings", 100)]
        [InlineData("Lord of The Rings", 100, 1)]
        [InlineData("Lord of The Rings", 100, 1, 1)]
        public void WhenValidInputIsGiven_Validator_ShouldNotBeReturnErrors(string title = default, int pageCount = default, int genreId = default, int authorId = default)
        {
            //arrange(Hazırlık)
            Random rnd = new Random();
            int id = rnd.Next(1, 3);

            UpdateBookCommand command = new UpdateBookCommand(null);
            command.BookId = id;
            command.updatedModel = new UpdateBookModel()
            {
                Title = title,
                PageCount = pageCount,
                PublishDate = DateTime.Now.Date.AddYears(-1),
                GenreId = genreId,
                AuthorId = authorId
            };

            //act(Çalıştırma)

            UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
            var result = validator.Validate(command);

            //assert(Doğrulama)

            result.Errors.Count.Should().Equals(0);
        }
    }
}