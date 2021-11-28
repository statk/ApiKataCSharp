using System;
using System.Collections.Generic;
using ApiTddKata.Models;

namespace ApiTddKata.Services
{
    public interface IPoiService
    {
        void UpsertPoi(PointOfInterest pointOfInterest);
        PointOfInterest GetPoiById(Guid pointOfInterestId);
        List<PointOfInterest> GetAllPoi();
        void DeletePoi(Guid guid);
    }
}