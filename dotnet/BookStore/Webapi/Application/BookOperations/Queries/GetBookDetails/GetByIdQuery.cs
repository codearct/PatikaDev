using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webapi.Common;
using Webapi.DBOperations;

namespace Webapi.Application.BookOperations.Queries.GetBookDetails
{
    public class GetByIdQuery
    {
        private readonly IBookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int BookId;
        public GetByIdQuery(IBookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public BookByIdViewModel Handle()
        {
            var book = _dbContext.Books.Include(x => x.Genre).Include(x => x.Author).Where(book => book.Id == BookId).SingleOrDefault();

            if (book is null)
            {
                throw new InvalidOperationException("Kitap bulunamadı!");
            }

            BookByIdViewModel vmBook = _mapper.Map<BookByIdViewModel>(book);

            // vmBook.Title = book.Title;
            // vmBook.PageCount = book.PageCount;
            // vmBook.PublishDate = book.PublishDate.Date.ToString("dd/MM/yyyy");
            // vmBook.Genre = ((GenreEnum)book.GenreId).ToString();

            return vmBook;
        }
    }
    public class BookByIdViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
    }
}