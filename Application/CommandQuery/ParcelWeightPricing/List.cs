using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandQuery.ParcelWeightPricing
{
    public class List
    {
        public class Query : IRequest<List<Domain.ParcelWeightPricing>> { }

        public class Handler : IRequestHandler<Query, List<Domain.ParcelWeightPricing>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Domain.ParcelWeightPricing>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.ParcelWeightPricing.ToListAsync(cancellationToken);
            }
        }
    }
}
