using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Business
{
    public class List
    {
        public class Query : IRequest<List<Commerce>> {}

        public class Handler : IRequestHandler<Query, List<Commerce>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Commerce>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Business.ToListAsync();
            }
        }
    }
}