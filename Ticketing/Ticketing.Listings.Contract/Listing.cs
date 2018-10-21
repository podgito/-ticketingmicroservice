using System;

namespace Ticketing.Listings.Contract
{
    public class Listing
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime EventDateTime { get; set; }
        public string Venue { get; set; }
        public string PrimaryArtist { get; set; }
        public string[] Artists { get; set; }   

    }
}
