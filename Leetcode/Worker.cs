// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Leetcode;

public class Worker : BackgroundService
{
    private readonly ILogger _logger;
    private readonly IHost _host;

    public Worker(ILogger<Worker> logger
    , IHost host)
    {
        _logger = logger;
        _host = host;
    }


    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation($"Worker running at: {DateTime.Now}" );
            await _host.StopAsync(stoppingToken);
        }
    }
}