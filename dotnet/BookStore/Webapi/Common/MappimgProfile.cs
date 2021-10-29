using AutoMapper;
using Webapi.Application.BookOperations.Commands.CreateBook;
using Webapi.Application.BookOperations.Queries.GetBookDetails;
using Webapi.Application.BookOperations.Queries.GetBooks;
using Webapi.Entities;
using Webapi.Application.GenreOperations.Queries.GetGenreDetails;
using Webapi.Application.GenreOperations.Queries.GetGenres;
using Webapi.Application.AuthorOperations.Queries.GetAuthors;
using Webapi.Application.AuthorOperations.Queries.GetAuthorDetails;
using Webapi.Application.AuthorOperations.Commands.CreateAuthor;
using Webapi.Application.UserOperations.Commands.CreateUser;

namespace Webapi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateBookModel, Book>();
            CreateMap<Book, BookByIdViewModel>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name))
                                                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author.Name + " " + src.Author.Surname));
            CreateMap<Book, BooksViewModel>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name))
                                             .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author.Name + " " + src.Author.Surname));
            CreateMap<Genre, GenresViewModel>();
            CreateMap<Genre, GenreDetailsViewModel>();
            CreateMap<Author, AuthorsViewModel>();
            CreateMap<Author, AuthorByIdViewModel>();
            CreateMap<CreateAuthorModel, Author>();
            CreateMap<CreateUserModel, User>();
        }
    }
}