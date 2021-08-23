using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Business
{
    public class Details
    {
        public class Query : IRequest<List<Commerce>>
        {
            public string Filter { get; set; }
        }

        public class Handler : IRequestHandler<Query, List<Commerce>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Commerce>> Handle(Query request, CancellationToken cancellationToken)
            {
                List<Commerce> result = await _context.Business.ToListAsync();
                return result.Where(x => x.Id.ToString().ToLower().Contains(request.Filter)
                || x.Name.ToLower().Contains(request.Filter)
                || x.CUIT.ToLower().Contains(request.Filter)).ToList();
            }
        }
    }
}