using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Webapi.Common;
using Webapi.DBOperations;
using Webapi.Entities;

namespace Webapi.Application.AuthorOperations.Commands.UpdateAuthor
{
    public class UpdateAuthorCommand
    {
        public int AuthorId { get; set; }
        public UpdateAuthorModel updatedModel { get; set; }
        private readonly BookStoreDbContext _context;
        public UpdateAuthorCommand(BookStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);

            if (author is null)
                throw new InvalidOperationException("Aradığınız yazar bulunamadı!");

            author.Name = updatedModel.Name != string.Empty ? updatedModel.Name : author.Name;
            author.Surname = updatedModel.Surname != string.Empty ? updatedModel.Surname : author.Surname;
            author.BirthDate = updatedModel.BirthDate != default ? updatedModel.BirthDate : author.BirthDate;

            _context.SaveChanges();
        }
    }



    public class UpdateAuthorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }
}