using System;
using AutoMapper;
using FluentAssertions;
using TestSetup;
using Webapi.Application.BookOperations.Commands.CreateBook;
using Webapi.DBOperations;
using Webapi.Entities;
using Xunit;

namespace Application.BookOperations.Commands.CreateBook
{
    public class CreateBookCommandValidatorTest : IClassFixture<CommonTestFixture>
    {

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
            CreateBookCommand command = new CreateBookCommand(null, null);
            command.Model = new CreateBookModel()
            {
                Title = title,
                PageCount = pageCount,
                PublishDate = DateTime.Now.Date.AddYears(-1),
                GenreId = genreId,
                AuthorId = authorId
            };

            //act(Çalıştırma)

            CreateBookCommandValidator validator = new CreateBookCommandValidator();
            var result = validator.Validate(command);

            //assert(Doğrulama)

            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnError()
        {
            CreateBookCommand command = new CreateBookCommand(null, null);

            command.Model = new CreateBookModel()
            {
                Title = "Lord of The Rings",
                PageCount = 100,
                PublishDate = DateTime.Now.Date,
                GenreId = 1,
                AuthorId = 1
            };

            CreateBookCommandValidator validator = new CreateBookCommandValidator();
            var result = validator.Validate(command);

            result.Errors.Count.Should().BeGreaterThan(0);

        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErrors()
        {
            CreateBookCommand command = new CreateBookCommand(null, null);

            command.Model = new CreateBookModel()
            {
                Title = "Lord of The Rings",
                PageCount = 100,
                PublishDate = DateTime.Now.Date.AddYears(-1),
                GenreId = 1,
                AuthorId = 1
            };

            CreateBookCommandValidator validator = new CreateBookCommandValidator();
            var result = validator.Validate(command);

            result.Errors.Count.Should().Equals(0);

        }

    }
}