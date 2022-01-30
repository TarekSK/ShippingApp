using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandQuery.Couriers
{
    public class List
    {
        public class Query : IRequest<List<Courier>>{}

        public class Handler : IRequestHandler<Query, List<Courier>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Courier>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Couriers.ToListAsync(cancellationToken);
            }
        }
    }
}
