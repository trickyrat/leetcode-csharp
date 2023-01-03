// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.IO;

using LeetCode;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Serilog;



await Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((builder) => {
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("appsettings.json", false);
    })
    .ConfigureServices(services => {
        services.AddHostedService<Worker>();
    })
    .UseSerilog((context, logger) => 
    {
        logger.ReadFrom.Configuration(context.Configuration);
    })
    .Build()
    .RunAsync();