using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Webapi.Common;
using Webapi.DBOperations;
using Webapi.Entities;

namespace Webapi.Application.UserOperations.Commands.CreateUser
{
    public class CreateUserCommand
    {
        public CreateUserModel Model { get; set; }
        private readonly IBookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateUserCommand(IBookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public void Handle()
        {
            var user = _dbContext.Users.SingleOrDefault(x => x.Email == Model.Email);
            if (user is not null)
            {
                throw new InvalidOperationException("Kullanıcı zaten mevcut!");
            }
            user = _mapper.Map<User>(Model);

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

        }
    }
    public class CreateUserModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}