using System;
using ApiTddKata;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ApiTddKata.Repository;
using ApiTddKata.Services;


using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) => 
        services.AddSingleton<IDbConnection, DbConnection>()
            .AddTransient<IPoiService, PoiService>()
            .AddTransient<PoiConsole>()
        )
    .Build();

await host.StartAsync();

var console = host.Services.GetService<PoiConsole>();
await console!.Main();
