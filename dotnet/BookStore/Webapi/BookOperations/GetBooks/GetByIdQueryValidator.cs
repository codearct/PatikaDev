using System;
using FluentValidation;

namespace Webapi.BookOperations.GetBooks
{
    public class GetByIdQueryValidator : AbstractValidator<GetByIdQuery>
    {
        public GetByIdQueryValidator()
        {
            RuleFor(byIdQuery => byIdQuery.BookId).GreaterThan(0);
        }
    }
}