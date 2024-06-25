using System;
using tutorial8.DTOs;

namespace tutorial8.Services
{
    public interface ITripServices
    {
        Task<IEnumerable<TripDTO>> GetTripsAsync();
    }
}

