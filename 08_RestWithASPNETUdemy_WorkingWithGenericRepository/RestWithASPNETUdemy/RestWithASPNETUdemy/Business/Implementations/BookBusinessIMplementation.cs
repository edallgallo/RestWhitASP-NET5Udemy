using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class BookBusinessIMplementation: IBookBusinnes
    {
        private readonly IRepository<Book> _repository;

        public BookBusinessIMplementation(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }
        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }
        public Book FindByID(long id)
        {
            return _repository.FindByID(id);
        }
        public Book Update(Book book)
        {
            return _repository.Update(book); ;
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }


    }
}
