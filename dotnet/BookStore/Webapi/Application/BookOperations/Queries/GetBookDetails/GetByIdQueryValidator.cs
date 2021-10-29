using System;
using FluentValidation;

namespace Webapi.Application.BookOperations.Queries.GetBookDetails
{
    public class GetByIdQueryValidator : AbstractValidator<GetByIdQuery>
    {
        public GetByIdQueryValidator()
        {
            RuleFor(byIdQuery => byIdQuery.BookId).GreaterThan(0);
        }
    }
}