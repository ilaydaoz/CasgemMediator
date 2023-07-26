using CasgemMediator.Dal;
using CasgemMediator.MediatorPattern.Command;
using MediatR;

namespace CasgemMediator.MediatorPattern.Handler
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
           var value = _context.Products.Find(request.ProductId);
            value.Brand = request.Brand;    
            value.Price= request.Price;
            value.Stock= request.Stock;
            value.Category= request.Category;
            value.Name= request.Name;
            await _context.SaveChangesAsync();
        }
    }
}
