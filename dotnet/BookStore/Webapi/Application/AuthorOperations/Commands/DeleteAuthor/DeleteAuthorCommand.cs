using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Webapi.Common;
using Webapi.DBOperations;

namespace Webapi.Application.AuthorOperations.Commands.DeleteAuthor
{
    public class DeleteAuthorCommand
    {
        private readonly IBookStoreDbContext _context;
        public int AuthorId { get; set; }
        public DeleteAuthorCommand(IBookStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
            var authorBook = _context.Books.SingleOrDefault(x => x.AuthorId == AuthorId);

            if (author is null)
                throw new InvalidOperationException("Silinecek yazar bulunamadı!");

            if (authorBook is not null)
                throw new InvalidOperationException("Yazarın kitabı yayında bu yazarı silmek için önce kitabını silmelisin!");


            _context.Authors.Remove(author);
            _context.SaveChanges();
        }
    }
}