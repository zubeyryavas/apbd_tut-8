using System;
namespace tutorial8.DTOs
{
    public class TripDTO
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int MaxPeople { get; set; }
        public ICollection<CountryDTO> Countries { get; set; }
        public ICollection<ClientDTO> Clients { get; set; }
    }
}

