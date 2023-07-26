using MediatR;

namespace CasgemMediator.MediatorPattern.Command
{
    public class RemoveProductCommand : IRequest
    {
        public RemoveProductCommand(int ıd)
        {
            Id=ıd;
        }
        public int Id { get; set; }
    }
}
