using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip.Application.Common.Interfaces;
using Trip.Domain.Entities;
using Trip.Shared.Tours.Queries.AllToursQuery;

namespace Trip.Application.Tours.Queries.AllToursQuery
{
    public class AllToursQuery : IRequest<List<TourForListVm>>
    {
    }

    public class AllToursQueryHandler : IRequestHandler<AllToursQuery, List<TourForListVm>>
    {
        public readonly ITripDbContext _context;
        public AllToursQueryHandler(ITripDbContext context)
        {
            _context = context;
        }
        public async Task<List<TourForListVm>> Handle(AllToursQuery request, CancellationToken cancellationToken)
        {
            var tours = await _context.Tour.ToListAsync();
            return MapPostsToVm(tours);
        }

        private List<TourForListVm> MapPostsToVm(List<Tour> tours)
        {
            var result = new List<TourForListVm>();
            foreach (var item in tours)
            {
                var tourVm = new TourForListVm()
                {
                    Name = item.Name,
                    Desc = item.Desc,
                    DateStart = item.DateStart,
                    DateEnd = item.DateEnd

                };
                result.Add(tourVm);
            }
            return result;
        }
    }
}
