using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Webapi.Common;
using Webapi.DBOperations;
using Webapi.Entities;
using Webapi.TokenOperations;
using Webapi.TokenOperations.Models;

namespace Webapi.Application.UserOperations.Commands.CreateToken
{
    public class CreateTokenCommand
    {
        public CreateTokenModel Model { get; set; }
        private readonly IBookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public CreateTokenCommand(IBookStoreDbContext dbContext, IMapper mapper, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _configuration = configuration;
        }
        public Token Handle()
        {
            var user = _dbContext.Users.SingleOrDefault(x => x.Email == Model.Email && x.Password == Model.Password);
            if (user is not null)
            {
                TokenHandler handler = new TokenHandler(_configuration);
                Token token = handler.CreateAccessToken(user);

                user.RefreshToken = token.RefreshToken;
                user.RefreshTokenExpireDate = token.Expiration.AddMinutes(5);
                _dbContext.SaveChanges();

                return token;
            }

            else
            {
                throw new InvalidOperationException("Kullanıcı Adı - Şifre Hatalı");
            }

        }
    }
    public class CreateTokenModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}