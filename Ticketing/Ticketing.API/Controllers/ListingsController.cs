using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ServiceFabric.Services.Remoting.Client;
using Ticketing.Listings.Contract;

namespace Ticketing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListingsController : ControllerBase
    {
        IListingsService _listingsService;
        public ListingsController()
        {
            _listingsService = ServiceProxy.Create<IListingsService>(new Uri("fabric:/Ticketing/Ticketing.Listings.Service"));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchTerm">Search by name or venue. A null returns a home page listings with personalised listings</param>
        /// <returns></returns>
        //public ActionResult<object> GetListings(string searchTerm)
        //{
        //    return new { };
        //}

        /// <summary>
        /// Get a specified listing
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ActionResult<Listing>> GetListing(string id)
        {
            return Ok(await _listingsService.GetListing(id));
        }

    }
}