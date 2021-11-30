using System;
using System.Linq;
using ApiTddKata.Models;
using ApiTddKata.Repository;
using ApiTddKata.Services;
using Xunit;

namespace ApiTddKata.Tests
{

    public class PoiConsoleTests
    {
        private readonly PoiConsole _console;
        private readonly IPoiService _poiService;
        private readonly IDbConnection _dConnection;
    
        public PoiConsoleTests()
        {
            _dConnection = new DbConnection();
            _poiService = new PoiService(_dConnection);
            _console = new PoiConsole(_poiService);
        }
        
        
        [Fact]
        public void Should_DbConnection_Contains_Data_When_Initialized()
        {
            Assert.True(_dConnection.PointOfInterest.Any());
        }

        [Fact]
        public void Should_Delete_Poi_Element_When_Delete_Executed()
        {
            var guid = Guid.NewGuid();
            _dConnection.PointOfInterest.Add(new PointOfInterest
            {
                Id = guid,
                Contact = "My test contact",
                Description = "This is description",
                Label = "My label",
                RatingsAverage = 5,
                Latitude = 42.0,
                Longitude = 24.0
            });
            
            _poiService.DeletePoi(guid);
            
            Assert.DoesNotContain(_dConnection.PointOfInterest, x => x.Id == guid);
        }
    }
}