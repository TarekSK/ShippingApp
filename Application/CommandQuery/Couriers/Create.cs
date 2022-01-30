using Domain;
using MediatR;
using Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandQuery.Couriers
{
    public class Create
    {
        public class Command : IRequest
        {
            public Courier Courier { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                // Courier - Add
                _context.Couriers.Add(request.Courier);

                // Save Changes
                await _context.SaveChangesAsync();

                // Return [Unit.Value] -> Default Return -> [Dummy]
                return Unit.Value;
            }
        }
    }
}
