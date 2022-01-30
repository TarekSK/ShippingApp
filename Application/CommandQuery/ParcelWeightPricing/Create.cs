using Domain;
using MediatR;
using Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandQuery.ParcelWeightPricing
{
    public class Create
    {
        public class Command : IRequest
        {
            public Domain.ParcelWeightPricing ParcelWeightPricing { get; set; }
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
                // Parcel Weight Pricing - Add
                _context.ParcelWeightPricing.Add(request.ParcelWeightPricing);

                // Save Changes
                await _context.SaveChangesAsync();

                // Return [Unit.Value] -> Default Return -> [Dummy]
                return Unit.Value;
            }
        }
    }
}
