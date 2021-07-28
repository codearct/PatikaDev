using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webapi.Common;
using Webapi.DBOperations;
using Webapi.Entities;

namespace Webapi.Application.AuthorOperations.Queries.GetAuthorDetails
{
    public class GetAuthorByIdQuery
    {
        private readonly IBookStoreDbContext _context;
        private readonly IMapper _mapper;
        public int AuthorId;
        public GetAuthorByIdQuery(IBookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public AuthorByIdViewModel Handle()
        {
            var author = _context.Authors.Where(author => author.Id == AuthorId).SingleOrDefault();

            if (author is null)
                throw new InvalidOperationException("Yazar Bulunamadı!");

            AuthorByIdViewModel authorByIdViewModel = _mapper.Map<AuthorByIdViewModel>(author);

            return authorByIdViewModel;

        }

    }
    public class AuthorByIdViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
    }
}