using System;
using System.Collections.Generic;

namespace ApiTddKata.Models
{
    public class PointOfInterest
    {
        public PointOfInterest()
        {
            PointOfInterestTags = new HashSet<PointOfInterestTags>();
        }

        public Guid Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public byte[] Icon { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int RatingsAverage { get; set; }
        public string Contact { get; set; }

        public ICollection<PointOfInterestTags> PointOfInterestTags { get; set; }
    }
}