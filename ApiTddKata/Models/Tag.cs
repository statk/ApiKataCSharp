using System;
using System.Collections.Generic;

namespace ApiTddKata.Models
{
    public class Tag
    {
        public Tag()
        {
            PointOfInterestTags = new HashSet<PointOfInterestTags>();
        }

        public Guid Id { get; set; }
        public string Label { get; set; }

        public ICollection<PointOfInterestTags> PointOfInterestTags { get; set; }
    }
}