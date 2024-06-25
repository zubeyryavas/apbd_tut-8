using System;
using Microsoft.EntityFrameworkCore;
using tutorial8.Contexts;
using tutorial8.DTOs;

namespace tutorial8.Services
{
    public class TripServices : ITripServices
    {
        private readonly TripDbContext _tripDbContext;

        public TripServices(TripDbContext tripDbContext)
        {
            _tripDbContext = tripDbContext;
        }
        public async Task<IEnumerable<TripDTO>> GetTripsAsync()
        {
            var trips = await _tripDbContext.Trips
                .Include(x => x.IdCountries)
                .Include(e => e.ClientTrips)
                .ThenInclude(y => y.IdClientNavigation)
                .Select(x => new TripDTO
                {
                    Name = x.Name,
                    Description = x.Description,
                    DateFrom = x.DateFrom,
                    DateTo = x.DateTo,
                    MaxPeople = x.MaxPeople,
                    Countries = x.IdCountries.Select(a => new CountryDTO
                    {
                        Name = a.Name
                    }).ToList(),
                    Clients = x.ClientTrips.Select(a => new ClientDTO
                    {
                        FirstName = a.IdClientNavigation.FirstName,
                        LastName = a.IdClientNavigation.LastName
                    }).ToList()
                })
                .ToListAsync();
            return trips;
        }
    }
}

