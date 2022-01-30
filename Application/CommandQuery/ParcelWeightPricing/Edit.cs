using AutoMapper;
using MediatR;
using Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandQuery.ParcelWeightPricing
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Domain.ParcelWeightPricing ParcelWeightPricing { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                // ParcelWeightPricing - GET
                var ParcelWeightPricing = await _context.ParcelWeightPricing.FindAsync(request.ParcelWeightPricing.ParcelWeightPricingId);

                // Auto Map ParcelWeightPricing Data
                _mapper.Map(request.ParcelWeightPricing, ParcelWeightPricing);

                // Save Changes
                await _context.SaveChangesAsync();

                // Return [Unit.Value] -> Default Return -> [Dummy]
                return Unit.Value;
            }
        }
    }
}
