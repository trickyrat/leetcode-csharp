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
    private int _exitCode = 0;

    public Worker(ILogger<Worker> logger
    , IHost host)
    {
        _logger = logger;
        _host = host;
    }


    protected async override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            _logger.LogInformation("Worker running at: {Now}", DateTime.Now);
            // Add your service here
        }
        catch (Exception ex)
        {
            _logger.LogError("Exception: {0}", ex.Message);
            _exitCode = -1;
            throw;
        }
        finally 
        {
            Environment.ExitCode = _exitCode;    
            await _host.StopAsync(stoppingToken);
        }
    }
}