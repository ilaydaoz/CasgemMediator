using CasgemMediator.MediatorPattern.Result;
using MediatR;

namespace CasgemMediator.MediatorPattern.Queries
{
    public class GetProductUpdateByIdQuery : IRequest<GetProductUpdateByIdQueryResult>
    {
        public GetProductUpdateByIdQuery(int ıd)
        {
         this.ıd = ıd;
        }

        public int ıd{ get; set; }
    }
}
