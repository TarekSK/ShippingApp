using AutoMapper;
using Domain;
using MediatR;
using Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandQuery.Couriers
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Courier Courier { get; set; }
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
                // Courier - GET
                var Courier = await _context.Couriers.FindAsync(request.Courier.CourierId);

                // Auto Map Courier Data
                _mapper.Map(request.Courier, Courier);

                // Save Changes
                await _context.SaveChangesAsync();

                // Return [Unit.Value] -> Default Return -> [Dummy]
                return Unit.Value;
            }
        }
    }
}
