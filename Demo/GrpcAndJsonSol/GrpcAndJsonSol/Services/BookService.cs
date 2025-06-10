using Grpc.Core;
using GrpcAndJsonSol;

namespace GrpcAndJsonSol.Services;

public class BookService : Books.BooksBase
{
    public override Task<Book> GetBook(GetBookRequest request, ServerCallContext context)
    {
        var book = new Book
        {
            Id = request.Id,
            Title = $"Kniha {request.Id}"
        };
        return Task.FromResult(book);
    }
}
