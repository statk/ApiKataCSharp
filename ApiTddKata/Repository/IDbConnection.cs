using System.Collections.Generic;
using ApiTddKata.Models;

namespace ApiTddKata.Repository
{
    public interface IDbConnection
    {
        List<PointOfInterest> PointOfInterest { get;}
        List<PointOfInterestTags> PointOfInterestTags { get;}
        List<Tag> Tag { get;}
    }
}