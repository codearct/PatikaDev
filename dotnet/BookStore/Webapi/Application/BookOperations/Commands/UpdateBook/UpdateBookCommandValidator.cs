using System;
using FluentValidation;

namespace Webapi.Application.BookOperations.Commands.UpdateBook
{
    public class UpdateBookCommandValidator : AbstractValidator<UpdateBookCommand>
    {
        public UpdateBookCommandValidator()
        {
            RuleFor(updatedCommand => updatedCommand.BookId).GreaterThan(0);
            RuleFor(updatedCommand => updatedCommand.updatedModel.GenreId).GreaterThan(0);
            RuleFor(updatedCommand => updatedCommand.updatedModel.PageCount).GreaterThan(0);
            RuleFor(updatedCommand => updatedCommand.updatedModel.PublishDate.Date).NotEmpty().LessThan(DateTime.Now.Date);
            RuleFor(updatedCommand => updatedCommand.updatedModel.Title).NotEmpty().MinimumLength(4);
            RuleFor(updatedCommand => updatedCommand.updatedModel.AuthorId).GreaterThan(0);
        }
    }
}