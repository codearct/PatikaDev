using System;
using FluentValidation;

namespace Webapi.Application.AuthorOperations.Queries.GetAuthorDetails
{
    public class GetAuthorByIdQueryValidator : AbstractValidator<GetAuthorByIdQuery>
    {
        public GetAuthorByIdQueryValidator()
        {
            RuleFor(query => query.AuthorId).GreaterThan(0);
        }
    }
}