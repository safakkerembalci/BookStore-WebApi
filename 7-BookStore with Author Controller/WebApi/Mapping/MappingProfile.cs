using AutoMapper;
using WebApi.Application.BookOperations.Queries.GetBookDetail;
using WebApi.Application.GenreOperations.Queries.GetGenreDetail;
using WebApi.Application.GenreOperations.Queries.GetGenres;
using WebApi.Entities;
using static WebApi.Application.AuthorOperations.Commands.CreateAuthor.CreateAuthorCommand;
using static WebApi.Application.AuthorOperations.Queries.GetAuthors.GetAuthorQuery;
using static WebApi.Application.AuthorOperations.Queries.GetAuthorsDetail.GetAuthorDetailQuery;
using static WebApi.Application.BookOperations.Commands.CreateBook.CreateBookCommand;
using static WebApi.Application.BookOperations.Queries.GetBooks.GetBooksQuery;

namespace WebApi.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateBookModel, Book>();

            CreateMap<Book, BookDetailViewModel>().ForMember(dest=>dest.Genre, opt=>opt.MapFrom(src=> src.Genre!.Name));

            CreateMap<Book, BooksViewModel>().ForMember(dest=>dest.Genre, opt=>opt.MapFrom(src=> src.Genre!.Name));

            CreateMap<Genre, GenresViewModel>();
            
            CreateMap<Genre, GenreDetailViewModel>();
            
            CreateMap<CreateAuthorModel, Author>();
            CreateMap<Author, AuthorsViewModel>();
            CreateMap<Author, AuthorDetailViewModel>();
            
        }
    }
}