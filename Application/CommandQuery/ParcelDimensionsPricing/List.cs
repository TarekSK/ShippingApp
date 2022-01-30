using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandQuery.ParcelDimensionsPricing
{
    public class List
    {
        public class Query : IRequest<List<Domain.ParcelDimensionsPricing>> { }

        public class Handler : IRequestHandler<Query, List<Domain.ParcelDimensionsPricing>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Domain.ParcelDimensionsPricing>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.ParcelDimensionsPricing.ToListAsync(cancellationToken);
            }
        }
    }
}
