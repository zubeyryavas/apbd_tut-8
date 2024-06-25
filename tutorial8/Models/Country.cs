﻿using System;
namespace tutorial8.Models
{
    public partial class Country
    {
        public int IdCountry { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Trip> IdTrips { get; set; }
    }
}

