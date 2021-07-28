using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Webapi.Common;
using Webapi.DBOperations;
using Webapi.Entities;

namespace Webapi.Application.BookOperations.Commands.UpdateBook
{
    public class UpdateBookCommand
    {
        public UpdateBookModel updatedModel { get; set; }
        public int BookId { get; set; }
        private readonly IBookStoreDbContext _dbContext;
        public UpdateBookCommand(IBookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handle()
        {
            var book = _dbContext.Books.SingleOrDefault(x => x.Id == BookId);

            if (book is null)
            {
                throw new InvalidOperationException("Aradığınız kitap bulunamadı!");
            }

            book.GenreId = updatedModel.GenreId != default ? updatedModel.GenreId : book.GenreId;
            book.PageCount = updatedModel.PageCount != default ? updatedModel.PageCount : book.PageCount;
            book.PublishDate = updatedModel.PublishDate != default ? updatedModel.PublishDate : book.PublishDate;
            book.Title = updatedModel.Title != default ? updatedModel.Title : book.Title;
            book.AuthorId = updatedModel.AuthorId != default ? updatedModel.AuthorId : book.AuthorId;

            _dbContext.SaveChanges();

        }
    }
    public class UpdateBookModel
    {
        public string Title { get; set; }
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
        public int AuthorId { get; set; }
    }
}