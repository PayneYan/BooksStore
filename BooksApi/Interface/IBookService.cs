using System.Collections.Generic;
using BooksApi.Models;

namespace BooksApi.Interface
{
    public interface IBookService
    {
        List<Book> Get();
          
        Book Get(string id);

        Book Create(Book book);
     
        void Update(string id, Book bookIn);
  
        void Remove(Book bookIn);

        void Remove(string id);
    }
}