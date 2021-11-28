using System;
using System.Threading.Tasks;
using ApiTddKata.Services;

namespace ApiTddKata
{
    public class PoiConsole
    {
        private readonly IPoiService _poiService;

        public PoiConsole(IPoiService poiService)
        {
            _poiService = poiService;
        }
        public async Task Main()
        {
            Console.WriteLine("Hello world");
        }
    }
}