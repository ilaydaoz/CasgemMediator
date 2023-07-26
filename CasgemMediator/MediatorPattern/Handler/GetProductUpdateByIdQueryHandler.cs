using CasgemMediator.Dal;
using CasgemMediator.MediatorPattern.Queries;
using CasgemMediator.MediatorPattern.Result;
using MediatR;

namespace CasgemMediator.MediatorPattern.Handler
{
    public class GetProductUpdateByIdQueryHandler : IRequestHandler<GetProductUpdateByIdQuery,GetProductUpdateByIdQueryResult>
    {
        private readonly Context _context;

        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductUpdateByIdQueryResult> Handle(GetProductUpdateByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.ıd);
            return new GetProductUpdateByIdQueryResult
            {
                Name = values.Name,
                Stock = values.Stock,
                Brand = values.Brand,
                Price = values.Price,
                Category = values.Category,
            };
           
        }
    }
}
