using System;
using System.Collections.Generic;
using ApiTddKata.Models;
using ApiTddKata.Repository;

namespace ApiTddKata.Services
{
    public class PoiService : IPoiService
    {
        private readonly IDbConnection _connection;

        public PoiService(IDbConnection connection)
        {
            _connection = connection;
        }
        public void UpsertPoi(PointOfInterest pointOfInterest)
        {
            throw new NotImplementedException();
        }

        public PointOfInterest GetPoiById(Guid pointOfInterestId)
        {
            throw new NotImplementedException();
        }

        public List<PointOfInterest> GetAllPoi()
        {
            throw new NotImplementedException();
        }
    }
}