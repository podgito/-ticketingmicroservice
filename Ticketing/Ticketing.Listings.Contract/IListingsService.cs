using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Listings.Contract
{
    public interface IListingsService: IService
    {

        Task<Listing> GetListing(string id);
        //Task<IEnumerable<Listing>> GetListings();
    }
}
