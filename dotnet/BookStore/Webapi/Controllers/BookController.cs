using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Webapi.BookOperations.CreateBook;
using Webapi.BookOperations.DeleteBook;
using Webapi.BookOperations.GetBooks;
using Webapi.BookOperations.UpdateBook;
using Webapi.DBOperations;

namespace Webapi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class BookController : ControllerBase
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public BookController(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            GetBooksQuery query = new GetBooksQuery(_context, _mapper);
            var result = query.Handle();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            BookByIdViewModel result;
            try
            {
                GetByIdQuery byIdQuery = new GetByIdQuery(_context, _mapper);
                byIdQuery.BookId = id;
                GetByIdQueryValidator validator = new GetByIdQueryValidator();
                validator.ValidateAndThrow(byIdQuery);
                result = byIdQuery.Handle();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(result);
        }

        //Post
        [HttpPost]
        public IActionResult AddBook([FromBody] CreateBookModel newBook)
        {
            CreateBookCommand command = new CreateBookCommand(_context, _mapper);
            try
            {
                command.Model = newBook;
                CreateBookCommandValidator validator = new CreateBookCommandValidator();
                validator.ValidateAndThrow(command);
                command.Handle();
                // if (!result.IsValid)
                // {
                //     foreach (var item in result.Errors)
                //     {
                //         Console.WriteLine("Özellik: " + item.PropertyName + "- Error Message: " + item.ErrorMessage);
                //     }
                // }
                // else
                // {
                //     command.Handle();
                // }


            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] UpdateBookModel updatedBook)
        {
            UpdateBookCommand updatedCommand = new UpdateBookCommand(_context);
            try
            {
                updatedCommand.BookId = id;
                updatedCommand.updatedModel = updatedBook;
                UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
                validator.ValidateAndThrow(updatedCommand);
                updatedCommand.Handle();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteBook(int id)
        {
            try
            {
                DeleteBookCommand command = new DeleteBookCommand(_context);
                command.BookId = id;
                DeleteBookCommandValidator validator = new DeleteBookCommandValidator();
                validator.ValidateAndThrow(command);
                command.Handle();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
    }
}