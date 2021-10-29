using System;
using FluentValidation;

namespace Webapi.Application.AuthorOperations.Commands.UpdateAuthor
{
    public class UpdateAuthorCommandValidator : AbstractValidator<UpdateAuthorCommand>
    {
        public UpdateAuthorCommandValidator()
        {
            RuleFor(updatedCommand => updatedCommand.updatedModel.BirthDate).LessThan(DateTime.Now.Date);
        }
    }
}