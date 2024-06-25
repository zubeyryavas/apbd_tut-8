﻿using System;
namespace tutorial8.Models
{
    public partial class Client
    {
        public Client()
        {
            ClientTrips = new HashSet<ClientTrip>();
        }

        public int IdClient { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Telephone { get; set; } = null!;
        public string Pesel { get; set; } = null!;

        public virtual ICollection<ClientTrip> ClientTrips { get; set; }
    }
}

