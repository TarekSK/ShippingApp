using AutoMapper;
using Domain;
using MediatR;
using Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandQuery.ParcelDimensionPricing
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Domain.ParcelDimensionsPricing ParcelDimensionsPricing { get; set; }
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
                // ParcelDimensionsPricing - GET
                var ParcelDimensionsPricing = await _context.ParcelDimensionsPricing.FindAsync(request.ParcelDimensionsPricing.ParcelDimensionsPricingId);

                // Auto Map ParcelDimensionsPricing Data
                _mapper.Map(request.ParcelDimensionsPricing, ParcelDimensionsPricing);

                // Save Changes
                await _context.SaveChangesAsync();

                // Return [Unit.Value] -> Default Return -> [Dummy]
                return Unit.Value;
            }
        }
    }
}
