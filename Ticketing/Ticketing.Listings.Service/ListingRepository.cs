using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Listings.Contract;

namespace Ticketing.Listings.Service
{
    internal class ListingRepository
    {
        public Task<Listing> GetListing(string id)
        {
            return Task.FromResult(new Listing());
        }

    }
}
