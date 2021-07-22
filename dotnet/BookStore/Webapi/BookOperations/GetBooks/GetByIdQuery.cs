using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Webapi.Common;
using Webapi.DBOperations;

namespace Webapi.BookOperations.GetBooks
{
    public class GetByIdQuery
    {
        private readonly BookStoreDbContext _dbContext;
        public GetByIdQuery(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public BookByIdViewModel Handle(int id)
        {

            BookByIdViewModel vmBook = new BookByIdViewModel();
            var book = _dbContext.Books.Where(book => book.Id == id).SingleOrDefault();

            vmBook.Title = book.Title;
            vmBook.PageCount = book.PageCount;
            vmBook.PublishDate = book.PublishDate.Date.ToString("dd/MM/yyyy");
            vmBook.Genre = ((GenreEnum)book.GenreId).ToString();

            return vmBook;
        }
    }
    public class BookByIdViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string Genre { get; set; }
    }
}