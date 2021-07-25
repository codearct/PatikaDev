using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Webapi.DBOperations;

namespace Webapi.Application.GenreOperations.Queries.GetGenreDetails
{
    public class GetGenreDetailsQuery
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public int GenreId { get; set; }
        public GetGenreDetailsQuery(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public GenreDetailsViewModel Handle()
        {
            var genre = _context.Genres.SingleOrDefault(x => x.IsActive && x.Id == GenreId);
            if (genre is null)
            {
                throw new InvalidOperationException("Kitap türü bulunamadı!");
            }

            return _mapper.Map<GenreDetailsViewModel>(genre);
        }

    }
    public class GenreDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}