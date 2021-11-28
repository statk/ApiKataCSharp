using System;
using System.Collections.Generic;
using ApiTddKata.Models;

namespace ApiTddKata.Repository
{
    public class DbConnection: IDbConnection
    {

        public DbConnection()
        {
            PointOfInterest = new List<PointOfInterest>();
            PointOfInterestTags = new List<PointOfInterestTags>();
            Tag = new List<Tag>();
            
            var tagId = Guid.Parse("d5a23dab-b33a-40d1-a857-5fbec0fef0dd");
            var poiId = Guid.Parse("fbec1c05-6d11-4d74-9d9b-7079c0021d51");

            var tag = new Tag
            {
                Id = tagId,
                Label = "My tag"
            };
            Tag.Add(tag);

            var pointOfInterest = new PointOfInterest
            {
                Id = poiId,
                Contact = "Contact",
                Description = "Point of interests description",
                Label = "Some label",
                RatingsAverage = 5,
                Latitude = 12.0,
                Longitude = 8.1,
            };
            PointOfInterest.Add(pointOfInterest);
            PointOfInterestTags.Add(new PointOfInterestTags
            {
                IdTag = tagId,
                IdPointOfInterest = poiId,
            });
        }
         

        public List<PointOfInterest> PointOfInterest { get; private set; }
        public List<PointOfInterestTags> PointOfInterestTags { get; private set; }
        public List<Tag> Tag { get; private set; }

        
    }
}