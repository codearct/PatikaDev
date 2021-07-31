using System;
using AutoMapper;
using FluentAssertions;
using TestSetup;

using Webapi.Application.BookOperations.Commands.DeleteBook;
using Webapi.DBOperations;
using Webapi.Entities;
using Xunit;

namespace Application.BookOperations.Commands.DeleteBook
{
    public class DeleteBookCommandValidatorTest : IClassFixture<CommonTestFixture>
    {
        [Fact]
        public void WhenInValidInputIsGiven_Validator_ShouldBeReturnErrors()
        {
            DeleteBookCommand command = new DeleteBookCommand(null);
            command.BookId = 0;

            DeleteBookCommandValidator validator = new DeleteBookCommandValidator();
            var result = validator.Validate(command);

            result.Errors.Count.Should().BeGreaterThan(0);
        }

        [Fact]
        public void WhenValidInputIsGiven_Validator_ShouldNotBeReturnErrors()
        {
            DeleteBookCommand command = new DeleteBookCommand(null);
            command.BookId = 1;

            DeleteBookCommandValidator validator = new DeleteBookCommandValidator();
            var result = validator.Validate(command);

            result.Errors.Count.Should().Equals(0);
        }
    }
}